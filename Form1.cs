using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

namespace Neart4USalesQuoteCalculator
{
    public partial class N4USalesQuoteGenerator : Form
    {
        public N4USalesQuoteGenerator()
        {
            InitializeComponent();
        }
        //Assigning the Constants for Equipment, Brand, Service Warranty,Installation Cost, Expedited Installation Fee and Discount Amount
        const string EQUIPMENT1 = "Elliptical", EQUIPMENT2 = "Threadmill", EQUIPMENT3 = "Exercise Bikes", EQUIPMENT4 = "Rowing Machine", EQUIPMENT5 = "Stair Climber";
        const decimal EQUIPMENTCOST1 = 1199, EQUIPMENTCOST2 = 899, EQUIPMENTCOST3 = 499, EQUIPMENTCOST4 = 699, EQUIPMENTCOST5 = 799;
        const string BRAND1 = "Own Brand", BRAND2 = "Techno Gym", BRAND3 = "Proform", BRAND4 = "Nordic Track", BRAND5 = "Peloton";
        const decimal BRANDDISCOUNT1 = -0.2m, BRANDDISCOUNT2 = -0.1m, BRANDDISCOUNT3 = 0, BRANDDISCOUNT4 = 0.15m, BRANDDISCOUNT5 = 0.25m;
        const decimal SERVICE1 = 0.15m, SERVICE2 = 0.25m, SERVICE3 = 0.30m;
        const decimal InstallationCost = 149;
        const decimal DiscountRate = 0.075m;
        bool ExpediteInstallation;
        const decimal ExpeditedInstallationfee = 99.00m;

        //Values to retrive for Order Button
        private string LastEquipment = "";
        private string LastBrand = "";

        // Summary tracking
        private int TotalOrders = 0;
        private int DiscountOrders = 0;
        private decimal TotalSales = 0m;
        private decimal TotalDiscountGiven = 0m;

        // Last quote (Order button)
        private decimal LastGrandTotal = 0;
        private bool LastDiscountApplied = false;
        private decimal LastDiscountAmount = 0m;
        private decimal LastWarrantyRate = 0;

        private void N4USalesQuoteGenerator_Load(object sender, EventArgs e)
        {
            // Clear all selections in the Equipment and Brand list boxes
            EquipmentList.ClearSelected();
            BrandList.ClearSelected();

            // Reset the quantity text box
            QuantityText.Text = "";

            // Uncheck all warranty options
            Oneyear.Checked = false;
            ThreeYear.Checked = false;
            Fiveyears.Checked = false;

            // Uncheck expedited installation option
            ExpeditedInstallationCost.Checked = false;

            // Clear the user display area
            UserView.Text = "";

            // Disable buttons as quote has to be generated first
            OrderButton.Enabled = false;
            SummaryButton.Enabled = false;

            // Reset last quote values if desired:
            LastGrandTotal = 0m;
            LastDiscountApplied = false;
            LastDiscountAmount = 0m;
            LastWarrantyRate = 0;

            //Set Form Name
            this.Text = "Sales Quote Generator";
        }

        private void QuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get Selected Equipment and Brand Index
                int EquipmentIndex = EquipmentList.SelectedIndex;
                int BrandIndex = BrandList.SelectedIndex;

                // Validation
                if (EquipmentIndex == -1 || BrandIndex == -1)
                {
                    MessageBox.Show("Please select both Equipment and Brand.");
                    return;
                }
                // Assigning Variables
                string Equipment = "";
                string Brand = "";
                decimal EquipmentCost = 0;
                decimal BrandDiscount = 0;

                // Equipment selection
                switch (EquipmentIndex)
                {
                    case 0: Equipment = EQUIPMENT1; EquipmentCost = EQUIPMENTCOST1; break;
                    case 1: Equipment = EQUIPMENT2; EquipmentCost = EQUIPMENTCOST2; break;
                    case 2: Equipment = EQUIPMENT3; EquipmentCost = EQUIPMENTCOST3; break;
                    case 3: Equipment = EQUIPMENT4; EquipmentCost = EQUIPMENTCOST4; break;
                    case 4: Equipment = EQUIPMENT5; EquipmentCost = EQUIPMENTCOST5; break;
                }
                // Brand selection
                switch (BrandIndex)
                {
                    case 0: Brand = BRAND1; BrandDiscount = BRANDDISCOUNT1; break;
                    case 1: Brand = BRAND2; BrandDiscount = BRANDDISCOUNT2; break;
                    case 2: Brand = BRAND3; BrandDiscount = BRANDDISCOUNT3; break;
                    case 3: Brand = BRAND4; BrandDiscount = BRANDDISCOUNT4; break;
                    case 4: Brand = BRAND5; BrandDiscount = BRANDDISCOUNT5; break;
                }
                // Parse Quantity
                if (!int.TryParse(QuantityText.Text, out int QTY) || QTY <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }
                //Base Equipment Cost With Brand Discount Applied
                decimal BaseCost = EquipmentCost;
                decimal EquipmentCosting = BaseCost + (BaseCost * BrandDiscount);

                // Total Equipment Cost
                decimal Total = (EquipmentCosting) * QTY;

                // Warranty Rate
                decimal WarrantyRate = 0m;

                //Warranty Year Selection
                if (Oneyear.Checked) WarrantyRate = SERVICE1;
                else if (ThreeYear.Checked) WarrantyRate = SERVICE2;
                else if (Fiveyears.Checked) WarrantyRate = SERVICE3;

                //Warranty Cost = % of Total Equipment Cost (Before Installation)
                decimal WarrantyCost = Total * WarrantyRate;

                // Assigning the Value of Expedited Installation Fee
                ExpediteInstallation = ExpeditedInstallationCost.Checked;
                decimal Installation = InstallationCost;
                string Expeditefee;

                if (ExpediteInstallation == true)
                {
                    Installation += ExpeditedInstallationfee;
                    Expeditefee = "99.00";
                }
                else
                {
                    Expeditefee = "0.00";
                }
                // SubTotal Calculation
                decimal SubTotal = (Total + WarrantyCost);

                //Discount eligibility
                bool DiscountApplied = false;
                decimal DiscountAmount = 0.0m;

                //Discount eligibility: 7.5% discount for 4+ items with 3- or 5-years warranty
                if (QTY >= 4 && Fiveyears.Checked || QTY >= 4 && ThreeYear.Checked)
                {
                    DiscountApplied = true;
                    DiscountAmount = SubTotal * DiscountRate;
                }
                //Overall Calculation
                decimal GrandTotal = (SubTotal - DiscountAmount) + Installation;
                
                //Save the values for later use in Order and Summary
                LastGrandTotal = GrandTotal;
                LastDiscountApplied = DiscountApplied;
                LastDiscountAmount = DiscountAmount;
                LastEquipment = Equipment;
                LastBrand = Brand;
                LastWarrantyRate = WarrantyRate;

                // Assising Values for the Output
                string QuoteDetails =
                    $"Sales Quote Details\r\n\r\n" +
                    $"Equipment: {Equipment}\r\n" +
                    $"Brand: {Brand}\r\n" +
                    $"Quantity: {QuantityText.Text}\r\n\r\n" +
                    $"Equipment Cost: {Total:C2}\r\n" +
                    $"Equipment Installation Cost: {InstallationCost:C2}\r\n" +
                    $"Service Warranty Cost({WarrantyRate * 100}%)\r: {WarrantyCost:C2}\r\n" +
                    $"Expedited Installation Cost: {Expeditefee:C2}\r\n" +
                    $"Discount Amount: {DiscountAmount:C2}\r\n\r\n" +
                    $"Grand Total: {GrandTotal:C2}";

                // Display Calculated Result
                UserView.Text = QuoteDetails;

                //Form Name Change
                this.Text = "Sales Quote Generator";

                //Enabling the Order Button
                OrderButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while generating the quote: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            //Table Name:
            this.Text = "Order Confirmation";

            // Confirm order
            DialogResult confirm = MessageBox.Show($"Do you wish to confirm this order?\r\n\r\nEquipment: {LastEquipment}\r\nBrand: {LastBrand}\r\nQuantity: {QuantityText.Text}\r\nWarranty Rate: {LastWarrantyRate * 100}%\r\n\r\nTotal: {LastGrandTotal:C2}", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)

            { //Assiging the Summary Totals
                TotalOrders++;
                TotalSales += LastGrandTotal;

                if (LastDiscountApplied)
                {
                    DiscountOrders++;
                    TotalDiscountGiven += LastDiscountAmount;
                }

                MessageBox.Show("Order successfully completed!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clearing the Values
                EquipmentList.ClearSelected();
                BrandList.ClearSelected();
                QuantityText.Text = "";
                Oneyear.Checked = false;
                ThreeYear.Checked = false;
                Fiveyears.Checked = false;
                ExpeditedInstallationCost.Checked = false;
                UserView.Text = "";

                //Form Name Change
                this.Text = "Order Confirmation";

                //Summary Button Disables
                OrderButton.Enabled = false;
                SummaryButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Order cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Form Name Change
                this.Text = "Sales Quote Generator";
            }
        }
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            if (TotalOrders == 0)
            {
                MessageBox.Show("No orders have been placed yet.", "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Average Revenue Calculation
                decimal AvgRevenue = TotalSales / TotalOrders;

                //Assigning the Values
                string Summary = $"Total Orders: {TotalOrders}\r\n" +
                $"Orders with Discount: {DiscountOrders}\r\n" +
                $"Total Discount Granted: {TotalDiscountGiven:C2}\r\n" +
                $"Total Sales (revenue): {TotalSales:C2}\r\n" +
                $"Average Revenue per Order: {AvgRevenue:C2}";

                // Display Calculated Result
                UserView.Text = Summary;

                //Set Form Name 
                this.Text = "Sales Summary";
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear Button - Reset Form
            N4USalesQuoteGenerator_Load(sender, e);
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the Application
            this.Close();
        } 
    }
}



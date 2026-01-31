namespace Neart4USalesQuoteCalculator
{
    partial class N4USalesQuoteGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N4USalesQuoteGenerator));
            panel1 = new Panel();
            ButtonsPanel = new Panel();
            ExitButton = new Button();
            ClearButton = new Button();
            SummaryButton = new Button();
            OrderButton = new Button();
            QuoteButton = new Button();
            UserView = new Label();
            EquipmentSelection = new Panel();
            Servicewarranty = new GroupBox();
            Fiveyears = new RadioButton();
            ThreeYear = new RadioButton();
            Oneyear = new RadioButton();
            ExpeditedInstallationCost = new CheckBox();
            logo = new PictureBox();
            QuantityText = new TextBox();
            Quantity = new Label();
            BrandDiscount = new Label();
            Brand = new Label();
            EquipmentCost = new Label();
            Equipment = new Label();
            BrandList = new ListBox();
            EquipmentList = new ListBox();
            QuoteTooltip = new ToolTip(components);
            OrderTooltip = new ToolTip(components);
            SummaryTooltip = new ToolTip(components);
            ClearTooltip = new ToolTip(components);
            ExitTooltip = new ToolTip(components);
            panel1.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            EquipmentSelection.SuspendLayout();
            Servicewarranty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonsPanel);
            panel1.Controls.Add(UserView);
            panel1.Controls.Add(EquipmentSelection);
            panel1.Location = new Point(39, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1779, 924);
            panel1.TabIndex = 0;
            QuoteTooltip.SetToolTip(panel1, "Press to Click for the Quote\r\n");
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = SystemColors.ControlLight;
            ButtonsPanel.BackgroundImageLayout = ImageLayout.Center;
            ButtonsPanel.BorderStyle = BorderStyle.FixedSingle;
            ButtonsPanel.Controls.Add(ExitButton);
            ButtonsPanel.Controls.Add(ClearButton);
            ButtonsPanel.Controls.Add(SummaryButton);
            ButtonsPanel.Controls.Add(OrderButton);
            ButtonsPanel.Controls.Add(QuoteButton);
            ButtonsPanel.Location = new Point(1285, 416);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(433, 472);
            ButtonsPanel.TabIndex = 2;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(139, 375);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(154, 62);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "&Exit";
            ExitTooltip.SetToolTip(ExitButton, "Press to Exit the Application");
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(139, 293);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(154, 60);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "&Clear";
            ClearTooltip.SetToolTip(ClearButton, "Press to Clear the Values");
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SummaryButton
            // 
            SummaryButton.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SummaryButton.Location = new Point(139, 208);
            SummaryButton.Name = "SummaryButton";
            SummaryButton.Size = new Size(154, 61);
            SummaryButton.TabIndex = 2;
            SummaryButton.Text = "&Summary";
            SummaryTooltip.SetToolTip(SummaryButton, "Press to Generate Summary");
            SummaryButton.UseVisualStyleBackColor = true;
            SummaryButton.Click += SummaryButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderButton.Location = new Point(139, 117);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(154, 61);
            OrderButton.TabIndex = 1;
            OrderButton.Text = "&Order";
            OrderTooltip.SetToolTip(OrderButton, "Press to Confirm The Order");
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // QuoteButton
            // 
            QuoteButton.AccessibleName = "";
            QuoteButton.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuoteButton.Location = new Point(139, 27);
            QuoteButton.Name = "QuoteButton";
            QuoteButton.Size = new Size(154, 60);
            QuoteButton.TabIndex = 0;
            QuoteButton.Tag = "";
            QuoteButton.Text = "&Quote";
            QuoteTooltip.SetToolTip(QuoteButton, "Press to Click for Quote Generation");
            QuoteButton.UseVisualStyleBackColor = true;
            QuoteButton.Click += QuoteButton_Click;
            // 
            // UserView
            // 
            UserView.BackColor = Color.White;
            UserView.BorderStyle = BorderStyle.FixedSingle;
            UserView.Font = new Font("Cambria", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserView.Location = new Point(21, 416);
            UserView.Name = "UserView";
            UserView.Size = new Size(1157, 493);
            UserView.TabIndex = 1;
            UserView.UseCompatibleTextRendering = true;
            // 
            // EquipmentSelection
            // 
            EquipmentSelection.BorderStyle = BorderStyle.FixedSingle;
            EquipmentSelection.Controls.Add(Servicewarranty);
            EquipmentSelection.Controls.Add(ExpeditedInstallationCost);
            EquipmentSelection.Controls.Add(logo);
            EquipmentSelection.Controls.Add(QuantityText);
            EquipmentSelection.Controls.Add(Quantity);
            EquipmentSelection.Controls.Add(BrandDiscount);
            EquipmentSelection.Controls.Add(Brand);
            EquipmentSelection.Controls.Add(EquipmentCost);
            EquipmentSelection.Controls.Add(Equipment);
            EquipmentSelection.Controls.Add(BrandList);
            EquipmentSelection.Controls.Add(EquipmentList);
            EquipmentSelection.Location = new Point(21, 47);
            EquipmentSelection.Name = "EquipmentSelection";
            EquipmentSelection.Size = new Size(1711, 339);
            EquipmentSelection.TabIndex = 0;
            // 
            // Servicewarranty
            // 
            Servicewarranty.BackgroundImageLayout = ImageLayout.Center;
            Servicewarranty.Controls.Add(Fiveyears);
            Servicewarranty.Controls.Add(ThreeYear);
            Servicewarranty.Controls.Add(Oneyear);
            Servicewarranty.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Servicewarranty.Location = new Point(1285, 39);
            Servicewarranty.Name = "Servicewarranty";
            Servicewarranty.Size = new Size(293, 200);
            Servicewarranty.TabIndex = 10;
            Servicewarranty.TabStop = false;
            Servicewarranty.Text = "Service Warranty";
            // 
            // Fiveyears
            // 
            Fiveyears.AutoSize = true;
            Fiveyears.Location = new Point(15, 158);
            Fiveyears.Name = "Fiveyears";
            Fiveyears.Size = new Size(219, 32);
            Fiveyears.TabIndex = 2;
            Fiveyears.TabStop = true;
            Fiveyears.Text = "5 Years         30%";
            Fiveyears.UseVisualStyleBackColor = true;
            // 
            // ThreeYear
            // 
            ThreeYear.AutoSize = true;
            ThreeYear.Location = new Point(15, 97);
            ThreeYear.Name = "ThreeYear";
            ThreeYear.Size = new Size(219, 32);
            ThreeYear.TabIndex = 1;
            ThreeYear.TabStop = true;
            ThreeYear.Text = "3 Years         25%";
            ThreeYear.UseVisualStyleBackColor = true;
            // 
            // Oneyear
            // 
            Oneyear.AutoSize = true;
            Oneyear.Location = new Point(15, 38);
            Oneyear.Name = "Oneyear";
            Oneyear.Size = new Size(213, 32);
            Oneyear.TabIndex = 0;
            Oneyear.TabStop = true;
            Oneyear.Text = "1 Year          15%";
            Oneyear.UseVisualStyleBackColor = true;
            // 
            // ExpeditedInstallationCost
            // 
            ExpeditedInstallationCost.AutoSize = true;
            ExpeditedInstallationCost.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpeditedInstallationCost.Location = new Point(1285, 278);
            ExpeditedInstallationCost.Name = "ExpeditedInstallationCost";
            ExpeditedInstallationCost.Size = new Size(341, 32);
            ExpeditedInstallationCost.TabIndex = 9;
            ExpeditedInstallationCost.Text = "Expedited Installation Cost";
            ExpeditedInstallationCost.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(1022, 164);
            logo.Name = "logo";
            logo.Size = new Size(200, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // QuantityText
            // 
            QuantityText.Location = new Point(1014, 96);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(200, 39);
            QuantityText.TabIndex = 7;
            QuantityText.TextAlign = HorizontalAlignment.Center;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Quantity.Location = new Point(1048, 45);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(109, 28);
            Quantity.TabIndex = 6;
            Quantity.Text = "Quantity";
            // 
            // BrandDiscount
            // 
            BrandDiscount.AutoSize = true;
            BrandDiscount.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrandDiscount.Location = new Point(786, 39);
            BrandDiscount.Name = "BrandDiscount";
            BrandDiscount.Size = new Size(183, 28);
            BrandDiscount.TabIndex = 5;
            BrandDiscount.Text = "Brand Discount";
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Brand.Location = new Point(524, 39);
            Brand.Name = "Brand";
            Brand.Size = new Size(80, 28);
            Brand.TabIndex = 4;
            Brand.Text = "Brand";
            // 
            // EquipmentCost
            // 
            EquipmentCost.AutoSize = true;
            EquipmentCost.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EquipmentCost.Location = new Point(275, 39);
            EquipmentCost.Name = "EquipmentCost";
            EquipmentCost.Size = new Size(186, 28);
            EquipmentCost.TabIndex = 3;
            EquipmentCost.Text = "Equipment Cost";
            // 
            // Equipment
            // 
            Equipment.AutoSize = true;
            Equipment.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Equipment.Location = new Point(10, 39);
            Equipment.Name = "Equipment";
            Equipment.Size = new Size(133, 28);
            Equipment.TabIndex = 2;
            Equipment.Text = "Equipment";
            // 
            // BrandList
            // 
            BrandList.Font = new Font("Cambria", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BrandList.FormattingEnabled = true;
            BrandList.Items.AddRange(new object[] { "Own Brand \t\t-20%", "Techno Gym\t\t-10%", "Proform\t\t\t  0%", "Nordic Track\t\t  15%", "Peloton\t\t                     25%" });
            BrandList.Location = new Point(524, 79);
            BrandList.Name = "BrandList";
            BrandList.Size = new Size(453, 164);
            BrandList.TabIndex = 1;
            // 
            // EquipmentList
            // 
            EquipmentList.Font = new Font("Cambria", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EquipmentList.FormattingEnabled = true;
            EquipmentList.Items.AddRange(new object[] { "Elliptical\t\t\t€1,199", "Threadmill\t\t€899", "Exercise Bike\t\t€499", "Rowing Machine\t\t€699", "Stair Climber\t\t€799" });
            EquipmentList.Location = new Point(10, 79);
            EquipmentList.Name = "EquipmentList";
            EquipmentList.Size = new Size(460, 164);
            EquipmentList.TabIndex = 0;
            // 
            // QuoteTooltip
            // 
            QuoteTooltip.IsBalloon = true;
            QuoteTooltip.ToolTipIcon = ToolTipIcon.Info;
            QuoteTooltip.ToolTipTitle = "Info";
            // 
            // OrderTooltip
            // 
            OrderTooltip.IsBalloon = true;
            OrderTooltip.ToolTipIcon = ToolTipIcon.Info;
            OrderTooltip.ToolTipTitle = "Info";
            // 
            // SummaryTooltip
            // 
            SummaryTooltip.IsBalloon = true;
            SummaryTooltip.ToolTipIcon = ToolTipIcon.Info;
            SummaryTooltip.ToolTipTitle = "Info";
            // 
            // ClearTooltip
            // 
            ClearTooltip.IsBalloon = true;
            ClearTooltip.ToolTipIcon = ToolTipIcon.Info;
            ClearTooltip.ToolTipTitle = "Info";
            // 
            // ExitTooltip
            // 
            ExitTooltip.IsBalloon = true;
            ExitTooltip.ToolTipIcon = ToolTipIcon.Info;
            ExitTooltip.ToolTipTitle = "Info";
            // 
            // N4USalesQuoteGenerator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1861, 987);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "N4USalesQuoteGenerator";
            Text = "N4USalesQuoteGenerator";
            Load += N4USalesQuoteGenerator_Load;
            panel1.ResumeLayout(false);
            ButtonsPanel.ResumeLayout(false);
            EquipmentSelection.ResumeLayout(false);
            EquipmentSelection.PerformLayout();
            Servicewarranty.ResumeLayout(false);
            Servicewarranty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel EquipmentSelection;
        private ListBox BrandList;
        private ListBox EquipmentList;
        private Label UserView;
        private Label Equipment;
        private Label EquipmentCost;
        private Label BrandDiscount;
        private Label Brand;
        private TextBox QuantityText;
        private Label Quantity;
        private PictureBox logo;
        private CheckBox ExpeditedInstallationCost;
        private GroupBox Servicewarranty;
        private RadioButton ThreeYear;
        private RadioButton Oneyear;
        private RadioButton Fiveyears;
        private Panel ButtonsPanel;
        private Button SummaryButton;
        private Button OrderButton;
        private Button QuoteButton;
        private Button ExitButton;
        private Button ClearButton;
        private ToolTip QuoteTooltip;
        private ToolTip OrderTooltip;
        private ToolTip SummaryTooltip;
        private ToolTip ClearTooltip;
        private ToolTip ExitTooltip;
    }
}

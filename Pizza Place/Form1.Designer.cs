namespace Pizza_Place
{
    partial class PizzaPlace
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
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.lblWelcometoPlatimimPizza = new System.Windows.Forms.Label();
            this.cboPizzaSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoRegularCrust = new System.Windows.Forms.RadioButton();
            this.rdoThickCrust = new System.Windows.Forms.RadioButton();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlive = new System.Windows.Forms.CheckBox();
            this.ckbBoxGreenOlive = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculateOrder = new System.Windows.Forms.Button();
            this.rtfOrderSummary = new System.Windows.Forms.RichTextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictPizza
            // 
            this.pictPizza.Image = global::Pizza_Place.Properties.Resources.pizzaPic;
            this.pictPizza.Location = new System.Drawing.Point(34, 12);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(343, 192);
            this.pictPizza.TabIndex = 0;
            this.pictPizza.TabStop = false;
            this.pictPizza.Click += new System.EventHandler(this.picPizza_Click);
            // 
            // lblWelcometoPlatimimPizza
            // 
            this.lblWelcometoPlatimimPizza.AutoSize = true;
            this.lblWelcometoPlatimimPizza.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcometoPlatimimPizza.Location = new System.Drawing.Point(395, 76);
            this.lblWelcometoPlatimimPizza.Name = "lblWelcometoPlatimimPizza";
            this.lblWelcometoPlatimimPizza.Size = new System.Drawing.Size(498, 50);
            this.lblWelcometoPlatimimPizza.TabIndex = 1;
            this.lblWelcometoPlatimimPizza.Text = "Welcome to Platinum Pizza";
            // 
            // cboPizzaSize
            // 
            this.cboPizzaSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboPizzaSize.FormattingEnabled = true;
            this.cboPizzaSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large ",
            "X-Large",
            "Ginormous"});
            this.cboPizzaSize.Location = new System.Drawing.Point(188, 210);
            this.cboPizzaSize.Name = "cboPizzaSize";
            this.cboPizzaSize.Size = new System.Drawing.Size(121, 29);
            this.cboPizzaSize.TabIndex = 2;
            this.cboPizzaSize.SelectedIndexChanged += new System.EventHandler(this.cboPizzaSize_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(132, 218);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(45, 21);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size:";
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderSummary.Location = new System.Drawing.Point(42, 386);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(135, 21);
            this.lblOrderSummary.TabIndex = 5;
            this.lblOrderSummary.Text = "Order Summary:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrustType.Location = new System.Drawing.Point(329, 218);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(93, 21);
            this.lblCrustType.TabIndex = 6;
            this.lblCrustType.Text = "Crust Type:";
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThinCrust.Location = new System.Drawing.Point(428, 216);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(62, 25);
            this.rdoThinCrust.TabIndex = 7;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            // 
            // rdoRegularCrust
            // 
            this.rdoRegularCrust.AutoSize = true;
            this.rdoRegularCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoRegularCrust.Location = new System.Drawing.Point(571, 216);
            this.rdoRegularCrust.Name = "rdoRegularCrust";
            this.rdoRegularCrust.Size = new System.Drawing.Size(87, 25);
            this.rdoRegularCrust.TabIndex = 8;
            this.rdoRegularCrust.TabStop = true;
            this.rdoRegularCrust.Text = "Regular";
            this.rdoRegularCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThickCrust
            // 
            this.rdoThickCrust.AutoSize = true;
            this.rdoThickCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThickCrust.Location = new System.Drawing.Point(496, 216);
            this.rdoThickCrust.Name = "rdoThickCrust";
            this.rdoThickCrust.Size = new System.Drawing.Size(69, 25);
            this.rdoThickCrust.TabIndex = 9;
            this.rdoThickCrust.TabStop = true;
            this.rdoThickCrust.Text = "Thick";
            this.rdoThickCrust.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPepperoni.Location = new System.Drawing.Point(191, 251);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(108, 25);
            this.ckbPepperoni.TabIndex = 10;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(93, 251);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(84, 21);
            this.lblToppings.TabIndex = 11;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(191, 341);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(190, 25);
            this.ckbSpicyItalianSausage.TabIndex = 12;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCanadianBacon.Location = new System.Drawing.Point(191, 310);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(148, 28);
            this.ckbCanadianBacon.TabIndex = 13;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseCompatibleTextRendering = true;
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(191, 279);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(92, 25);
            this.ckbSausage.TabIndex = 14;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbGreenPepper.Location = new System.Drawing.Point(395, 279);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(132, 25);
            this.ckbGreenPepper.TabIndex = 18;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlive
            // 
            this.ckbBlackOlive.AutoSize = true;
            this.ckbBlackOlive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBlackOlive.Location = new System.Drawing.Point(395, 310);
            this.ckbBlackOlive.Name = "ckbBlackOlive";
            this.ckbBlackOlive.Size = new System.Drawing.Size(114, 25);
            this.ckbBlackOlive.TabIndex = 17;
            this.ckbBlackOlive.Text = "Black Olive";
            this.ckbBlackOlive.UseVisualStyleBackColor = true;
            // 
            // ckbBoxGreenOlive
            // 
            this.ckbBoxGreenOlive.AutoSize = true;
            this.ckbBoxGreenOlive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBoxGreenOlive.Location = new System.Drawing.Point(395, 341);
            this.ckbBoxGreenOlive.Name = "ckbBoxGreenOlive";
            this.ckbBoxGreenOlive.Size = new System.Drawing.Size(118, 25);
            this.ckbBoxGreenOlive.TabIndex = 16;
            this.ckbBoxGreenOlive.Text = "Green Olive";
            this.ckbBoxGreenOlive.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(395, 251);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(76, 25);
            this.ckbOnion.TabIndex = 15;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJalepeno.Location = new System.Drawing.Point(549, 279);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(98, 25);
            this.ckbJalepeno.TabIndex = 22;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbExtraCheese.Location = new System.Drawing.Point(549, 310);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(126, 25);
            this.ckbExtraCheese.TabIndex = 21;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(549, 341);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(112, 25);
            this.ckbMushroom.TabIndex = 20;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbBananaPeppers.Location = new System.Drawing.Point(549, 251);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(151, 25);
            this.ckbBananaPeppers.TabIndex = 19;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(625, 388);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(85, 21);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(670, 438);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(40, 21);
            this.lblTax.TabIndex = 24;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(658, 487);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 21);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculateOrder
            // 
            this.btnCalculateOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateOrder.Location = new System.Drawing.Point(675, 536);
            this.btnCalculateOrder.Name = "btnCalculateOrder";
            this.btnCalculateOrder.Size = new System.Drawing.Size(176, 62);
            this.btnCalculateOrder.TabIndex = 26;
            this.btnCalculateOrder.Text = "Calculate Order";
            this.btnCalculateOrder.UseVisualStyleBackColor = true;
            this.btnCalculateOrder.Click += new System.EventHandler(this.btnCalculateOrder_Click);
            // 
            // rtfOrderSummary
            // 
            this.rtfOrderSummary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtfOrderSummary.Location = new System.Drawing.Point(184, 388);
            this.rtfOrderSummary.Name = "rtfOrderSummary";
            this.rtfOrderSummary.Size = new System.Drawing.Size(394, 234);
            this.rtfOrderSummary.TabIndex = 27;
            this.rtfOrderSummary.Text = "";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSubTotal.Location = new System.Drawing.Point(716, 388);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(135, 29);
            this.txtSubTotal.TabIndex = 28;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTax.Location = new System.Drawing.Point(716, 442);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(135, 29);
            this.txtTax.TabIndex = 29;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalAmount.Location = new System.Drawing.Point(716, 491);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(135, 29);
            this.txtTotalAmount.TabIndex = 30;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearOrder.Location = new System.Drawing.Point(675, 607);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(176, 62);
            this.btnClearOrder.TabIndex = 31;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // PizzaPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 681);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.rtfOrderSummary);
            this.Controls.Add(this.btnCalculateOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.ckbExtraCheese);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbBananaPeppers);
            this.Controls.Add(this.ckbGreenPepper);
            this.Controls.Add(this.ckbBlackOlive);
            this.Controls.Add(this.ckbBoxGreenOlive);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.ckbCanadianBacon);
            this.Controls.Add(this.ckbSpicyItalianSausage);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.ckbPepperoni);
            this.Controls.Add(this.rdoThickCrust);
            this.Controls.Add(this.rdoRegularCrust);
            this.Controls.Add(this.rdoThinCrust);
            this.Controls.Add(this.lblCrustType);
            this.Controls.Add(this.lblOrderSummary);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboPizzaSize);
            this.Controls.Add(this.lblWelcometoPlatimimPizza);
            this.Controls.Add(this.pictPizza);
            this.Name = "PizzaPlace";
            this.Text = "Platinum Pizza";
            this.Load += new System.EventHandler(this.PizzaPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictPizza;
        private Label lblWelcometoPlatimimPizza;
        private ComboBox cboPizzaSize;
        private Label lblSize;
        private Label lblOrderSummary;
        private Label lblCrustType;
        private RadioButton rdoThinCrust;
        private RadioButton rdoRegularCrust;
        private RadioButton rdoThickCrust;
        private CheckBox ckbPepperoni;
        private Label lblToppings;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbBlackOlive;
        private CheckBox ckbBoxGreenOlive;
        private CheckBox ckbOnion;
        private CheckBox ckbJalepeno;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private CheckBox ckbBananaPeppers;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculateOrder;
        private RichTextBox rtfOrderSummary;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotalAmount;
        private Button btnClearOrder;
    }
}
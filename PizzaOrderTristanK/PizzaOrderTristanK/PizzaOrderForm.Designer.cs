namespace PizzaOrderTristanK
{
    partial class frmPizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPizzaSize = new System.Windows.Forms.Label();
            this.nudPizzaSize = new System.Windows.Forms.NumericUpDown();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.lblXLarge = new System.Windows.Forms.Label();
            this.lblPizzaNumber = new System.Windows.Forms.Label();
            this.lblOnePizza = new System.Windows.Forms.Label();
            this.lblTwoPizzas = new System.Windows.Forms.Label();
            this.nudPizzaNumber = new System.Windows.Forms.NumericUpDown();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblOneTopping = new System.Windows.Forms.Label();
            this.lblTwoToppings = new System.Windows.Forms.Label();
            this.lblThreeToppings = new System.Windows.Forms.Label();
            this.lblFourToppings = new System.Windows.Forms.Label();
            this.nudToppingsNumber = new System.Windows.Forms.NumericUpDown();
            this.lblDrink = new System.Windows.Forms.Label();
            this.lblYesDrink = new System.Windows.Forms.Label();
            this.lblNoDrink = new System.Windows.Forms.Label();
            this.nudDrink = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaSize
            // 
            this.lblPizzaSize.AutoSize = true;
            this.lblPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSize.Location = new System.Drawing.Point(12, 21);
            this.lblPizzaSize.Name = "lblPizzaSize";
            this.lblPizzaSize.Size = new System.Drawing.Size(261, 20);
            this.lblPizzaSize.TabIndex = 0;
            this.lblPizzaSize.Text = "What size pizza would you like?";
            // 
            // nudPizzaSize
            // 
            this.nudPizzaSize.Location = new System.Drawing.Point(173, 63);
            this.nudPizzaSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPizzaSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaSize.Name = "nudPizzaSize";
            this.nudPizzaSize.Size = new System.Drawing.Size(120, 20);
            this.nudPizzaSize.TabIndex = 1;
            this.nudPizzaSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedium.Location = new System.Drawing.Point(12, 51);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(115, 16);
            this.lblMedium.TabIndex = 2;
            this.lblMedium.Text = "1 - Medium ($4.99)";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLarge.Location = new System.Drawing.Point(12, 67);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(102, 16);
            this.lblLarge.TabIndex = 3;
            this.lblLarge.Text = "2 - Large ($9.99)";
            this.lblLarge.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblXLarge
            // 
            this.lblXLarge.AutoSize = true;
            this.lblXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXLarge.Location = new System.Drawing.Point(12, 83);
            this.lblXLarge.Name = "lblXLarge";
            this.lblXLarge.Size = new System.Drawing.Size(142, 16);
            this.lblXLarge.TabIndex = 4;
            this.lblXLarge.Text = "3 - Extra Large ($12.99)";
            this.lblXLarge.Click += new System.EventHandler(this.lblXLarge_Click);
            // 
            // lblPizzaNumber
            // 
            this.lblPizzaNumber.AutoSize = true;
            this.lblPizzaNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaNumber.Location = new System.Drawing.Point(12, 123);
            this.lblPizzaNumber.Name = "lblPizzaNumber";
            this.lblPizzaNumber.Size = new System.Drawing.Size(277, 20);
            this.lblPizzaNumber.TabIndex = 5;
            this.lblPizzaNumber.Text = "How many pizza\'s would you like?";
            // 
            // lblOnePizza
            // 
            this.lblOnePizza.AutoSize = true;
            this.lblOnePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnePizza.Location = new System.Drawing.Point(13, 155);
            this.lblOnePizza.Name = "lblOnePizza";
            this.lblOnePizza.Size = new System.Drawing.Size(84, 16);
            this.lblOnePizza.TabIndex = 6;
            this.lblOnePizza.Text = "1 - One pizza";
            // 
            // lblTwoPizzas
            // 
            this.lblTwoPizzas.AutoSize = true;
            this.lblTwoPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoPizzas.Location = new System.Drawing.Point(13, 171);
            this.lblTwoPizzas.Name = "lblTwoPizzas";
            this.lblTwoPizzas.Size = new System.Drawing.Size(95, 16);
            this.lblTwoPizzas.TabIndex = 7;
            this.lblTwoPizzas.Text = "2 - Two pizza\'s";
            // 
            // nudPizzaNumber
            // 
            this.nudPizzaNumber.Location = new System.Drawing.Point(160, 167);
            this.nudPizzaNumber.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudPizzaNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaNumber.Name = "nudPizzaNumber";
            this.nudPizzaNumber.Size = new System.Drawing.Size(120, 20);
            this.nudPizzaNumber.TabIndex = 8;
            this.nudPizzaNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(12, 214);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(291, 20);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "How many toppings would you like?";
            // 
            // lblOneTopping
            // 
            this.lblOneTopping.AutoSize = true;
            this.lblOneTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneTopping.Location = new System.Drawing.Point(12, 254);
            this.lblOneTopping.Name = "lblOneTopping";
            this.lblOneTopping.Size = new System.Drawing.Size(140, 16);
            this.lblOneTopping.TabIndex = 10;
            this.lblOneTopping.Text = "1 - One topping ($0.75)";
            // 
            // lblTwoToppings
            // 
            this.lblTwoToppings.AutoSize = true;
            this.lblTwoToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoToppings.Location = new System.Drawing.Point(12, 280);
            this.lblTwoToppings.Name = "lblTwoToppings";
            this.lblTwoToppings.Size = new System.Drawing.Size(148, 16);
            this.lblTwoToppings.TabIndex = 11;
            this.lblTwoToppings.Text = "2 - Two toppings ($1.35)";
            // 
            // lblThreeToppings
            // 
            this.lblThreeToppings.AutoSize = true;
            this.lblThreeToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeToppings.Location = new System.Drawing.Point(13, 307);
            this.lblThreeToppings.Name = "lblThreeToppings";
            this.lblThreeToppings.Size = new System.Drawing.Size(158, 16);
            this.lblThreeToppings.TabIndex = 12;
            this.lblThreeToppings.Text = "3 - Three toppings ($2.15)";
            // 
            // lblFourToppings
            // 
            this.lblFourToppings.AutoSize = true;
            this.lblFourToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourToppings.Location = new System.Drawing.Point(13, 334);
            this.lblFourToppings.Name = "lblFourToppings";
            this.lblFourToppings.Size = new System.Drawing.Size(149, 16);
            this.lblFourToppings.TabIndex = 13;
            this.lblFourToppings.Text = "4 - Four toppings ($2.75)";
            // 
            // nudToppingsNumber
            // 
            this.nudToppingsNumber.Location = new System.Drawing.Point(183, 292);
            this.nudToppingsNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppingsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppingsNumber.Name = "nudToppingsNumber";
            this.nudToppingsNumber.Size = new System.Drawing.Size(120, 20);
            this.nudToppingsNumber.TabIndex = 14;
            this.nudToppingsNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(12, 369);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(193, 20);
            this.lblDrink.TabIndex = 15;
            this.lblDrink.Text = "Would you like a drink?";
            // 
            // lblYesDrink
            // 
            this.lblYesDrink.AutoSize = true;
            this.lblYesDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesDrink.Location = new System.Drawing.Point(12, 398);
            this.lblYesDrink.Name = "lblYesDrink";
            this.lblYesDrink.Size = new System.Drawing.Size(91, 16);
            this.lblYesDrink.TabIndex = 16;
            this.lblYesDrink.Text = "1 - Yes ($0.50)";
            // 
            // lblNoDrink
            // 
            this.lblNoDrink.AutoSize = true;
            this.lblNoDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDrink.Location = new System.Drawing.Point(13, 416);
            this.lblNoDrink.Name = "lblNoDrink";
            this.lblNoDrink.Size = new System.Drawing.Size(85, 16);
            this.lblNoDrink.TabIndex = 17;
            this.lblNoDrink.Text = "2 - No ($0.00)";
            // 
            // nudDrink
            // 
            this.nudDrink.Location = new System.Drawing.Point(109, 406);
            this.nudDrink.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDrink.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDrink.Name = "nudDrink";
            this.nudDrink.Size = new System.Drawing.Size(120, 20);
            this.nudDrink.TabIndex = 18;
            this.nudDrink.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(436, 168);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(82, 20);
            this.lblSubtotal.TabIndex = 19;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(436, 201);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(42, 20);
            this.lblTax.TabIndex = 20;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(436, 233);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(54, 20);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(427, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 39);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 438);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudDrink);
            this.Controls.Add(this.lblNoDrink);
            this.Controls.Add(this.lblYesDrink);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.nudToppingsNumber);
            this.Controls.Add(this.lblFourToppings);
            this.Controls.Add(this.lblThreeToppings);
            this.Controls.Add(this.lblTwoToppings);
            this.Controls.Add(this.lblOneTopping);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.nudPizzaNumber);
            this.Controls.Add(this.lblTwoPizzas);
            this.Controls.Add(this.lblOnePizza);
            this.Controls.Add(this.lblPizzaNumber);
            this.Controls.Add(this.lblXLarge);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.nudPizzaSize);
            this.Controls.Add(this.lblPizzaSize);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order";
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.NumericUpDown nudPizzaSize;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.Label lblXLarge;
        private System.Windows.Forms.Label lblPizzaNumber;
        private System.Windows.Forms.Label lblOnePizza;
        private System.Windows.Forms.Label lblTwoPizzas;
        private System.Windows.Forms.NumericUpDown nudPizzaNumber;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblOneTopping;
        private System.Windows.Forms.Label lblTwoToppings;
        private System.Windows.Forms.Label lblThreeToppings;
        private System.Windows.Forms.Label lblFourToppings;
        private System.Windows.Forms.NumericUpDown nudToppingsNumber;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Label lblYesDrink;
        private System.Windows.Forms.Label lblNoDrink;
        private System.Windows.Forms.NumericUpDown nudDrink;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}


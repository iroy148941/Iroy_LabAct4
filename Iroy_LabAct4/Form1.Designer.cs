namespace Iroy_LabAct4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.rdoDelivery = new System.Windows.Forms.RadioButton();
            this.rdoTakeout = new System.Windows.Forms.RadioButton();
            this.rdoDineIn = new System.Windows.Forms.RadioButton();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.nudFoodQty = new System.Windows.Forms.NumericUpDown();
            this.nudDrinkQty = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFoodTotal = new System.Windows.Forms.Label();
            this.lblDrinkTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABCD CAFE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSeniorCitizen);
            this.groupBox1.Controls.Add(this.rdoDelivery);
            this.groupBox1.Controls.Add(this.rdoTakeout);
            this.groupBox1.Controls.Add(this.rdoDineIn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkSeniorCitizen
            // 
            this.chkSeniorCitizen.AutoSize = true;
            this.chkSeniorCitizen.Location = new System.Drawing.Point(36, 61);
            this.chkSeniorCitizen.Name = "chkSeniorCitizen";
            this.chkSeniorCitizen.Size = new System.Drawing.Size(187, 19);
            this.chkSeniorCitizen.TabIndex = 2;
            this.chkSeniorCitizen.Text = "Senior Citizen (20% discount)";
            this.chkSeniorCitizen.UseVisualStyleBackColor = true;
            this.chkSeniorCitizen.CheckedChanged += new System.EventHandler(this.chkSeniorCitizen_CheckedChanged);
            // 
            // rdoDelivery
            // 
            this.rdoDelivery.AutoSize = true;
            this.rdoDelivery.Location = new System.Drawing.Point(213, 29);
            this.rdoDelivery.Name = "rdoDelivery";
            this.rdoDelivery.Size = new System.Drawing.Size(68, 19);
            this.rdoDelivery.TabIndex = 2;
            this.rdoDelivery.TabStop = true;
            this.rdoDelivery.Text = "Delivery";
            this.rdoDelivery.UseVisualStyleBackColor = true;
            this.rdoDelivery.CheckedChanged += new System.EventHandler(this.rdoDelivery_CheckedChanged);
            // 
            // rdoTakeout
            // 
            this.rdoTakeout.AutoSize = true;
            this.rdoTakeout.Location = new System.Drawing.Point(122, 29);
            this.rdoTakeout.Name = "rdoTakeout";
            this.rdoTakeout.Size = new System.Drawing.Size(72, 19);
            this.rdoTakeout.TabIndex = 2;
            this.rdoTakeout.TabStop = true;
            this.rdoTakeout.Text = "Take out";
            this.rdoTakeout.UseVisualStyleBackColor = true;
            this.rdoTakeout.CheckedChanged += new System.EventHandler(this.rdoTakeout_CheckedChanged);
            // 
            // rdoDineIn
            // 
            this.rdoDineIn.AutoSize = true;
            this.rdoDineIn.Location = new System.Drawing.Point(36, 29);
            this.rdoDineIn.Name = "rdoDineIn";
            this.rdoDineIn.Size = new System.Drawing.Size(64, 19);
            this.rdoDineIn.TabIndex = 2;
            this.rdoDineIn.TabStop = true;
            this.rdoDineIn.Text = "Dine in";
            this.rdoDineIn.UseVisualStyleBackColor = true;
            this.rdoDineIn.CheckedChanged += new System.EventHandler(this.rdoDineIn_CheckedChanged);
            // 
            // cmbFood
            // 
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Items.AddRange(new object[] {
            "Burger",
            "Chicken sandwich",
            "Spaghetti",
            "French Fries",
            " "});
            this.cmbFood.Location = new System.Drawing.Point(83, 183);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(163, 21);
            this.cmbFood.TabIndex = 2;
            this.cmbFood.SelectedIndexChanged += new System.EventHandler(this.cmbFood_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbDrink
            // 
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.Items.AddRange(new object[] {
            "Soft Drink",
            "Iced Tea",
            "Coffee",
            "Bottled Water"});
            this.cmbDrink.Location = new System.Drawing.Point(83, 230);
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(163, 21);
            this.cmbDrink.TabIndex = 6;
            this.cmbDrink.SelectedIndexChanged += new System.EventHandler(this.cmbDrink_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Drinks:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Payment:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(137, 263);
            this.txtPayment.Multiline = true;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(109, 23);
            this.txtPayment.TabIndex = 11;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // nudFoodQty
            // 
            this.nudFoodQty.Location = new System.Drawing.Point(324, 184);
            this.nudFoodQty.Name = "nudFoodQty";
            this.nudFoodQty.Size = new System.Drawing.Size(79, 20);
            this.nudFoodQty.TabIndex = 12;
            this.nudFoodQty.ValueChanged += new System.EventHandler(this.nudFoodQty_ValueChanged);
            // 
            // nudDrinkQty
            // 
            this.nudDrinkQty.Location = new System.Drawing.Point(324, 234);
            this.nudDrinkQty.Name = "nudDrinkQty";
            this.nudDrinkQty.Size = new System.Drawing.Size(79, 20);
            this.nudDrinkQty.TabIndex = 13;
            this.nudDrinkQty.ValueChanged += new System.EventHandler(this.nudDrinkQty_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "RECIEPT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "ABCD CAFE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(178, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Order Summary";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblFoodTotal
            // 
            this.lblFoodTotal.AutoSize = true;
            this.lblFoodTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodTotal.Location = new System.Drawing.Point(91, 350);
            this.lblFoodTotal.Name = "lblFoodTotal";
            this.lblFoodTotal.Size = new System.Drawing.Size(68, 15);
            this.lblFoodTotal.TabIndex = 18;
            this.lblFoodTotal.Text = "Food Total:";
            this.lblFoodTotal.Click += new System.EventHandler(this.lblFoodTotal_Click);
            // 
            // lblDrinkTotal
            // 
            this.lblDrinkTotal.AutoSize = true;
            this.lblDrinkTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkTotal.Location = new System.Drawing.Point(91, 374);
            this.lblDrinkTotal.Name = "lblDrinkTotal";
            this.lblDrinkTotal.Size = new System.Drawing.Size(69, 15);
            this.lblDrinkTotal.TabIndex = 19;
            this.lblDrinkTotal.Text = "Drink Total:";
            this.lblDrinkTotal.Click += new System.EventHandler(this.lblDrinkTotal_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(93, 398);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 15);
            this.lblSubTotal.TabIndex = 20;
            this.lblSubTotal.Text = "SubTotal:";
            this.lblSubTotal.Click += new System.EventHandler(this.lblSubTotal_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(93, 419);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(58, 15);
            this.lblDiscount.TabIndex = 21;
            this.lblDiscount.Text = "Discount:";
            this.lblDiscount.Click += new System.EventHandler(this.lblDiscount_Click);
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharges.Location = new System.Drawing.Point(94, 440);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(56, 15);
            this.lblCharges.TabIndex = 22;
            this.lblCharges.Text = "Charges:";
            this.lblCharges.Click += new System.EventHandler(this.lblCharges_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(101, 462);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(94, 484);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(53, 15);
            this.lblChange.TabIndex = 24;
            this.lblChange.Text = "Change:";
            this.lblChange.Click += new System.EventHandler(this.lblChange_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 501);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(322, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(479, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 440);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "grpReciept";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(287, 370);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblDrinkTotal);
            this.Controls.Add(this.lblFoodTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudDrinkQty);
            this.Controls.Add(this.nudFoodQty);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSeniorCitizen;
        private System.Windows.Forms.RadioButton rdoDelivery;
        private System.Windows.Forms.RadioButton rdoTakeout;
        private System.Windows.Forms.RadioButton rdoDineIn;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.NumericUpDown nudFoodQty;
        private System.Windows.Forms.NumericUpDown nudDrinkQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFoodTotal;
        private System.Windows.Forms.Label lblDrinkTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


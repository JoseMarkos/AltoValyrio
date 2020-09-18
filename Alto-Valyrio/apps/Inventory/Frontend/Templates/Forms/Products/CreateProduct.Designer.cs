namespace Alto_Valyrio.apps.Inventory.Frontend.Templates.Forms.Products
{
    partial class CreateProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.txtPackingAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveAndNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboPackingType = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.comboRefrigerated = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Controls.Add(this.txtPackingAmount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSaveAndNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.comboPackingType);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.comboLocation);
            this.panel1.Controls.Add(this.dateExpiration);
            this.panel1.Controls.Add(this.comboRefrigerated);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtBrand);
            this.panel1.Controls.Add(this.comboCategory);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 660);
            this.panel1.TabIndex = 0;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(666, 464);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(232, 33);
            this.txtTotalAmount.TabIndex = 18;
            this.txtTotalAmount.Text = "1";
            this.txtTotalAmount.Visible = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(666, 363);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(232, 33);
            this.txtTotalPrice.TabIndex = 12;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(666, 319);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(99, 25);
            this.labelTotalPrice.TabIndex = 17;
            this.labelTotalPrice.Text = "Total price";
            // 
            // txtPackingAmount
            // 
            this.txtPackingAmount.Enabled = false;
            this.txtPackingAmount.Location = new System.Drawing.Point(666, 252);
            this.txtPackingAmount.Name = "txtPackingAmount";
            this.txtPackingAmount.Size = new System.Drawing.Size(232, 33);
            this.txtPackingAmount.TabIndex = 11;
            this.txtPackingAmount.TextChanged += new System.EventHandler(this.UpdateAmount);
            this.txtPackingAmount.TextChanged += new System.EventHandler(this.MakeCalculationEvent);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(666, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Amount in packing";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(666, 141);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(232, 33);
            this.txtAmount.TabIndex = 10;
            this.txtAmount.Text = "1";
            this.txtAmount.TextChanged += new System.EventHandler(this.MakeCalculationEvent);
            this.txtAmount.TextChanged += new System.EventHandler(this.UpdateAmount);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.BackColor = System.Drawing.Color.Bisque;
            this.btnSaveAndNew.Location = new System.Drawing.Point(579, 22);
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(166, 40);
            this.btnSaveAndNew.TabIndex = 14;
            this.btnSaveAndNew.Text = "Save and New";
            this.btnSaveAndNew.UseVisualStyleBackColor = false;
            this.btnSaveAndNew.Click += new System.EventHandler(this.BtnSaveAndNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Location = new System.Drawing.Point(444, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCancel.Location = new System.Drawing.Point(769, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // labelError
            // 
            this.labelError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelError.ForeColor = System.Drawing.Color.Maroon;
            this.labelError.Location = new System.Drawing.Point(37, 613);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(564, 40);
            this.labelError.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(341, 569);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 33);
            this.txtDescription.TabIndex = 9;
            // 
            // comboPackingType
            // 
            this.comboPackingType.FormattingEnabled = true;
            this.comboPackingType.Location = new System.Drawing.Point(341, 464);
            this.comboPackingType.Name = "comboPackingType";
            this.comboPackingType.Size = new System.Drawing.Size(260, 33);
            this.comboPackingType.TabIndex = 8;
            this.comboPackingType.SelectedIndexChanged += new System.EventHandler(this.EnableAmountPackingField);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(341, 363);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(260, 33);
            this.txtWeight.TabIndex = 7;
            // 
            // comboLocation
            // 
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Location = new System.Drawing.Point(341, 252);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(260, 33);
            this.comboLocation.TabIndex = 6;
            // 
            // dateExpiration
            // 
            this.dateExpiration.Location = new System.Drawing.Point(341, 141);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(260, 33);
            this.dateExpiration.TabIndex = 5;
            // 
            // comboRefrigerated
            // 
            this.comboRefrigerated.FormattingEnabled = true;
            this.comboRefrigerated.Location = new System.Drawing.Point(37, 569);
            this.comboRefrigerated.Name = "comboRefrigerated";
            this.comboRefrigerated.Size = new System.Drawing.Size(241, 33);
            this.comboRefrigerated.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(37, 464);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(241, 33);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.MakeCalculationEvent);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(37, 363);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(241, 33);
            this.txtBrand.TabIndex = 2;
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(37, 252);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(241, 33);
            this.comboCategory.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 141);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 33);
            this.txtName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 528);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Packing type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Weight (kg)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Expiration Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Refrigerated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price (pr. unit)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(930, 660);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboRefrigerated;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.DateTimePicker dateExpiration;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox comboPackingType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAndNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPackingAmount;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtTotalAmount;
    }
}
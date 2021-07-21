
namespace VehicleApp
{
    partial class VehicleInventoryForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabNewVeh = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CBxVType = new System.Windows.Forms.ComboBox();
            this.TxtVIN = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtLicense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabInventory = new System.Windows.Forms.TabPage();
            this.LstInventory = new System.Windows.Forms.ListBox();
            this.TxtSummery = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TabNewVeh.SuspendLayout();
            this.TabInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.TabNewVeh);
            this.tabControl1.Controls.Add(this.TabInventory);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 316);
            this.tabControl1.TabIndex = 0;
            // 
            // TabNewVeh
            // 
            this.TabNewVeh.Controls.Add(this.textBox1);
            this.TabNewVeh.Controls.Add(this.CBxVType);
            this.TabNewVeh.Controls.Add(this.TxtVIN);
            this.TabNewVeh.Controls.Add(this.BtnAdd);
            this.TabNewVeh.Controls.Add(this.TxtLicense);
            this.TabNewVeh.Controls.Add(this.label3);
            this.TabNewVeh.Controls.Add(this.label2);
            this.TabNewVeh.Controls.Add(this.label1);
            this.TabNewVeh.Location = new System.Drawing.Point(4, 4);
            this.TabNewVeh.Name = "TabNewVeh";
            this.TabNewVeh.Padding = new System.Windows.Forms.Padding(3);
            this.TabNewVeh.Size = new System.Drawing.Size(247, 308);
            this.TabNewVeh.TabIndex = 0;
            this.TabNewVeh.Text = "New Vehicle Form";
            this.TabNewVeh.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 179);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(225, 123);
            this.textBox1.TabIndex = 8;
            // 
            // CBxVType
            // 
            this.CBxVType.FormattingEnabled = true;
            this.CBxVType.Items.AddRange(new object[] {
            "Sedan"});
            this.CBxVType.Location = new System.Drawing.Point(108, 90);
            this.CBxVType.Name = "CBxVType";
            this.CBxVType.Size = new System.Drawing.Size(125, 28);
            this.CBxVType.TabIndex = 7;
            // 
            // TxtVIN
            // 
            this.TxtVIN.Location = new System.Drawing.Point(108, 50);
            this.TxtVIN.Name = "TxtVIN";
            this.TxtVIN.Size = new System.Drawing.Size(125, 27);
            this.TxtVIN.TabIndex = 6;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(69, 133);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtLicense
            // 
            this.TxtLicense.Location = new System.Drawing.Point(108, 16);
            this.TxtLicense.Name = "TxtLicense";
            this.TxtLicense.Size = new System.Drawing.Size(125, 27);
            this.TxtLicense.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "VIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "License";
            // 
            // TabInventory
            // 
            this.TabInventory.Controls.Add(this.TxtSummery);
            this.TabInventory.Controls.Add(this.LstInventory);
            this.TabInventory.Location = new System.Drawing.Point(4, 4);
            this.TabInventory.Name = "TabInventory";
            this.TabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.TabInventory.Size = new System.Drawing.Size(247, 308);
            this.TabInventory.TabIndex = 1;
            this.TabInventory.Text = "Inventory List";
            this.TabInventory.UseVisualStyleBackColor = true;
            this.TabInventory.Click += new System.EventHandler(this.TabInventory_Click);
            // 
            // LstInventory
            // 
            this.LstInventory.FormattingEnabled = true;
            this.LstInventory.ItemHeight = 20;
            this.LstInventory.Location = new System.Drawing.Point(7, 6);
            this.LstInventory.Name = "LstInventory";
            this.LstInventory.Size = new System.Drawing.Size(235, 184);
            this.LstInventory.TabIndex = 1;
            this.LstInventory.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListInventory_MDoubleClick);
            // 
            // TxtSummery
            // 
            this.TxtSummery.Location = new System.Drawing.Point(7, 196);
            this.TxtSummery.Multiline = true;
            this.TxtSummery.Name = "TxtSummery";
            this.TxtSummery.ReadOnly = true;
            this.TxtSummery.Size = new System.Drawing.Size(234, 106);
            this.TxtSummery.TabIndex = 2;
            // 
            // VehicleInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 354);
            this.Controls.Add(this.tabControl1);
            this.Name = "VehicleInventoryForm";
            this.Text = "Vehicle Inventory";
            this.tabControl1.ResumeLayout(false);
            this.TabNewVeh.ResumeLayout(false);
            this.TabNewVeh.PerformLayout();
            this.TabInventory.ResumeLayout(false);
            this.TabInventory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabNewVeh;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TabInventory;
        private System.Windows.Forms.ListBox LstInventory;
        private System.Windows.Forms.ComboBox CBxVType;
        private System.Windows.Forms.TextBox TxtVIN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtSummery;
    }
}


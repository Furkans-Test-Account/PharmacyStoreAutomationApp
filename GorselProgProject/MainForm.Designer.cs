namespace GorselProgProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBoxMedicine = new GroupBox();
            labelidd = new Label();
            textBox6 = new TextBox();
            labelStock = new Label();
            labelOrder = new Label();
            buttonOrder = new Button();
            textBox1 = new TextBox();
            labelOwner = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            labelPrice = new Label();
            labelExpDate = new Label();
            labelPlace = new Label();
            labelLicenseNo = new Label();
            labelName = new Label();
            labeliD = new Label();
            groupBox2 = new GroupBox();
            groupBoxDepo = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBoxMedicine.SuspendLayout();
            groupBoxDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMedicine
            // 
            groupBoxMedicine.BackColor = SystemColors.ActiveCaption;
            groupBoxMedicine.Controls.Add(labelidd);
            groupBoxMedicine.Controls.Add(textBox6);
            groupBoxMedicine.Controls.Add(labelStock);
            groupBoxMedicine.Controls.Add(labelOrder);
            groupBoxMedicine.Controls.Add(buttonOrder);
            groupBoxMedicine.Controls.Add(textBox1);
            groupBoxMedicine.Controls.Add(labelOwner);
            groupBoxMedicine.Controls.Add(dateTimePicker1);
            groupBoxMedicine.Controls.Add(textBox5);
            groupBoxMedicine.Controls.Add(textBox4);
            groupBoxMedicine.Controls.Add(textBox3);
            groupBoxMedicine.Controls.Add(textBox2);
            groupBoxMedicine.Controls.Add(buttonUpdate);
            groupBoxMedicine.Controls.Add(buttonAdd);
            groupBoxMedicine.Controls.Add(labelPrice);
            groupBoxMedicine.Controls.Add(labelExpDate);
            groupBoxMedicine.Controls.Add(labelPlace);
            groupBoxMedicine.Controls.Add(labelLicenseNo);
            groupBoxMedicine.Controls.Add(labelName);
            groupBoxMedicine.Controls.Add(labeliD);
            groupBoxMedicine.Controls.Add(groupBox2);
            groupBoxMedicine.Location = new Point(3, 1);
            groupBoxMedicine.Name = "groupBoxMedicine";
            groupBoxMedicine.Size = new Size(397, 461);
            groupBoxMedicine.TabIndex = 0;
            groupBoxMedicine.TabStop = false;
            groupBoxMedicine.Text = "Control Panel";
            // 
            // labelidd
            // 
            labelidd.AutoSize = true;
            labelidd.Location = new Point(191, 31);
            labelidd.Name = "labelidd";
            labelidd.Size = new Size(17, 15);
            labelidd.TabIndex = 22;
            labelidd.Text = "id";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(204, 274);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 21;
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new Point(24, 277);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(55, 15);
            labelStock.TabIndex = 20;
            labelStock.Text = "In Stock :";
            // 
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.Location = new Point(23, 407);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(95, 15);
            labelOrder.TabIndex = 19;
            labelOrder.Text = "Order Medicine :";
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(159, 403);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(75, 23);
            buttonOrder.TabIndex = 18;
            buttonOrder.Text = "Order Now";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 17;
            // 
            // labelOwner
            // 
            labelOwner.AutoSize = true;
            labelOwner.Location = new Point(24, 157);
            labelOwner.Name = "labelOwner";
            labelOwner.Size = new Size(90, 15);
            labelOwner.TabIndex = 16;
            labelOwner.Text = "License Owner :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 309);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(204, 230);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(204, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(204, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(259, 348);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(96, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update/Edit";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(159, 348);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add ";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(24, 238);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(39, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price :";
            // 
            // labelExpDate
            // 
            labelExpDate.AutoSize = true;
            labelExpDate.Location = new Point(23, 317);
            labelExpDate.Name = "labelExpDate";
            labelExpDate.Size = new Size(90, 15);
            labelExpDate.TabIndex = 6;
            labelExpDate.Text = "Expretion Date :";
            // 
            // labelPlace
            // 
            labelPlace.AutoSize = true;
            labelPlace.Location = new Point(24, 202);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(103, 15);
            labelPlace.TabIndex = 5;
            labelPlace.Text = "Production Place :";
            // 
            // labelLicenseNo
            // 
            labelLicenseNo.AutoSize = true;
            labelLicenseNo.Location = new Point(24, 111);
            labelLicenseNo.Name = "labelLicenseNo";
            labelLicenseNo.Size = new Size(99, 15);
            labelLicenseNo.TabIndex = 4;
            labelLicenseNo.Text = "License Number :";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(24, 69);
            labelName.Name = "labelName";
            labelName.Size = new Size(94, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Medicine Name:";
            // 
            // labeliD
            // 
            labeliD.AutoSize = true;
            labeliD.Location = new Point(24, 31);
            labeliD.Name = "labeliD";
            labeliD.Size = new Size(70, 15);
            labeliD.TabIndex = 2;
            labeliD.Text = "Medicine ID";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(403, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 270);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBoxDepo
            // 
            groupBoxDepo.Controls.Add(dataGridView1);
            groupBoxDepo.Location = new Point(406, 1);
            groupBoxDepo.Name = "groupBoxDepo";
            groupBoxDepo.Size = new Size(414, 461);
            groupBoxDepo.TabIndex = 2;
            groupBoxDepo.TabStop = false;
            groupBoxDepo.Text = "Depot";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(408, 439);
            dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 466);
            Controls.Add(groupBoxDepo);
            Controls.Add(groupBoxMedicine);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            groupBoxMedicine.ResumeLayout(false);
            groupBoxMedicine.PerformLayout();
            groupBoxDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMedicine;
        private GroupBox groupBox2;
        private GroupBox groupBoxDepo;
        private DataGridView dataGridView1;
        private Label labelPrice;
        private Label labelExpDate;
        private Label labelPlace;
        private Label labelLicenseNo;
        private Label labelName;
        private Label labeliD;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBox1;
        private Label labelOwner;
        private DateTimePicker dateTimePicker1;
        private Label labelOrder;
        private Button buttonOrder;
        private TextBox textBox6;
        private Label labelStock;
        private Label labelidd;
    }
}
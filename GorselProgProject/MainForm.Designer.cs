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
            buttonDelete = new Button();
            checkBoxStock = new CheckBox();
            labelidd = new Label();
            labelStock = new Label();
            labelOrder = new Label();
            buttonOrder = new Button();
            textBoxOwner = new TextBox();
            labelOwner = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBoxPrice = new TextBox();
            textBoxPlace = new TextBox();
            textBoxName = new TextBox();
            textBoxNumber = new TextBox();
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
            groupBoxMedicine.Controls.Add(buttonDelete);
            groupBoxMedicine.Controls.Add(checkBoxStock);
            groupBoxMedicine.Controls.Add(labelidd);
            groupBoxMedicine.Controls.Add(labelStock);
            groupBoxMedicine.Controls.Add(labelOrder);
            groupBoxMedicine.Controls.Add(buttonOrder);
            groupBoxMedicine.Controls.Add(textBoxOwner);
            groupBoxMedicine.Controls.Add(labelOwner);
            groupBoxMedicine.Controls.Add(dateTimePicker1);
            groupBoxMedicine.Controls.Add(textBoxPrice);
            groupBoxMedicine.Controls.Add(textBoxPlace);
            groupBoxMedicine.Controls.Add(textBoxName);
            groupBoxMedicine.Controls.Add(textBoxNumber);
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
            // buttonDelete
            // 
            buttonDelete.Location = new Point(310, 360);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(70, 23);
            buttonDelete.TabIndex = 24;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // checkBoxStock
            // 
            checkBoxStock.AutoSize = true;
            checkBoxStock.Location = new Point(243, 277);
            checkBoxStock.Name = "checkBoxStock";
            checkBoxStock.Size = new Size(15, 14);
            checkBoxStock.TabIndex = 23;
            checkBoxStock.UseVisualStyleBackColor = true;
            // 
            // labelidd
            // 
            labelidd.AutoSize = true;
            labelidd.Location = new Point(204, 31);
            labelidd.Name = "labelidd";
            labelidd.Size = new Size(17, 15);
            labelidd.TabIndex = 22;
            labelidd.Text = "id";
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
            // textBoxOwner
            // 
            textBoxOwner.Location = new Point(204, 154);
            textBoxOwner.Name = "textBoxOwner";
            textBoxOwner.Size = new Size(100, 23);
            textBoxOwner.TabIndex = 17;
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
            dateTimePicker1.Location = new Point(159, 317);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(204, 230);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 14;
            // 
            // textBoxPlace
            // 
            textBoxPlace.Location = new Point(204, 194);
            textBoxPlace.Name = "textBoxPlace";
            textBoxPlace.Size = new Size(100, 23);
            textBoxPlace.TabIndex = 13;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(204, 69);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 12;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(204, 111);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(100, 23);
            textBoxNumber.TabIndex = 11;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(225, 360);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(70, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(138, 360);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add ";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
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
            groupBoxDepo.Size = new Size(789, 461);
            groupBoxDepo.TabIndex = 2;
            groupBoxDepo.TabStop = false;
            groupBoxDepo.Text = "Depot";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(783, 439);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 472);
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
        private TextBox textBoxPrice;
        private TextBox textBoxPlace;
        private TextBox textBoxName;
        private TextBox textBoxNumber;
        private Button buttonUpdate;
        private Button buttonAdd;
        private TextBox textBoxOwner;
        private Label labelOwner;
        private DateTimePicker dateTimePicker1;
        private Label labelOrder;
        private Button buttonOrder;
        private Label labelStock;
        private Label labelidd;
        private CheckBox checkBoxStock;
        private Button buttonDelete;
    }
}
namespace GorselProgProject
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            labelChoice = new Label();
            richTextBoxMail = new RichTextBox();
            comboBoxList = new ComboBox();
            labelCity = new Label();
            listBoxCity = new ListBox();
            buttonSend = new Button();
            groupBoxRight = new GroupBox();
            groupBoxLeft = new GroupBox();
            textBoxSearch = new TextBox();
            groupBoxRight.SuspendLayout();
            groupBoxLeft.SuspendLayout();
            SuspendLayout();
            // 
            // labelChoice
            // 
            labelChoice.AutoSize = true;
            labelChoice.Location = new Point(6, 47);
            labelChoice.Name = "labelChoice";
            labelChoice.Size = new Size(63, 15);
            labelChoice.TabIndex = 2;
            labelChoice.Text = "Complaint";
            // 
            // richTextBoxMail
            // 
            richTextBoxMail.Location = new Point(37, 30);
            richTextBoxMail.Name = "richTextBoxMail";
            richTextBoxMail.Size = new Size(404, 260);
            richTextBoxMail.TabIndex = 6;
            richTextBoxMail.Text = "";
            // 
            // comboBoxList
            // 
            comboBoxList.FormattingEnabled = true;
            comboBoxList.Location = new Point(190, 47);
            comboBoxList.Name = "comboBoxList";
            comboBoxList.Size = new Size(121, 23);
            comboBoxList.TabIndex = 7;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(6, 122);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(28, 15);
            labelCity.TabIndex = 8;
            labelCity.Text = "City";
            // 
            // listBoxCity
            // 
            listBoxCity.FormattingEnabled = true;
            listBoxCity.ItemHeight = 15;
            listBoxCity.Location = new Point(190, 122);
            listBoxCity.Name = "listBoxCity";
            listBoxCity.Size = new Size(120, 94);
            listBoxCity.TabIndex = 9;
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(366, 321);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 23);
            buttonSend.TabIndex = 10;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // groupBoxRight
            // 
            groupBoxRight.BackColor = Color.Wheat;
            groupBoxRight.Controls.Add(richTextBoxMail);
            groupBoxRight.Controls.Add(buttonSend);
            groupBoxRight.Location = new Point(334, 8);
            groupBoxRight.Name = "groupBoxRight";
            groupBoxRight.Size = new Size(461, 439);
            groupBoxRight.TabIndex = 12;
            groupBoxRight.TabStop = false;
            groupBoxRight.Text = "groupBoxRight";
            // 
            // groupBoxLeft
            // 
            groupBoxLeft.BackColor = SystemColors.ActiveCaption;
            groupBoxLeft.Controls.Add(textBoxSearch);
            groupBoxLeft.Controls.Add(labelChoice);
            groupBoxLeft.Controls.Add(labelCity);
            groupBoxLeft.Controls.Add(comboBoxList);
            groupBoxLeft.Controls.Add(listBoxCity);
            groupBoxLeft.Location = new Point(0, 8);
            groupBoxLeft.Name = "groupBoxLeft";
            groupBoxLeft.Size = new Size(328, 439);
            groupBoxLeft.TabIndex = 13;
            groupBoxLeft.TabStop = false;
            groupBoxLeft.Text = "groupBoxLeft";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(90, 122);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(74, 23);
            textBoxSearch.TabIndex = 13;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxLeft);
            Controls.Add(groupBoxRight);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderForm";
            Text = "Order Form";
            Load += OrderForm_Load_1;
            groupBoxRight.ResumeLayout(false);
            groupBoxLeft.ResumeLayout(false);
            groupBoxLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelChoice;
        private RichTextBox richTextBoxMail;
        private ComboBox comboBoxList;
        private Label labelCity;
        private ListBox listBoxCity;
        private Button buttonSend;
        private GroupBox groupBoxRight;
        private GroupBox groupBoxLeft;
        private TextBox textBoxSearch;
    }
}
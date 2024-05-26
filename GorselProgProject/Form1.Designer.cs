namespace GorselProgProject
{
    partial class LoadingForm
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
            components = new System.ComponentModel.Container();
            labelLoading = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelLoading
            // 
            labelLoading.AutoSize = true;
            labelLoading.Location = new Point(67, 26);
            labelLoading.Name = "labelLoading";
            labelLoading.Size = new Size(38, 15);
            labelLoading.TabIndex = 0;
            labelLoading.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(27, 57);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(170, 23);
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(233, 116);
            Controls.Add(progressBar1);
            Controls.Add(labelLoading);
            Name = "LoadingForm";
            Text = "Loading...";
            Load += LoadingForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoading;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
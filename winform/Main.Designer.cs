namespace winform
{
    partial class frmMain
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
            lbusername = new Label();
            SuspendLayout();
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(285, 199);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(168, 20);
            lbusername.TabIndex = 1;
            lbusername.Text = "Đăng nhập thành công!!";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbusername);
            Name = "frmMain";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbusername;
    }
}
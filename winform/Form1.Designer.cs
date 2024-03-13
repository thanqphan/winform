namespace winform
{
    partial class Form1
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
            lbusername = new Label();
            txtusername = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(55, 21);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(73, 20);
            lbusername.TabIndex = 0;
            lbusername.Text = "username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(161, 21);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(157, 26);
            txtusername.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(161, 99);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(157, 26);
            txtMatKhau.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 99);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(txtMatKhau);
            Controls.Add(label1);
            Controls.Add(txtusername);
            Controls.Add(lbusername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbusername;
        private TextBox txtusername;
        private TextBox txtMatKhau;
        private Label label1;
    }
}
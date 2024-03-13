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
            txtPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(95, 44);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(109, 20);
            lbusername.TabIndex = 0;
            lbusername.Text = "Tên Đăng nhập";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(210, 41);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(157, 26);
            txtusername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(210, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 26);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 122);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Mật khẩu";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(265, 170);
            button1.Name = "button1";
            button1.Size = new Size(102, 29);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 261);
            Controls.Add(button1);
            Controls.Add(txtPassword);
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
        private TextBox txtPassword;
        private Label label1;
        private Button button1;
    }
}
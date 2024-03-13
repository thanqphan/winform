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
            SuspendLayout();
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(55, 22);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(73, 20);
            lbusername.TabIndex = 0;
            lbusername.Text = "username";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(161, 22);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(157, 27);
            txtusername.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
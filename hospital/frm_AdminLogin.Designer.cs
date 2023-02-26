namespace hospital
{
    partial class frm_AdminLogin
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
            this.txb_Power = new System.Windows.Forms.TextBox();
            this.lbl_Power = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Power
            // 
            this.txb_Power.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Power.Location = new System.Drawing.Point(224, 184);
            this.txb_Power.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Power.Name = "txb_Power";
            this.txb_Power.PasswordChar = '*';
            this.txb_Power.Size = new System.Drawing.Size(152, 30);
            this.txb_Power.TabIndex = 15;
            this.txb_Power.Text = "admin";
            // 
            // lbl_Power
            // 
            this.lbl_Power.AutoSize = true;
            this.lbl_Power.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Power.Location = new System.Drawing.Point(147, 189);
            this.lbl_Power.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Power.Name = "lbl_Power";
            this.lbl_Power.Size = new System.Drawing.Size(69, 20);
            this.lbl_Power.TabIndex = 14;
            this.lbl_Power.Text = "权限：";
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(224, 123);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.Size = new System.Drawing.Size(152, 30);
            this.txb_Password.TabIndex = 13;
            this.txb_Password.Text = "1234";
            // 
            // txb_Number
            // 
            this.txb_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Number.Location = new System.Drawing.Point(224, 55);
            this.txb_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(152, 30);
            this.txb_Number.TabIndex = 12;
            this.txb_Number.Text = "3200707014";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Close.Location = new System.Drawing.Point(345, 253);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 29);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "关闭";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(132, 253);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 29);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(147, 123);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Number.Location = new System.Drawing.Point(147, 55);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 20);
            this.lbl_Number.TabIndex = 8;
            this.lbl_Number.Text = "账号：";
            // 
            // frm_AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 337);
            this.Controls.Add(this.txb_Power);
            this.Controls.Add(this.lbl_Power);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Number);
            this.Name = "frm_AdminLogin";
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Power;
        private System.Windows.Forms.Label lbl_Power;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Number;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Number;
    }
}
namespace hospital
{
    partial class frm_User
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
            this.llbl_MissPassword = new System.Windows.Forms.LinkLabel();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llbl_MissPassword
            // 
            this.llbl_MissPassword.AutoSize = true;
            this.llbl_MissPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llbl_MissPassword.Location = new System.Drawing.Point(165, 153);
            this.llbl_MissPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_MissPassword.Name = "llbl_MissPassword";
            this.llbl_MissPassword.Size = new System.Drawing.Size(109, 20);
            this.llbl_MissPassword.TabIndex = 19;
            this.llbl_MissPassword.TabStop = true;
            this.llbl_MissPassword.Text = "忘记密码！";
            this.llbl_MissPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_MissPassword_LinkClicked);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SignUp.Location = new System.Drawing.Point(236, 183);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(100, 29);
            this.btn_SignUp.TabIndex = 18;
            this.btn_SignUp.Text = "注册";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.Location = new System.Drawing.Point(84, 183);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 29);
            this.btn_Login.TabIndex = 17;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_Password
            // 
            this.txb_Password.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Password.Location = new System.Drawing.Point(144, 109);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(151, 30);
            this.txb_Password.TabIndex = 16;
            this.txb_Password.Text = "xly020710";
            // 
            // txb_Number
            // 
            this.txb_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Number.Location = new System.Drawing.Point(143, 52);
            this.txb_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(152, 30);
            this.txb_Number.TabIndex = 15;
            this.txb_Number.Text = "3200707001";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(81, 113);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 20);
            this.lbl_Password.TabIndex = 14;
            this.lbl_Password.Text = "密码：";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Number.Location = new System.Drawing.Point(81, 56);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 20);
            this.lbl_Number.TabIndex = 13;
            this.lbl_Number.Text = "账号：";
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.llbl_MissPassword);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Number);
            this.Name = "frm_User";
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbl_MissPassword;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Number;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Number;
    }
}
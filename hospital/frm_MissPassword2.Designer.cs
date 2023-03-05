namespace hospital
{
    partial class frm_MissPassword2
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Confrim = new System.Windows.Forms.Button();
            this.lbl_AgainPassword = new System.Windows.Forms.Label();
            this.txb_AgainPassword = new System.Windows.Forms.TextBox();
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Reset.Location = new System.Drawing.Point(313, 237);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(100, 29);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "重置";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Confrim
            // 
            this.btn_Confrim.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confrim.Location = new System.Drawing.Point(65, 237);
            this.btn_Confrim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confrim.Name = "btn_Confrim";
            this.btn_Confrim.Size = new System.Drawing.Size(100, 29);
            this.btn_Confrim.TabIndex = 14;
            this.btn_Confrim.Text = "确认";
            this.btn_Confrim.UseVisualStyleBackColor = true;
            this.btn_Confrim.Click += new System.EventHandler(this.btn_Confrim_Click);
            // 
            // lbl_AgainPassword
            // 
            this.lbl_AgainPassword.AutoSize = true;
            this.lbl_AgainPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_AgainPassword.Location = new System.Drawing.Point(76, 147);
            this.lbl_AgainPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AgainPassword.Name = "lbl_AgainPassword";
            this.lbl_AgainPassword.Size = new System.Drawing.Size(109, 20);
            this.lbl_AgainPassword.TabIndex = 13;
            this.lbl_AgainPassword.Text = "确认密码：";
            // 
            // txb_AgainPassword
            // 
            this.txb_AgainPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_AgainPassword.Location = new System.Drawing.Point(189, 144);
            this.txb_AgainPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txb_AgainPassword.Name = "txb_AgainPassword";
            this.txb_AgainPassword.Size = new System.Drawing.Size(160, 30);
            this.txb_AgainPassword.TabIndex = 12;
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_NewPassword.Location = new System.Drawing.Point(189, 95);
            this.txb_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.Size = new System.Drawing.Size(160, 30);
            this.txb_NewPassword.TabIndex = 11;
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.AutoSize = true;
            this.lbl_NewPassword.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NewPassword.Location = new System.Drawing.Point(100, 99);
            this.lbl_NewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(89, 20);
            this.lbl_NewPassword.TabIndex = 10;
            this.lbl_NewPassword.Text = "新密码：";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Number.Location = new System.Drawing.Point(116, 44);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 20);
            this.lbl_Number.TabIndex = 9;
            this.lbl_Number.Text = "账号：";
            // 
            // txb_Number
            // 
            this.txb_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Number.Location = new System.Drawing.Point(189, 44);
            this.txb_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.ReadOnly = true;
            this.txb_Number.Size = new System.Drawing.Size(160, 30);
            this.txb_Number.TabIndex = 8;
            // 
            // frm_MissPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 298);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Confrim);
            this.Controls.Add(this.lbl_AgainPassword);
            this.Controls.Add(this.txb_AgainPassword);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.lbl_NewPassword);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.txb_Number);
            this.Name = "frm_MissPassword2";
            this.Text = "设置新密码";
            this.Load += new System.EventHandler(this.frm_MissPassword2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Confrim;
        private System.Windows.Forms.Label lbl_AgainPassword;
        private System.Windows.Forms.TextBox txb_AgainPassword;
        private System.Windows.Forms.TextBox txb_NewPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.TextBox txb_Number;
    }
}
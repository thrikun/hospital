namespace hospital
{
    partial class frm_MissPassword
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
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Confrim = new System.Windows.Forms.Button();
            this.btn_Catch = new System.Windows.Forms.Button();
            this.txb_CheckNumber = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.txb_Number = new System.Windows.Forms.TextBox();
            this.lbl_CheckNumber = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Return.Location = new System.Drawing.Point(269, 247);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(100, 29);
            this.btn_Return.TabIndex = 17;
            this.btn_Return.Text = "返回";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Confrim
            // 
            this.btn_Confrim.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Confrim.Location = new System.Drawing.Point(73, 247);
            this.btn_Confrim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confrim.Name = "btn_Confrim";
            this.btn_Confrim.Size = new System.Drawing.Size(100, 29);
            this.btn_Confrim.TabIndex = 16;
            this.btn_Confrim.Text = "确认";
            this.btn_Confrim.UseVisualStyleBackColor = true;
            this.btn_Confrim.Click += new System.EventHandler(this.btn_Confrim_Click);
            // 
            // btn_Catch
            // 
            this.btn_Catch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Catch.Location = new System.Drawing.Point(358, 167);
            this.btn_Catch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Catch.Name = "btn_Catch";
            this.btn_Catch.Size = new System.Drawing.Size(100, 29);
            this.btn_Catch.TabIndex = 15;
            this.btn_Catch.Text = "获取验证码";
            this.btn_Catch.UseVisualStyleBackColor = true;
            this.btn_Catch.Click += new System.EventHandler(this.btn_Catch_Click);
            // 
            // txb_CheckNumber
            // 
            this.txb_CheckNumber.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_CheckNumber.Location = new System.Drawing.Point(145, 170);
            this.txb_CheckNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txb_CheckNumber.Name = "txb_CheckNumber";
            this.txb_CheckNumber.Size = new System.Drawing.Size(173, 30);
            this.txb_CheckNumber.TabIndex = 14;
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Phone.Location = new System.Drawing.Point(145, 113);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(173, 30);
            this.txb_Phone.TabIndex = 13;
            // 
            // txb_Number
            // 
            this.txb_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Number.Location = new System.Drawing.Point(145, 59);
            this.txb_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Number.Name = "txb_Number";
            this.txb_Number.Size = new System.Drawing.Size(173, 30);
            this.txb_Number.TabIndex = 12;
            // 
            // lbl_CheckNumber
            // 
            this.lbl_CheckNumber.AutoSize = true;
            this.lbl_CheckNumber.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CheckNumber.Location = new System.Drawing.Point(57, 174);
            this.lbl_CheckNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CheckNumber.Name = "lbl_CheckNumber";
            this.lbl_CheckNumber.Size = new System.Drawing.Size(89, 20);
            this.lbl_CheckNumber.TabIndex = 11;
            this.lbl_CheckNumber.Text = "验证码：";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Phone.Location = new System.Drawing.Point(54, 116);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(89, 20);
            this.lbl_Phone.TabIndex = 10;
            this.lbl_Phone.Text = "手机号：";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Number.Location = new System.Drawing.Point(70, 63);
            this.lbl_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(69, 20);
            this.lbl_Number.TabIndex = 9;
            this.lbl_Number.Text = "账号：";
            // 
            // frm_MissPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 333);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Confrim);
            this.Controls.Add(this.btn_Catch);
            this.Controls.Add(this.txb_CheckNumber);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.txb_Number);
            this.Controls.Add(this.lbl_CheckNumber);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.lbl_Number);
            this.Name = "frm_MissPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "忘记密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Confrim;
        private System.Windows.Forms.Button btn_Catch;
        private System.Windows.Forms.TextBox txb_CheckNumber;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.TextBox txb_Number;
        private System.Windows.Forms.Label lbl_CheckNumber;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_Number;
    }
}
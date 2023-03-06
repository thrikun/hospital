namespace hospital
{
    partial class frm_HospitalSelfHelpSystem
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
            this.button1 = new System.Windows.Forms.Button();
            this.lnk_Out = new System.Windows.Forms.LinkLabel();
            this.btn_HospitalAccountRecord = new System.Windows.Forms.Button();
            this.btn_BankBind = new System.Windows.Forms.Button();
            this.btn_OutpatientRecharge = new System.Windows.Forms.Button();
            this.btn_BalanceInquiry = new System.Windows.Forms.Button();
            this.btn_OutpatientAppointment = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "历史病例";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnk_Out
            // 
            this.lnk_Out.AutoSize = true;
            this.lnk_Out.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnk_Out.Location = new System.Drawing.Point(565, 23);
            this.lnk_Out.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnk_Out.Name = "lnk_Out";
            this.lnk_Out.Size = new System.Drawing.Size(109, 20);
            this.lnk_Out.TabIndex = 24;
            this.lnk_Out.TabStop = true;
            this.lnk_Out.Text = "退出登录！";
            this.lnk_Out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Out_LinkClicked);
            // 
            // btn_HospitalAccountRecord
            // 
            this.btn_HospitalAccountRecord.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_HospitalAccountRecord.Location = new System.Drawing.Point(510, 117);
            this.btn_HospitalAccountRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btn_HospitalAccountRecord.Name = "btn_HospitalAccountRecord";
            this.btn_HospitalAccountRecord.Size = new System.Drawing.Size(123, 94);
            this.btn_HospitalAccountRecord.TabIndex = 23;
            this.btn_HospitalAccountRecord.Text = "交易记录";
            this.btn_HospitalAccountRecord.UseVisualStyleBackColor = true;
            // 
            // btn_BankBind
            // 
            this.btn_BankBind.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BankBind.Location = new System.Drawing.Point(386, 117);
            this.btn_BankBind.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BankBind.Name = "btn_BankBind";
            this.btn_BankBind.Size = new System.Drawing.Size(116, 94);
            this.btn_BankBind.TabIndex = 22;
            this.btn_BankBind.Text = "银行卡绑定";
            this.btn_BankBind.UseVisualStyleBackColor = true;
            // 
            // btn_OutpatientRecharge
            // 
            this.btn_OutpatientRecharge.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OutpatientRecharge.Location = new System.Drawing.Point(262, 116);
            this.btn_OutpatientRecharge.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OutpatientRecharge.Name = "btn_OutpatientRecharge";
            this.btn_OutpatientRecharge.Size = new System.Drawing.Size(115, 95);
            this.btn_OutpatientRecharge.TabIndex = 16;
            this.btn_OutpatientRecharge.Text = "门诊充值";
            this.btn_OutpatientRecharge.UseVisualStyleBackColor = true;
            // 
            // btn_BalanceInquiry
            // 
            this.btn_BalanceInquiry.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BalanceInquiry.Location = new System.Drawing.Point(262, 219);
            this.btn_BalanceInquiry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BalanceInquiry.Name = "btn_BalanceInquiry";
            this.btn_BalanceInquiry.Size = new System.Drawing.Size(115, 92);
            this.btn_BalanceInquiry.TabIndex = 17;
            this.btn_BalanceInquiry.Text = "余额查询";
            this.btn_BalanceInquiry.UseVisualStyleBackColor = true;
            // 
            // btn_OutpatientAppointment
            // 
            this.btn_OutpatientAppointment.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OutpatientAppointment.Location = new System.Drawing.Point(126, 117);
            this.btn_OutpatientAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OutpatientAppointment.Name = "btn_OutpatientAppointment";
            this.btn_OutpatientAppointment.Size = new System.Drawing.Size(129, 196);
            this.btn_OutpatientAppointment.TabIndex = 15;
            this.btn_OutpatientAppointment.Text = "门诊预约";
            this.btn_OutpatientAppointment.UseVisualStyleBackColor = true;
            this.btn_OutpatientAppointment.Click += new System.EventHandler(this.btn_OutpatientAppointment_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Status.Location = new System.Drawing.Point(464, 23);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 20);
            this.lbl_Status.TabIndex = 25;
            // 
            // frm_HospitalSelfHelpSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lnk_Out);
            this.Controls.Add(this.btn_HospitalAccountRecord);
            this.Controls.Add(this.btn_BankBind);
            this.Controls.Add(this.btn_OutpatientRecharge);
            this.Controls.Add(this.btn_BalanceInquiry);
            this.Controls.Add(this.btn_OutpatientAppointment);
            this.Controls.Add(this.button1);
            this.Name = "frm_HospitalSelfHelpSystem";
            this.Text = "用户中心";
            this.Load += new System.EventHandler(this.frm_HospitalSelfHelpSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnk_Out;
        private System.Windows.Forms.Button btn_HospitalAccountRecord;
        private System.Windows.Forms.Button btn_BankBind;
        private System.Windows.Forms.Button btn_OutpatientRecharge;
        private System.Windows.Forms.Button btn_BalanceInquiry;
        private System.Windows.Forms.Button btn_OutpatientAppointment;
        private System.Windows.Forms.Label lbl_Status;
    }
}
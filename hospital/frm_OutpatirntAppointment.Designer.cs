namespace hospital
{
    partial class frm_OutpatirntAppointment
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
            this.btn_Appoint = new System.Windows.Forms.Button();
            this.gpb_Select = new System.Windows.Forms.GroupBox();
            this.cmb_Select = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.gpb_Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Appoint
            // 
            this.btn_Appoint.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Appoint.Location = new System.Drawing.Point(212, 178);
            this.btn_Appoint.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Appoint.Name = "btn_Appoint";
            this.btn_Appoint.Size = new System.Drawing.Size(100, 29);
            this.btn_Appoint.TabIndex = 16;
            this.btn_Appoint.Text = "预约";
            this.btn_Appoint.UseVisualStyleBackColor = true;
            // 
            // gpb_Select
            // 
            this.gpb_Select.Controls.Add(this.cmb_Select);
            this.gpb_Select.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpb_Select.Location = new System.Drawing.Point(95, 87);
            this.gpb_Select.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_Select.Name = "gpb_Select";
            this.gpb_Select.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_Select.Size = new System.Drawing.Size(321, 71);
            this.gpb_Select.TabIndex = 14;
            this.gpb_Select.TabStop = false;
            this.gpb_Select.Text = "请选择科室：";
            // 
            // cmb_Select
            // 
            this.cmb_Select.FormattingEnabled = true;
            this.cmb_Select.Location = new System.Drawing.Point(35, 31);
            this.cmb_Select.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Select.Name = "cmb_Select";
            this.cmb_Select.Size = new System.Drawing.Size(256, 28);
            this.cmb_Select.TabIndex = 13;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Status.Location = new System.Drawing.Point(13, 9);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 20);
            this.lbl_Status.TabIndex = 17;
            // 
            // frm_OutpatirntAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 323);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Appoint);
            this.Controls.Add(this.gpb_Select);
            this.Name = "frm_OutpatirntAppointment";
            this.Text = "门诊预约";
            this.Load += new System.EventHandler(this.frm_OutpatirntAppointment_Load);
            this.gpb_Select.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Appoint;
        private System.Windows.Forms.GroupBox gpb_Select;
        private System.Windows.Forms.ComboBox cmb_Select;
        private System.Windows.Forms.Label lbl_Status;
    }
}
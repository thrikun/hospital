namespace hospital
{
    partial class frm_HistoricalCases
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
            this.lnk_Return = new System.Windows.Forms.LinkLabel();
            this.btn_SeekPrescribe = new System.Windows.Forms.Button();
            this.btn_Seek = new System.Windows.Forms.Button();
            this.cmb_IsHospital = new System.Windows.Forms.ComboBox();
            this.lbl_IsHospital = new System.Windows.Forms.Label();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.txb_Seek = new System.Windows.Forms.TextBox();
            this.dtp_Seek = new System.Windows.Forms.DateTimePicker();
            this.btn_DESC = new System.Windows.Forms.Button();
            this.btn_ASC = new System.Windows.Forms.Button();
            this.cmb_Seek = new System.Windows.Forms.ComboBox();
            this.lbl_Seek = new System.Windows.Forms.Label();
            this.dgv_HistoricalCases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricalCases)).BeginInit();
            this.SuspendLayout();
            // 
            // lnk_Return
            // 
            this.lnk_Return.AutoSize = true;
            this.lnk_Return.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnk_Return.Location = new System.Drawing.Point(905, 11);
            this.lnk_Return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnk_Return.Name = "lnk_Return";
            this.lnk_Return.Size = new System.Drawing.Size(49, 20);
            this.lnk_Return.TabIndex = 31;
            this.lnk_Return.TabStop = true;
            this.lnk_Return.Text = "返回";
            // 
            // btn_SeekPrescribe
            // 
            this.btn_SeekPrescribe.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_SeekPrescribe.Location = new System.Drawing.Point(769, 116);
            this.btn_SeekPrescribe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SeekPrescribe.Name = "btn_SeekPrescribe";
            this.btn_SeekPrescribe.Size = new System.Drawing.Size(121, 29);
            this.btn_SeekPrescribe.TabIndex = 30;
            this.btn_SeekPrescribe.Text = "查看开药记录";
            this.btn_SeekPrescribe.UseVisualStyleBackColor = true;
            // 
            // btn_Seek
            // 
            this.btn_Seek.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Seek.Location = new System.Drawing.Point(274, 34);
            this.btn_Seek.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Seek.Name = "btn_Seek";
            this.btn_Seek.Size = new System.Drawing.Size(100, 29);
            this.btn_Seek.TabIndex = 29;
            this.btn_Seek.Text = "查找";
            this.btn_Seek.UseVisualStyleBackColor = true;
            this.btn_Seek.Click += new System.EventHandler(this.btn_Seek_Click);
            // 
            // cmb_IsHospital
            // 
            this.cmb_IsHospital.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_IsHospital.FormattingEnabled = true;
            this.cmb_IsHospital.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmb_IsHospital.Location = new System.Drawing.Point(529, 120);
            this.cmb_IsHospital.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_IsHospital.Name = "cmb_IsHospital";
            this.cmb_IsHospital.Size = new System.Drawing.Size(96, 28);
            this.cmb_IsHospital.TabIndex = 28;
            // 
            // lbl_IsHospital
            // 
            this.lbl_IsHospital.AutoSize = true;
            this.lbl_IsHospital.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_IsHospital.Location = new System.Drawing.Point(434, 124);
            this.lbl_IsHospital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IsHospital.Name = "lbl_IsHospital";
            this.lbl_IsHospital.Size = new System.Drawing.Size(109, 20);
            this.lbl_IsHospital.TabIndex = 27;
            this.lbl_IsHospital.Text = "是否住院：";
            // 
            // cmb_Year
            // 
            this.cmb_Year.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Location = new System.Drawing.Point(529, 71);
            this.cmb_Year.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(96, 28);
            this.cmb_Year.TabIndex = 26;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Year.Location = new System.Drawing.Point(466, 75);
            this.lbl_Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(69, 20);
            this.lbl_Year.TabIndex = 25;
            this.lbl_Year.Text = "年龄：";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmb_Gender.Location = new System.Drawing.Point(529, 25);
            this.cmb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(96, 28);
            this.cmb_Gender.TabIndex = 24;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(466, 29);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(69, 20);
            this.lbl_Gender.TabIndex = 23;
            this.lbl_Gender.Text = "性别：";
            // 
            // txb_Seek
            // 
            this.txb_Seek.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_Seek.Location = new System.Drawing.Point(44, 110);
            this.txb_Seek.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Seek.Name = "txb_Seek";
            this.txb_Seek.Size = new System.Drawing.Size(265, 30);
            this.txb_Seek.TabIndex = 22;
            // 
            // dtp_Seek
            // 
            this.dtp_Seek.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Seek.Location = new System.Drawing.Point(44, 75);
            this.dtp_Seek.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Seek.Name = "dtp_Seek";
            this.dtp_Seek.Size = new System.Drawing.Size(265, 30);
            this.dtp_Seek.TabIndex = 21;
            // 
            // btn_DESC
            // 
            this.btn_DESC.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DESC.Location = new System.Drawing.Point(844, 61);
            this.btn_DESC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DESC.Name = "btn_DESC";
            this.btn_DESC.Size = new System.Drawing.Size(100, 29);
            this.btn_DESC.TabIndex = 20;
            this.btn_DESC.Text = "降序";
            this.btn_DESC.UseVisualStyleBackColor = true;
            // 
            // btn_ASC
            // 
            this.btn_ASC.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ASC.Location = new System.Drawing.Point(696, 61);
            this.btn_ASC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ASC.Name = "btn_ASC";
            this.btn_ASC.Size = new System.Drawing.Size(100, 29);
            this.btn_ASC.TabIndex = 19;
            this.btn_ASC.Text = "升序";
            this.btn_ASC.UseVisualStyleBackColor = true;
            // 
            // cmb_Seek
            // 
            this.cmb_Seek.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_Seek.FormattingEnabled = true;
            this.cmb_Seek.Location = new System.Drawing.Point(136, 36);
            this.cmb_Seek.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Seek.Name = "cmb_Seek";
            this.cmb_Seek.Size = new System.Drawing.Size(84, 28);
            this.cmb_Seek.TabIndex = 18;
            // 
            // lbl_Seek
            // 
            this.lbl_Seek.AutoSize = true;
            this.lbl_Seek.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Seek.Location = new System.Drawing.Point(41, 40);
            this.lbl_Seek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Seek.Name = "lbl_Seek";
            this.lbl_Seek.Size = new System.Drawing.Size(109, 20);
            this.lbl_Seek.TabIndex = 17;
            this.lbl_Seek.Text = "查找条件：";
            // 
            // dgv_HistoricalCases
            // 
            this.dgv_HistoricalCases.AllowUserToAddRows = false;
            this.dgv_HistoricalCases.AllowUserToDeleteRows = false;
            this.dgv_HistoricalCases.AllowUserToResizeColumns = false;
            this.dgv_HistoricalCases.AllowUserToResizeRows = false;
            this.dgv_HistoricalCases.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HistoricalCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HistoricalCases.Location = new System.Drawing.Point(25, 166);
            this.dgv_HistoricalCases.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_HistoricalCases.Name = "dgv_HistoricalCases";
            this.dgv_HistoricalCases.RowHeadersWidth = 51;
            this.dgv_HistoricalCases.RowTemplate.Height = 23;
            this.dgv_HistoricalCases.Size = new System.Drawing.Size(919, 390);
            this.dgv_HistoricalCases.TabIndex = 16;
            // 
            // frm_HistoricalCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 566);
            this.Controls.Add(this.lnk_Return);
            this.Controls.Add(this.btn_SeekPrescribe);
            this.Controls.Add(this.btn_Seek);
            this.Controls.Add(this.cmb_IsHospital);
            this.Controls.Add(this.lbl_IsHospital);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.txb_Seek);
            this.Controls.Add(this.dtp_Seek);
            this.Controls.Add(this.btn_DESC);
            this.Controls.Add(this.btn_ASC);
            this.Controls.Add(this.cmb_Seek);
            this.Controls.Add(this.lbl_Seek);
            this.Controls.Add(this.dgv_HistoricalCases);
            this.Name = "frm_HistoricalCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "历史病例";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HistoricalCases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnk_Return;
        private System.Windows.Forms.Button btn_SeekPrescribe;
        private System.Windows.Forms.Button btn_Seek;
        private System.Windows.Forms.ComboBox cmb_IsHospital;
        private System.Windows.Forms.Label lbl_IsHospital;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox txb_Seek;
        private System.Windows.Forms.DateTimePicker dtp_Seek;
        private System.Windows.Forms.Button btn_DESC;
        private System.Windows.Forms.Button btn_ASC;
        private System.Windows.Forms.ComboBox cmb_Seek;
        private System.Windows.Forms.Label lbl_Seek;
        private System.Windows.Forms.DataGridView dgv_HistoricalCases;
    }
}
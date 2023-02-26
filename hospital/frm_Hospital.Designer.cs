namespace 闽侯县医院门诊系统
{
    partial class frm_Hospital
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.btn_Administator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_User
            // 
            this.btn_User.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_User.Location = new System.Drawing.Point(191, 79);
            this.btn_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(100, 29);
            this.btn_User.TabIndex = 3;
            this.btn_User.Text = "用户端";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Doctor.Location = new System.Drawing.Point(36, 79);
            this.btn_Doctor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(100, 29);
            this.btn_Doctor.TabIndex = 2;
            this.btn_Doctor.Text = "医生端";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // btn_Administator
            // 
            this.btn_Administator.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Administator.Location = new System.Drawing.Point(113, 129);
            this.btn_Administator.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Administator.Name = "btn_Administator";
            this.btn_Administator.Size = new System.Drawing.Size(100, 29);
            this.btn_Administator.TabIndex = 4;
            this.btn_Administator.Text = "管理员";
            this.btn_Administator.UseVisualStyleBackColor = true;
            this.btn_Administator.Click += new System.EventHandler(this.btn_Administator_Click);
            // 
            // frm_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(333, 185);
            this.Controls.Add(this.btn_Administator);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Doctor);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Hospital";
            this.Text = "闽侯县医院";
            this.Load += new System.EventHandler(this.frm_Hospital_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Button btn_Administator;
    }
}


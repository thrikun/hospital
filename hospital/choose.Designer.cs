namespace hospital
{
    partial class choose
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
            this.btn_Administator = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Administator
            // 
            this.btn_Administator.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Administator.Location = new System.Drawing.Point(131, 102);
            this.btn_Administator.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Administator.Name = "btn_Administator";
            this.btn_Administator.Size = new System.Drawing.Size(100, 29);
            this.btn_Administator.TabIndex = 7;
            this.btn_Administator.Text = "管理员";
            this.btn_Administator.UseVisualStyleBackColor = true;
            this.btn_Administator.Click += new System.EventHandler(this.btn_Administator_Click);
            // 
            // btn_User
            // 
            this.btn_User.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_User.Location = new System.Drawing.Point(209, 52);
            this.btn_User.Margin = new System.Windows.Forms.Padding(4);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(100, 29);
            this.btn_User.TabIndex = 6;
            this.btn_User.Text = "用户端";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Doctor.Location = new System.Drawing.Point(54, 52);
            this.btn_Doctor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(100, 29);
            this.btn_Doctor.TabIndex = 5;
            this.btn_Doctor.Text = "医生端";
            this.btn_Doctor.UseVisualStyleBackColor = true;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 197);
            this.Controls.Add(this.btn_Administator);
            this.Controls.Add(this.btn_User);
            this.Controls.Add(this.btn_Doctor);
            this.Name = "choose";
            this.Text = "选择身份";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Administator;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Doctor;
    }
}


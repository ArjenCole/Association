namespace Association
{
    partial class FMmain
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
            this.TXTextension = new System.Windows.Forms.TextBox();
            this.BTNexe = new System.Windows.Forms.Button();
            this.PBfileIco = new System.Windows.Forms.PictureBox();
            this.BTNassociation = new System.Windows.Forms.Button();
            this.LBLextension = new System.Windows.Forms.Label();
            this.LBLexePath = new System.Windows.Forms.Label();
            this.LBLfileDiscribe = new System.Windows.Forms.Label();
            this.TXTfileDiscribe = new System.Windows.Forms.TextBox();
            this.LBLcontent = new System.Windows.Forms.Label();
            this.TXTcontent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBfileIco)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTextension
            // 
            this.TXTextension.Location = new System.Drawing.Point(98, 12);
            this.TXTextension.Name = "TXTextension";
            this.TXTextension.Size = new System.Drawing.Size(57, 21);
            this.TXTextension.TabIndex = 0;
            this.TXTextension.TextChanged += new System.EventHandler(this.TXTextension_TextChanged);
            // 
            // BTNexe
            // 
            this.BTNexe.Location = new System.Drawing.Point(29, 118);
            this.BTNexe.Name = "BTNexe";
            this.BTNexe.Size = new System.Drawing.Size(126, 23);
            this.BTNexe.TabIndex = 1;
            this.BTNexe.Text = "选择程序";
            this.BTNexe.UseVisualStyleBackColor = true;
            this.BTNexe.Click += new System.EventHandler(this.BTNexe_Click);
            // 
            // PBfileIco
            // 
            this.PBfileIco.Location = new System.Drawing.Point(40, 253);
            this.PBfileIco.Name = "PBfileIco";
            this.PBfileIco.Size = new System.Drawing.Size(100, 100);
            this.PBfileIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBfileIco.TabIndex = 2;
            this.PBfileIco.TabStop = false;
            this.PBfileIco.Click += new System.EventHandler(this.PBfileIco_Click);
            // 
            // BTNassociation
            // 
            this.BTNassociation.Location = new System.Drawing.Point(29, 361);
            this.BTNassociation.Name = "BTNassociation";
            this.BTNassociation.Size = new System.Drawing.Size(126, 100);
            this.BTNassociation.TabIndex = 3;
            this.BTNassociation.Text = "确认关联";
            this.BTNassociation.UseVisualStyleBackColor = true;
            this.BTNassociation.Click += new System.EventHandler(this.BTNassociation_Click);
            // 
            // LBLextension
            // 
            this.LBLextension.AutoSize = true;
            this.LBLextension.Location = new System.Drawing.Point(27, 15);
            this.LBLextension.Name = "LBLextension";
            this.LBLextension.Size = new System.Drawing.Size(53, 12);
            this.LBLextension.TabIndex = 4;
            this.LBLextension.Text = "扩展名：";
            // 
            // LBLexePath
            // 
            this.LBLexePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLexePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBLexePath.Location = new System.Drawing.Point(29, 149);
            this.LBLexePath.Name = "LBLexePath";
            this.LBLexePath.Size = new System.Drawing.Size(126, 96);
            this.LBLexePath.TabIndex = 5;
            this.LBLexePath.Text = "程序地址";
            this.LBLexePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBLfileDiscribe
            // 
            this.LBLfileDiscribe.AutoSize = true;
            this.LBLfileDiscribe.Location = new System.Drawing.Point(27, 44);
            this.LBLfileDiscribe.Name = "LBLfileDiscribe";
            this.LBLfileDiscribe.Size = new System.Drawing.Size(65, 12);
            this.LBLfileDiscribe.TabIndex = 7;
            this.LBLfileDiscribe.Text = "文件描述：";
            // 
            // TXTfileDiscribe
            // 
            this.TXTfileDiscribe.Location = new System.Drawing.Point(98, 41);
            this.TXTfileDiscribe.Name = "TXTfileDiscribe";
            this.TXTfileDiscribe.Size = new System.Drawing.Size(57, 21);
            this.TXTfileDiscribe.TabIndex = 6;
            // 
            // LBLcontent
            // 
            this.LBLcontent.AutoSize = true;
            this.LBLcontent.Location = new System.Drawing.Point(27, 81);
            this.LBLcontent.Name = "LBLcontent";
            this.LBLcontent.Size = new System.Drawing.Size(65, 12);
            this.LBLcontent.TabIndex = 9;
            this.LBLcontent.Text = "文件内容：";
            // 
            // TXTcontent
            // 
            this.TXTcontent.Location = new System.Drawing.Point(98, 78);
            this.TXTcontent.Name = "TXTcontent";
            this.TXTcontent.Size = new System.Drawing.Size(57, 21);
            this.TXTcontent.TabIndex = 8;
            // 
            // FMmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 480);
            this.Controls.Add(this.LBLcontent);
            this.Controls.Add(this.TXTcontent);
            this.Controls.Add(this.LBLfileDiscribe);
            this.Controls.Add(this.TXTfileDiscribe);
            this.Controls.Add(this.LBLexePath);
            this.Controls.Add(this.LBLextension);
            this.Controls.Add(this.BTNassociation);
            this.Controls.Add(this.PBfileIco);
            this.Controls.Add(this.BTNexe);
            this.Controls.Add(this.TXTextension);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ass";
            ((System.ComponentModel.ISupportInitialize)(this.PBfileIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTextension;
        private System.Windows.Forms.Button BTNexe;
        private System.Windows.Forms.PictureBox PBfileIco;
        private System.Windows.Forms.Button BTNassociation;
        private System.Windows.Forms.Label LBLextension;
        private System.Windows.Forms.Label LBLexePath;
        private System.Windows.Forms.Label LBLfileDiscribe;
        private System.Windows.Forms.TextBox TXTfileDiscribe;
        private System.Windows.Forms.Label LBLcontent;
        private System.Windows.Forms.TextBox TXTcontent;
    }
}


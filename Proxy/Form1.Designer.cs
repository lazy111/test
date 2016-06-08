namespace Proxy
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLazyLoad = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLazyLoad
            // 
            this.btnLazyLoad.Location = new System.Drawing.Point(448, 99);
            this.btnLazyLoad.Name = "btnLazyLoad";
            this.btnLazyLoad.Size = new System.Drawing.Size(106, 23);
            this.btnLazyLoad.TabIndex = 0;
            this.btnLazyLoad.Text = "Load Picture";
            this.btnLazyLoad.UseVisualStyleBackColor = true;
            this.btnLazyLoad.Click += new System.EventHandler(this.btnLazyLoad_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(41, 45);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(382, 205);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 335);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnLazyLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLazyLoad;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}


namespace WP_2020_01_MID_3A713155
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.tex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn.Location = new System.Drawing.Point(12, 185);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(353, 74);
            this.btn.TabIndex = 0;
            this.btn.Text = "分析運勢";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // tex
            // 
            this.tex.Font = new System.Drawing.Font("微軟正黑體", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tex.Location = new System.Drawing.Point(12, 77);
            this.tex.Multiline = true;
            this.tex.Name = "tex";
            this.tex.Size = new System.Drawing.Size(208, 90);
            this.tex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入星座";
            // 
            // pic
            // 
            this.pic.Image = global::WP_2020_01_MID_3A713155.Properties.Resources._1;
            this.pic.Location = new System.Drawing.Point(12, 276);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(435, 203);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(226, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 96);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter\r\n按一次就好";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.tex);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "星座運勢分析";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox tex;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


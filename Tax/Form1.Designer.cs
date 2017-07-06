namespace Tax
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPretax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAftertax = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "金額";
            // 
            // textBoxPretax
            // 
            this.textBoxPretax.Location = new System.Drawing.Point(15, 29);
            this.textBoxPretax.Name = "textBoxPretax";
            this.textBoxPretax.Size = new System.Drawing.Size(100, 19);
            this.textBoxPretax.TabIndex = 1;
            this.textBoxPretax.Text = "0";
            this.textBoxPretax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "税込金額";
            // 
            // labelAftertax
            // 
            this.labelAftertax.AutoSize = true;
            this.labelAftertax.Location = new System.Drawing.Point(204, 32);
            this.labelAftertax.Name = "labelAftertax";
            this.labelAftertax.Size = new System.Drawing.Size(27, 12);
            this.labelAftertax.TabIndex = 3;
            this.labelAftertax.Text = "0 円";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(140, 74);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "消費税追加";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "円";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 115);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelAftertax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPretax);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPretax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAftertax;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label4;
    }
}


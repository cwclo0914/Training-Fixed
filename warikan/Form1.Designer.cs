﻿namespace warikan
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPretax = new System.Windows.Forms.TextBox();
            this.textBoxPpl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPerperson = new System.Windows.Forms.Label();
            this.labelRemainder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // textBoxPretax
            // 
            this.textBoxPretax.Location = new System.Drawing.Point(15, 29);
            this.textBoxPretax.Name = "textBoxPretax";
            this.textBoxPretax.Size = new System.Drawing.Size(82, 19);
            this.textBoxPretax.TabIndex = 2;
            this.textBoxPretax.Text = "0";
            this.textBoxPretax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPpl
            // 
            this.textBoxPpl.Location = new System.Drawing.Point(145, 28);
            this.textBoxPpl.Name = "textBoxPpl";
            this.textBoxPpl.Size = new System.Drawing.Size(81, 19);
            this.textBoxPpl.TabIndex = 3;
            this.textBoxPpl.Text = "0";
            this.textBoxPpl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "円";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "余り";
            // 
            // labelPerperson
            // 
            this.labelPerperson.AutoSize = true;
            this.labelPerperson.Location = new System.Drawing.Point(13, 77);
            this.labelPerperson.Name = "labelPerperson";
            this.labelPerperson.Size = new System.Drawing.Size(27, 12);
            this.labelPerperson.TabIndex = 8;
            this.labelPerperson.Text = "0 円";
            // 
            // labelRemainder
            // 
            this.labelRemainder.AutoSize = true;
            this.labelRemainder.Location = new System.Drawing.Point(143, 77);
            this.labelRemainder.Name = "labelRemainder";
            this.labelRemainder.Size = new System.Drawing.Size(27, 12);
            this.labelRemainder.TabIndex = 9;
            this.labelRemainder.Text = "0 円";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRemainder);
            this.Controls.Add(this.labelPerperson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPpl);
            this.Controls.Add(this.textBoxPretax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPretax;
        private System.Windows.Forms.TextBox textBoxPpl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPerperson;
        private System.Windows.Forms.Label labelRemainder;
        private System.Windows.Forms.Button button1;
    }
}


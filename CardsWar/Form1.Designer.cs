namespace CardsWar
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
            this.labelCpuScore = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "コンピュータ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "プレイヤー";
            // 
            // labelCpuScore
            // 
            this.labelCpuScore.AutoSize = true;
            this.labelCpuScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCpuScore.Location = new System.Drawing.Point(14, 92);
            this.labelCpuScore.Name = "labelCpuScore";
            this.labelCpuScore.Size = new System.Drawing.Size(91, 19);
            this.labelCpuScore.TabIndex = 2;
            this.labelCpuScore.Text = "得点：0点";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPlayerScore.Location = new System.Drawing.Point(12, 265);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(91, 19);
            this.labelPlayerScore.TabIndex = 3;
            this.labelPlayerScore.Text = "得点：0点";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComment.ForeColor = System.Drawing.Color.Red;
            this.labelComment.Location = new System.Drawing.Point(143, 164);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(0, 19);
            this.labelComment.TabIndex = 4;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(360, 312);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 347);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelCpuScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCpuScore;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonStart;
    }
}


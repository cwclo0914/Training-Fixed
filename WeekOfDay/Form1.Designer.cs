namespace WeekOfDay
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
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDate = new System.Windows.Forms.NumericUpDown();
            this.labelDay = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "西暦年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "月";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "日";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(15, 29);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(62, 19);
            this.numericUpDownYear.TabIndex = 3;
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(85, 28);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(44, 19);
            this.numericUpDownMonth.TabIndex = 4;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownDate
            // 
            this.numericUpDownDate.Location = new System.Drawing.Point(143, 28);
            this.numericUpDownDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDate.Name = "numericUpDownDate";
            this.numericUpDownDate.Size = new System.Drawing.Size(44, 19);
            this.numericUpDownDate.TabIndex = 5;
            this.numericUpDownDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(221, 31);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(0, 12);
            this.labelDay.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(15, 54);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(332, 28);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "曜日算出";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 94);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.numericUpDownDate);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDate;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Button buttonCalculate;
    }
}


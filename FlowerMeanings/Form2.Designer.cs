namespace FlowerMeanings
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewContents = new System.Windows.Forms.DataGridView();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Meaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContents
            // 
            this.dataGridViewContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeleteButton,
            this.Flower,
            this.Colour,
            this.Meaning});
            this.dataGridViewContents.Location = new System.Drawing.Point(15, 13);
            this.dataGridViewContents.Name = "dataGridViewContents";
            this.dataGridViewContents.RowTemplate.Height = 21;
            this.dataGridViewContents.Size = new System.Drawing.Size(693, 198);
            this.dataGridViewContents.TabIndex = 0;
            this.dataGridViewContents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContents_CellContentClick);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(277, 217);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(370, 217);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteButton.HeaderText = "削除";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ReadOnly = true;
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Flower
            // 
            this.Flower.HeaderText = "花の名前（カタカナ）";
            this.Flower.Name = "Flower";
            this.Flower.Width = 150;
            // 
            // Colour
            // 
            this.Colour.HeaderText = "色";
            this.Colour.Items.AddRange(new object[] {
            "",
            "赤",
            "白",
            "ピンク",
            "黄",
            "紫",
            "青",
            "黒"});
            this.Colour.Name = "Colour";
            this.Colour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Colour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Meaning
            // 
            this.Meaning.HeaderText = "花言葉";
            this.Meaning.Name = "Meaning";
            this.Meaning.Width = 300;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 246);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridViewContents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "花言葉の追加・編集・削除";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewContents;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flower;
        private System.Windows.Forms.DataGridViewComboBoxColumn Colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meaning;
    }
}
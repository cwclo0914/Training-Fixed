using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerMeanings
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> contentsDicationary = ContentsFileIO.Read();

            foreach (KeyValuePair<string,string> s in contentsDicationary)
            {
                if (s.Key.IndexOf('(') != -1)
                {
                    char[] spliter = { '(', ')' };
                    string[] c1 = s.Key.Split(spliter);
                    string c2 = s.Value;
                    dataGridViewContents.Rows.Add("削除", c1[0], c1[1], c2);
                }
                else if (s.Key != null && s.Value != null)
                {
                    string c1 = s.Key;
                    string c2 = s.Value;
                    dataGridViewContents.Rows.Add("削除", c1, null, c2);
                }

                
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int count = dataGridViewContents.Rows.Count;
            List<string> contentsList = new List<string>();

            for (int i = 0; i < count - 1; i++)
            {
                string c1 = (string)dataGridViewContents[1, i].Value;
                string c3 = (string)dataGridViewContents[3, i].Value;
                if (dataGridViewContents[2, i].Value != null)
                {
                    string c2 = (string)dataGridViewContents[2, i].Value;
                    contentsList.Add(c1 + '(' + c2 + ')' + ',' + c3 + Environment.NewLine);
                }
                else
                    contentsList.Add(c1 + ',' + c3 + Environment.NewLine);
            }

            ContentsFileIO.Write(contentsList);
        }

        private void dataGridViewContents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewContents.Columns["DeleteButton"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("本当に削除してもいいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        dataGridViewContents.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

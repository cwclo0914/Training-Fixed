using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerMeanings
{
    class Flower
    {

        public static string Get(string name, string colour)
        {
            string meaning = "";
            Dictionary<string, string> contentsDicationary = ContentsFileIO.Read();

            if (contentsDicationary == null)
                return null;

            if (contentsDicationary.Count <= 0)
                return null;

            string key = "";

            if (colour == "")
            {
                key = name;
            }
            else
            {
                key = name + "(" + colour + ")";
            }

            string value;
            if (contentsDicationary.TryGetValue(key, out value))
                meaning = contentsDicationary[key];
            else
            {
                MessageBox.Show("エラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            return meaning;
        }
    }
}

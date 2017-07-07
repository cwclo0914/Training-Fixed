using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FlowerMeanings
{
    static class ContentsFileIO
    {
        //csv reading
        public static Dictionary<string,string> Read()
        {
            Dictionary<string,string> dictionary = new Dictionary<string, string>();

            if (File.Exists(@"Data\flowers.csv") == false)
            {
                return dictionary;
            }

            try
            {
                using (StreamReader reader = new StreamReader
                    (@"Data\flowers.csv", Encoding.Default))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] c = line.Split(',');
                        dictionary.Add(c[0],c[1]);
                    }
                }
                return dictionary;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return dictionary;
            }
        }

        //csv writing
        public static void Write(List<string> list)
        {
            if (Directory.Exists("Data") == false)
            {
                Directory.CreateDirectory("Data");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter
                    (@"Data\flowers.csv", false, Encoding.Default))
                {
                    foreach (string s in list)
                    {
                        writer.Write(s);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

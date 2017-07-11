using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random cRandom = new System.Random();
            
            int min = 0;
            int max = 100;
            int rand = cRandom.Next(max + 1);
            int ans = max + 1;
            int count = 0;
            //Console.WriteLine(rand);
            do
            {
                count++;
                Console.Write("{0}から{1}の間の数値を当ててください。＞", min, max);
                try
                {
                    ans = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (ans < rand)
                {
                    while (ans < min)
                    {
                        Console.Write("入力し直してください。＞");
                        try
                        {
                            ans = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    Console.WriteLine("答えはもっと大きいです。");
                    min = ans + 1;
                }
                else if (ans > rand)
                {
                    while (ans > max)
                    {
                        Console.Write("入力し直してください。＞");
                        try
                        {
                            ans = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    Console.WriteLine("答えはもっと小さいです。");
                    max = ans - 1;
                }
                else if (ans == rand)
                {
                    Console.WriteLine("おめでとう。{0}回目で当たりました。", count);
                }
            }
            while (ans != rand);

            Console.WriteLine("終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}

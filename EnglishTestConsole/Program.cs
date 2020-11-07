using System;

namespace EnglishTestConsole
{
    /// <summary>
    /// プログラムの主軸となるプログラム
    /// </summary>
    class Program
    {
        /// <summary>
        /// プログラム実行時に実行される最初のメソッド
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        static void Main(string[] args)
        {
            Console.WriteLine("English Test!!");
            Console.WriteLine("英語");
            Console.WriteLine("------------------------");
            Console.WriteLine("1.English");
            Console.WriteLine("------------------------");
            Console.WriteLine("2.Japanese");
            Console.WriteLine("------------------------");
            Console.WriteLine("3.Chinese");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter your answer");
            string answer = Console.ReadLine();
            if(answer == "1")
            {
                Console.WriteLine("Good Job!!");
            }
            else
            {
                Console.WriteLine("Miss!");
            }
            Console.WriteLine("Exit to press \"Enter\" key.");
            Console.ReadLine();
        }
    }
}

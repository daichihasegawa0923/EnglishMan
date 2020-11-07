using EnglishTestConsole.Logic;
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
            bool isNext = true;
            var questionOutputter = new QuesionOutputter(105);
            var count = 1;

            while(isNext)
            {
                string questionText = string.Empty;
                string answer = string.Empty;

                var canOutput = questionOutputter.GetQuestionText(ref questionText,ref answer);
                if (!canOutput)
                    break;
                
                questionText = count.ToString() + Environment.NewLine + questionText;
                Console.WriteLine(questionText);
                var usersAnswer = Console.ReadLine();

                if(usersAnswer == answer)
                {
                    Console.WriteLine("Good Job");
                }
                else
                {
                    Console.WriteLine("Miss!"+Environment.NewLine+"正しい答え:" + answer);
                }

                Console.WriteLine();
                count++;
            }
            Console.WriteLine("終了!");
            Console.ReadLine();
        }
    }
}

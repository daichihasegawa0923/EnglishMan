using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishTestConsole.Model
{
    /// <summary>
    /// 問題のモデル
    /// </summary>
    public class QuesionModel
    {
        /// <summary>
        /// 問題文
        /// </summary>
        public string Question { private set; get; }

        /// <summary>
        /// 解答
        /// </summary>
        public string Answer { private set; get; }

        /// <summary>
        /// 得点
        /// </summary>
        public int Point { private set; get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="question">問題文</param>
        /// <param name="answer">解答</param>
        /// <param name="point">得点</param>
        public QuesionModel(string question,string answer,int point)
        {
            this.Question = question;
            this.Answer = answer;
            this.Point = point;
        }
    }
}

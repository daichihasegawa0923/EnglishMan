using System;
using System.Collections.Generic;
using System.Text;
using EnglishTestConsole.Model;

namespace EnglishTestConsole.Logic
{
    /// <summary>
    /// 問題を出力する
    /// </summary>
    public class QuesionOutputter
    {
        /// <summary>
        /// 出力される予定の問題
        /// </summary>
        private readonly List<QuesionModel> _questions = new List<QuesionModel>()
        {
            new QuesionModel("英語","English",0),
            new QuesionModel("りんご","Apple",0),
            new QuesionModel("どく","Poison",0),
            new QuesionModel("やみ","Dark",0),
            new QuesionModel("氷","Ice",0),
            new QuesionModel("画面","Display",0),
            new QuesionModel("ドラゴンクエスト","DRAGON QUEST",0),
            new QuesionModel("投げる","Throw",0),
            new QuesionModel("神","God",0),
            new QuesionModel("走る","Run",0),
            new QuesionModel("範馬勇次郎","The strongest creature in the world.",0)
        };

        public QuesionOutputter(int maxCount)
        {
            _maxCount = maxCount;
        }

        private int _maxCount;
        private int _count = 0;

        /// <summary>
        /// 問題を出力する
        /// </summary>
        /// <param name="quesionText">ref 問題文</param>
        /// <param name="answer">ref 解答</param>
        /// <returns>true:出力可能, false: 出力失敗</returns>
        public bool GetQuestionText(ref string quesionText,ref string answer)
        {
            if (_questions.Count == 0 || _count >= _maxCount)
                return false;

            int index = new Random().Next(0, _questions.Count - 1);
            var question = _questions[index];
            _questions.RemoveAt(index);

            quesionText = "問題："+Environment.NewLine + question.Question;
            answer = question.Answer;
            _count++;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfksScore.Interfaces
{
    public interface IKataForm
    {
        double JudgeScore1 { get; set; }
        double JudgeScore2 { get; set; }
        double JudgeScore3 { get; set; }
        double JudgeScore4 { get; set; }
        double JudgeScore5 { get; set; }
        double AverageScore { get; set; }
        string ScoreHistory { get; set; }
        double CalculateAverage();
        double CalculateScore();
        string GetScoreHistory();
    }
}

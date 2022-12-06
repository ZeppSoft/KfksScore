using KfksScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfksScore.Interfaces
{
    public interface IESBoard
    {
        string CompetitionName { get; set; }
        string CompetitionCategory { get; set; }
        string CompetitionTime { get; set; }
        string TimeDescription { get; set; }
        string CompetitionScore { get; set; }
        int FormSizeWidth { get; set; }
        int FormSizeHeight { get; set; }
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int CompetitorLeftScore { get; set; }
        int CompetitorRightScore { get; set; }
        string CompetitorLeftScoreHistory { get; set; }
        string CompetitorRightScoreHistory { get; set; }
        string CompetitorLeftName { get; set; }
        string CompetitorRightName { get; set; }
        decimal TatamiNumber { get; set; }
        string FirstLeft1 { get; set; }
        string FirstLeft2 { get; set; }
        string FirstLeft3 { get; set; }
        string FirstLeft4 { get; set; }
        string FirstLeft5 { get; set; }
        string SecondLeft1 { get; set; }
        string SecondLeft2 { get; set; }
        string SecondLeft3 { get; set; }
        string SecondLeft4 { get; set; }
        string SecondLeft5 { get; set; }









    }
}

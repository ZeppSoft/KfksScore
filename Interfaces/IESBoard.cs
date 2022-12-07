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
        int ScoreFontSize { get; set; }
        int CompetitorLeftScore { get; set; }
        int CompetitorRightScore { get; set; }
        string CompetitorLeftScoreHistory { get; set; }
        string CompetitorRightScoreHistory { get; set; }
        string CompetitorLeftName { get; set; }
        string CompetitorRightName { get; set; }
        string WaitForCompetitorLeftText { get; set; }
        string WaitForCompetitorRightText { get; set; }
        decimal TatamiNumber { get; set; }
        string AtanaiOneLeft { get; set; }
        string AtanaiTwoLeft { get; set; }
        string AtanaiThreeLeft { get; set; }
        string AtanaiFourLeft { get; set; }
        string AtanaiFiveLeft { get; set; }
        string AtanaiSixLeft { get; set; }
        string AtanaiSevenLeft { get; set; }
        string AtanaiEightLeft { get; set; }
        string AtanaiNineLeft { get; set; }
        string AtanaiTenLeft { get; set; }
        string AtanaiOneRight { get; set; }
        string AtanaiTwoRight { get; set; }
        string AtanaiThreeRight { get; set; }
        string AtanaiFourRight { get; set; }
        string AtanaiFiveRight { get; set; }
        string AtanaiSixRight { get; set; }
        string AtanaiSevenRight { get; set; }
        string AtanaiEightRight { get; set; }
        string AtanaiNineRight { get; set; }
        string AtanaiTenRight { get; set; }









    }
}

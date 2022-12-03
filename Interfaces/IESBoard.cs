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
         string CompetitionScore { get; set; }
         int DisplayWidth { get; set; }
         int DisplayHeight { get; set; }
         int CompetitorLeftScore { get; set; }
         int CompetitorRightScore { get; set; }
         string CompetitorLeftName { get; set; }
         string CompetitorRightName { get; set; }
    }
}

using KfksScore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KfksScore.Models
{
    public class Board : IESBoard
    {
        public Board()
        {
            CompetitionName = "Название соревнования";
            CompetitionCategory = "Мальчики 10-11 лет весом до 42кг";
            CompetitionTime = "Основное время";
            CompetitionScore = "Счёт";
        }
        #region IESBoard
        public string CompetitionName { get; set; }
        public string CompetitionCategory { get; set; }
        public string CompetitionTime { get; set; }
        public string CompetitionScore { get; set; }
        #endregion
    }
}

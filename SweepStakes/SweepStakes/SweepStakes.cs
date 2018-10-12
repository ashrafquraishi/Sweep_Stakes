using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakes
    {
        Dictionary<int, Contestants> ContestantsList = new Dictionary<int, Contestants>();
        public string name;
        int counter = 1;
         public	SweepStakes(string name)
         {
            this.name = name;
         }
         void RegisterContestant(Contestants contestant)
         {
            contestant.ContestantInfo();
            contestant.registrationnumber = counter;
            ContestantsList.Add(counter, contestant);
            counter++;
         }

        void  PickWinner()
        {



        }
       //-	void PrintContestantInfo(Contestant contestant)

    }
}

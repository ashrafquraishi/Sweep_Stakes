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
        int WinningNumber;
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

        void  PickWinningNumber()
        {
            Random random = new Random();
            WinningNumber = random.Next(1, counter);
            Console.WriteLine("The Winning Number Is", WinningNumber);


        }
      	void PrintContestantInfo(Contestants contestant)
        {

        }

    }
}

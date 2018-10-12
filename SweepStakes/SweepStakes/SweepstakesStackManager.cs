using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesStackManager:ISweepstakesManager
    {
        Stack<SweepStakes> sweepsStack = new Stack<SweepStakes>();
        public void InsertSweepstakes(SweepStakes sweepstakes)
        {
            sweepsStack.Push(sweepstakes);
        }
        public SweepStakes GetNextSweepstakesWinner()
        {
            return sweepsStack.Pop();
        }
    }
}

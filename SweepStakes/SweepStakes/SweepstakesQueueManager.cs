using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepstakesQueueManager:ISweepstakesManager
    {
        Queue<SweepStakes> sweepsQueue = new Queue<SweepStakes>();

        public void InsertSweepstakes(SweepStakes sweepstake)
        {
            sweepsQueue.Enqueue(sweepstake);
        }
        public SweepStakes GetNextSweepstakesWinner()
        {
            return sweepsQueue.Dequeue();
        }
    }
}

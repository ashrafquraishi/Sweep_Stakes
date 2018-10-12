using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        ISweepstakesManager sweepStakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepStakesManager = sweepstakesManager;
        }
        public SweepStakes GetSweepstakes()
        {
            return sweepStakesManager.GetNextSweepstakesWinner();
        }
        public void InsertSweepstakes()
        {
            sweepStakesManager.InsertSweepstakes(Contestants.);
        }
        
    
    }
}

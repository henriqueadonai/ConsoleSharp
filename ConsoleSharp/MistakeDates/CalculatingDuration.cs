using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharp.MistakeDates
{
    //blog.submain.com/4-common-datetime-mistakes-c-avoid/?utm_source=Main&utm_campaign=0fdf0d4fca-EMAIL_CAMPAIGN_2017_12_19&utm_medium=email&utm_term=0_aa2f642d94-0fdf0d4fca-246075361
    //NaivelyCalculationg Duration
    public class Match
    {
        public DateTime StartTime{ get; set; }

        public DateTime EndTime { get; set; }
    }


    public class CalculatingDuration
    {
        public Match match { get; set; }

        public void StartMatch() {

            DateTime start = DateTime.Now;            
            match.StartTime = start;
        }

        public void EndMatch()
        {
            DateTime end = DateTime.Now;
            match.EndTime = end;
        }


        //Forcing UTC
        public void ForcingUTCCalculation()
        {
            var start = DateTime.Now; // local time
            var end = DateTime.Now; // local time
            var duration = end.ToUniversalTime() - start.ToUniversalTime(); // converting to UTC
        }

        //Allways use UTC to calculate date
        public void UTCCalculation()
        {
            DateTime start = DateTime.UtcNow;
            DateTime end = DateTime.UtcNow;
            TimeSpan duration = end - start;
        }
    }
}

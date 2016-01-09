using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProjektISS
{
    public static class TimerExample // In App_Code folder
    {
        static Timer _timer; // From System.Timers
        static void Start(int miliseconds)
        {
            _timer = new Timer(miliseconds); // Set up the timer for 3 seconds
                                      //
                                      // Type "_timer.Elapsed += " and press tab twice.
                                      //
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true; // Enable it
        }
        static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }
    }

}

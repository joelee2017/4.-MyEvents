using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyEvents_CSharp
{
    public class ClsWidget
    {

        /// <summary>
        /// ercentDone_EventHandler委派的名稱，引數(int percent,  ref  bool cancel)
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="cancel"></param>
      // step 1 declare event
        public delegate void PercentDone_EventHandler(int percent,  ref  bool cancel);
        public event PercentDone_EventHandler PercentDone;//事件名稱PercentDone

        public void LongTask(int max, int Intervals)
        {
            bool cancel = false;
            int i = 1;

            while ((i <= max))
            {
                // Step 2; Fire Event - Invoke 
                if (PercentDone != null)
                {
                    PercentDone.Invoke(i, ref cancel);
                }

                i = (i + Intervals);
                if ((cancel == true))
                {
                    return;
                }
                Application.DoEvents();
            }
        }
    }
}

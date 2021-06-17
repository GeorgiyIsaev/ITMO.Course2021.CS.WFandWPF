using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonLibrary
{
   public class BeepButtonExclamation : Button
    {
        protected override void OnClick(EventArgs args)
        {
            SystemSounds.Exclamation.Play();
            base.OnClick(args);
        }
    } 
}

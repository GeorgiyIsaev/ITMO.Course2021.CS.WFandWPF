using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonLibrary
{
    public class BeepButtonQuestion : Button
    {
        protected override void OnClick(EventArgs args)
        {
            SystemSounds.Question.Play();
            base.OnClick(args);
        }
    }
}
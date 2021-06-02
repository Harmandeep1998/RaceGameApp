using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGameApp
{
    public abstract class Punter
    {
        public int Cash { get; set; }

        public bool Busted { get; set; }

        public Bet MyBet { get; set; }

        public Label MyLabel { get; set; }

        public RadioButton MyRadioButton { get; set; }

        public string Name { get; set; }

        public TextBox MyText { get; set; }
    }
}

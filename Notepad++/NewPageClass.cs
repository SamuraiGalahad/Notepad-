using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad__
{
    class NewTabPage : TabPage
    {
        private bool _save = false;
        public bool Save
        {
            get { return _save; }
            set { _save = value; }
        }
    }
}

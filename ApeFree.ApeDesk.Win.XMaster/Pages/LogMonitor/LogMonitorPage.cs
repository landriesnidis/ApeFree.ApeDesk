using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.LogMonitor
{
    public partial class LogMonitorPage : UserControl, IPage
    {
        public string PageTitle => "LogMonitor";

        public Image PageIcon => throw new NotImplementedException();

        public LogMonitorPage()
        {
            InitializeComponent();
        }
    }
}

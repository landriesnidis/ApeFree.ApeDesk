using ApeFree.ApeDesk.Win.XMaster.Pages.RemoteScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.XMaster.Pages.FileDistribution
{
    public partial class FileDistributionPage : UserControl, IPage
    {
        public string PageTitle => "File Distribution";

        public Image PageIcon => null;

        private FileDistributionPage()
        {
            InitializeComponent();
        }

        public FileDistributionPage(ApeRpc.IService[] services) : this()
        {
            foreach (ApeRpc.IService service in services)
            {
                var rsc = new FileDistributionItem(service);
                rsc.Parent = glp;
            }
        }
    }
}

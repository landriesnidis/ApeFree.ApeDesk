using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApeFree.ApeDesk.Win.XMaster.Pages
{
    public interface IPage
    {
        string PageTitle { get; }

        Image PageIcon { get;  }
    }
}

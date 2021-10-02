using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nJobee.JobDescr
{
  public partial class JobdCleaning : 
    IJobd
    // UserControl
  {
    public JobdCleaning()
    {
      InitializeComponent();
    }

    public override int GetCash()
    {
      if (Radio2rooms.Checked)
        return 144000;
      if (Radio3rooms.Checked)
        return 180000;
      if (Radio4rooms.Checked)
        return 228000;
      return 0;
    }

    public override int GetTime()
    {
      if (Radio2rooms.Checked)
        return 2 * 60;
      if (Radio3rooms.Checked)
        return 3 * 60;
      if (Radio4rooms.Checked)
        return 4 * 60;
      return 0;
    }
  }
}

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
  public partial class JobdDisinfectionService :
    // UserControl
    IJobd
  {
    public JobdDisinfectionService()
    {
      InitializeComponent();
    }

    public override int GetCash()
    {
      if (RadioBelow70.Checked)
        return 550000;
      if (RadioBelow100.Checked)
        return 700000;
      if (RadioBelow130.Checked)
        return 800000;
      if (RadioBelow180.Checked)
        return 900000;
      return 2750000;
    }

    public override int GetTime()
    {
      if (RadioBelow70.Checked)
        return 1 * 60;
      if (RadioBelow100.Checked)
        return 1 * 60 + 30;
      if (RadioBelow130.Checked)
        return 2 * 60;
      if (RadioBelow180.Checked)
        return 2 * 60 + 30;
      return 3 * 60;
    }
  }
}

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
  public partial class JobdACService : 
    // UserControl
    IJobd
  {
    public JobdACService()
    {
      InitializeComponent();
    }

    public override int GetCash()
    {
      int numberOfAirConditions = (int)NumUDQuality.Value;
      int totalCash = numberOfAirConditions * (RadioBelow.Checked ? 150000 : 175000);

      if (CheckRefill.Checked)
        totalCash += numberOfAirConditions * 100000; 
      return totalCash; 
    }

    public override int GetTime()
    {
      return (int)NumUDQuality.Value * 60;
    }
  }
}

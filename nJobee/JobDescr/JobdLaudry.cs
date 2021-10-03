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
  public partial class JobdLaudry : 
    // UserControl
    IJobd
  {
    public JobdLaudry()
    {
      InitializeComponent();
    }

    public override int GetCash()
    {
      int numberOfKilograms = (int)NumUDKg.Value;
      int totalCash = numberOfKilograms * 15000;
      if (CheckDry.Checked)
        totalCash += numberOfKilograms * 5000; 
      return totalCash; 
    }

    public override int GetTime()
    {
      return 2 * 60;
    }
  }
}

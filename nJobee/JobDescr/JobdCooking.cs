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
  public partial class JobdCooking :
    // UserControl
    IJobd
  {
    public JobdCooking()
    {
      InitializeComponent();
    }

    private void JobdCooking_Load(object sender, EventArgs e)
    {
      ComboxStyle.SelectedIndex = 0;
    }

    public override int GetCash()
    {
      if (NumUDPeople.Value <= 4)
        return 120000;
      return 150000;
    }

    public override int GetTime()
    {
      if (NumUDPeople.Value <= 4)
        return 2 * 60;
      return 3 * 60;
    }
  }
}

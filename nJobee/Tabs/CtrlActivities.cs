using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nJobee
{
  public partial class CtrlActivities : UserControl
  {
    private int ActivityCount;

    public CtrlActivities()
    {
      InitializeComponent();
      ActivityCount = 0; 
    }

    public bool AddActivity(Label label)
    {
      if (ActivityCount < TabpanelActivities.RowCount)
      {
        TabpanelActivities.Controls.Add(label); 
        ActivityCount++; 
        return true;
      }

      return false;
    }
  }
}

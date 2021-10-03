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
  public partial class JobdGroceryAssistance : 
    IJobd
    // UserControl
  {
    public JobdGroceryAssistance()
    {
      InitializeComponent();
    }

    private void JobdGroceryAssistance_Load(object sender, EventArgs e)
    {
      ComboxCash.SelectedIndex = 0; 
    }

    public override int GetCash()
    {
      string value = ComboxCash.SelectedItem.ToString();
      value = value.Replace(".", "").Replace("đ", "");
      return int.Parse(value) + 256000;
    }

    public override int GetTime()
    {
      return 0;
    }
  }
}

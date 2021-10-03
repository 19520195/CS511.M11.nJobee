using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nJobee
{
  class ActivitiyDescriptor
  {
    public string Name { get; set; }
    public string Cash { get; set; }
    public string Time { get; set; }
    public string Addr { get; set; }

    public Label ToLabel()
    {
      Label label = new Label();
      label.Dock = DockStyle.Fill;
      label.Text = String.Format("{0} {1} ({2})", Name, Time, Cash);
      return label; 
    }
  }
}

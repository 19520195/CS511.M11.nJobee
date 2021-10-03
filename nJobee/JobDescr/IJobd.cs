using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nJobee.JobDescr
{
  public abstract class IJobd : System.Windows.Forms.UserControl
  {
    public abstract int GetCash();

    public abstract int GetTime();
  }
}

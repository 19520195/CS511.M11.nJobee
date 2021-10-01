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
  public partial class Master : Form
  {
    public Master()
    {
      InitializeComponent();

      // Binding selection for control buttons
      ButtonHome.Click += ChangeSelection; 
      ButtonActivities.Click += ChangeSelection; 
      ButtonAccount.Click += ChangeSelection; 
    }

    private void ChangeSelection(object sender, EventArgs e)
    {
      PanelSlide.Location = ((Control)sender).Location;
    }
  }
}

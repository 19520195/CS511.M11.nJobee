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
      ButtonSettings.Click += ChangeSelection;
    }

    private void Master_Load(object sender, EventArgs e)
    {
      ShowUserControls(UCtrlHome);
    }

    private void ChangeSelection(object sender, EventArgs e)
    { 
      PanelSlide.Location = ((Control)sender).Location;
    }

    private void ShowUserControls(UserControl control)
    {
      UCtrlHome.Hide();
      UCtrlActivities.Hide();
      UCtrlAccount.Hide();
      control.Show(); 
    }

    private void ButtonHome_Click(object sender, EventArgs e)
    {
      ShowUserControls(UCtrlHome);
    }

    private void ButtonActivities_Click(object sender, EventArgs e)
    {
      ShowUserControls(UCtrlActivities);
    }

    private void ButtonAccount_Click(object sender, EventArgs e)
    {
      ShowUserControls(UCtrlAccount);
    }

    private void ButtonSettings_Click(object sender, EventArgs e)
    {
      //
    }
  }
}

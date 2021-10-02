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
  public partial class CtrlHome : UserControl
  {
    public CtrlHome()
    {
      InitializeComponent();
    }

    private void ButtonCleaning_Click(object sender, EventArgs e)
    {
      Descriptor descriptor = new Descriptor();
      DialogResult result = descriptor.ShowDialog();
      if (result == DialogResult.OK)
      {
        LabelTimeValue.Text = descriptor.GetTimeValue();
        LabelAddressValue.Text = descriptor.GetAddressValue();
      }
    }

    private void ButtonCash_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Click vào OK để hoàn tất thanh toán", "Xác nhận Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
      if (result == DialogResult.OK)
      {
        System.Diagnostics.Process.Start("http://google.com");
      }
    }
  }
}

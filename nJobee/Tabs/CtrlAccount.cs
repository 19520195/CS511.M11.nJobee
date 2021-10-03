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
  public partial class CtrlAccount : UserControl
  {
    public CtrlAccount()
    {
      InitializeComponent();
      TextBoxName.Text = Properties.Settings.Default.Name;
      TextBoxEmail.Text = Properties.Settings.Default.Email;
      TextBoxPhone.Text = Properties.Settings.Default.Phone;
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
      Properties.Settings.Default.Name = TextBoxName.Text.Trim();
      Properties.Settings.Default.Email = TextBoxEmail.Text.Trim();
      Properties.Settings.Default.Phone = TextBoxPhone.Text.Trim();
      MessageBox.Show("Thông tin của bạn đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}

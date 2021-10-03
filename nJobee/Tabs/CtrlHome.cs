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

    private void CtrlHome_Load(object sender, EventArgs e)
    {
      ResetCashState(); 
    }

    private void ButtonCleaning_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdCleaning());
    }

    private void ButtonGroceryAssistance_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdGroceryAssistance());
    }

    private void ButtonACService_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdACService());
    }

    private void ButtonDisinfectionService_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdDisinfectionService());
    }

    private void ButtonLaudry_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdLaudry());
    }

    private void ButtonHomeCooking_Click(object sender, EventArgs e)
    {
      ShowDescriptor(((Control)sender).Text, new JobDescr.JobdCooking());
    }

    private void ButtonCash_Click(object sender, EventArgs e)
    {
      if (LabelServiceValue.Text.Length == 0) MessageBox.Show("Bạn chưa chọn gì cả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      else
      {
        DialogResult result = MessageBox.Show("Click vào OK để hoàn tất thanh toán", "Xác nhận Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (result == DialogResult.OK)
        {
          var activityDescriptor = new ActivitiyDescriptor();
          activityDescriptor.Name = LabelServiceValue.Text;
          activityDescriptor.Cash = LabelCashValue.Text;
          activityDescriptor.Time = LabelTimeValue.Text;
          activityDescriptor.Addr = LabelAddressValue.Text;
          if (Program.master.UpdateActivities(activityDescriptor.ToLabel()))
          {
            System.Diagnostics.Process.Start("https://19520195.github.io/HTMLPublic/SuccessfulCash.html");
          }
          else
          {
            MessageBox.Show("Quá số lượng việc làm đăng tải", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); 
          }

          ResetCashState();
        }
      }
    }

    private void ResetCashState()
    {
      LabelServiceValue.Text = ""; 
      LabelCashValue.Text = "0đ";
      LabelTimeValue.Text = "Chưa xác định";
      LabelAddressValue.Text = "Chưa xác định";
    }

    private void ShowDescriptor(string JobName, JobDescr.IJobd Jobd)
    {
      Descriptor descriptor = new Descriptor();
      descriptor.AddJobDescription(Jobd);

      DialogResult result = descriptor.ShowDialog();
      if (result == DialogResult.OK)
      {
        LabelServiceValue.Text = JobName;
        LabelCashValue.Text = descriptor.GetCashValue();
        LabelTimeValue.Text = descriptor.GetTimeValue();
        LabelAddressValue.Text = descriptor.GetAddressValue();
      }
      else ResetCashState();
    }
  }
}

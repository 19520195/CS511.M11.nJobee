
namespace nJobee.JobDescr
{
  partial class JobdDisinfectionService
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.RadioBelow70 = new System.Windows.Forms.RadioButton();
      this.RadioBelow100 = new System.Windows.Forms.RadioButton();
      this.RadioBelow130 = new System.Windows.Forms.RadioButton();
      this.RadioBelow180 = new System.Windows.Forms.RadioButton();
      this.RadioBelow500 = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // RadioBelow70
      // 
      this.RadioBelow70.AutoSize = true;
      this.RadioBelow70.Checked = true;
      this.RadioBelow70.Location = new System.Drawing.Point(24, 21);
      this.RadioBelow70.Margin = new System.Windows.Forms.Padding(8);
      this.RadioBelow70.Name = "RadioBelow70";
      this.RadioBelow70.Size = new System.Drawing.Size(133, 30);
      this.RadioBelow70.TabIndex = 0;
      this.RadioBelow70.TabStop = true;
      this.RadioBelow70.Text = "Dưới 70m²\t";
      this.RadioBelow70.UseVisualStyleBackColor = true;
      // 
      // RadioBelow100
      // 
      this.RadioBelow100.AutoSize = true;
      this.RadioBelow100.Location = new System.Drawing.Point(24, 67);
      this.RadioBelow100.Margin = new System.Windows.Forms.Padding(8);
      this.RadioBelow100.Name = "RadioBelow100";
      this.RadioBelow100.Size = new System.Drawing.Size(142, 30);
      this.RadioBelow100.TabIndex = 0;
      this.RadioBelow100.Text = "Dưới 100m²";
      this.RadioBelow100.UseVisualStyleBackColor = true;
      // 
      // RadioBelow130
      // 
      this.RadioBelow130.AutoSize = true;
      this.RadioBelow130.Location = new System.Drawing.Point(24, 113);
      this.RadioBelow130.Margin = new System.Windows.Forms.Padding(8);
      this.RadioBelow130.Name = "RadioBelow130";
      this.RadioBelow130.Size = new System.Drawing.Size(140, 30);
      this.RadioBelow130.TabIndex = 0;
      this.RadioBelow130.Text = "Dưới 130m²";
      this.RadioBelow130.UseVisualStyleBackColor = true;
      // 
      // RadioBelow180
      // 
      this.RadioBelow180.AutoSize = true;
      this.RadioBelow180.Location = new System.Drawing.Point(24, 159);
      this.RadioBelow180.Margin = new System.Windows.Forms.Padding(8);
      this.RadioBelow180.Name = "RadioBelow180";
      this.RadioBelow180.Size = new System.Drawing.Size(141, 30);
      this.RadioBelow180.TabIndex = 0;
      this.RadioBelow180.Text = "Dưới 180m²";
      this.RadioBelow180.UseVisualStyleBackColor = true;
      // 
      // RadioBelow500
      // 
      this.RadioBelow500.AutoSize = true;
      this.RadioBelow500.Location = new System.Drawing.Point(24, 205);
      this.RadioBelow500.Margin = new System.Windows.Forms.Padding(8);
      this.RadioBelow500.Name = "RadioBelow500";
      this.RadioBelow500.Size = new System.Drawing.Size(146, 30);
      this.RadioBelow500.TabIndex = 0;
      this.RadioBelow500.Text = "Dưới 500m²";
      this.RadioBelow500.UseVisualStyleBackColor = true;
      // 
      // JobdDisinfectionService
      // 
      this.Controls.Add(this.RadioBelow500);
      this.Controls.Add(this.RadioBelow180);
      this.Controls.Add(this.RadioBelow130);
      this.Controls.Add(this.RadioBelow100);
      this.Controls.Add(this.RadioBelow70);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "JobdDisinfectionService";
      this.Size = new System.Drawing.Size(280, 260);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton RadioBelow70;
    private System.Windows.Forms.RadioButton RadioBelow100;
    private System.Windows.Forms.RadioButton RadioBelow130;
    private System.Windows.Forms.RadioButton RadioBelow180;
    private System.Windows.Forms.RadioButton RadioBelow500;
  }
}

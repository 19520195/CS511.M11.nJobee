
namespace nJobee
{
  partial class Master
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.PanelUser = new System.Windows.Forms.Panel();
      this.LabelUserName = new System.Windows.Forms.Label();
      this.PicboxUserProfile = new System.Windows.Forms.PictureBox();
      this.PanelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicboxUserProfile)).BeginInit();
      this.SuspendLayout();
      // 
      // PanelUser
      // 
      this.PanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(78)))));
      this.PanelUser.Controls.Add(this.LabelUserName);
      this.PanelUser.Controls.Add(this.PicboxUserProfile);
      this.PanelUser.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelUser.Location = new System.Drawing.Point(0, 0);
      this.PanelUser.Name = "PanelUser";
      this.PanelUser.Size = new System.Drawing.Size(240, 540);
      this.PanelUser.TabIndex = 0;
      // 
      // LabelUserName
      // 
      this.LabelUserName.Location = new System.Drawing.Point(3, 123);
      this.LabelUserName.Name = "LabelUserName";
      this.LabelUserName.Size = new System.Drawing.Size(234, 45);
      this.LabelUserName.TabIndex = 2;
      this.LabelUserName.Text = "Nha Le";
      this.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PicboxUserProfile
      // 
      this.PicboxUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.PicboxUserProfile.Image = global::nJobee.Properties.Resources.DefaultAvatar;
      this.PicboxUserProfile.Location = new System.Drawing.Point(72, 16);
      this.PicboxUserProfile.Name = "PicboxUserProfile";
      this.PicboxUserProfile.Size = new System.Drawing.Size(96, 96);
      this.PicboxUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PicboxUserProfile.TabIndex = 0;
      this.PicboxUserProfile.TabStop = false;
      // 
      // Master
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColor;
      this.ClientSize = new System.Drawing.Size(960, 540);
      this.Controls.Add(this.PanelUser);
      this.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Master";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.PanelUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PicboxUserProfile)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelUser;
    private System.Windows.Forms.PictureBox PicboxUserProfile;
    private System.Windows.Forms.Label LabelUserName;
  }
}



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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
      this.PanelLeft = new System.Windows.Forms.Panel();
      this.PanelControl = new System.Windows.Forms.Panel();
      this.ButtonUser = new System.Windows.Forms.Button();
      this.ImageControl = new System.Windows.Forms.ImageList(this.components);
      this.ButtonActivity = new System.Windows.Forms.Button();
      this.ButtonFinding = new System.Windows.Forms.Button();
      this.PanelUser = new System.Windows.Forms.Panel();
      this.LabelFullname = new System.Windows.Forms.Label();
      this.PicboxAvatar = new System.Windows.Forms.PictureBox();
      this.PanelLeft.SuspendLayout();
      this.PanelControl.SuspendLayout();
      this.PanelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).BeginInit();
      this.SuspendLayout();
      // 
      // PanelLeft
      // 
      this.PanelLeft.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.PanelLeft.Controls.Add(this.PanelControl);
      this.PanelLeft.Controls.Add(this.PanelUser);
      this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelLeft.Location = new System.Drawing.Point(0, 0);
      this.PanelLeft.Name = "PanelLeft";
      this.PanelLeft.Size = new System.Drawing.Size(240, 540);
      this.PanelLeft.TabIndex = 0;
      // 
      // PanelControl
      // 
      this.PanelControl.Controls.Add(this.ButtonUser);
      this.PanelControl.Controls.Add(this.ButtonActivity);
      this.PanelControl.Controls.Add(this.ButtonFinding);
      this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelControl.Location = new System.Drawing.Point(0, 165);
      this.PanelControl.Margin = new System.Windows.Forms.Padding(0);
      this.PanelControl.Name = "PanelControl";
      this.PanelControl.Size = new System.Drawing.Size(240, 375);
      this.PanelControl.TabIndex = 5;
      // 
      // ButtonUser
      // 
      this.ButtonUser.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonUser.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonUser.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonUser.FlatAppearance.BorderSize = 0;
      this.ButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonUser.ImageIndex = 3;
      this.ButtonUser.ImageList = this.ImageControl;
      this.ButtonUser.Location = new System.Drawing.Point(0, 96);
      this.ButtonUser.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonUser.Name = "ButtonUser";
      this.ButtonUser.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonUser.Size = new System.Drawing.Size(240, 48);
      this.ButtonUser.TabIndex = 5;
      this.ButtonUser.Text = "Tài khoản";
      this.ButtonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonUser.UseVisualStyleBackColor = false;
      // 
      // ImageControl
      // 
      this.ImageControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageControl.ImageStream")));
      this.ImageControl.TransparentColor = System.Drawing.Color.Transparent;
      this.ImageControl.Images.SetKeyName(0, "Activities.png");
      this.ImageControl.Images.SetKeyName(1, "Home.png");
      this.ImageControl.Images.SetKeyName(2, "Settings.png");
      this.ImageControl.Images.SetKeyName(3, "User.png");
      // 
      // ButtonActivity
      // 
      this.ButtonActivity.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonActivity.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonActivity.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonActivity.FlatAppearance.BorderSize = 0;
      this.ButtonActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonActivity.ImageIndex = 0;
      this.ButtonActivity.ImageList = this.ImageControl;
      this.ButtonActivity.Location = new System.Drawing.Point(0, 48);
      this.ButtonActivity.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonActivity.Name = "ButtonActivity";
      this.ButtonActivity.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonActivity.Size = new System.Drawing.Size(240, 48);
      this.ButtonActivity.TabIndex = 3;
      this.ButtonActivity.Text = "Hoạt động";
      this.ButtonActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonActivity.UseVisualStyleBackColor = false;
      // 
      // ButtonFinding
      // 
      this.ButtonFinding.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonFinding.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonFinding.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonFinding.FlatAppearance.BorderSize = 0;
      this.ButtonFinding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonFinding.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonFinding.ImageIndex = 1;
      this.ButtonFinding.ImageList = this.ImageControl;
      this.ButtonFinding.Location = new System.Drawing.Point(0, 0);
      this.ButtonFinding.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonFinding.Name = "ButtonFinding";
      this.ButtonFinding.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonFinding.Size = new System.Drawing.Size(240, 48);
      this.ButtonFinding.TabIndex = 0;
      this.ButtonFinding.Text = "Tìm kiếm";
      this.ButtonFinding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonFinding.UseVisualStyleBackColor = false;
      // 
      // PanelUser
      // 
      this.PanelUser.Controls.Add(this.LabelFullname);
      this.PanelUser.Controls.Add(this.PicboxAvatar);
      this.PanelUser.Dock = System.Windows.Forms.DockStyle.Top;
      this.PanelUser.Location = new System.Drawing.Point(0, 0);
      this.PanelUser.Margin = new System.Windows.Forms.Padding(0);
      this.PanelUser.Name = "PanelUser";
      this.PanelUser.Padding = new System.Windows.Forms.Padding(16);
      this.PanelUser.Size = new System.Drawing.Size(240, 165);
      this.PanelUser.TabIndex = 4;
      // 
      // LabelFullname
      // 
      this.LabelFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::nJobee.Properties.Settings.Default, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.LabelFullname.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelFullname.Location = new System.Drawing.Point(16, 112);
      this.LabelFullname.Name = "LabelFullname";
      this.LabelFullname.Size = new System.Drawing.Size(208, 45);
      this.LabelFullname.TabIndex = 2;
      this.LabelFullname.Text = global::nJobee.Properties.Settings.Default.Name;
      this.LabelFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PicboxAvatar
      // 
      this.PicboxAvatar.Dock = System.Windows.Forms.DockStyle.Top;
      this.PicboxAvatar.Image = global::nJobee.Properties.Resources.DefaultAvatar;
      this.PicboxAvatar.Location = new System.Drawing.Point(16, 16);
      this.PicboxAvatar.Name = "PicboxAvatar";
      this.PicboxAvatar.Size = new System.Drawing.Size(208, 96);
      this.PicboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PicboxAvatar.TabIndex = 0;
      this.PicboxAvatar.TabStop = false;
      // 
      // Master
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColor;
      this.ClientSize = new System.Drawing.Size(960, 540);
      this.Controls.Add(this.PanelLeft);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Master";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.PanelLeft.ResumeLayout(false);
      this.PanelControl.ResumeLayout(false);
      this.PanelUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelLeft;
    private System.Windows.Forms.Panel PanelControl;
    private System.Windows.Forms.Button ButtonUser;
    private System.Windows.Forms.Button ButtonActivity;
    private System.Windows.Forms.Button ButtonFinding;
    private System.Windows.Forms.Panel PanelUser;
    private System.Windows.Forms.Label LabelFullname;
    private System.Windows.Forms.PictureBox PicboxAvatar;
    private System.Windows.Forms.ImageList ImageControl;
  }
}


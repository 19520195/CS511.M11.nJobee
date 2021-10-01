
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
      this.PanelSlide = new System.Windows.Forms.Panel();
      this.ButtonAccount = new System.Windows.Forms.Button();
      this.ImageControl = new System.Windows.Forms.ImageList(this.components);
      this.ButtonActivities = new System.Windows.Forms.Button();
      this.ButtonHome = new System.Windows.Forms.Button();
      this.PanelUser = new System.Windows.Forms.Panel();
      this.LabelFullname = new System.Windows.Forms.Label();
      this.PicboxAvatar = new System.Windows.Forms.PictureBox();
      this.PanelRight = new System.Windows.Forms.Panel();
      this.UCtrlHome = new nJobee.CtrlHome();
      this.UCtrlActivities = new nJobee.CtrlActivities();
      this.UCtrlAccount = new nJobee.CtrlAccount();
      this.PanelLeft.SuspendLayout();
      this.PanelControl.SuspendLayout();
      this.PanelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).BeginInit();
      this.PanelRight.SuspendLayout();
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
      this.PanelControl.Controls.Add(this.PanelSlide);
      this.PanelControl.Controls.Add(this.ButtonAccount);
      this.PanelControl.Controls.Add(this.ButtonActivities);
      this.PanelControl.Controls.Add(this.ButtonHome);
      this.PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelControl.Location = new System.Drawing.Point(0, 165);
      this.PanelControl.Margin = new System.Windows.Forms.Padding(0);
      this.PanelControl.Name = "PanelControl";
      this.PanelControl.Size = new System.Drawing.Size(240, 375);
      this.PanelControl.TabIndex = 5;
      // 
      // PanelSlide
      // 
      this.PanelSlide.BackColor = System.Drawing.Color.Black;
      this.PanelSlide.Location = new System.Drawing.Point(0, 0);
      this.PanelSlide.Name = "PanelSlide";
      this.PanelSlide.Size = new System.Drawing.Size(4, 48);
      this.PanelSlide.TabIndex = 1;
      // 
      // ButtonAccount
      // 
      this.ButtonAccount.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonAccount.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonAccount.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonAccount.FlatAppearance.BorderSize = 0;
      this.ButtonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonAccount.ImageIndex = 3;
      this.ButtonAccount.ImageList = this.ImageControl;
      this.ButtonAccount.Location = new System.Drawing.Point(0, 96);
      this.ButtonAccount.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonAccount.Name = "ButtonAccount";
      this.ButtonAccount.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonAccount.Size = new System.Drawing.Size(240, 48);
      this.ButtonAccount.TabIndex = 5;
      this.ButtonAccount.Text = "Tài khoản";
      this.ButtonAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonAccount.UseVisualStyleBackColor = false;
      this.ButtonAccount.Click += new System.EventHandler(this.ButtonAccount_Click);
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
      // ButtonActivities
      // 
      this.ButtonActivities.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonActivities.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonActivities.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonActivities.FlatAppearance.BorderSize = 0;
      this.ButtonActivities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonActivities.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonActivities.ImageIndex = 0;
      this.ButtonActivities.ImageList = this.ImageControl;
      this.ButtonActivities.Location = new System.Drawing.Point(0, 48);
      this.ButtonActivities.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonActivities.Name = "ButtonActivities";
      this.ButtonActivities.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonActivities.Size = new System.Drawing.Size(240, 48);
      this.ButtonActivities.TabIndex = 3;
      this.ButtonActivities.Text = "Hoạt động";
      this.ButtonActivities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonActivities.UseVisualStyleBackColor = false;
      this.ButtonActivities.Click += new System.EventHandler(this.ButtonActivities_Click);
      // 
      // ButtonHome
      // 
      this.ButtonHome.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonHome.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::nJobee.Properties.Settings.Default, "BackColorC", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top;
      this.ButtonHome.FlatAppearance.BorderSize = 0;
      this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ButtonHome.ImageIndex = 1;
      this.ButtonHome.ImageList = this.ImageControl;
      this.ButtonHome.Location = new System.Drawing.Point(0, 0);
      this.ButtonHome.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonHome.Name = "ButtonHome";
      this.ButtonHome.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
      this.ButtonHome.Size = new System.Drawing.Size(240, 48);
      this.ButtonHome.TabIndex = 0;
      this.ButtonHome.Text = "Tìm kiếm";
      this.ButtonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ButtonHome.UseVisualStyleBackColor = false;
      this.ButtonHome.Click += new System.EventHandler(this.ButtonHome_Click);
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
      // PanelRight
      // 
      this.PanelRight.Controls.Add(this.UCtrlHome);
      this.PanelRight.Controls.Add(this.UCtrlActivities);
      this.PanelRight.Controls.Add(this.UCtrlAccount);
      this.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelRight.Location = new System.Drawing.Point(240, 0);
      this.PanelRight.Name = "PanelRight";
      this.PanelRight.Size = new System.Drawing.Size(720, 540);
      this.PanelRight.TabIndex = 1;
      // 
      // UCtrlHome
      // 
      this.UCtrlHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(217)))), ((int)(((byte)(120)))));
      this.UCtrlHome.Font = new System.Drawing.Font("Montserrat", 14.25F);
      this.UCtrlHome.Location = new System.Drawing.Point(0, 0);
      this.UCtrlHome.Name = "UCtrlHome";
      this.UCtrlHome.Size = new System.Drawing.Size(720, 540);
      this.UCtrlHome.TabIndex = 0;
      // 
      // UCtrlActivities
      // 
      this.UCtrlActivities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(217)))), ((int)(((byte)(120)))));
      this.UCtrlActivities.Font = new System.Drawing.Font("Montserrat", 14.25F);
      this.UCtrlActivities.Location = new System.Drawing.Point(0, 0);
      this.UCtrlActivities.Name = "UCtrlActivities";
      this.UCtrlActivities.Size = new System.Drawing.Size(720, 540);
      this.UCtrlActivities.TabIndex = 1;
      // 
      // UCtrlAccount
      // 
      this.UCtrlAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(217)))), ((int)(((byte)(120)))));
      this.UCtrlAccount.Font = new System.Drawing.Font("Montserrat", 14.25F);
      this.UCtrlAccount.Location = new System.Drawing.Point(0, 0);
      this.UCtrlAccount.Name = "UCtrlAccount";
      this.UCtrlAccount.Size = new System.Drawing.Size(720, 540);
      this.UCtrlAccount.TabIndex = 0;
      this.UCtrlAccount.Visible = false;
      // 
      // Master
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.ClientSize = new System.Drawing.Size(960, 540);
      this.Controls.Add(this.PanelRight);
      this.Controls.Add(this.PanelLeft);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Master";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "n/Jobee";
      this.PanelLeft.ResumeLayout(false);
      this.PanelControl.ResumeLayout(false);
      this.PanelUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).EndInit();
      this.PanelRight.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelLeft;
    private System.Windows.Forms.Panel PanelControl;
    private System.Windows.Forms.Button ButtonAccount;
    private System.Windows.Forms.Button ButtonActivities;
    private System.Windows.Forms.Button ButtonHome;
    private System.Windows.Forms.Panel PanelUser;
    private System.Windows.Forms.Label LabelFullname;
    private System.Windows.Forms.PictureBox PicboxAvatar;
    private System.Windows.Forms.ImageList ImageControl;
    private System.Windows.Forms.Panel PanelSlide;
    private System.Windows.Forms.Panel PanelRight;
    private CtrlAccount UCtrlAccount;
    private CtrlActivities UCtrlActivities;
    private CtrlHome UCtrlHome;
  }
}


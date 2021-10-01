
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
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.LabelUserName = new System.Windows.Forms.Label();
      this.PicboxUserProfile = new System.Windows.Forms.PictureBox();
      this.PanelView = new System.Windows.Forms.Panel();
      this.uctrlUser1 = new nJobee.UctrlUser();
      this.PanelUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicboxUserProfile)).BeginInit();
      this.PanelView.SuspendLayout();
      this.SuspendLayout();
      // 
      // PanelUser
      // 
      this.PanelUser.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.PanelUser.Controls.Add(this.button3);
      this.PanelUser.Controls.Add(this.button2);
      this.PanelUser.Controls.Add(this.button1);
      this.PanelUser.Controls.Add(this.LabelUserName);
      this.PanelUser.Controls.Add(this.PicboxUserProfile);
      this.PanelUser.Dock = System.Windows.Forms.DockStyle.Left;
      this.PanelUser.Location = new System.Drawing.Point(0, 0);
      this.PanelUser.Name = "PanelUser";
      this.PanelUser.Size = new System.Drawing.Size(240, 540);
      this.PanelUser.TabIndex = 0;
      // 
      // button3
      // 
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Location = new System.Drawing.Point(0, 287);
      this.button3.Margin = new System.Windows.Forms.Padding(0);
      this.button3.Name = "button3";
      this.button3.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
      this.button3.Size = new System.Drawing.Size(240, 48);
      this.button3.TabIndex = 3;
      this.button3.Text = "Tài khoản";
      this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Location = new System.Drawing.Point(0, 239);
      this.button2.Margin = new System.Windows.Forms.Padding(0);
      this.button2.Name = "button2";
      this.button2.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
      this.button2.Size = new System.Drawing.Size(240, 48);
      this.button2.TabIndex = 3;
      this.button2.Text = "Hoạt động";
      this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button1
      // 
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(0, 191);
      this.button1.Margin = new System.Windows.Forms.Padding(0);
      this.button1.Name = "button1";
      this.button1.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
      this.button1.Size = new System.Drawing.Size(240, 48);
      this.button1.TabIndex = 3;
      this.button1.Text = "Tìm kiếm";
      this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button1.UseVisualStyleBackColor = true;
      // 
      // LabelUserName
      // 
      this.LabelUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::nJobee.Properties.Settings.Default, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.LabelUserName.Location = new System.Drawing.Point(0, 123);
      this.LabelUserName.Name = "LabelUserName";
      this.LabelUserName.Size = new System.Drawing.Size(240, 45);
      this.LabelUserName.TabIndex = 2;
      this.LabelUserName.Text = global::nJobee.Properties.Settings.Default.Name;
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
      // PanelView
      // 
      this.PanelView.Controls.Add(this.uctrlUser1);
      this.PanelView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PanelView.Location = new System.Drawing.Point(240, 0);
      this.PanelView.Name = "PanelView";
      this.PanelView.Size = new System.Drawing.Size(720, 540);
      this.PanelView.TabIndex = 1;
      // 
      // uctrlUser1
      // 
      this.uctrlUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(160)))));
      this.uctrlUser1.Font = new System.Drawing.Font("Open Sans", 15.75F);
      this.uctrlUser1.Location = new System.Drawing.Point(0, 0);
      this.uctrlUser1.Name = "uctrlUser1";
      this.uctrlUser1.Size = new System.Drawing.Size(720, 540);
      this.uctrlUser1.TabIndex = 0;
      // 
      // Master
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColor;
      this.ClientSize = new System.Drawing.Size(960, 540);
      this.Controls.Add(this.PanelView);
      this.Controls.Add(this.PanelUser);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Master";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.PanelUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PicboxUserProfile)).EndInit();
      this.PanelView.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PanelUser;
    private System.Windows.Forms.PictureBox PicboxUserProfile;
    private System.Windows.Forms.Label LabelUserName;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Panel PanelView;
    private UctrlUser uctrlUser1;
  }
}


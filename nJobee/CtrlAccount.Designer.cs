
namespace nJobee
{
  partial class CtrlAccount
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
      this.TextBoxName = new System.Windows.Forms.TextBox();
      this.TextBoxEmail = new System.Windows.Forms.TextBox();
      this.LabelName = new System.Windows.Forms.Label();
      this.LabelEmail = new System.Windows.Forms.Label();
      this.LabelPhone = new System.Windows.Forms.Label();
      this.TextBoxPhone = new System.Windows.Forms.TextBox();
      this.ButtonSave = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.PicboxAvatar = new System.Windows.Forms.PictureBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).BeginInit();
      this.SuspendLayout();
      // 
      // TextBoxName
      // 
      this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxName.Location = new System.Drawing.Point(228, 4);
      this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxName.Name = "TextBoxName";
      this.TextBoxName.Size = new System.Drawing.Size(364, 31);
      this.TextBoxName.TabIndex = 0;
      // 
      // TextBoxEmail
      // 
      this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxEmail.Location = new System.Drawing.Point(228, 65);
      this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxEmail.Name = "TextBoxEmail";
      this.TextBoxEmail.Size = new System.Drawing.Size(364, 31);
      this.TextBoxEmail.TabIndex = 1;
      // 
      // LabelName
      // 
      this.LabelName.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelName.Location = new System.Drawing.Point(4, 4);
      this.LabelName.Margin = new System.Windows.Forms.Padding(4);
      this.LabelName.Name = "LabelName";
      this.LabelName.Size = new System.Drawing.Size(216, 31);
      this.LabelName.TabIndex = 2;
      this.LabelName.Text = "Tên người dùng";
      this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // LabelEmail
      // 
      this.LabelEmail.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelEmail.Location = new System.Drawing.Point(4, 65);
      this.LabelEmail.Margin = new System.Windows.Forms.Padding(4);
      this.LabelEmail.Name = "LabelEmail";
      this.LabelEmail.Size = new System.Drawing.Size(216, 31);
      this.LabelEmail.TabIndex = 2;
      this.LabelEmail.Text = "Địa chỉ mail";
      this.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // LabelPhone
      // 
      this.LabelPhone.Dock = System.Windows.Forms.DockStyle.Top;
      this.LabelPhone.Location = new System.Drawing.Point(4, 126);
      this.LabelPhone.Margin = new System.Windows.Forms.Padding(4);
      this.LabelPhone.Name = "LabelPhone";
      this.LabelPhone.Size = new System.Drawing.Size(216, 25);
      this.LabelPhone.TabIndex = 2;
      this.LabelPhone.Text = "Số điện thoại";
      this.LabelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TextBoxPhone
      // 
      this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxPhone.Location = new System.Drawing.Point(228, 126);
      this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxPhone.Name = "TextBoxPhone";
      this.TextBoxPhone.Size = new System.Drawing.Size(364, 31);
      this.TextBoxPhone.TabIndex = 2;
      // 
      // ButtonSave
      // 
      this.ButtonSave.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonSave.FlatAppearance.BorderSize = 0;
      this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonSave.Location = new System.Drawing.Point(261, 429);
      this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new System.Drawing.Size(363, 38);
      this.ButtonSave.TabIndex = 3;
      this.ButtonSave.Text = "Lưu";
      this.ButtonSave.UseVisualStyleBackColor = false;
      this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.29878F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.70122F));
      this.tableLayoutPanel1.Controls.Add(this.LabelName, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.LabelEmail, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.TextBoxPhone, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.TextBoxEmail, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.LabelPhone, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.TextBoxName, 1, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 230);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(32, 16, 32, 16);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(656, 183);
      this.tableLayoutPanel1.TabIndex = 4;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.PicboxAvatar);
      this.panel1.Location = new System.Drawing.Point(32, 64);
      this.panel1.Margin = new System.Windows.Forms.Padding(16, 64, 16, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(656, 134);
      this.panel1.TabIndex = 5;
      // 
      // PicboxAvatar
      // 
      this.PicboxAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PicboxAvatar.Image = global::nJobee.Properties.Resources.DefaultAvatar;
      this.PicboxAvatar.Location = new System.Drawing.Point(0, 0);
      this.PicboxAvatar.Margin = new System.Windows.Forms.Padding(4);
      this.PicboxAvatar.Name = "PicboxAvatar";
      this.PicboxAvatar.Size = new System.Drawing.Size(656, 134);
      this.PicboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.PicboxAvatar.TabIndex = 0;
      this.PicboxAvatar.TabStop = false;
      // 
      // CtrlAccount
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.ButtonSave);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "CtrlAccount";
      this.Size = new System.Drawing.Size(720, 540);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.PicboxAvatar)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox PicboxAvatar;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.TextBox TextBoxEmail;
    private System.Windows.Forms.Label LabelName;
    private System.Windows.Forms.Label LabelEmail;
    private System.Windows.Forms.Label LabelPhone;
    private System.Windows.Forms.Button ButtonSave;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox TextBoxPhone;
    private System.Windows.Forms.Panel panel1;
  }
}

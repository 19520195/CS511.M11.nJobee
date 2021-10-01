
namespace nJobee
{
  partial class UctrlUser
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.TextBoxName = new System.Windows.Forms.TextBox();
      this.TextBoxEmail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TextBoxPhone = new System.Windows.Forms.TextBox();
      this.ButtonSave = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::nJobee.Properties.Resources.DefaultAvatar;
      this.pictureBox1.Location = new System.Drawing.Point(271, 41);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 128);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // TextBoxName
      // 
      this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxName.Location = new System.Drawing.Point(296, 242);
      this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
      this.TextBoxName.Name = "TextBoxName";
      this.TextBoxName.Size = new System.Drawing.Size(320, 36);
      this.TextBoxName.TabIndex = 0;
      // 
      // TextBoxEmail
      // 
      this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxEmail.Location = new System.Drawing.Point(296, 286);
      this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
      this.TextBoxEmail.Name = "TextBoxEmail";
      this.TextBoxEmail.Size = new System.Drawing.Size(320, 36);
      this.TextBoxEmail.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(83, 242);
      this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(193, 36);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tên người dùng";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(83, 286);
      this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(193, 36);
      this.label2.TabIndex = 2;
      this.label2.Text = "Địa chỉ mail";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(83, 330);
      this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(193, 36);
      this.label3.TabIndex = 2;
      this.label3.Text = "Số điện thoại";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TextBoxPhone
      // 
      this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxPhone.Location = new System.Drawing.Point(296, 330);
      this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
      this.TextBoxPhone.Name = "TextBoxPhone";
      this.TextBoxPhone.Size = new System.Drawing.Size(320, 36);
      this.TextBoxPhone.TabIndex = 2;
      // 
      // ButtonSave
      // 
      this.ButtonSave.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ButtonSave.FlatAppearance.BorderSize = 0;
      this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonSave.Location = new System.Drawing.Point(296, 386);
      this.ButtonSave.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonSave.Name = "ButtonSave";
      this.ButtonSave.Size = new System.Drawing.Size(320, 38);
      this.ButtonSave.TabIndex = 3;
      this.ButtonSave.Text = "Lưu";
      this.ButtonSave.UseVisualStyleBackColor = false;
      this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // UctrlUser
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.Controls.Add(this.ButtonSave);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TextBoxEmail);
      this.Controls.Add(this.TextBoxPhone);
      this.Controls.Add(this.TextBoxName);
      this.Controls.Add(this.pictureBox1);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "UctrlUser";
      this.Size = new System.Drawing.Size(720, 540);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.TextBox TextBoxEmail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox TextBoxPhone;
    private System.Windows.Forms.Button ButtonSave;
  }
}


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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.TextBoxName = new System.Windows.Forms.TextBox();
      this.TextBoxEmail = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.TextBoxPhone = new System.Windows.Forms.TextBox();
      this.ButtonSave = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Image = global::nJobee.Properties.Resources.DefaultAvatar;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(656, 134);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // TextBoxName
      // 
      this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxName.Location = new System.Drawing.Point(229, 4);
      this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxName.Name = "TextBoxName";
      this.TextBoxName.Size = new System.Drawing.Size(363, 31);
      this.TextBoxName.TabIndex = 0;
      // 
      // TextBoxEmail
      // 
      this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxEmail.Location = new System.Drawing.Point(229, 64);
      this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxEmail.Name = "TextBoxEmail";
      this.TextBoxEmail.Size = new System.Drawing.Size(363, 31);
      this.TextBoxEmail.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Margin = new System.Windows.Forms.Padding(4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(217, 31);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tên người dùng";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(4, 64);
      this.label2.Margin = new System.Windows.Forms.Padding(4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(217, 31);
      this.label2.TabIndex = 2;
      this.label2.Text = "Địa chỉ mail";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Top;
      this.label3.Location = new System.Drawing.Point(4, 124);
      this.label3.Margin = new System.Windows.Forms.Padding(4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(217, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Số điện thoại";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // TextBoxPhone
      // 
      this.TextBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.TextBoxPhone.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TextBoxPhone.Location = new System.Drawing.Point(229, 124);
      this.TextBoxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 64, 4);
      this.TextBoxPhone.Name = "TextBoxPhone";
      this.TextBoxPhone.Size = new System.Drawing.Size(363, 31);
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
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.TextBoxPhone, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.TextBoxEmail, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
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
      this.panel1.Controls.Add(this.pictureBox1);
      this.panel1.Location = new System.Drawing.Point(32, 64);
      this.panel1.Margin = new System.Windows.Forms.Padding(16, 64, 16, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(656, 134);
      this.panel1.TabIndex = 5;
      // 
      // UctrlUser
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.ButtonSave);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "UctrlUser";
      this.Size = new System.Drawing.Size(720, 540);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox TextBoxName;
    private System.Windows.Forms.TextBox TextBoxEmail;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button ButtonSave;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TextBox TextBoxPhone;
    private System.Windows.Forms.Panel panel1;
  }
}

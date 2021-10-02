
namespace nJobee
{
  partial class Descriptor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descriptor));
      this.ComboxAddress = new System.Windows.Forms.TextBox();
      this.GrpboxAddress = new System.Windows.Forms.GroupBox();
      this.ComboxWard = new System.Windows.Forms.ComboBox();
      this.ComboxProvince = new System.Windows.Forms.ComboBox();
      this.ComboxDistrict = new System.Windows.Forms.ComboBox();
      this.GrpboxDateTime = new System.Windows.Forms.GroupBox();
      this.PickerDate = new System.Windows.Forms.DateTimePicker();
      this.PickerTime = new System.Windows.Forms.DateTimePicker();
      this.ButtonOK = new System.Windows.Forms.Button();
      this.GrpboxDescription = new System.Windows.Forms.GroupBox();
      this.GrpboxAddress.SuspendLayout();
      this.GrpboxDateTime.SuspendLayout();
      this.SuspendLayout();
      // 
      // ComboxAddress
      // 
      this.ComboxAddress.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ComboxAddress.Location = new System.Drawing.Point(11, 185);
      this.ComboxAddress.Margin = new System.Windows.Forms.Padding(8);
      this.ComboxAddress.Name = "ComboxAddress";
      this.ComboxAddress.Size = new System.Drawing.Size(338, 31);
      this.ComboxAddress.TabIndex = 3;
      // 
      // GrpboxAddress
      // 
      this.GrpboxAddress.Controls.Add(this.ComboxWard);
      this.GrpboxAddress.Controls.Add(this.ComboxAddress);
      this.GrpboxAddress.Controls.Add(this.ComboxProvince);
      this.GrpboxAddress.Controls.Add(this.ComboxDistrict);
      this.GrpboxAddress.Location = new System.Drawing.Point(25, 25);
      this.GrpboxAddress.Margin = new System.Windows.Forms.Padding(16, 16, 8, 16);
      this.GrpboxAddress.Name = "GrpboxAddress";
      this.GrpboxAddress.Size = new System.Drawing.Size(360, 240);
      this.GrpboxAddress.TabIndex = 2;
      this.GrpboxAddress.TabStop = false;
      this.GrpboxAddress.Text = "Địa chỉ";
      // 
      // ComboxWard
      // 
      this.ComboxWard.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxWard.DropDownHeight = 256;
      this.ComboxWard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboxWard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ComboxWard.IntegralHeight = false;
      this.ComboxWard.Location = new System.Drawing.Point(11, 135);
      this.ComboxWard.Margin = new System.Windows.Forms.Padding(8);
      this.ComboxWard.Name = "ComboxWard";
      this.ComboxWard.Size = new System.Drawing.Size(338, 34);
      this.ComboxWard.TabIndex = 2;
      // 
      // ComboxProvince
      // 
      this.ComboxProvince.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxProvince.DropDownHeight = 256;
      this.ComboxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboxProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ComboxProvince.IntegralHeight = false;
      this.ComboxProvince.Location = new System.Drawing.Point(11, 35);
      this.ComboxProvince.Margin = new System.Windows.Forms.Padding(8);
      this.ComboxProvince.Name = "ComboxProvince";
      this.ComboxProvince.Size = new System.Drawing.Size(338, 34);
      this.ComboxProvince.Sorted = true;
      this.ComboxProvince.TabIndex = 0;
      this.ComboxProvince.SelectedIndexChanged += new System.EventHandler(this.ComboxProvince_SelectedIndexChanged);
      // 
      // ComboxDistrict
      // 
      this.ComboxDistrict.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxDistrict.DropDownHeight = 256;
      this.ComboxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboxDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ComboxDistrict.IntegralHeight = false;
      this.ComboxDistrict.Location = new System.Drawing.Point(11, 85);
      this.ComboxDistrict.Margin = new System.Windows.Forms.Padding(8);
      this.ComboxDistrict.Name = "ComboxDistrict";
      this.ComboxDistrict.Size = new System.Drawing.Size(338, 34);
      this.ComboxDistrict.TabIndex = 1;
      this.ComboxDistrict.SelectedIndexChanged += new System.EventHandler(this.ComboxDistrict_SelectedIndexChanged);
      // 
      // GrpboxDateTime
      // 
      this.GrpboxDateTime.Controls.Add(this.PickerDate);
      this.GrpboxDateTime.Controls.Add(this.PickerTime);
      this.GrpboxDateTime.Location = new System.Drawing.Point(25, 289);
      this.GrpboxDateTime.Margin = new System.Windows.Forms.Padding(16, 16, 8, 16);
      this.GrpboxDateTime.Name = "GrpboxDateTime";
      this.GrpboxDateTime.Size = new System.Drawing.Size(360, 86);
      this.GrpboxDateTime.TabIndex = 3;
      this.GrpboxDateTime.TabStop = false;
      this.GrpboxDateTime.Text = "Thời gian";
      // 
      // PickerDate
      // 
      this.PickerDate.CustomFormat = "d / MM / yyyy";
      this.PickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.PickerDate.Location = new System.Drawing.Point(11, 35);
      this.PickerDate.Margin = new System.Windows.Forms.Padding(8);
      this.PickerDate.Name = "PickerDate";
      this.PickerDate.Size = new System.Drawing.Size(166, 31);
      this.PickerDate.TabIndex = 0;
      // 
      // PickerTime
      // 
      this.PickerTime.CustomFormat = "HH:mm";
      this.PickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.PickerTime.Location = new System.Drawing.Point(193, 35);
      this.PickerTime.Margin = new System.Windows.Forms.Padding(8);
      this.PickerTime.Name = "PickerTime";
      this.PickerTime.ShowUpDown = true;
      this.PickerTime.Size = new System.Drawing.Size(82, 31);
      this.PickerTime.TabIndex = 1;
      // 
      // ButtonOK
      // 
      this.ButtonOK.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonOK.Location = new System.Drawing.Point(401, 333);
      this.ButtonOK.Margin = new System.Windows.Forms.Padding(16, 8, 16, 16);
      this.ButtonOK.Name = "ButtonOK";
      this.ButtonOK.Size = new System.Drawing.Size(294, 42);
      this.ButtonOK.TabIndex = 12;
      this.ButtonOK.Text = "Hoàn tất";
      this.ButtonOK.UseVisualStyleBackColor = false;
      this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
      // 
      // GrpboxDescription
      // 
      this.GrpboxDescription.Location = new System.Drawing.Point(401, 25);
      this.GrpboxDescription.Margin = new System.Windows.Forms.Padding(8, 16, 16, 8);
      this.GrpboxDescription.Name = "GrpboxDescription";
      this.GrpboxDescription.Size = new System.Drawing.Size(294, 292);
      this.GrpboxDescription.TabIndex = 13;
      this.GrpboxDescription.TabStop = false;
      this.GrpboxDescription.Text = "Chi tiết";
      // 
      // Descriptor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.ClientSize = new System.Drawing.Size(720, 400);
      this.Controls.Add(this.GrpboxDescription);
      this.Controls.Add(this.ButtonOK);
      this.Controls.Add(this.GrpboxDateTime);
      this.Controls.Add(this.GrpboxAddress);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Descriptor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Thông tin";
      this.Load += new System.EventHandler(this.Descriptor_Load);
      this.GrpboxAddress.ResumeLayout(false);
      this.GrpboxAddress.PerformLayout();
      this.GrpboxDateTime.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TextBox ComboxAddress;
    private System.Windows.Forms.GroupBox GrpboxAddress;
    private System.Windows.Forms.ComboBox ComboxWard;
    private System.Windows.Forms.ComboBox ComboxDistrict;
    private System.Windows.Forms.ComboBox ComboxProvince;
    private System.Windows.Forms.GroupBox GrpboxDateTime;
    private System.Windows.Forms.DateTimePicker PickerTime;
    private System.Windows.Forms.DateTimePicker PickerDate;
    private System.Windows.Forms.Button ButtonOK;
    private System.Windows.Forms.GroupBox GrpboxDescription;
  }
}
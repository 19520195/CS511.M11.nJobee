
namespace nJobee.JobDescr
{
  partial class JobdCooking
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
      this.NumUDPeople = new System.Windows.Forms.NumericUpDown();
      this.LabelPeople = new System.Windows.Forms.Label();
      this.LabelStyle = new System.Windows.Forms.Label();
      this.ComboxStyle = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.NumUDPeople)).BeginInit();
      this.SuspendLayout();
      // 
      // NumUDPeople
      // 
      this.NumUDPeople.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.NumUDPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.NumUDPeople.Location = new System.Drawing.Point(183, 53);
      this.NumUDPeople.Margin = new System.Windows.Forms.Padding(0, 16, 16, 16);
      this.NumUDPeople.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.NumUDPeople.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.NumUDPeople.Name = "NumUDPeople";
      this.NumUDPeople.Size = new System.Drawing.Size(81, 31);
      this.NumUDPeople.TabIndex = 1;
      this.NumUDPeople.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // LabelPeople
      // 
      this.LabelPeople.Location = new System.Drawing.Point(16, 53);
      this.LabelPeople.Margin = new System.Windows.Forms.Padding(16);
      this.LabelPeople.Name = "LabelPeople";
      this.LabelPeople.Size = new System.Drawing.Size(151, 31);
      this.LabelPeople.TabIndex = 2;
      this.LabelPeople.Text = "Số người";
      this.LabelPeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // LabelStyle
      // 
      this.LabelStyle.Location = new System.Drawing.Point(21, 116);
      this.LabelStyle.Margin = new System.Windows.Forms.Padding(16);
      this.LabelStyle.Name = "LabelStyle";
      this.LabelStyle.Size = new System.Drawing.Size(243, 34);
      this.LabelStyle.TabIndex = 2;
      this.LabelStyle.Text = "Phong cách chế biến";
      this.LabelStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ComboxStyle
      // 
      this.ComboxStyle.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxStyle.FormattingEnabled = true;
      this.ComboxStyle.Items.AddRange(new object[] {
            "Việt Nam",
            "Hàn Quốc",
            "Châu Âu",
            "Trung Quốc"});
      this.ComboxStyle.Location = new System.Drawing.Point(21, 166);
      this.ComboxStyle.Margin = new System.Windows.Forms.Padding(0);
      this.ComboxStyle.Name = "ComboxStyle";
      this.ComboxStyle.Size = new System.Drawing.Size(243, 34);
      this.ComboxStyle.TabIndex = 3;
      // 
      // JobdCooking
      // 
      this.Controls.Add(this.ComboxStyle);
      this.Controls.Add(this.LabelStyle);
      this.Controls.Add(this.LabelPeople);
      this.Controls.Add(this.NumUDPeople);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "JobdCooking";
      this.Size = new System.Drawing.Size(280, 260);
      this.Load += new System.EventHandler(this.JobdCooking_Load);
      ((System.ComponentModel.ISupportInitialize)(this.NumUDPeople)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown NumUDPeople;
    private System.Windows.Forms.Label LabelPeople;
    private System.Windows.Forms.Label LabelStyle;
    private System.Windows.Forms.ComboBox ComboxStyle;
  }
}

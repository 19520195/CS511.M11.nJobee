
namespace nJobee.JobDescr
{
  partial class JobdACService
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
      this.RadioBelow = new System.Windows.Forms.RadioButton();
      this.RadioAbove = new System.Windows.Forms.RadioButton();
      this.LabelQuality = new System.Windows.Forms.Label();
      this.NumUDQuality = new System.Windows.Forms.NumericUpDown();
      this.CheckRefill = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.NumUDQuality)).BeginInit();
      this.SuspendLayout();
      // 
      // RadioBelow
      // 
      this.RadioBelow.AutoSize = true;
      this.RadioBelow.Checked = true;
      this.RadioBelow.Location = new System.Drawing.Point(65, 23);
      this.RadioBelow.Name = "RadioBelow";
      this.RadioBelow.Size = new System.Drawing.Size(121, 30);
      this.RadioBelow.TabIndex = 0;
      this.RadioBelow.TabStop = true;
      this.RadioBelow.Text = "Dưới 2HP";
      this.RadioBelow.UseVisualStyleBackColor = true;
      // 
      // RadioAbove
      // 
      this.RadioAbove.AutoSize = true;
      this.RadioAbove.Location = new System.Drawing.Point(65, 74);
      this.RadioAbove.Name = "RadioAbove";
      this.RadioAbove.Size = new System.Drawing.Size(118, 30);
      this.RadioAbove.TabIndex = 0;
      this.RadioAbove.Text = "Trên 2HP";
      this.RadioAbove.UseVisualStyleBackColor = true;
      // 
      // LabelQuality
      // 
      this.LabelQuality.AutoSize = true;
      this.LabelQuality.Location = new System.Drawing.Point(60, 126);
      this.LabelQuality.Name = "LabelQuality";
      this.LabelQuality.Size = new System.Drawing.Size(97, 26);
      this.LabelQuality.TabIndex = 1;
      this.LabelQuality.Text = "Số lượng";
      // 
      // NumUDQuality
      // 
      this.NumUDQuality.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.NumUDQuality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.NumUDQuality.Location = new System.Drawing.Point(163, 124);
      this.NumUDQuality.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
      this.NumUDQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.NumUDQuality.Name = "NumUDQuality";
      this.NumUDQuality.Size = new System.Drawing.Size(37, 31);
      this.NumUDQuality.TabIndex = 2;
      this.NumUDQuality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // CheckRefill
      // 
      this.CheckRefill.AutoSize = true;
      this.CheckRefill.Location = new System.Drawing.Point(65, 184);
      this.CheckRefill.Name = "CheckRefill";
      this.CheckRefill.Size = new System.Drawing.Size(106, 30);
      this.CheckRefill.TabIndex = 3;
      this.CheckRefill.Text = "Bơm ga";
      this.CheckRefill.UseVisualStyleBackColor = true;
      // 
      // JobdACService
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.CheckRefill);
      this.Controls.Add(this.NumUDQuality);
      this.Controls.Add(this.LabelQuality);
      this.Controls.Add(this.RadioAbove);
      this.Controls.Add(this.RadioBelow);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "JobdACService";
      this.Size = new System.Drawing.Size(280, 260);
      ((System.ComponentModel.ISupportInitialize)(this.NumUDQuality)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton RadioBelow;
    private System.Windows.Forms.RadioButton RadioAbove;
    private System.Windows.Forms.Label LabelQuality;
    private System.Windows.Forms.NumericUpDown NumUDQuality;
    private System.Windows.Forms.CheckBox CheckRefill;
  }
}

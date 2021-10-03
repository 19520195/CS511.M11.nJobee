
namespace nJobee.JobDescr
{
  partial class JobdLaudry
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
      this.CheckDry = new System.Windows.Forms.CheckBox();
      this.NumUDKg = new System.Windows.Forms.NumericUpDown();
      this.LabelQuantity = new System.Windows.Forms.Label();
      this.LabelKg = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.NumUDKg)).BeginInit();
      this.SuspendLayout();
      // 
      // CheckDry
      // 
      this.CheckDry.AutoSize = true;
      this.CheckDry.Location = new System.Drawing.Point(22, 134);
      this.CheckDry.Name = "CheckDry";
      this.CheckDry.Size = new System.Drawing.Size(188, 30);
      this.CheckDry.TabIndex = 0;
      this.CheckDry.Text = "Sấy khô quần áo";
      this.CheckDry.UseVisualStyleBackColor = true;
      // 
      // NumUDKg
      // 
      this.NumUDKg.Location = new System.Drawing.Point(120, 85);
      this.NumUDKg.Name = "NumUDKg";
      this.NumUDKg.Size = new System.Drawing.Size(83, 31);
      this.NumUDKg.TabIndex = 1;
      // 
      // LabelQuantity
      // 
      this.LabelQuantity.AutoSize = true;
      this.LabelQuantity.Location = new System.Drawing.Point(17, 87);
      this.LabelQuantity.Name = "LabelQuantity";
      this.LabelQuantity.Size = new System.Drawing.Size(97, 26);
      this.LabelQuantity.TabIndex = 2;
      this.LabelQuantity.Text = "Số lượng";
      // 
      // LabelKg
      // 
      this.LabelKg.AutoSize = true;
      this.LabelKg.Location = new System.Drawing.Point(209, 87);
      this.LabelKg.Name = "LabelKg";
      this.LabelKg.Size = new System.Drawing.Size(36, 26);
      this.LabelKg.TabIndex = 3;
      this.LabelKg.Text = "kg";
      // 
      // JobdLaudry
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LabelKg);
      this.Controls.Add(this.LabelQuantity);
      this.Controls.Add(this.NumUDKg);
      this.Controls.Add(this.CheckDry);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "JobdLaudry";
      this.Size = new System.Drawing.Size(280, 260);
      ((System.ComponentModel.ISupportInitialize)(this.NumUDKg)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox CheckDry;
    private System.Windows.Forms.NumericUpDown NumUDKg;
    private System.Windows.Forms.Label LabelQuantity;
    private System.Windows.Forms.Label LabelKg;
  }
}

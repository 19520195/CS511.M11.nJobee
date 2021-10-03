
namespace nJobee
{
  partial class CtrlActivities
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
      this.TabpanelActivities = new System.Windows.Forms.TableLayoutPanel();
      this.LabelTitle = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TabpanelActivities
      // 
      this.TabpanelActivities.ColumnCount = 1;
      this.TabpanelActivities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.TabpanelActivities.Location = new System.Drawing.Point(16, 88);
      this.TabpanelActivities.Margin = new System.Windows.Forms.Padding(16, 0, 16, 32);
      this.TabpanelActivities.Name = "TabpanelActivities";
      this.TabpanelActivities.RowCount = 8;
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
      this.TabpanelActivities.Size = new System.Drawing.Size(688, 420);
      this.TabpanelActivities.TabIndex = 0;
      // 
      // LabelTitle
      // 
      this.LabelTitle.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
      this.LabelTitle.Location = new System.Drawing.Point(16, 16);
      this.LabelTitle.Margin = new System.Windows.Forms.Padding(16);
      this.LabelTitle.Name = "LabelTitle";
      this.LabelTitle.Size = new System.Drawing.Size(688, 56);
      this.LabelTitle.TabIndex = 1;
      this.LabelTitle.Text = "Danh Sách Hoạt Động";
      this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // CtrlActivities
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.Controls.Add(this.LabelTitle);
      this.Controls.Add(this.TabpanelActivities);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "CtrlActivities";
      this.Size = new System.Drawing.Size(720, 540);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TabpanelActivities;
    private System.Windows.Forms.Label LabelTitle;
  }
}

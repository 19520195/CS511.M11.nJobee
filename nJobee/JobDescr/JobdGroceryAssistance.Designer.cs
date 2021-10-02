
namespace nJobee.JobDescr
{
  partial class JobdGroceryAssistance
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
      this.ComboxCash = new System.Windows.Forms.ComboBox();
      this.RichboxList = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // ComboxCash
      // 
      this.ComboxCash.BackColor = global::nJobee.Properties.Settings.Default.BackColorB;
      this.ComboxCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboxCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ComboxCash.FormattingEnabled = true;
      this.ComboxCash.Items.AddRange(new object[] {
            "300.000đ",
            "500.000đ",
            "700.000đ",
            "800.000đ",
            "900.000đ",
            "1.000.000đ"});
      this.ComboxCash.Location = new System.Drawing.Point(16, 210);
      this.ComboxCash.Margin = new System.Windows.Forms.Padding(16);
      this.ComboxCash.Name = "ComboxCash";
      this.ComboxCash.Size = new System.Drawing.Size(248, 34);
      this.ComboxCash.TabIndex = 0;
      // 
      // RichboxList
      // 
      this.RichboxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.RichboxList.Location = new System.Drawing.Point(16, 16);
      this.RichboxList.Margin = new System.Windows.Forms.Padding(16, 16, 16, 4);
      this.RichboxList.Name = "RichboxList";
      this.RichboxList.Size = new System.Drawing.Size(248, 174);
      this.RichboxList.TabIndex = 1;
      this.RichboxList.Text = "+ 1.1kg thịt nạc\n+ 8 hộp Vinamilk";
      // 
      // JobdGroceryAssistance
      // 
      this.Controls.Add(this.RichboxList);
      this.Controls.Add(this.ComboxCash);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "JobdGroceryAssistance";
      this.Size = new System.Drawing.Size(280, 260);
      this.Load += new System.EventHandler(this.JobdGroceryAssistance_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox ComboxCash;
    private System.Windows.Forms.RichTextBox RichboxList;
  }
}

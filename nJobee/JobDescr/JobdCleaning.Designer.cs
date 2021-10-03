
namespace nJobee.JobDescr
{
  partial class JobdCleaning
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
      this.Radio4rooms = new System.Windows.Forms.RadioButton();
      this.Radio3rooms = new System.Windows.Forms.RadioButton();
      this.Radio2rooms = new System.Windows.Forms.RadioButton();
      this.Label2rooms = new System.Windows.Forms.Label();
      this.Label3rooms = new System.Windows.Forms.Label();
      this.Label4rooms = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Radio4rooms
      // 
      this.Radio4rooms.Location = new System.Drawing.Point(16, 160);
      this.Radio4rooms.Margin = new System.Windows.Forms.Padding(16);
      this.Radio4rooms.Name = "Radio4rooms";
      this.Radio4rooms.Size = new System.Drawing.Size(248, 40);
      this.Radio4rooms.TabIndex = 2;
      this.Radio4rooms.Text = "105m² / 4 phòng";
      this.Radio4rooms.UseVisualStyleBackColor = true;
      // 
      // Radio3rooms
      // 
      this.Radio3rooms.Location = new System.Drawing.Point(16, 88);
      this.Radio3rooms.Margin = new System.Windows.Forms.Padding(16);
      this.Radio3rooms.Name = "Radio3rooms";
      this.Radio3rooms.Size = new System.Drawing.Size(248, 40);
      this.Radio3rooms.TabIndex = 1;
      this.Radio3rooms.Text = "85m² / 3 phòng";
      this.Radio3rooms.UseVisualStyleBackColor = true;
      // 
      // Radio2rooms
      // 
      this.Radio2rooms.Checked = true;
      this.Radio2rooms.Location = new System.Drawing.Point(16, 16);
      this.Radio2rooms.Margin = new System.Windows.Forms.Padding(16);
      this.Radio2rooms.Name = "Radio2rooms";
      this.Radio2rooms.Size = new System.Drawing.Size(248, 40);
      this.Radio2rooms.TabIndex = 0;
      this.Radio2rooms.TabStop = true;
      this.Radio2rooms.Text = "55m² / 2 phòng";
      this.Radio2rooms.UseVisualStyleBackColor = true;
      // 
      // Label2rooms
      // 
      this.Label2rooms.AutoSize = true;
      this.Label2rooms.Font = new System.Drawing.Font("Montserrat", 10F);
      this.Label2rooms.Location = new System.Drawing.Point(220, 36);
      this.Label2rooms.Name = "Label2rooms";
      this.Label2rooms.Size = new System.Drawing.Size(44, 20);
      this.Label2rooms.TabIndex = 3;
      this.Label2rooms.Text = "2 giờ";
      // 
      // Label3rooms
      // 
      this.Label3rooms.AutoSize = true;
      this.Label3rooms.Font = new System.Drawing.Font("Montserrat", 10F);
      this.Label3rooms.Location = new System.Drawing.Point(220, 102);
      this.Label3rooms.Name = "Label3rooms";
      this.Label3rooms.Size = new System.Drawing.Size(44, 20);
      this.Label3rooms.TabIndex = 4;
      this.Label3rooms.Text = "3 giờ";
      // 
      // Label4rooms
      // 
      this.Label4rooms.AutoSize = true;
      this.Label4rooms.Font = new System.Drawing.Font("Montserrat", 10F);
      this.Label4rooms.Location = new System.Drawing.Point(220, 174);
      this.Label4rooms.Name = "Label4rooms";
      this.Label4rooms.Size = new System.Drawing.Size(45, 20);
      this.Label4rooms.TabIndex = 4;
      this.Label4rooms.Text = "4 giờ";
      // 
      // JobdCleaning
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Label4rooms);
      this.Controls.Add(this.Label3rooms);
      this.Controls.Add(this.Label2rooms);
      this.Controls.Add(this.Radio4rooms);
      this.Controls.Add(this.Radio3rooms);
      this.Controls.Add(this.Radio2rooms);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "JobdCleaning";
      this.Size = new System.Drawing.Size(280, 260);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RadioButton Radio4rooms;
    private System.Windows.Forms.RadioButton Radio3rooms;
    private System.Windows.Forms.RadioButton Radio2rooms;
    private System.Windows.Forms.Label Label2rooms;
    private System.Windows.Forms.Label Label3rooms;
    private System.Windows.Forms.Label Label4rooms;
  }
}

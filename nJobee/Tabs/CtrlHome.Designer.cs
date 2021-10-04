
namespace nJobee
{
  partial class CtrlHome
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlHome));
      this.TabpanelFunctions = new System.Windows.Forms.TableLayoutPanel();
      this.ButtonHomeCooking = new System.Windows.Forms.Button();
      this.ButtonLaudry = new System.Windows.Forms.Button();
      this.ButtonDisinfectionService = new System.Windows.Forms.Button();
      this.ButtonACService = new System.Windows.Forms.Button();
      this.ButtonCleaning = new System.Windows.Forms.Button();
      this.ButtonGroceryAssistance = new System.Windows.Forms.Button();
      this.LabelCash = new System.Windows.Forms.Label();
      this.ButtonCash = new System.Windows.Forms.Button();
      this.TabpanelCash = new System.Windows.Forms.TableLayoutPanel();
      this.LabelAddress = new System.Windows.Forms.Label();
      this.LabelTime = new System.Windows.Forms.Label();
      this.LabelCashValue = new System.Windows.Forms.Label();
      this.LabelAddressValue = new System.Windows.Forms.Label();
      this.LabelTimeValue = new System.Windows.Forms.Label();
      this.LabelService = new System.Windows.Forms.Label();
      this.LabelServiceValue = new System.Windows.Forms.Label();
      this.ImlistControl = new System.Windows.Forms.ImageList(this.components);
      this.TabpanelFunctions.SuspendLayout();
      this.TabpanelCash.SuspendLayout();
      this.SuspendLayout();
      // 
      // TabpanelFunctions
      // 
      this.TabpanelFunctions.ColumnCount = 4;
      this.TabpanelFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelFunctions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelFunctions.Controls.Add(this.ButtonHomeCooking, 1, 1);
      this.TabpanelFunctions.Controls.Add(this.ButtonLaudry, 0, 1);
      this.TabpanelFunctions.Controls.Add(this.ButtonDisinfectionService, 3, 0);
      this.TabpanelFunctions.Controls.Add(this.ButtonACService, 2, 0);
      this.TabpanelFunctions.Controls.Add(this.ButtonCleaning, 0, 0);
      this.TabpanelFunctions.Controls.Add(this.ButtonGroceryAssistance, 1, 0);
      this.TabpanelFunctions.Location = new System.Drawing.Point(35, 32);
      this.TabpanelFunctions.Name = "TabpanelFunctions";
      this.TabpanelFunctions.RowCount = 2;
      this.TabpanelFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.TabpanelFunctions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.TabpanelFunctions.Size = new System.Drawing.Size(650, 290);
      this.TabpanelFunctions.TabIndex = 0;
      // 
      // ButtonHomeCooking
      // 
      this.ButtonHomeCooking.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonHomeCooking.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonHomeCooking.FlatAppearance.BorderSize = 0;
      this.ButtonHomeCooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonHomeCooking.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonHomeCooking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonHomeCooking.ImageKey = "Cooking.png";
      this.ButtonHomeCooking.ImageList = this.ImlistControl;
      this.ButtonHomeCooking.Location = new System.Drawing.Point(178, 161);
      this.ButtonHomeCooking.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonHomeCooking.Name = "ButtonHomeCooking";
      this.ButtonHomeCooking.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonHomeCooking.Size = new System.Drawing.Size(130, 113);
      this.ButtonHomeCooking.TabIndex = 9;
      this.ButtonHomeCooking.Text = "Nấu Ăn";
      this.ButtonHomeCooking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonHomeCooking.UseVisualStyleBackColor = false;
      this.ButtonHomeCooking.Click += new System.EventHandler(this.ButtonHomeCooking_Click);
      // 
      // ButtonLaudry
      // 
      this.ButtonLaudry.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonLaudry.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonLaudry.FlatAppearance.BorderSize = 0;
      this.ButtonLaudry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonLaudry.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonLaudry.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonLaudry.ImageKey = "Laudry.png";
      this.ButtonLaudry.ImageList = this.ImlistControl;
      this.ButtonLaudry.Location = new System.Drawing.Point(16, 161);
      this.ButtonLaudry.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonLaudry.Name = "ButtonLaudry";
      this.ButtonLaudry.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonLaudry.Size = new System.Drawing.Size(130, 113);
      this.ButtonLaudry.TabIndex = 8;
      this.ButtonLaudry.Text = "Giặt Ủi";
      this.ButtonLaudry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonLaudry.UseVisualStyleBackColor = false;
      this.ButtonLaudry.Click += new System.EventHandler(this.ButtonLaudry_Click);
      // 
      // ButtonDisinfectionService
      // 
      this.ButtonDisinfectionService.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonDisinfectionService.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonDisinfectionService.FlatAppearance.BorderSize = 0;
      this.ButtonDisinfectionService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonDisinfectionService.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonDisinfectionService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonDisinfectionService.ImageKey = "DisinfectionService.png";
      this.ButtonDisinfectionService.ImageList = this.ImlistControl;
      this.ButtonDisinfectionService.Location = new System.Drawing.Point(502, 16);
      this.ButtonDisinfectionService.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonDisinfectionService.Name = "ButtonDisinfectionService";
      this.ButtonDisinfectionService.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonDisinfectionService.Size = new System.Drawing.Size(132, 113);
      this.ButtonDisinfectionService.TabIndex = 7;
      this.ButtonDisinfectionService.Text = "Khử khuẩn";
      this.ButtonDisinfectionService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonDisinfectionService.UseVisualStyleBackColor = false;
      this.ButtonDisinfectionService.Click += new System.EventHandler(this.ButtonDisinfectionService_Click);
      // 
      // ButtonACService
      // 
      this.ButtonACService.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonACService.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonACService.FlatAppearance.BorderSize = 0;
      this.ButtonACService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonACService.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonACService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonACService.ImageKey = "ACService.png";
      this.ButtonACService.ImageList = this.ImlistControl;
      this.ButtonACService.Location = new System.Drawing.Point(340, 16);
      this.ButtonACService.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonACService.Name = "ButtonACService";
      this.ButtonACService.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonACService.Size = new System.Drawing.Size(130, 113);
      this.ButtonACService.TabIndex = 2;
      this.ButtonACService.Text = "Dọn Máy Lạnh";
      this.ButtonACService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonACService.UseVisualStyleBackColor = false;
      this.ButtonACService.Click += new System.EventHandler(this.ButtonACService_Click);
      // 
      // ButtonCleaning
      // 
      this.ButtonCleaning.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonCleaning.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonCleaning.FlatAppearance.BorderSize = 0;
      this.ButtonCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonCleaning.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonCleaning.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonCleaning.ImageIndex = 0;
      this.ButtonCleaning.ImageList = this.ImlistControl;
      this.ButtonCleaning.Location = new System.Drawing.Point(16, 16);
      this.ButtonCleaning.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonCleaning.Name = "ButtonCleaning";
      this.ButtonCleaning.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonCleaning.Size = new System.Drawing.Size(130, 113);
      this.ButtonCleaning.TabIndex = 0;
      this.ButtonCleaning.Text = "Tổng Vệ Sinh";
      this.ButtonCleaning.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonCleaning.UseVisualStyleBackColor = false;
      this.ButtonCleaning.Click += new System.EventHandler(this.ButtonCleaning_Click);
      // 
      // ButtonGroceryAssistance
      // 
      this.ButtonGroceryAssistance.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonGroceryAssistance.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ButtonGroceryAssistance.FlatAppearance.BorderSize = 0;
      this.ButtonGroceryAssistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonGroceryAssistance.Font = new System.Drawing.Font("Montserrat", 10F);
      this.ButtonGroceryAssistance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ButtonGroceryAssistance.ImageKey = "GroceryService.png";
      this.ButtonGroceryAssistance.ImageList = this.ImlistControl;
      this.ButtonGroceryAssistance.Location = new System.Drawing.Point(178, 16);
      this.ButtonGroceryAssistance.Margin = new System.Windows.Forms.Padding(16);
      this.ButtonGroceryAssistance.Name = "ButtonGroceryAssistance";
      this.ButtonGroceryAssistance.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
      this.ButtonGroceryAssistance.Size = new System.Drawing.Size(130, 113);
      this.ButtonGroceryAssistance.TabIndex = 13;
      this.ButtonGroceryAssistance.Text = "Đi Chợ";
      this.ButtonGroceryAssistance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
      this.ButtonGroceryAssistance.UseVisualStyleBackColor = false;
      this.ButtonGroceryAssistance.Click += new System.EventHandler(this.ButtonGroceryAssistance_Click);
      // 
      // LabelCash
      // 
      this.LabelCash.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelCash.Location = new System.Drawing.Point(4, 39);
      this.LabelCash.Margin = new System.Windows.Forms.Padding(4);
      this.LabelCash.Name = "LabelCash";
      this.LabelCash.Size = new System.Drawing.Size(154, 27);
      this.LabelCash.TabIndex = 1;
      this.LabelCash.Text = "Tổng tiền";
      this.LabelCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ButtonCash
      // 
      this.ButtonCash.BackColor = global::nJobee.Properties.Settings.Default.BackColorC;
      this.ButtonCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.ButtonCash.Location = new System.Drawing.Point(206, 481);
      this.ButtonCash.Margin = new System.Windows.Forms.Padding(8);
      this.ButtonCash.Name = "ButtonCash";
      this.ButtonCash.Size = new System.Drawing.Size(183, 42);
      this.ButtonCash.TabIndex = 11;
      this.ButtonCash.Text = "Thanh Toán";
      this.ButtonCash.UseVisualStyleBackColor = false;
      this.ButtonCash.Click += new System.EventHandler(this.ButtonCash_Click);
      // 
      // TabpanelCash
      // 
      this.TabpanelCash.ColumnCount = 2;
      this.TabpanelCash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelCash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
      this.TabpanelCash.Controls.Add(this.LabelAddress, 0, 3);
      this.TabpanelCash.Controls.Add(this.LabelTime, 0, 2);
      this.TabpanelCash.Controls.Add(this.LabelCash, 0, 1);
      this.TabpanelCash.Controls.Add(this.LabelCashValue, 1, 1);
      this.TabpanelCash.Controls.Add(this.LabelAddressValue, 1, 3);
      this.TabpanelCash.Controls.Add(this.LabelTimeValue, 1, 2);
      this.TabpanelCash.Controls.Add(this.LabelService, 0, 0);
      this.TabpanelCash.Controls.Add(this.LabelServiceValue, 1, 0);
      this.TabpanelCash.Location = new System.Drawing.Point(35, 333);
      this.TabpanelCash.Margin = new System.Windows.Forms.Padding(8);
      this.TabpanelCash.Name = "TabpanelCash";
      this.TabpanelCash.RowCount = 4;
      this.TabpanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelCash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.TabpanelCash.Size = new System.Drawing.Size(650, 140);
      this.TabpanelCash.TabIndex = 12;
      // 
      // LabelAddress
      // 
      this.LabelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelAddress.Location = new System.Drawing.Point(4, 109);
      this.LabelAddress.Margin = new System.Windows.Forms.Padding(4);
      this.LabelAddress.Name = "LabelAddress";
      this.LabelAddress.Size = new System.Drawing.Size(154, 27);
      this.LabelAddress.TabIndex = 6;
      this.LabelAddress.Text = "Địa chỉ";
      this.LabelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // LabelTime
      // 
      this.LabelTime.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelTime.Location = new System.Drawing.Point(4, 74);
      this.LabelTime.Margin = new System.Windows.Forms.Padding(4);
      this.LabelTime.Name = "LabelTime";
      this.LabelTime.Size = new System.Drawing.Size(154, 27);
      this.LabelTime.TabIndex = 3;
      this.LabelTime.Text = "Thời gian làm";
      this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // LabelCashValue
      // 
      this.LabelCashValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelCashValue.Location = new System.Drawing.Point(166, 39);
      this.LabelCashValue.Margin = new System.Windows.Forms.Padding(4);
      this.LabelCashValue.Name = "LabelCashValue";
      this.LabelCashValue.Size = new System.Drawing.Size(480, 27);
      this.LabelCashValue.TabIndex = 4;
      this.LabelCashValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // LabelAddressValue
      // 
      this.LabelAddressValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelAddressValue.Location = new System.Drawing.Point(166, 109);
      this.LabelAddressValue.Margin = new System.Windows.Forms.Padding(4);
      this.LabelAddressValue.Name = "LabelAddressValue";
      this.LabelAddressValue.Size = new System.Drawing.Size(480, 27);
      this.LabelAddressValue.TabIndex = 7;
      this.LabelAddressValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // LabelTimeValue
      // 
      this.LabelTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelTimeValue.Location = new System.Drawing.Point(166, 74);
      this.LabelTimeValue.Margin = new System.Windows.Forms.Padding(4);
      this.LabelTimeValue.Name = "LabelTimeValue";
      this.LabelTimeValue.Size = new System.Drawing.Size(480, 27);
      this.LabelTimeValue.TabIndex = 5;
      this.LabelTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // LabelService
      // 
      this.LabelService.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelService.Location = new System.Drawing.Point(4, 4);
      this.LabelService.Margin = new System.Windows.Forms.Padding(4);
      this.LabelService.Name = "LabelService";
      this.LabelService.Size = new System.Drawing.Size(154, 27);
      this.LabelService.TabIndex = 8;
      this.LabelService.Text = "Dịch vụ";
      this.LabelService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // LabelServiceValue
      // 
      this.LabelServiceValue.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LabelServiceValue.Location = new System.Drawing.Point(166, 4);
      this.LabelServiceValue.Margin = new System.Windows.Forms.Padding(4);
      this.LabelServiceValue.Name = "LabelServiceValue";
      this.LabelServiceValue.Size = new System.Drawing.Size(480, 27);
      this.LabelServiceValue.TabIndex = 9;
      this.LabelServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // ImlistControl
      // 
      this.ImlistControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlistControl.ImageStream")));
      this.ImlistControl.TransparentColor = System.Drawing.Color.Transparent;
      this.ImlistControl.Images.SetKeyName(0, "Cleaning.png");
      this.ImlistControl.Images.SetKeyName(1, "GroceryService.png");
      this.ImlistControl.Images.SetKeyName(2, "ACService.png");
      this.ImlistControl.Images.SetKeyName(3, "DisinfectionService.png");
      this.ImlistControl.Images.SetKeyName(4, "Laudry.png");
      this.ImlistControl.Images.SetKeyName(5, "Cooking.png");
      // 
      // CtrlHome
      // 
      this.BackColor = global::nJobee.Properties.Settings.Default.BackColorA;
      this.Controls.Add(this.TabpanelCash);
      this.Controls.Add(this.ButtonCash);
      this.Controls.Add(this.TabpanelFunctions);
      this.Font = global::nJobee.Properties.Settings.Default.Font;
      this.Name = "CtrlHome";
      this.Size = new System.Drawing.Size(720, 540);
      this.Load += new System.EventHandler(this.CtrlHome_Load);
      this.TabpanelFunctions.ResumeLayout(false);
      this.TabpanelCash.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel TabpanelFunctions;
    private System.Windows.Forms.Button ButtonCleaning;
    private System.Windows.Forms.Button ButtonACService;
    private System.Windows.Forms.Button ButtonHomeCooking;
    private System.Windows.Forms.Button ButtonLaudry;
    private System.Windows.Forms.Button ButtonDisinfectionService;
    private System.Windows.Forms.Button ButtonGroceryAssistance;
    private System.Windows.Forms.Label LabelCash;
    private System.Windows.Forms.Button ButtonCash;
    private System.Windows.Forms.TableLayoutPanel TabpanelCash;
    private System.Windows.Forms.Label LabelTime;
    private System.Windows.Forms.Label LabelTimeValue;
    private System.Windows.Forms.Label LabelCashValue;
    private System.Windows.Forms.Label LabelAddress;
    private System.Windows.Forms.Label LabelAddressValue;
    private System.Windows.Forms.Label LabelService;
    private System.Windows.Forms.Label LabelServiceValue;
    private System.Windows.Forms.ImageList ImlistControl;
  }
}

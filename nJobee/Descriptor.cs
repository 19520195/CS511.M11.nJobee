using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace nJobee
{
  public partial class Descriptor : Form
  {
    private DataTable AdministratorUnits;

    public Descriptor()
    {
      InitializeComponent();
    }

    private void Descriptor_Load(object sender, EventArgs e)
    {
      DataSet units = new DataSet();
      units.ReadXml(XmlReader.Create(new StringReader(Properties.Resources.Vietnam)));

      AdministratorUnits = units.Tables[0];
      foreach (var row in AdministratorUnits.Select("Level='Province'"))
        ComboxProvince.Items.Add(row["Name"]);      
      ComboxProvince.SelectedIndex = 0;
    }

    private void ComboxProvince_SelectedIndexChanged(object sender, EventArgs e)
    {
      var province = AdministratorUnits.Select(String.Format("Name='{0}'", ComboxProvince.SelectedItem));
      string provinceID = (string)province[0]["ID"];
      var selectResult = AdministratorUnits.Select(String.Format("Level='District' AND Superior='{0}'", provinceID));

      ComboxDistrict.Items.Clear();
      foreach (var row in selectResult)
        ComboxDistrict.Items.Add(row["Name"]);
      ComboxDistrict.SelectedIndex = 0;
    }

    private void ComboxDistrict_SelectedIndexChanged(object sender, EventArgs e)
    {
      var district = AdministratorUnits.Select(String.Format("Name='{0}'", ComboxDistrict.SelectedItem));
      string districtID = (string)district[0]["ID"];
      var selectResult = AdministratorUnits.Select(String.Format("Level='Ward' AND Superior='{0}'", districtID));

      ComboxWard.Items.Clear();
      foreach (var row in selectResult)
        ComboxWard.Items.Add(row["Name"]);
      ComboxWard.SelectedIndex = 0;
    }
  }
}

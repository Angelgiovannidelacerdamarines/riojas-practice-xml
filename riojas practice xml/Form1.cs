using System.Windows.Forms;
using System.Xml;

namespace riojas_practice_xml


{
    public partial class Form1 : Form
    {
        string url;
        XmlReader read;
        public Form1()
        {
            InitializeComponent();
            url = "https://www.w3schools.com/xml/cd_catalog.xml";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void AddValue(String path)
        {

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load(path);

            XmlNodeList nodeList = xmlDoc.SelectNodes("/CATALOG/CD");

            foreach (XmlNode node in nodeList)

            {

                string title = node.SelectSingleNode("TITLE").InnerText; ; string artist = node.SelectSingleNode("ARTIST").InnerText; ;

                string country = node.SelectSingleNode("COUNTRY").InnerText; ;

                string company = node.SelectSingleNode("COMPANY").InnerText; ; string price = node.SelectSingleNode("PRICE").InnerText; ;

                string year = node.SelectSingleNode("YEAR").InnerText; ;

                ListViewItem item = new ListViewItem(new string[] { title, artist, country, company, price, year }); listView1.Items.Add(item);

                foreach (ColumnHeader column in listView1.Columns)



                    column.Width = -3;

            }  }   }
}

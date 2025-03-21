using System.Collections;
using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment10_1
{
    public partial class Form1 : Form
    {
        List<Weather>? _weatherList;
        string jsonPATH = @"C:\Files\weatherJSON.txt";
        string xmlPATH = @"C:\Files\weatherXML.xml";
        public Form1()
        {
            InitializeComponent();
            comboWeatherType.DataSource = Enum.GetValues(typeof(WeatherType));
            _weatherList = new List<Weather>();
            ClearAll();
        }

        private void btnJsonSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonPATH))
            {
                File.Delete(jsonPATH);
            }
            FileStream jsonStream = new FileStream(jsonPATH, FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(jsonStream, _weatherList);
            jsonStream.Close();
            MessageBox.Show("JSON serialization for weather list done!");
        }
        private void btnJsonDeserialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(jsonPATH))
            {
                FileStream jsonStream = new FileStream(jsonPATH, FileMode.Open, FileAccess.Read);
                var obj = JsonSerializer.Deserialize<List<Weather>>(jsonStream);
                MessageBox.Show($"Count: {obj.Count} items in the list deserialized!");
                jsonStream.Close();
            }
            else
            {
                MessageBox.Show("Error! File does not exist!");
            }
        }
        private void btnXmlSerialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlPATH))
            {
                File.Delete(xmlPATH);
            }

            FileStream xmlStream = new FileStream(xmlPATH, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Weather>));
            xmlSerializer.Serialize(xmlStream, _weatherList);
            xmlStream.Close();
            MessageBox.Show("XML serialization done!");
        }
        private void btnXmlDeserialize_Click(object sender, EventArgs e)
        {
            if (File.Exists(xmlPATH))
            {
                FileStream xmlStream = new FileStream(xmlPATH, FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Weather>));
                var obj = (List<Weather>)xmlSerializer.Deserialize(xmlStream);
                MessageBox.Show($"Count: {obj.Count} items in the list deserialized!");
                xmlStream.Close();
            }
            else
            {
                MessageBox.Show("Error! File does not exist!");
            }
        }
        private void btnAddCity_Click(object sender, EventArgs e)
        {
            Weather newWeather = new Weather();
            newWeather.City = txtCity.Text;
            newWeather.Type = (WeatherType)comboWeatherType.SelectedIndex;
            newWeather.Temperature = int.Parse(txtTemperature.Text);
            newWeather.WindLevel = txtWindLevel.Text;
            _weatherList.Add(newWeather);
            ClearAll();
            MessageBox.Show($"New Weather of city: [{newWeather.City}] added!");
        }
        private void ClearAll()
        {
            txtCity.Clear();
            txtWindLevel.Clear();
            txtTemperature.Clear();
            comboWeatherType.ResetText();
        }
        private void txtCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCity.Text == string.Empty)
            {
                MessageBox.Show("City can't be empty!");
                e.Cancel = true;
                txtCity.Clear();
            }
        }
        private void txtTemperature_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTemperature.Text == string.Empty)
            {
                MessageBox.Show("Temperature can't be empty!");
                e.Cancel = true;
                txtTemperature.Clear();
            }
        }
        private void txtWindLevel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtWindLevel.Text == string.Empty)
            {
                MessageBox.Show("Wind level can't be empty!");
                e.Cancel = true;
                txtWindLevel.Clear();
            }
        }
    }
}

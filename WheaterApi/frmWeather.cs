using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WheaterApi
{
    public partial class frmWeather : Form
    {
        string strApiKey = "07e9c33b92a34da1e323d928aa017110";

        WeatherInfo WhaterInfo;

        public frmWeather()
        {
            InitializeComponent();
        }

        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string strUrl = string.Format("https://api.openweathermap.org/data/2.5/weather?q=Cascavel,br&APPID=07e9c33b92a34da1e323d928aa017110");
                var json = web.DownloadString(strUrl);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                //picIcon.ImageLocation = "https://openweathermap.org/img/w" + Info.lstweather[0].icon + ".png";
                label7.Text = Info.sys.sunset.ToString();
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Http;
using System.IO;
using Microsoft.VisualBasic.Devices;
using System.Runtime.ConstrainedExecution;
using System.Net.Http.Json;

namespace geolocalizador_de_ip
{
    public partial class FrmResultados : Form
    {
        public string ipString { get; set; } //O método get recebe o conteúdo da textbox 'tbxIP' do form 'FormMenu' e o método set envia para a string 'ipString';

        public FrmResultados()
        {
            InitializeComponent();
            
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            var ip = ipString; //A variável 'ip' recebe o conteúdo da string 'ipString';
            var Ip_Url = "http://ip-api.com/json/" + ip + "?fields=1059321";
            using (HttpClient client = new HttpClient()) 
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress= new Uri(Ip_Url);
                HttpResponseMessage response = client.GetAsync(Ip_Url).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var geolocationinfo = response.Content.ReadAsAsync<LocationDetails>().GetAwaiter().GetResult();
                    if (geolocationinfo != null)
                    {
                        txbIp.Text = geolocationinfo.query.ToString();
                        txbContinente.Text = geolocationinfo.continent.ToString();
                        txbPais.Text = geolocationinfo.country.ToString();
                        txbEstado.Text = geolocationinfo.regionName.ToString();
                        txbCidade.Text = geolocationinfo.city.ToString();
                        txbCodigoPostal.Text = geolocationinfo.zip.ToString();
                        txbLatitude.Text = geolocationinfo.lat.ToString();
                        txbLongitude.Text = geolocationinfo.lon.ToString();
                        txbFusoHorario.Text = geolocationinfo.timezone.ToString();
                    }
                }
            }
        }

        public class LocationDetails
        {
            public string query { get; set; }
            public string host { get; set; }
            public string provedor { get; set; }
            public string country { get; set; }
            public string regionName { get; set; }
            public string city { get; set; }
            public string continent { get; set; }
            public string zip { get; set; }
            public string lat { get; set; }
            public string lon { get; set; }
            public string hora { get; set; }
            public string data { get; set; }
            public string timezone { get; set; }
        }
    }
}

using Newtonsoft.Json;
using RebeAppBurguer2205.Models;

namespace RebeAppBurguer2205
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7082/api/");
            var response = client.GetAsync("burger").Result;
            if (response.IsSuccessStatusCode)
            {
                var burgers = response.Content.ReadAsStringAsync().Result;
                var burgersList = JsonConvert.DeserializeObject<List<Burger>>(burgers);

                listView.ItemsSource = burgersList;

            }
        }
    }

}

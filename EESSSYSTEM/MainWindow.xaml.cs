using EESSSYSTEM.Core;
using EESSSYSTEM.Core.constanst;
using EESSSYSTEM.Data.DataSource.Remote;
using EESSSYSTEM.Data.Models;
using EESSSYSTEM.Domain.Usecases;
using EESSSYSTEM.Presentation.Pages.HomePage;
using EESSSYSTEM.Presentation.Pages.MembersPage;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace EESSSYSTEM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task btnProbarApi_ClickAsync()
        {
            // URL de la API o recurso que deseas consultar
            string url = "https://pokeapi.co/api/v2/pokemon/ditto";

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Realizar la solicitud HTTP GET y esperar la respuesta
                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    // Verificar si la solicitud fue exitosa (código de estado 200)
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer el contenido de la respuesta como una cadena
                        string contenido = await response.Content.ReadAsStringAsync();

                        // Aquí puedes procesar el contenido de la respuesta según tus necesidades
                        MessageBox.Show(contenido, "Respuesta Exitosa", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error en la solicitud: {response.StatusCode}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        //static async Task PostPrueba()
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        CustomUrl urlService = new CustomUrl("pages");
        //        try
        //        {
        //            var content = new StringContent(
        //                "{\"parent\": {\"database_id\": \"c1afe51eceda4d5bb78d7b220e55f38e\"}, " +
        //                "\"properties\": {\"Name\": {\"title\": [{\"text\": {\"content\": \"Pagina 14\"}}]}}}",
        //                Encoding.UTF8,
        //                "application/json"
        //            );



        //            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, urlService.uri);
        //            /*foreach (var header in urlService.Headers)
        //            {
        //                MessageBox.Show(header.Key + header.Value);
        //                request.Headers.Add(header.Key, header.Value);
        //            }*/
        //            //request.Headers.Add("Content-Type", "application/json; charset=UTF-8");
        //            request.Headers.Add("Authorization", Credentials.BearerToken);
        //            request.Headers.Add("Notion-Version", Credentials.NotionVersion);
        //            request.Content = content;

        //            HttpResponseMessage response = await client.SendAsync(request);


        //            string responseBody = await response.Content.ReadAsStringAsync();
        //            Console.WriteLine(responseBody);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}");
        //        }
        //    }
        //}



        


        

        private void btnProbarApi_Click(object sender, RoutedEventArgs e)
        {
            Get();
        }


        public async void Get()
        {
            var useCase = DependencyInjector.GetInstance<GetAllMembersUseCase>();
            var response = await useCase.Call(new NoParams());
            foreach (var item in response)
            {
                MessageBox.Show(item.Name);
            }
        }

        private void BtnMembers_Click(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            MembersPage membersPage = new MembersPage();
            grdMain.Children.Add(membersPage);
            txbNamePage.Text = "Miembros";

        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            grdMain.Children.Clear();
            HomePage homePage = new HomePage();
            grdMain.Children.Add(homePage);
            txbNamePage.Text = "Pagina principal";
        }
    }








}

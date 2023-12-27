using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EESSSYSTEM.Core.constanst;
using EESSSYSTEM.Data.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace EESSSYSTEM.Data.DataSource.Remote
{
    public class MemberDataSourcerRemote
    {

        


        public async Task<List<MemberModel>> Get()
        {

            var requestData = new
            {
                sorts = new[]
                   {
                new { property = "Name", direction = "ascending" }
            },
                page_size = 100
            };


            var list = await GetAllAdvanced(requestData);
            var memberLost = list[list.Count - 1];
            var requestData2 = new
            {
                sorts = new[]
             {
                    new { property = "Name", direction = "ascending" }
                },
                page_size = 100,
                start_cursor = memberLost.IdDocument
            };

            list.Remove(memberLost);

            var list2 = await GetAllAdvanced(requestData2);

            list.AddRange(list2);
            return list;
        }

        private async Task<List<MemberModel>> GetAllAdvanced(object body)
        {
            List<MemberModel> members = new();
            try
            {
                string jsonData = JsonConvert.SerializeObject(body);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");


                dynamic? response = await ServiceHttp.Get(
                    uri: UriService.Uri("databases", new List<string> { DataBasesId.MiVariableString, "query" }),
                    body: content
                    );

                if (response == null) return new();

                foreach (var item in response.results)
                {
                    MemberModel s = new(item);
                    members.Add(s);
                }
                var lost = members[members.Count - 1];

                return members;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new();
            }
        }
    }
}

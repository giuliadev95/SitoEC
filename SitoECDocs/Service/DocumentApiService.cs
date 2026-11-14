using Newtonsoft.Json;
using SitoECDocs.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SitoECDocs.Service
{
    public class DocumentApiService
    {
        private static readonly HttpClient client = new HttpClient();

        // Creates the method as Asynchronous - it runs in parallel with the main webapp's thread.
        public async Task <List< Document>>GetDocumentsAsync()
        {
            string url = "https://localhost:44380/api/document";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string jsonResult = await response.Content.ReadAsStringAsync();
            DocumentResponse result = JsonConvert.DeserializeObject<DocumentResponse>(jsonResult);

            return result?.Items ?? new List<Document>();
        }
    }
}
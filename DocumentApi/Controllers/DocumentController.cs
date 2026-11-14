using DocumentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocumentApi.Controllers
{
    public class DocumentController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            var documents = new List<Document>
            {
                new Document()
                {
                    Id= 1,
                    Name = "Contratto.pdf"
                },
                    new Document
                {
                    Id = 2,
                    Name = "Fattura.pdf"
                }
            };


            var response = new
            {
                Error = new List<string>(),
                Items = documents
            };

            return Ok(response);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitoECDocs.Models
{
    public class DocumentResponse
    {
        public List<string> Error {  get; set; }
        public List<Document> Items { get; set; }
    }
}
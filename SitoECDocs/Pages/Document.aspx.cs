using SitoECDocs.Models;
using SitoECDocs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitoECDocs.Pages
{
    public partial class Document : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DocumentApiService service = new DocumentApiService();


                List<SitoECDocs.Models.Document> documents = await service.GetDocumentsAsync();

                gvDocuments.DataSource = documents;
                gvDocuments.DataBind();
            }
        }
    }
}
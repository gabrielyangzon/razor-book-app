using Book_App.Model;
using Book_App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public DataModelServices _dataModelServices { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }

        public IEnumerable<UsersModel> Users { get; set; }

         

        public IndexModel(ILogger<IndexModel> logger , DataModelServices dataModelServices)
        {
            _logger = logger;

            this._dataModelServices = dataModelServices;
        }

        public void OnGet()
        {
           Products = _dataModelServices.GetData();

           Users = _dataModelServices.GetUsers().Result.AsEnumerable();
        }
    }
}

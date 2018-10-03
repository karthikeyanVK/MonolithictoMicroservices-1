using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PetShop.Business;
using PetShop.Model;

namespace PetShop.API.Controllers
{
    public class SearchProductsController : ApiController
    {
        // GET api/SearchProducts
        public IEnumerable<SearchResult> Get()
        {
            var searchService = new SearchService();
            return searchService.GetData();
        }

       
    }
}
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Api.Search.Interfaces;
using OnlineStore.Api.Search.Models;
using System.Threading.Tasks;

namespace OnlineStore.Api.Search.Controllers
{
    [ApiController]
    [Route("api/search")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpPost]
        public async Task<IActionResult> SearchAsync(SearchTerm term)
        {
            var result = await _searchService.SearchAsync(term.CustomerId);
            if(result.IsSuccess)
            {
                return Ok(result.SearchResults);
            }

            return NotFound();
        }
    }
}

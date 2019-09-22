using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plumsail.CommonLib.Exceptions;
using Plumsail.Web.Core.DataContracts;
using Plumsail.Web.Core.MVCFilters;
using Plumsail.Web.Core.WebServices;

namespace Plumsail.Web.Host.Controllers
{
    [ApiVersion("1")]
    [Route("/api/v{api-version:apiVersion}/[controller]")]
    [ServiceFilter(typeof(ResponseWrapperAttribute))]
    public class NotebookController : ControllerBase
    {
        private INotebookWebService _notebookWebService;

        public NotebookController(INotebookWebService notebookWebService)
        {
            _notebookWebService = notebookWebService;
        }

        [HttpGet("get")]
        public async Task<IActionResult> GetListFiltered(NotebookFilter filter)
        {
            var res = await _notebookWebService.GetNotebooksFilteredAsync(filter);
            return new ObjectResult(res);
        }
    }
}
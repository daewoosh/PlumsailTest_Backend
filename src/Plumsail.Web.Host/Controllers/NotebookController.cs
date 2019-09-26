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
    [ServiceFilter(typeof(ResponseWrapperAttribute))] //упаковка ответа на запрос в json (из объекта типа IRequestResult)
    public class NotebookController : ControllerBase
    {
        private INotebookWebService _notebookWebService;

        public NotebookController(INotebookWebService notebookWebService)
        {
            _notebookWebService = notebookWebService;
        }

        /// <summary>
        /// Получить список ноутбуков по фильтру с возможностью пэйджинга (paging)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet("get")]
        public async Task<IActionResult> GetListFiltered(GetNotebooksFilteredRequest filter)
        {
            var res = await _notebookWebService.GetNotebooksFilteredAsync(filter);
            return new ObjectResult(res);
        }
    }
}
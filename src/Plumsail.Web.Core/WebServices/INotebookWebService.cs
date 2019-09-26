using MediatR;
using Plumsail.CommonLib.DataContracts;
using Plumsail.Domain.Entities;
using Plumsail.Web.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Plumsail.Web.Core.WebServices
{
    public interface INotebookWebService
    {
        /// <summary>
        /// Получить список ноутбуков по фильтру с возможностью пэйджинга (paging)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<PagedCollection<Notebook>> GetNotebooksFilteredAsync(GetNotebooksFilteredRequest filter);
    }

    public class NotebookWebService : INotebookWebService
    {
        /// <summary>
        /// https://github.com/jbogard/MediatR
        /// 
        /// </summary>
        private IMediator _mediator;

        public NotebookWebService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<PagedCollection<Notebook>> GetNotebooksFilteredAsync(GetNotebooksFilteredRequest filter)
        {
            var response = await _mediator.Send(filter);
            return response;
        }
    }
}

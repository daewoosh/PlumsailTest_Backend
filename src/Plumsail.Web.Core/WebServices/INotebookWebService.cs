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
        Task<PagedCollection<Notebook>> GetNotebooksFilteredAsync(NotebookFilter filter);
    }

    public class NotebookWebService : INotebookWebService
    {
        private IMediator _mediator;

        public NotebookWebService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<PagedCollection<Notebook>> GetNotebooksFilteredAsync(NotebookFilter filter)
        {
            var response = await _mediator.Send(filter);
            return response;
        }
    }
}

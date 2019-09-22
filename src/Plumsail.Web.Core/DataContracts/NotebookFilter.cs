using MediatR;
using Plumsail.CommonLib.DataContracts;
using Plumsail.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.Web.Core.DataContracts
{
    public class NotebookFilter : IRequest<PagedCollection<Notebook>>
    {
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

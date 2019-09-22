using Plumsail.Domain.Interfaces;
using System.Collections.Generic;

namespace Plumsail.Domain.Entities
{
    /// <summary>
    /// Производитель ноутбуков.
    /// </summary>
    public class Vendor : BaseEntity, IAggregateRoot
    {
        public Vendor()
        {
            Notebooks = new HashSet<Notebook>();
        }
        public int Id { get; set; }

        /// <summary>
        /// Нзвание.
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<Notebook> Notebooks { get; set; }
    }
}

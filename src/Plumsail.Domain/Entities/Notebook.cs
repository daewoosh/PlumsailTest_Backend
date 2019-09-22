using Plumsail.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.Domain.Entities
{
    /// <summary>
    /// Ноутбук.
    /// </summary>
    public class Notebook : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата выпуска.
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Дата создания в приложении.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Имеет ли тач на дисплее.
        /// </summary>
        public bool HasTouchScreen { get; set; }

        /// <summary>
        /// Показывать ли в каталоге?.
        /// </summary>
        public bool ShowInCatalog { get; set; }

        /// <summary>
        /// Объем ОЗУ
        /// </summary>
        public int RAMSize { get; set; }

        /// <summary>
        /// Вес в грамммах.
        /// </summary>
        public decimal WeightGramm { get; set; }

        /// <summary>
        /// Изображение.
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Идентификатор производителя
        /// </summary>
        public int VendorId { get; set; }


        public virtual Vendor Vendor { get; set; }


    }
}

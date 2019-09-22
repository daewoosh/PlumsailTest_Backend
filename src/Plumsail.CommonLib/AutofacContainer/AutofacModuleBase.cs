using Autofac;
using System;
using System.Collections.Generic;

namespace Plumsail.CommonLib
{
    public class AutofacModuleBase : Module
    {
        /// <summary>
		/// Вложенные модули
		/// </summary>
		protected List<AutofacModuleBase> includedModules = new List<AutofacModuleBase>();

        /// <summary>
        /// Старт работы
        /// </summary>
        public virtual void Start()
        {
            StartAllModules();
        }

        /// <summary>
        /// Остановка работы
        /// Вызывается при заверщении
        /// </summary>
        public virtual void Stop()
        {
            StopAllModules();
        }

        /// <summary>
        ///Помещает модули во внутреннюю коллекцию для последующей регистрации
        /// </summary>
        /// <param name="module"></param>
        protected void AddModule(AutofacModuleBase module)
        {
            if (module == null)
                return;

            includedModules.Add(module);
        }

        /// <summary>
        /// Регистрирует модули из коллекции
        /// </summary>
        /// <param name="containerBuilder"></param>
        protected void RegisterModules(ContainerBuilder containerBuilder)
        {
            foreach (var module in includedModules)
            {
                containerBuilder.RegisterModule(module);
            }
        }

        /// <summary>
        /// Вызов метода Start у всех модулей
        /// </summary>
        private void StartAllModules()
        {
            foreach (var module in includedModules)
            {
                module.Start();
            }
        }

        /// <summary>
        /// Вызов метода Stop у всех модулей
        /// </summary>
        private void StopAllModules()
        {
            foreach (var module in includedModules)
            {
                module.Stop();
            }
        }
    }
}

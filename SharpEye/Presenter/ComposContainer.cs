using Presenter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    /// <summary>
    /// Создает сущности сборки
    /// </summary>
    class ComposContainer
    {
        private static ComposContainer _instatnce;
        private static String _parh = ""; // временно


        private CompositionContainer _container;

        private ComposContainer()
        {
            var catalog = new DirectoryCatalog(Settings.Default.AddinDirectory);
            _container = new CompositionContainer(catalog);
        }

        public static ComposContainer Instance()
        {
            if (_instatnce == null)
            {
                _instatnce = new ComposContainer();
            }

            return _instatnce;
        }

        public void Compose(object context)
        {
            _container.ComposeParts(context);
        }
    }
}

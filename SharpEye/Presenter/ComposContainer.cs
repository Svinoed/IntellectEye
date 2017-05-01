using Presenter.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Presenter
{
    /// <summary>
    /// Создает сущности сборки
    /// </summary>
    class ComposContainer
    {
        private static ComposContainer _instatnce;
        private CompositionContainer _container;

        private ComposContainer()
        {
            //Искать части проекта в директории где лежит проект
            System.Windows.Forms.MessageBox.Show("Environment.CurrentDirectory: " + Environment.CurrentDirectory); //Test/bin/x86/debug
            System.Windows.Forms.MessageBox.Show("System.Windows.Forms.Application.ExecutablePath: " + System.Windows.Forms.Application.ExecutablePath.ToString());//Test/bin/x86/debug/TestApp.exe
            System.Windows.Forms.MessageBox.Show("Assembly.GetExecutingAssembly().Location: " + Assembly.GetExecutingAssembly().Location);//Test/bin/x86/debug/Presenter.dll
            System.Windows.Forms.MessageBox.Show("System.Windows.Forms.Application.StartupPath: " + System.Windows.Forms.Application.StartupPath);//Test/bin/x86/debug
            System.Windows.Forms.MessageBox.Show("AppDomain.CurrentDomain.BaseDirectory" + AppDomain.CurrentDomain.BaseDirectory);//Test/bin/x86/debug

            var catalog = new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location.ToString()));
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

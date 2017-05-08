using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Interfaces;

namespace Model
{
    /// <summary>
    /// Класс выполняет внедрение зависимости в слои презентера и вью.
    /// </summary>
    public class EntityCreator
    {
        /// <summary>
        /// Метод вызывается во время загрузки приложения.
        /// Испорльзуйте его если вам необходимо выполнить инициаллизацию ваших
        /// компонентов.
        /// </summary>
        public static void Initialize()
        {
            VideoOS.Platform.SDK.Environment.Initialize();
            VideoOS.Platform.SDK.UI.Environment.Initialize();
            VideoOS.Platform.SDK.Environment.Properties.ConfigurationRefreshIntervalInMs = 5000;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Объек, выполняющий соединение с сервером</returns>
        public static IConnectionModel ConnectionModelBuild()
        {
            return new ConnectionModel();
        }

        public static ICameraManagerModel CameraManagerBuild()
        {
            return new CameraManagerModel();
        }

        public static IVideoModel VideoModelBuild()
        {
           return new VideoModel();
        }

        public static IAudioModel AudioModelBuild()
        {
            return new AudioModel();
        }
    }
}

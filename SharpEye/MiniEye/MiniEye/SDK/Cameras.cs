using System;
using System.Collections.Generic;
using VideoOS.Platform;
using VideoOS.Platform.Data;
using VideoOS.Platform.Live;
using VideoOS.Platform.SDK.Platform;

namespace MiniEye.SDK
{
    interface ICameras
    {
        /// <summary>
        /// Возвращает список всех камер
        /// </summary>
        List<string> GetAll();
    }
    class Cameras : ICameras
    {
        private List<string> _Cameras = null;
        private List<Item> _CamerasItems = null;
        public Cameras()
        {
            _Cameras = new List<string>();
            _CamerasItems = new List<Item>();
            
        }
        
        public List<string> GetAll()
        {
            //VideoOS.Platform.SDK.Environment.Initialize();
            _Cameras.Clear();
            _CamerasItems.Clear();
            // Получить Items корневого уровня
            List<Item> list = Configuration.Instance.GetItems();

            // Для каждого корневого елемента проверить подэлементы. Milestone говорит что уверены в том, что корневые
            // элементы не могут быть камерами "We are certain, none of the root level Items is a camera"
            foreach (Item item in list)
            {
                CheckChildren(item);
            }

            if (_Cameras.Count == 0)
                throw new Exception("Камеры не найдены");
            return _Cameras;
        }
        public List<Item> GetItems()
        {
            if (GetAll().Count != 0)
                return _CamerasItems;
            else
                throw new Exception("Камеры не найдены");
        }

        private void CheckChildren(Item parent)
        {
            // Получить камеры следующего уровня
            List<Item> itemsOnNextLevel = parent.GetChildren();
            if (itemsOnNextLevel != null)
            {
                foreach (Item item in itemsOnNextLevel)
                {
                    // камера должна иметь Kind == Camera и не должна быть папкой (It seems that camera folders have Kind == Camera)
                    if (item.FQID.Kind == Kind.Camera && item.FQID.FolderType == FolderType.No)
                    {
                        // Добавить имя камеры в список
                        _Cameras.Add(item.Name);
                        _CamerasItems.Add(item);
                    }
                    else
                    {
                        // Проверка следующего уровня если есть что проверять
                        // Рекурсия
                        if (item.HasChildren != HasChildren.No)
                            CheckChildren(item);
                    }
                }
            }
        }
    }
}

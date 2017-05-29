using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using Contract;
using View.Interfaces;
using System.ComponentModel.Composition;

namespace Presenter
{
    /// <summary>
    /// 
    /// </summary>
    class BookMarkerService : IBookMarkerService
    {
        [Import(typeof(IBookMarkModel))]
        private IBookMarkModel _bookMarkerModel;

        public BookMarkerService()
        {
            ComposContainer.Instance().Compose(this);
        }
        public void CreateBookmark(ICameraModel camera, DateTime dateTime, string bookmarkName)
        {
            _bookMarkerModel.CreateBookmark(camera.Id, dateTime,bookmarkName);//Надо бы потестить. Это самый простой способ создать метку в лайв
        }

        public void EditBookmark(dynamic bookmarkId, string name)
        {
            _bookMarkerModel.EditBookmark(bookmarkId, name);
        }

        public void DeleteBookmark(dynamic bookmarkId)
        {
            _bookMarkerModel.DeleteBookmark(bookmarkId);
        }
    }
}

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

        BookMarkerService()
        {
            ComposContainer.Instance().Compose(this);
        }
        public BookMarkerService(IBookMarkModel bookMarker)
        {
            _bookMarkerModel = bookMarker;
        }
        public void CreateMarker(string id, DateTime dateTime)
        {
            _bookMarkerModel.CreateBookMark(id, dateTime);//Надо бы потестить. Это самый простой способ создать метку в лайв
        }
    }
}

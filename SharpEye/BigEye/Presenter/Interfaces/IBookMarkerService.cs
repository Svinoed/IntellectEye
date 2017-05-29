using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
namespace Presenter.Interfaces
{
    /// <summary>
    /// Определяет 
    /// </summary>

    interface IBookMarkerService
    {
        void CreateBookmark( ICameraModel cam, DateTime dateTime, string bookmarkName);

        void EditBookmark(dynamic bookmarkId, string name);

        void DeleteBookmark(dynamic bookmarkId);
    }
}

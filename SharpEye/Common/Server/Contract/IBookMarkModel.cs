using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IBookMarkModel
    {
        void CreateBookmark(dynamic id,DateTime eventTime,string bookmarkName);
        void EditBookmark(dynamic bookmarkId, string name);
        void DeleteBookmark(dynamic bookmarkId);
        dynamic SearchForBookmark(DateTime eventTime);//Возвращаемый тип?
        dynamic SearchForBookmark(dynamic id);//Возвращаемый тип?
    }
}

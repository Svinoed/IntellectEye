using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface IBookMarkModel
    {
        void CreateBookMark(dynamic id,DateTime eventTime);
        void EditBookMark();
        dynamic SearchForBookMark(DateTime eventTime);//Возвращаемый тип?
        dynamic SearchForBookMark(dynamic id);//Возвращаемый тип?
    }
}

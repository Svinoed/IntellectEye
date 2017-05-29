using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract
{
    public interface ICommentModel
    {
        void CreateComment(dynamic id, DateTime eventTimeStart,DateTime eventTimeEnd, string commentHeader, string description);
        void EditComment(dynamic bookmarkId, string name, string description);
        void DeleteComment(dynamic bookmarkId);
    }
}

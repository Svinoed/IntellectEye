using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;

namespace Presenter.Interfaces
{
    public interface ICommentService
    {
        void CreateComment(ICameraModel cam, DateTime startDateTime,DateTime endDateTime, string header, string description);

        void EditComment(dynamic bookmarkId, string name, string description);

        void DeleteComment(dynamic bookmarkId);

    }
}

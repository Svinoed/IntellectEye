using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Interfaces
{
    public interface ICommentService
    {
        void CreaterComment(string id, DateTime dateTime, string header, string description);

    }
}

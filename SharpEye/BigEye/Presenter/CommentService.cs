using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.Interfaces;
using View.Interfaces;
using Contract;
using System.ComponentModel.Composition;

namespace Presenter
{
    class CommentService : ICommentService
    {
        [Import(typeof(ICommentModel))]
        private ICommentModel _commentModel;
        public CommentService(ICommentModel commentModel)
        {
            ComposContainer.Instance().Compose(this);
            _commentModel = commentModel;
        }
        public void CreateComment(ICameraModel cam, DateTime startDateTime,DateTime endDateTime, string header, string description)
        {
            _commentModel.CreateComment(cam.Id, startDateTime,endDateTime, header, description);
        }

        public void DeleteComment(dynamic bookmarkId)
        {
            _commentModel.DeleteComment(bookmarkId);
        }

        public void EditComment(dynamic bookmarkId, string name, string description)
        {
            _commentModel.EditComment(bookmarkId, name, description);
        }
    }
}

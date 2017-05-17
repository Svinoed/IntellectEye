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
        public void CreaterComment(string id, DateTime dateTime, string header, string description)
        {
            _commentModel.CreateComment(id, dateTime, header, description);
        }
    }
}

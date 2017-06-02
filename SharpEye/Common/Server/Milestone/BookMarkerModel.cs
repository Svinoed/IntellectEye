using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.Composition;
using VideoOS.Platform.Data;
using VideoOS.Platform;

namespace Model
{
    [Export(typeof(IBookMarkModel))]
    [Export(typeof(ICommentModel))]
    public class BookMarkerModel : IBookMarkModel, ICommentModel
    {
        BookMarkerModel() { }

        public void CreateBookmark(dynamic id, DateTime eventTime, string bookmarkName)
        {
            Item camera = Configuration.Instance.GetItem(id);
            BookmarkReference bookmarkReference = BookmarkService.Instance.BookmarkGetNewReference(camera.FQID, true);
            try
            {
                BookmarkService.Instance.BookmarkCreate(
                                    camera.FQID,
                                    eventTime.AddSeconds(-0.1),//Время начала фрагмента, ассоциированного с меткой
                                    eventTime,//Фактическое время срабатывания метки
                                    eventTime.AddSeconds(0.1),//Время окончания фрагмента, ассоциированного с меткой
                                    bookmarkReference.ToString(),//Уникальный идентификатор метки или комментария
                                    bookmarkName, //Название нужно для облегчения поиска
                                    null);// Комментарий не требуется
            }
            catch (Exception)
            {
                //Как обрабатывать сторонние ошибки?
                throw new NotImplementedException();
            }
        }

        public void CreateComment(dynamic id, DateTime eventTimeStart,DateTime eventTimeEnd, string commentHeader, string description)
        {
            Item camera = Configuration.Instance.GetItem(id);
            BookmarkReference bookmarkReference = BookmarkService.Instance.BookmarkGetNewReference(camera.FQID, true);

            try
            {
                BookmarkService.Instance.BookmarkCreate(
                                    camera.FQID,
                                    eventTimeStart.AddSeconds(-1),//Время начала фрагмента, ассоциированного с меткой
                                    eventTimeStart,//Фактическое время срабатывания метки
                                    eventTimeEnd,//Время окончания фрагмента, ассоциированного с меткой
                                    bookmarkReference.ToString(),//Уникальный идентификатор метки или комментария
                                    commentHeader, //Заголовок комментация
                                    description);//Текст комментария
            }
            catch (Exception)
            {
                //Как обрабатывать сторонние ошибки?
                throw new NotImplementedException();
            }
        }

        public void EditBookmark(dynamic bookmarkId, string name)
        {
            Bookmark bookmarkFetched = BookmarkService.Instance.BookmarkGet((FQID)bookmarkId);
            if (bookmarkFetched != null)
            {
                bookmarkFetched.Header = name;
                BookmarkService.Instance.BookmarkUpdate(bookmarkFetched);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void DeleteBookmark(dynamic bookmarkId)
        {
            BookmarkService.Instance.BookmarkDelete((FQID)bookmarkId.BookmarkFQID);
        }

        public void DeleteComment(dynamic bookmarkId)
        {
            BookmarkService.Instance.BookmarkDelete((FQID)bookmarkId.BookmarkFQID);
        }

        public void EditComment(dynamic bookmarkId, string name,string description)
        {
            Bookmark bookmarkFetched = BookmarkService.Instance.BookmarkGet((FQID)bookmarkId);
            if (bookmarkFetched != null)
            {
                bookmarkFetched.Header = name;
                bookmarkFetched.Description = description;
                BookmarkService.Instance.BookmarkUpdate(bookmarkFetched);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        //Пока здесь будет жить костыль, до тех пор, пока не определимся с выходным значением
        public dynamic SearchForBookmark(DateTime eventTime)
        {
            throw new NotImplementedException();
        }
        
        //Пока здесь будет жить костыль, до тех пор, пока не определимся с выходным значением
        public dynamic SearchForBookmark(dynamic BookmarkId)//bookmark.BookmarkFQID
        {
            throw new NotImplementedException();
            /*Bookmark bm = BookmarkService.Instance.BookmarkGet(BookmarkId);
            if (bm != null)
            {

            }
            else
            {
                
            }
            return bm;*/
        }
    }
}

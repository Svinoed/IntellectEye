using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using System.ComponentModel.Composition;
using VideoOS.Platform.Data;

namespace Model
{
    [Export(typeof(IBookMarkModel))]
    [Export(typeof(ICommentModel))]
    class BookMarkerModel:IBookMarkModel,ICommentModel
    {
        BookMarkerModel() { }

        public void CreateBookMark(dynamic id, DateTime eventTime)
        {
            BookmarkReference bookmarkReference = BookmarkService.Instance.BookmarkGetNewReference(id, true);
            Bookmark currentBookmark = null;
            try
            {
                currentBookmark = BookmarkService.Instance.BookmarkCreate(
                                    id,
                                    eventTime.AddSeconds(-5),//Время начала фрагмента, ассоциированного с меткой
                                    eventTime,//Фактическое время срабатывания метки
                                    eventTime.AddSeconds(5),//Время окончания фрагмента, ассоциированного с меткой
                                    bookmarkReference.ToString(),//Уникальный идентификатор метки или комментария
                                    null, //Название и описание метки не нужны
                                    null);//
            }
            catch (Exception)
            {
                //Как обрабатывать сторонние ошибки?
                throw new NotImplementedException();
            }
        }

        public void CreateComment(dynamic id, DateTime eventTime, string header, string description)
        {
            BookmarkReference bookmarkReference = BookmarkService.Instance.BookmarkGetNewReference(id, true);
            Bookmark currentBookmark = null;
            try
            {
                currentBookmark = BookmarkService.Instance.BookmarkCreate(
                                    id,
                                    eventTime.AddSeconds(-5),//Время начала фрагмента, ассоциированного с меткой
                                    eventTime,//Фактическое время срабатывания метки
                                    eventTime.AddSeconds(5),//Время окончания фрагмента, ассоциированного с меткой
                                    bookmarkReference.ToString(),//Уникальный идентификатор метки или комментария
                                    header, //Заголовок комментация
                                    description);//Текст комментария
            }
            catch (Exception)
            {
                //Как обрабатывать сторонние ошибки?
                throw new NotImplementedException();
            }
        }

        public void EditBookMark()
        {
            throw new NotImplementedException();
        }
        
        public void EditComment()
        {
            throw new NotImplementedException();
        }
        //Пока здесь будет жить костыль, до тех пор, пока не определимся с выходным значением
        public dynamic SearchForBookMark(DateTime eventTime)
        {
            throw new NotImplementedException();
        }
        
        //Пока здесь будет жить костыль, до тех пор, пока не определимся с выходным значением
        public dynamic SearchForBookMark(dynamic BookmarkId)//bookmark.BookmarkFQID
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

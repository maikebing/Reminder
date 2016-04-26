using System;

namespace Reminder.Models
{
    public class Memo
    {
        public virtual long MemoId { set; get; }
        public virtual DateTime RegistrationDate { set; get; }
        public virtual string Title { set; get; }
        public virtual string Text { set; get; }
        public virtual bool IsVisible { set; get; }
        public virtual long? ParentId { set; get; }
    }
}

using ShareProjects.Share.ExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareProjects.Share.Utilities
{
    public class FluentValidator
    {
        public FluentValidator()
        {
            Result = ActionResult.Success();
        }
        public FluentValidator IsValidText(string text, string error)
        {
            AddCheck(text.IsValid(), error);
            return this;
        }
        public FluentValidator IsValidEmail(string email, string error)
        {
            AddCheck(email.IsValidEmailString(), error);
            return this;
        }
        public FluentValidator IsValidEmailCollection(List<string> emails, string error)
        {
            emails.ForEach(email => AddCheck(email.IsValidEmailString(), error?? emails + "Is not a valid email"));
            return this;
        }
        public FluentValidator IsNot(object item, object expected, string error)
        {
            AddCheck(item != expected, error);
            return this;
        }
        public FluentValidator IsValidCollection<T>(IEnumerable<T> items, string error)
        {
            AddCheck(items!=null && items.Count() > 0, error);
            return this;
        }
        public FluentValidator IsValidGuid(Guid guid, string error)
        {
            AddCheck(guid.IsNullOrEmpty(), error);
            return this;
        }
        public FluentValidator IsTrue(bool check, string error)
        {
            AddCheck(check, error);
            return this;
        }

        private void AddCheck(bool isValid, string error)
        {
            if (Result.WasSuccesful && !isValid)
            {
                Result = ActionResult.Failed().AddError(error);
            }
            else if (Result.NotSuccesful && !isValid)
            {
                Result.AddError(error);
            }
        }

        public ActionResult Result { get; private set; }
    }
}

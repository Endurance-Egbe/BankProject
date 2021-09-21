using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareProjects.Share.Utilities
{
    public enum ErrorCode
    {
        BadRequest = 400,
        UnAuthorized = 401,
        NotFound = 404,
        InternalServerError = 500,
        OK = 200
    }

    public class ActionResult
    {
        internal ActionResult() { }
        public bool WasSuccesful { get; set; }

        public bool NotSuccesful => WasSuccesful == false;

        public ErrorCode Code { get; set; }

        public List<string> Errors { get; protected set; } = new List<string>();

        public ActionResult AddError(string error)
        {
            Errors.Add(error);
            return this;
        }

        public ActionResult SetErrors(IEnumerable<string> errors)
        {
            Errors = errors?.ToList();
            return this;
        }

        public static ActionResult Failed(ErrorCode errorCode = ErrorCode.InternalServerError)
        {
            return new ActionResult() { WasSuccesful = false, Code = errorCode };
        }

        public static ActionResult Success()
        {
            return new ActionResult() { WasSuccesful = true, Code = ErrorCode.OK };
        }
    }

    public class ActionResult<T> : ActionResult
    {
        internal ActionResult()
        {

        }

        public static new ActionResult<T> Failed(ErrorCode code = ErrorCode.InternalServerError)
        {
            return new ActionResult<T>() { WasSuccesful = false, Code = code };
        }

        public static ActionResult<T> Failed(T data, ErrorCode code = ErrorCode.InternalServerError)
        {
            return new ActionResult<T>() { WasSuccesful = false, Data = data, Code = code };
        }

        public static ActionResult<T> Success(T output)
        {
            return new ActionResult<T>() { WasSuccesful = true, Data = output, Code = ErrorCode.OK };
        }

        public new ActionResult<T> SetErrors(IEnumerable<string> errors)
        {
            if (errors == null) return this;
            Errors.AddRange(errors);
            return this;
        }

        public new ActionResult<T> AddError(string error)
        {
            Errors.Add(error);
            return this;
        }

        public T Data { get; private set; }
    }
}

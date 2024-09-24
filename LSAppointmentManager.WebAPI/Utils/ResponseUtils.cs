using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace LSAppointmentManager.WebAPI.Utils
{
    public class ErrorResponse
    {
        public string Controller { get; set; }
        public string Code { get; set; }
        public List<IError> Errors { get; set; }
    }

    public class GenericOkResponse
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Message { get; set; }
    }
    public class ResponseUtils
    {
        private readonly string _controller;
        public ResponseUtils()
        {
            _controller = string.Empty;
        }
        public ResponseUtils(string controller)
        {
            _controller = controller;
        }
        public IResult HandleResult<T>(Result<T> result)
        {
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }
            else
            {
                return Results.BadRequest(new ErrorResponse()
                {
                    Code = "ERROR",
                    Controller = _controller,
                    Errors = result.Errors
                });
            }
        }

        public IResult HandleResultGet<T>(Result<T> result)
        {
            if (result.IsSuccess)
            {
                if (result.Value == null)
                {
                    return Results.NotFound(new ErrorResponse()
                    {
                        Code = "NOT_FOUND",
                        Controller = _controller,
                        Errors = result.Errors
                    });
                }
                return Results.Ok(result.Value);
            }
            else
            {
                return Results.BadRequest(new ErrorResponse()
                {
                    Code = "ERROR",
                    Controller = _controller,
                    Errors = result.Errors
                });
            }
        }

        public IResult HandleDelete(Result result, string message)
        {
            if (result.IsSuccess)
            {
                return Results.Ok(new GenericOkResponse()
                {
                    Action = "DELETE",
                    Controller = _controller,
                    Message = message
                });
            }
            else
            {
                return Results.BadRequest(new ErrorResponse()
                {
                    Errors = result.Errors
                });
            }
        }

        public static IResult HandleResult(Result result, string action, string controller, string message)
        {
            if (result.IsSuccess)
            {
                return Results.Ok(new GenericOkResponse()
                {
                    Action = action,
                    Controller = controller,
                    Message = message
                });
            }
            else
            {
                return Results.BadRequest(new ErrorResponse()
                {
                    Errors = result.Errors
                });
            }
        }
    }
}

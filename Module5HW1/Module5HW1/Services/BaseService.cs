using System;
using System.Threading.Tasks;
using Module5HW1.Helpers;
using Module5HW1.Model;

namespace Module5HW1.Services;

public abstract class BaseService
{
    protected async Task<TResult> ExecuteSafeAsync<TResult>(Func<Task<TResult>> action)
        where TResult : Validation, new()
    {
        try
        {
           return await action();
        }
        catch (BusinessException e)
        {
            return new TResult
            {
                Error = e.Message,
                ErrorCode = e.ErrorCode
            };
        }
    }
}
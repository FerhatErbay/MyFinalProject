using System;
namespace Core.Utilities.Results
{
    public interface IDataResult<TEntity> : IResult
    {
        TEntity Entity { get; }
    }
}

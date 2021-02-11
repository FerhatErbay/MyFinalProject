using System;
namespace Core.Utilities.Results
{
    public class ErrorDataResult<TEntity> : DataResult<TEntity>
    {
        public ErrorDataResult(TEntity entity, string message) : base(entity, false, message)
        {

        }

        public ErrorDataResult(TEntity entity) : base(entity, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}

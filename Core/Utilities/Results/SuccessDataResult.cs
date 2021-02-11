using System;
namespace Core.Utilities.Results
{
    public class SuccessDataResult<TEntity> : DataResult<TEntity>
    {
        public SuccessDataResult(TEntity entity, string message):base(entity,true,message)
        {

        }

        public SuccessDataResult(TEntity entity):base(entity,true)
        {

        }

        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        public SuccessDataResult():base(default,true)
        {

        }
    }
}

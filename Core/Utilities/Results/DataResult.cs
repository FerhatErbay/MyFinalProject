using System;
namespace Core.Utilities.Results
{
    public class DataResult<TEntity> : Result, IDataResult<TEntity>
    {
        public DataResult(TEntity entity, bool success, string messages):base(success,messages)
        {
            Entity = entity;
        }

        public DataResult(TEntity entity, bool success):base(success)
        {
            Entity = entity;
        }

        public TEntity Entity { get; }
    }
}

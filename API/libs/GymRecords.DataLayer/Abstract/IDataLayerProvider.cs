using System;
using System.Threading.Tasks;

namespace GymRecords.DataLayer.Abstract
{
    public interface IDataLayerProvider
    {
        Task<TResult> ExecuteAsync<TIn, TResult>(string dbName, TIn request = null, Action<TResult> action = null) 
            where TIn: class, new() 
            where TResult: class, new();
    }
}
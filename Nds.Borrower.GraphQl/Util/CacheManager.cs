using Newtonsoft.Json;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Caching;

namespace Nds.Borrower.GraphQl.Util
{
    public class CacheManager
    {
        //private readonly IRedisClient _redisClient;

        public CacheManager(IRedisClient redisClient)
        {
            //_redisClient = redisClient;
        }

        public static T Get<T>(string key)
        {
            return (T)MemoryCache.Default.Get(key);
        }

        public static void Set(string key, object item)
        {
            MemoryCache.Default.Add(key, item, DateTimeOffset.UtcNow.AddMinutes(5));
        }


        public void Delete(string key)
        {
            MemoryCache.Default.Remove(key);

        }

        //public IQueryable<T> GetAll<T>()
        //{
        //    using (var redisClient = new RedisClient())
        //    {
        //        var redis = redisClient.As<T>();
        //        return redisClient.GetAll<T>().AsQueryable();
        //    }
        //}

        //public IQueryable<T> GetAll<T>(string hash, string value, Expression<Func<T, bool>> filter)
        //{
        //    var filtered = _redisClient.GetAllEntriesFromHash(hash).Where(c => c.Value.Equals(value, StringComparison.InvariantCultureIgnoreCase));
        //    var ids = filtered.Select(c => c.Key);

        //    var ret = _redisClient.As<T>().GetByIds(ids).AsQueryable()
        //                        .Where(filter);

        //    return ret;
        //}

        //public IQueryable<T> GetAll<T>(string hash, string value)
        //{
        //    var filtered = _redisClient.GetAllEntriesFromHash(hash).Where(c => c.Value.Equals(value, StringComparison.InvariantCultureIgnoreCase));
        //    var ids = filtered.Select(c => c.Key);

        //    var ret = _redisClient.As<T>().GetByIds(ids).AsQueryable();
        //    return ret;
        //}

        //public static void Set<T>(T item)
        //{

        //    using (var redisClient = new RedisClient())
        //    {
        //        var redis = redisClient.As<T>();
        //        redisClient.Store<T>(item);
        //    }
        //}


        //public void Set<T>(T item, string hash, string value, string keyName)
        //{
        //    ////Type t = item.GetType();
        //    ////PropertyInfo prop = t.GetProperty(keyName);

        //    ////_redisClient.SetEntryInHash(hash, prop.GetValue(item).ToString(), value.ToLower());

        //    ////_redisClient.As<T>().Store(item);
        //}

        //public void Set<T>(T item, List<string> hash, List<string> value, string keyName)
        //{
        //    Type t = item.GetType();
        //    PropertyInfo prop = t.GetProperty(keyName);

        //    for (int i = 0; i < hash.Count; i++)
        //    {
        //        _redisClient.SetEntryInHash(hash[i], prop.GetValue(item).ToString(), value[i].ToLower());
        //    }

        //    _redisClient.As<T>().Store(item);
        //}

        //public void SetAll<T>(List<T> listItems)
        //{
        //    using (var redisClient = new RedisClient())
        //    {
        //        var redis = redisClient.As<T>();
        //        redisClient.StoreAll<T>(listItems);
        //    }
        //}

        //public void SetAll<T>(List<T> list, string hash, string value, string keyName)
        //{
        //    foreach (var item in list)
        //    {
        //        Type t = item.GetType();
        //        PropertyInfo prop = t.GetProperty(keyName);

        //        _redisClient.SetEntryInHash(hash, prop.GetValue(item).ToString(), value.ToLower());

        //        _redisClient.As<T>().StoreAll(list);
        //    }
        //}

        //public void SetAll<T>(List<T> list, List<string> hash, List<string> value, string keyName)
        //{
        //    foreach (var item in list)
        //    {
        //        Type t = item.GetType();
        //        PropertyInfo prop = t.GetProperty(keyName);

        //        for (int i = 0; i < hash.Count; i++)
        //        {
        //            _redisClient.SetEntryInHash(hash[i], prop.GetValue(item).ToString(), value[i].ToLower());
        //        }

        //        _redisClient.As<T>().StoreAll(list);
        //    }
        //}

        //public void DeleteAll<T>(T item)
        //{
        //    using (var redisClient = new RedisClient())
        //    {
        //        var redis = redisClient.As<T>();
        //        redisClient.DeleteAll<T>();
        //    }
        //}

        //public long PublishMessage(string channel, object item)
        //{
        //    var ret = _redisClient.PublishMessage(channel, JsonConvert.SerializeObject(item));
        //    return ret;
        //}
    }
}
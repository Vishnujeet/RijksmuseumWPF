using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace RM.Cache
{
    public static class DataCache
    {
        private static readonly ObjectCache Cache = MemoryCache.Default;

        public static T Get<T>(string key) where T : class
        {
            try
            {
                return (T) Cache[key];
            }
            catch
            {
                return null;
            }
        }

        public static void Add<T>(T objectToCache, string key) where T : class
        {
            Cache.Add(key, objectToCache, DateTime.Now.AddMinutes(5));
        }


        public static void Add(object objectToCache, string key)
        {
            Cache.Add(key, objectToCache, DateTime.Now.AddMinutes(5));
        }


        public static void Clear(string key)
        {
            Cache.Remove(key);
        }

        public static bool Exists(string key)
        {
            return Cache.Get(key) != null;
        }


        public static List<string> GetAll()
        {
            return Cache.Select(keyValuePair => keyValuePair.Key).ToList();
        }
    }
}
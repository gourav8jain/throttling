using Microsoft.Extensions.Caching.Distributed;

namespace throttling.Extensions
{
    public static class DistributedCachingExtensions
    {
        public async static Task SetCahceValueAsync<T>(this IDistributedCache distributedCache, string key, T value, CancellationToken token = default)
        {
            await distributedCache.SetAsync(key, value.ToByteArray(), token);
        }

        public async static Task<T> GetCacheValueAsync<T>(this IDistributedCache distributedCache, string key, CancellationToken token = default) where T : class
        {
            var result = await distributedCache.GetAsync(key, token);
            return result.FromByteArray<T>();
        }
    }
}

using System;
using System.Collections.Generic;

class Cache<TKey, TValue> where TKey : notnull
{
    private class CacheItem
    {
        public TValue Value { get; set; }
        public DateTime Expiration { get; set; }

        public CacheItem(TValue value, TimeSpan duration)
        {
            Value = value;
            Expiration = DateTime.Now.Add(duration);
        }
    }

    private Dictionary<TKey, CacheItem> items = new Dictionary<TKey, CacheItem>();

    // Add
    public void Add(TKey key, TValue value, TimeSpan duration)
    {
        items[key] = new CacheItem(value, duration);
    }

    // Get
    public TValue? Get(TKey key)
    {
        if (!items.ContainsKey(key))
            return default;

        CacheItem item = items[key];

        if (DateTime.Now >= item.Expiration)
        {
            items.Remove(key);
            return default;
        }

        return item.Value;
    }

    // Remove
    public void Remove(TKey key)
    {
        items.Remove(key);
    }

    // Contains
    public bool Contains(TKey key)
    {
        return Get(key) is not null;
    }
}
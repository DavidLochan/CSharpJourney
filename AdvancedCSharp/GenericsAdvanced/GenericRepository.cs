using System;

namespace GenericsAdvanced
{
    public class Repository<TKey, TValue>
    {
        public void Save(TKey id, TValue data)
        {
            Console.WriteLine($"Saved item with ID: {id}, Data: {data}");
        }
    }
}
using System;
using System.Collections.Generic;

namespace HashTable
{
    public class Pair<U,V>
    {
        public U first;
        public V second;

        public Pair(U first, V second)
        {
            this.first = first;
            this.second = second; 
        }
    }

    public class Bucket
    {
        private LinkedList<Pair<int, int>> bucket;

        public Bucket()
        {
            bucket = new LinkedList<Pair<int, int>>();
        }

        public int Get(int key)
        {
            foreach (var item in bucket)
            {
                if(item.first.Equals(key))
                {
                    return item.second;
                }
            }
            return -1;
        }

        public void Update(int key,int value)
        {
            bool found = false;

            foreach (var item in bucket)
            {
                if(item.first.Equals(key))
                {
                    item.second = value;
                    found = true;
                }
            }

            if(!found)
            {
                bucket.AddFirst(new Pair<int,int>(key, value));
            }
        }

        public void Remove(int key)
        {
            foreach (var item in bucket)
            {
                if(item.first.Equals(key))
                {
                    bucket.Remove(item);
                    break;
                }
            }
        }
    }
    public class MyHashMap
    {
        private int keyspace;
        private List<Bucket> hash_table;

        public MyHashMap()
        {
            keyspace = 2069;
            hash_table = new List<Bucket>();

            for (int i = 0; i < keyspace; i++)
            {
                hash_table.Add(new Bucket());
            }
        }

        public void Put(int key,int value)
        {
            int hashkey = key % this.keyspace;
            this.hash_table[hashkey].Update(key, value);
        }

        public int Get(int key)
        {
            int hashkey = key % this.keyspace;
            return this.hash_table[hashkey].Get(key);
        }

        public void Remove(int key)
        {
            int hashkey = key % this.keyspace;
             this.hash_table[hashkey].Remove(key);
        }
    }
}

using System;
using System.Collections.Generic;

namespace HashSet
{
    public class MyHashSet
    {
        private Bucket[] bucketArray;
        private int keyRange;

        public MyHashSet()
        {
            this.keyRange = 769;
            this.bucketArray = new Bucket[this.keyRange];
            for (int i = 0; i < this.keyRange; i++)
            {
                this.bucketArray[i] = new Bucket();
            }
        }

        protected int _hash(int key)
        {
            return (key % this.keyRange);
        }

        public void Add(int key)
        {
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].Insert(key);
        }

        public void Remove(int key)
        {
            int bucketIndex = this._hash(key);
            this.bucketArray[bucketIndex].Delete(key);
        }

        public bool Contains(int key)
        {
            int bucketIndex = this._hash(key);
            return this.bucketArray[bucketIndex].Exists(key);
        }
    }

    public class Bucket
    {
        private LinkedList<int> container;

        public Bucket()
        {
            container = new LinkedList<int>();

        }

        public void Insert(int key)
        {
            if(!this.container.Contains(key))
            {
                this.container.AddFirst(key);
            }
        }

        public void Delete(int key)
        {
            this.container.Remove(key);
        }

        public bool Exists(int key)
        {
            return this.container.Contains(key);
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}

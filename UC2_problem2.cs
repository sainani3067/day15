using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Assignment
{
    class UC2_problem2
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<k, v>>[] items;
        public UC2_problem2(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<k, v>>[size];
        }
        protected int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        protected LinkedList<KeyValue<k, v>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<k, v>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<k, v>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        public void Add(k key,v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);
            KeyValue<k, v> item = new KeyValue<k, v>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public void Remove(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<k, v> founditem = default(KeyValue<k, v>);
            foreach (KeyValue<k, v> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    founditem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(founditem);
            }
        }
        public v Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<k, v>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<k, v> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(v);
        }
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
    }
}
    

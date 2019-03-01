using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void PrintLinkedList<T>(SingleLinkedList<T> list) where T : IComparable<T>
        {
            if (list == null) return;

            var p = list.First;
            while (p != null)
            {
                System.Console.WriteLine(p.Value);
                p = p.Next;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var lru = new LruLinkedList(5);
            #region LRU_Set_Value_When_Not_Existed
            //lru.Set(1);
            //lru.Set(3);
            //lru.Set(5);
            //lru.Set(7);
            //lru.Set(9);
            #endregion
            #region LRU_Set_Value_When_Existed
            //lru.Set(1);
            //lru.Set(3);
            //lru.Set(5);
            //lru.Set(7);
            //lru.Set(3);
            #endregion
            #region LRU_Set_Value_When_Full
            lru.Set(1);
            lru.Set(3);
            lru.Set(5);
            lru.Set(7);
            lru.Set(9);
            lru.Set(8);
            #endregion
            var list = lru.LikLinkedList;

            PrintLinkedList(list);

            Console.ReadKey();
        }

    }

    public class LruLinkedList
    {
        private readonly int _capacity;
        public SingleLinkedList<int> LikLinkedList=new SingleLinkedList<int>();
            public LruLinkedList(int capacity=10)
        {
            _capacity = capacity;
        }

        public void Set(int value)
        {
            var deleteNode = LikLinkedList.Delete(value);
            if (deleteNode != null)
            {
                LikLinkedList.Insert(1, value);
                return;
            }

            if (LikLinkedList.Length == _capacity)
            {
                LikLinkedList.Delete(LikLinkedList.Length);
            }
            LikLinkedList.Insert(1, value);
        }

    }
}

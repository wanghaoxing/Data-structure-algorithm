using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LinkedList
{
    public class SingleLinkedList<T> where T : IComparable<T>
    {
        public SingleLinkedList()
        {
            Head = new ListNode<T>(default(T));
        }

        public SingleLinkedList(params T[] list)
        {
            Head = new ListNode<T>(default(T));
            if (list == null) return;
            var p = Head;
            foreach (var item in list)
            {
                var q = new ListNode<T>(item);
                p.Next = q;
                p = q;
            }

            Length = list.Length;
        }
        public ListNode<T> First => Head.Next;
        public ListNode<T> Head { get; }
        public int Length { get; private set; }

        public ListNode<T> Insert(int position, T newElem)
        {
            if (position < 1 || position > Length + 1)
            {
                throw new IndexOutOfRangeException("Position must be in bound of list");
            }

            var p = Head;
            int j = 1;
            while (p != null && j < position)
            {
                p = p.Next;
                ++j;

            }
            var newNode = new ListNode<T>(newElem);
            newNode.Next = p.Next;
            p.Next = newNode;
            Length++;
            return newNode;
        }

        public ListNode<T> Delete(T value)
        {
            ListNode<T> cur = Head;
            while (cur.Next!=null&&cur.Next.Value.CompareTo(value)!=0)
            {
                cur = cur.Next;
            }
            if (cur.Next == null) return null;

            var q = cur.Next;
            cur.Next = q.Next;

            Length--;

            return q;
        }

        public ListNode<T> Delete(int position)
        {
            if (position < 1 || position > Length)
            {
                return null;
            }

            var p = First;
            int j = 1;
            while (p != null && j < position - 1)
            {
                p = p.Next;
                ++j;
            }

            var q = p.Next;
            p.Next = q.Next;

            Length--;

            return q;
        }
    }

    public class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;
        }

        public T Value { get; }
        public ListNode<T> Next { get; set; }
    }
}

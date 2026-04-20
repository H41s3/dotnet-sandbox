using System;
using System.Text;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {

        private class Node<K> : INode<K>
        {
            public K Value { get; set; }
            public Node<K> Next { get; set; }
            public Node<K> Previous { get; set; }

            public Node(K value, Node<K> previous, Node<K> next)
            {
                Value = value;
                Previous = previous;
                Next = next;
            }

            public override string ToString()
            {
                StringBuilder s = new StringBuilder();
                s.Append("{");
                s.Append(Previous.Previous == null ? "XXX" : Previous.Value.ToString());
                s.Append("-(");
                s.Append(Value);
                s.Append(")-");
                s.Append(Next.Next == null ? "XXX" : Next.Value.ToString());
                s.Append("}");
                return s.ToString();
            }

        }

        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Count { get; private set; } = 0;

        public DoublyLinkedList()
        {
            Head = new Node<T>(default(T), null, null);
            Tail = new Node<T>(default(T), Head, null);
            Head.Next = Tail;
        }

        public INode<T> First
        {
            get
            {
                if (Count == 0) return null;
                else return Head.Next;
            }
        }

        public INode<T> Last
        {
            get
            {
                if (Count == 0) return null;
                else return Tail.Previous;
            }
        }

        public INode<T> After(INode<T> node)
        {
            if (node == null) throw new NullReferenceException();
            Node<T> node_current = node as Node<T>;
            if (node_current.Previous == null || node_current.Next == null) throw new InvalidOperationException("The node referred as 'before' is no longer in the list");
            if (node_current.Next.Equals(Tail)) return null;
            else return node_current.Next;
        }

        public INode<T> AddLast(T value)
        {
            return AddBetween(value, Tail.Previous, Tail);
        }

        private Node<T> AddBetween(T value, Node<T> previous, Node<T> next)
        {
            Node<T> node = new Node<T>(value, previous, next);
            previous.Next = node;
            next.Previous = node;
            Count++;
            return node;
        }

        public INode<T> Find(T value)
        {
            Node<T> node = Head.Next;
            while (!node.Equals(Tail))
            {
                if (node.Value.Equals(value)) return node;
                node = node.Next;
            }
            return null;
        }

        public override string ToString()
        {
            if (Count == 0) return "[]";
            StringBuilder s = new StringBuilder();
            s.Append("[");
            int k = 0;
            Node<T> node = Head.Next;
            while (!node.Equals(Tail))
            {
                s.Append(node.ToString());
                node = node.Next;
                if (k < Count - 1) s.Append(",");
                k++;
            }
            s.Append("]");
            return s.ToString();
        }

        public INode<T> Before(INode<T> node)
        {
            if (node == null) throw new NullReferenceException();
            Node<T> node_current = node as Node<T>;
            if (node_current.Previous == null || node_current.Next == null)
                throw new InvalidOperationException("The node referred as 'after' is no longer in the list");
            if (node_current.Previous.Equals(Head)) return null;
            else return node_current.Previous;
        }

        public INode<T> AddFirst(T value)
        {
            return AddBetween(value, Head, Head.Next);
        }

        public INode<T> AddBefore(INode<T> before, T value)
        {
            if (before == null) throw new NullReferenceException();
            Node<T> node_current = before as Node<T>;
            if (node_current.Previous == null || node_current.Next == null)
                throw new InvalidOperationException("The node referred as 'before' is no longer in the list");
            return AddBetween(value, node_current.Previous, node_current);
        }

        public INode<T> AddAfter(INode<T> after, T value)
        {
            if (after == null) throw new NullReferenceException();
            Node<T> node_current = after as Node<T>;
            if (node_current.Previous == null || node_current.Next == null)
                throw new InvalidOperationException("The node referred as 'after' is no longer in the list");
            return AddBetween(value, node_current, node_current.Next);
        }

        public void Clear()
        {
            Node<T> current = Head.Next;
            while (!current.Equals(Tail))
            {
                Node<T> next = current.Next;
                current.Previous = null;
                current.Next = null;
                current = next;
            }
            Head.Next = Tail;
            Tail.Previous = Head;
            Count = 0;
        }

        public void Remove(INode<T> node)
        {
            if (node == null) throw new NullReferenceException();
            Node<T> node_current = node as Node<T>;
            if (node_current.Previous == null || node_current.Next == null)
                throw new InvalidOperationException("The node is no longer in the list");
            node_current.Previous.Next = node_current.Next;
            node_current.Next.Previous = node_current.Previous;
            node_current.Previous = null;
            node_current.Next = null;
            Count--;
        }

        public void RemoveFirst()
        {
            if (Count == 0) throw new InvalidOperationException("The list is empty");
            Remove(Head.Next);
        }

        public void RemoveLast()
        {
            if (Count == 0) throw new InvalidOperationException("The list is empty");
            Remove(Tail.Previous);
        }

    }
}
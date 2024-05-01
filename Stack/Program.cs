using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Queue<string> quene = new Queue<string>();
            //quene.Enqueue("s");
            //quene.Enqueue("a");
            //quene.Enqueue("b");
            //quene.Enqueue("c");
            //quene.Enqueue("d");
            //quene.Enqueue("e");
            //quene.Dequeue();
            //foreach (var item in quene)
            //{
            //    //Console.WriteLine(item);
            //}
            //Stack<string> stack = new Stack<string>();
            //stack.Push("s");
            //stack.Push("a");
            //stack.Push("b");
            //stack.Push("c");
            //stack.Push("d");
            //stack.Push("e");
            //stack.Pop();
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----");
            Console.WriteLine(stack.Capasity);
            Console.WriteLine(stack.Count);
        }
    }
    class MyStack<T> : IEnumerable
    {
        public T[] _arr;
        public int Count { get; private set; }
        public int Capasity { get; private set; }


        public MyStack()
        {
            Capasity = 4;
            Count = 0;
            _arr = new T[Capasity];
        }
        public MyStack(int capacity)
        {
            Capasity = capacity;
            _arr = new T[capacity];
        }
        //public MyStack(ICollection C)
        //{
        //    Capasity = C.Count;
        //    _arr = new T[C.Count];
        //}
        public void Push(T item)
        {
            if (Count == Capasity)
            {
                Capasity *= 2;
                Array.Resize(ref _arr, Capasity);
            }
            _arr[Count++] = item;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = Count-1; i >= 0; i--)
            {
                yield return _arr[i];
            }
        }
        public void Pop()
        {
            Count--;
            if(Count <= 0)
            {
                Console.WriteLine("silmeye element yoxdur");
            }
            else
            {
                Array.Resize(ref _arr , Count);
            }
            
        }
        public T Peek()
        {
            T lastValue = _arr[Count - 1];
            return lastValue;
        }
    }

}

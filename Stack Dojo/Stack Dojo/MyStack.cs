using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Dojo
{
    public class MyStack<T>
    {
        int capacity { get; }
        T[] stack;
        int top;

        public MyStack(int capacity)

        {
            this.capacity = capacity;
            stack = new T[capacity];
            top = -1;
        }

        public void Push(T Element)
        {
            if (top == capacity - 1)
            {
                throw new StackOverflowException();
            }
            else
            {
                top = top + 1;
                stack[top] = Element;
            }
        }

        public T Pop()
        {
            T RemovedElement;
            if (!(top <= 0))
            {
                RemovedElement = stack[top];
                top = top - 1;
                return RemovedElement;
            }
            throw new StackUnderflowException();
        }

        public T Peek()
        {
            if (!(top <= 0))
            {
                return stack[top];
            }
            throw new StackUnderflowException();
        }

        public int GetFreeSpacesLeft()
        {
            return capacity - top-1;
        }



    }
}

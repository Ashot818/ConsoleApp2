using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MyStack<T>
    {
        Queue<T> queue1 = new Queue<T>();
        Queue<T> queue2 = new Queue<T>();

        public void Push(T element)
        {
            queue2.Enqueue(element);

            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }

            Queue<T> temp = queue1;
            queue1 = queue2;
            queue2 = temp;
        }
        
        public T Pop()
        {
           
            if (queue1.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

                
           return queue1.Dequeue();
        }

        public T Peek()
        {

            if (queue1.Count == 0)
            {
                throw new InvalidOperationException("stack is emtyp");
            }
            return queue1.Dequeue();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindromodev
{
    internal class Queue
    {
        public int front;
        public int rear;
        public char[] values;
        public int size;
        public Queue(int parametre)
        {
            this.size = parametre;
            values = new char[size];
            front = rear = -1;
        }
        public Boolean Queuedolumu()
        {
            return this.rear == (size - 1);
        }
        public Boolean Queuebosmu()
        {
            return this.front == this.rear;
        }
        public void enQueue(string data)
        {
            if (Queuedolumu())
                Console.WriteLine("Kuyruk dolu");
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    rear++;
                    this.values[i] = data[i];
                }

            }
        }
        public void Qprint()
        {
            if (Queuebosmu())
                Console.WriteLine(" Kuyruk boş");
            else
            {
                for (int i = front + 1; i < this.size; i++)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }
        public int deQueue()
        {
            if (Queuebosmu())
            {
                Console.WriteLine("kuyruk boş");
                return -1;
            }
            else
            {
                front++;
                return values[front];
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindromodev
{
    internal class stack
    {
        public int top;
        public int size;
        public char[] Svalues;

        public stack(int parametre)
        {
            this.top = -1;
            this.size = parametre;
            Svalues = new char[size];

        }
        Boolean stackdolumu()
        {
            if (this.top == (this.size - 1))
                return true;
            else
                return false;
        }
        Boolean stackbosmu()
        {
            if (this.top == -1)
                return true;
            else
                return false;
        }
        public void push(string data)
        {
            if (stackdolumu())
                Console.WriteLine("Stack dolu ");
            else
            {
                for (int i = 0; i < data.Length; i++)
                {
                    this.top++;
                    this.Svalues[i] = data[i];

                }

            }
        }
        public void Sprint()
        {
            if (stackbosmu())
                Console.WriteLine("Stack boş");
            else
            {
                for (int i = this.top; i > -1; i--)
                {
                    Console.WriteLine(this.Svalues[i]);
                }
            }
        }
        public int pop()
        {
            if (stackbosmu())
            {
                Console.WriteLine("Stack Boş.");
                return -1;
            }
            else
            {
                this.top = this.top - 1;
                return this.Svalues[this.top + 1];
            }

        }

    }
}

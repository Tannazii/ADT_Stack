using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }
        public int Top {  get; set; }

        public Stack(int size)
        {
            this.MaxSize= size;
            //creat Array with size
            this.StackArray= new string[size];
            //becaus of 0 index
            this.Top = -1;

        }

        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;

        }

        public string Pop()
        {
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }
        public bool isFull()
        {
            return (MaxSize-1==Top);
        }






    }
}

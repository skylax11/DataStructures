using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] stackArray { get; set; }
        public int top { get; set; }

        public Stack(int size)
        {
            MaxSize = size;
            stackArray = new string[size];
            top = 0;
        }
        public void Push(string item)
        {
            stackArray[top] = item;
            top++;
        }
        public string PopOff()
        {
            top--;
            int top_holder = top;
            return stackArray[top_holder];
        }
        public string Peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return top == 0;
        }
        public bool isFull()
        {
            return MaxSize - 1 == top;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Queue
{
    public class Queue
    {
        public int MaxSize { get; set; }
        public object[] QueueArray { get; set; } // Store
        public int Front { get; set; } // The index which allows to keep tracking front 
        public int Rear { get; set; }
        public int NItems { get; set; } // lenght

        public Queue(int size)
        {
            MaxSize = size;
            QueueArray = new object[size];
            Front = 0;
            Rear = -1;
        }
        public void Enqueue(object item)
        {
            Rear++;
            QueueArray[Rear] = item;
            NItems++;
        }
        public object Dequeue()
        {
            var temp = QueueArray[Front];
            Front++;
            if (Front == MaxSize)
            {
                Front = 0;
            }
            NItems--;
            return temp;
        }
        public object Peek()
        {
            return QueueArray[Front];
        }
    }
}


using ConsoleApp16.Queue;
using ConsoleApp16.Linked_List;
using ConsoleApp16.Stack;
using System.Diagnostics;
using ConsoleApp16.BinarySearch;


/* LINKED LIST - NODE (EVERY NODE IS LINKED TO FRONT ONE, LAST NODE LINKS TO NULL) 

LinkedList list1 = new LinkedList();

list1.InsertFirst(294);
list1.InsertLast(1);
list1.InsertLast(2);
list1.InsertLast(3);

list1.DisplayList(); */

// ------------------------- // 

/* STACK (CAN NOT ABLE TO ADD FROM BOTTOM, ADDS AND REMOVES FROM PEAK)

Stack stack = new Stack(10);

for (int i = 0; i < 5; i++)
{
    stack.Push("A");
    stack.Push("B");
}
stack.PopOff();
while (!stack.isEmpty())
{
    var x = stack.PopOff();
    Console.WriteLine(x);
}*/
/* QUEUE (FIRST IN FIRST OUT, REMOVES FROM START POINT, ADDS FROM REAR POINT)

Queue queue = new Queue(3);
queue.Enqueue(5);
queue.Enqueue("26.07.2023 ");
queue.Enqueue("LETS GOOOOOOO");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(queue.Dequeue());
}
*/

/*  BINARY SEARCH (CAN ABLE TO USE ONLY IN SORTED ARRAYS.)
BinarySearch bs = new BinarySearch();
int[] numbers = { 23, 34, 79, 90 };
if (bs.BinarySearchFunction(numbers,79) != -1)
{
    Console.WriteLine("It contains that number.");
}
else
{
    Console.WriteLine("It does not.");
}*/


using ConsoleApp16.Queue;
using ConsoleApp16.Linked_List;
using ConsoleApp16.Stack;
using System.Diagnostics;
using ConsoleApp16.BinarySearch;
using ConsoleApp16.BinarySearchTree;
using ConsoleApp16.Bubble_Sort;


/* LINKED LIST - NODE (EVERY NODE IS LINKED TO FRONT ONE, LAST NODE LINKS TO NULL)  O(1) if done on the head, O(N) if done at any other location

LinkedList list1 = new LinkedList();

list1.InsertFirst(294);
list1.InsertLast(1);
list1.InsertLast(2);
list1.InsertLast(3);

list1.DisplayList(); */

// ------------------------- // 

/* STACK (CAN NOT ABLE TO ADD FROM BOTTOM, ADDS AND REMOVES FROM PEAK) O(1)

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
/* QUEUE (FIRST IN FIRST OUT, REMOVES FROM START POINT, ADDS FROM REAR POINT) O(N)

Queue queue = new Queue(3);
queue.Enqueue(5);
queue.Enqueue("26.07.2023 ");
queue.Enqueue("LETS GOOOOOOO");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(queue.Dequeue());
}
*/

/*  BINARY SEARCH (CAN ABLE TO USE ONLY IN SORTED ARRAYS.) (Mostly  O(log n), Sometimes O(1) )
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

/* BINARY SEARCH TREE  O(log n)

BinarySearchTree bst = new BinarySearchTree();
bst.Insert(5, "Ahmet");
bst.Insert(7, "DE");
bst.Insert(21, "Ahm");
bst.Insert(2, "DEas");
bst.Insert(1, "Ds");

Console.WriteLine(bst.Find(21)); */

/* BUBBLE SORT ( NOT AN EFFICIENT METHOD. ) O(n²)

BubbleSort bs = new BubbleSort();
int[] array = { 1, 56, 677, 8, 3, 0, -23, 45 };
bs.BubbleSortMethod(array);
Console.WriteLine(array[0]);*/
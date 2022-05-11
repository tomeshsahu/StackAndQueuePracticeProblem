using System;
using StackAndQueuePracticeProblem;

Console.WriteLine("Stack And Queue Practice Problem");
bool check = true;
while (check)
{

    Console.WriteLine("1. UC1-PushElementInStack\n2. UC2-PeekElementFromStack\n3.UC3-AddElementInQueue");
    Console.WriteLine("Enter option for Execute the Program");

    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            UC1PushElementInStack stack = new UC1PushElementInStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            break;
        
        case 2:
            UC2StackPeekPop stack1 = new UC2StackPeekPop();
            stack1.Peek();
            break;
        case 3:
            UC3AddElementInQueue stack2 = new UC3AddElementInQueue();
            stack2.Enqueue(70);
            stack2.Enqueue(30);
            stack2.Enqueue(56);
            break;

        case 0:
            check = false;
            break;

    }
}

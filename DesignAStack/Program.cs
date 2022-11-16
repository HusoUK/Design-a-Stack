using DesignAStack;
using System.Collections;

var stack = new MyStack();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push('A');
stack.Push("BBbb");
stack.Push(null);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

Console.WriteLine("----------------------------------------\n----------------------------------------");

stack.Display();

Console.WriteLine("----------------------------------------\n----------------------------------------");
stack.Clear();
stack.Display();


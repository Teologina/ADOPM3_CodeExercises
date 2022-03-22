// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var t1 = new Thread(Thread1);
var t2 = new Thread(Thread2);
var t3 = new Thread(Thread3);

Console.WriteLine("Main terminated");

static void Thread1(object arg)
{

}
static void Thread2(object arg)
{

}
static void Thread3(object arg)
{

}


//Exercises
//1. Create and start a thread that loops 5 times and in each loop prints out "Hello{i} from Thread1" and sleeps 2 second
//2. Create and start a thread that loops 10 times and in each loop prints out "Hello{i} from Thread2" and sleeps 1 second
//3. Create and start a thread that loops 15 times and in each loop prints out "Hello{i} from Thread3" and sleeps 0,5 second
//4. Change the order of execution using Join so that thread2 and thread3 starts after thread1 has completed execution

//5. Throw a new Exception(); in thread2 after 2 loops, what happens
//6. Throw a new Exception(); in thread1 after 2 loops, what happens

//7. remove the exceptions and change all threads to Lamda that captures a variable, Message, of type string from Main
//   and prints it out instead of "Hello"

//8. Challange: Change variable Message to an individual content for each Thread

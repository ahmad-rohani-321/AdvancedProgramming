using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Immutable;
namespace CollectionsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add("Ahmad");
            arrayList.Add("Mohammad");
            arrayList.Add('2');
            arrayList.Add(20);
            
            Console.WriteLine(arrayList[2]);*/

            /* Stack stack = new Stack();
            stack.Push(123);
            stack.Push('a');
            stack.Push("Ahmad");

            Console.WriteLine(stack.Peek());*/


            /*Queue queue = new Queue();
            queue.Enqueue("Ahmad");
            queue.Enqueue('S');
            queue.Enqueue(123);


            Console.WriteLine(queue.Peek());*/



            /*Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 2);
            hashtable.Add(2, "Ahmad");
            hashtable.Add(3, 'A');
            Console.WriteLine(hashtable[2]);*/

            /*SortedList sortedList = new SortedList();
            sortedList.Add(1, "Ahmad");
            */



            // Generics 

            /*List<string> vs = new List<string>();
            vs.Add("Ahmad");
            vs.Add("Sayeed Ahmad");
            for (int i = 0; i < vs.Count(); i++)
            {
                Console.WriteLine(vs[i]);
            }*/


            /*Stack<String> vs = new Stack<string>();
            vs.Push("Ahmad");
            vs.Push("Hamid");
            Console.WriteLine(vs.Peek());*/

            /*Queue<String> vs = new Queue<string>();
            vs.Enqueue("Ahmad");
            vs.Enqueue("Mohammad");
            vs.Enqueue("Sayeed Ahmad");
            vs.Enqueue("Hamid");
            Console.WriteLine(vs.Peek());*/

            /*HashSet<String> vs = new HashSet<string>();
            vs.Add("Ahmad");
            vs.Add("Hamid");
            vs.Add("Ahmad");
            foreach (string item in vs)
            {
                Console.WriteLine(item);
            }*/


            /*Dictionary<int, string> pairs = new Dictionary<int, string>();
            pairs.Add(1, "Ahmad");
            Console.WriteLine(pairs[1]);*/

            /*SortedList<int, String> keys = new SortedList<int, string>();
            keys.Add(1, "Ahmad");
            keys.Add(3, "Mohammad");
            keys.Add(2, "Khan");
            keys.Add(5, "Hamid");
            keys.Add(4, "Jan");
            keys.Add(6, "Ubaid");

            foreach (var item in keys)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }*/

            /*SortedSet<int> vs = new SortedSet<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(6);
            vs.Add(5);
            vs.Add(3);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }*/


            /*SortedDictionary<int, string> pairs = new SortedDictionary<int, string>();
            pairs.Add(1, "Ahmad");
            pairs.Add(3, "Mohammad");
            pairs.Add(2, "Khan");
            pairs.Add(5, "Hamid");
            pairs.Add(4, "Jan");
            pairs.Add(6, "Ubaid");
            foreach (var item in pairs)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }*/

            /*LinkedList<int> vs = new LinkedList<int>();
            LinkedListNode<int> ll = vs.AddFirst(1);
            LinkedListNode<int> llb = vs.AddAfter(ll, 5);
            vs.AddBefore(llb, 2);
            vs.AddLast(20);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }*/

            /*BlockingCollection<int> vs = new BlockingCollection<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(5);
            vs.Add(3);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }*/

            /*ConcurrentBag<int> vs = new ConcurrentBag<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(4);
            vs.Add(3);
            vs.Add(7);
            vs.Add(8);
            vs.Add(6);
            vs.Add(5);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }*/
            /*ConcurrentStack<int> vs = new ConcurrentStack<int>();
            vs.Push(1);
            vs.PushRange(new int[] { 2, 3, 4, 5, 6, 7});*/

            /*ConcurrentQueue<int> vs = new ConcurrentQueue<int>();
            vs.Enqueue(1);
            vs.Enqueue(3);
            vs.Enqueue(4);
            vs.Enqueue(5);
            vs.Enqueue(6);
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }*/

            ConcurrentDictionary<string, string> myConcuDict = new ConcurrentDictionary<string, string>();
            myConcuDict.TryAdd("1", "A");
            myConcuDict.TryAdd("2", "B");
            myConcuDict.TryAdd("3", "C");
            foreach (var item in myConcuDict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}

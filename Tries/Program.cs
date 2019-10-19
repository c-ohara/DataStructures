using System;
using WordTries.Classes;

namespace WordTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie newlist = new Trie();
            newlist.Add("cool");
            newlist.Add("cooler");
            newlist.Add("coolest");
            newlist.Add("coolio");
            newlist.Add("dork");
            newlist.Add("gamma");
            newlist.Add("gametes");
            Console.WriteLine(newlist.Contains("coolio"));
            Console.WriteLine(newlist.Contains("coole"));
            Console.WriteLine(newlist.Contains("hello"));
            Console.WriteLine(newlist.AutoComplete("coo"));
            Console.WriteLine(newlist.AutoComplete("gam"));
        }
    }
}
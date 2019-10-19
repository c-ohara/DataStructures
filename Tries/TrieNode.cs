using System.Collections.Generic;

namespace WordTries.Classes
{
    public class TrieNode
    {
        public string Value;
        public bool isWord;
        public List<TrieNode> Nexts;
        public TrieNode () {
            Value = null;
            isWord = false;
            Nexts = new List<TrieNode>();
        }
        public TrieNode (string val)
        {
            Value = val;
            isWord = false;
            Nexts = new List<TrieNode>();
        }
    }
}
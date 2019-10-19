using System.Collections.Generic;

namespace WordTries.Classes
{
    public class Trie
    {
        public TrieNode Head;
        
        public Trie() {
            Head = new TrieNode();
        }

        public void Add(string word) 
        {
            TrieNode runner = Head;
            bool makenew = true;
            for (int i = 0; i < word.Length; i++) {
                makenew = true;
                foreach (TrieNode Node in runner.Nexts) {
                    if (Node.Value == word[i].ToString()) {
                        runner = Node;
                        makenew = false;
                        break;
                    }
                }
                if (makenew) {
                    runner.Nexts.Add(new TrieNode(word[i].ToString()));
                    runner = runner.Nexts[runner.Nexts.Count -1];
                }
            }
            runner.isWord = true;
        }
        public bool Contains(string word) 
        {
            TrieNode runner = Head;
            bool missing = true;
            for (int i = 0; i < word.Length; i++) {
                foreach(TrieNode Node in runner.Nexts) {
                    if (Node.Value == word[i].ToString()) {
                        runner = Node;
                        missing = false;
                        break;
                    }
                }
                if (missing) {
                    return false;
                }
            }
            return runner.isWord;
        }

        public string[] AutoComplete(string prefix, TrieNode runner = null, List<string> words = null)
        {
            string autoword = prefix;
            if (runner == null) {
                words = new List<string>();
                runner = this.Head;
                bool missing = true;
                for (int i = 0; i < prefix.Length; i++) {
                    foreach(TrieNode Node in runner.Nexts) {
                        if (Node.Value == prefix[i].ToString()) {
                            runner = Node;
                            missing = false;
                            break;
                        }
                    }
                    if (missing) {
                        return new string[0];
                    }
                }  
            }
            if (runner.isWord) {
                words.Add(autoword);
            }
            foreach (TrieNode run in runner.Nexts) {
                AutoComplete(autoword + run.Value, run, words);
            }
            return words.ToArray();
        }
    }
}

//new string to keep track of all the new ones.

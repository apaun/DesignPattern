using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            var trie = new Trie();

            trie.Insert("abh");
            trie.Insert("abc");

            Console.WriteLine(trie.Search("abh"));
            Console.WriteLine(trie.Search("abc"));
            Console.WriteLine(trie.Search("a"));
            Console.WriteLine(trie.Search("abhi"));

        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public class TrieNode
        {
            public TrieNode[] Children;

            public bool isWordEnd;

            public TrieNode()
            {
                this.Children = new TrieNode[26];
                isWordEnd = false;
            }
        }

        public void Insert(string key)
        {
            var pCrawl = root;
            for (int i = 0; i < key.Length; i++)
            {
                int index = key[i] - 'a';
                if (pCrawl.Children[index] == null)
                {
                    pCrawl.Children[index] = new TrieNode();
                }
                pCrawl = pCrawl.Children[index];
            }

            pCrawl.isWordEnd = true;
        }

        public bool Search(string key)
        {
            var pCrawl = root;
            for (int i = 0; i < key.Length; i++)
            {
                var index = key[i] - 'a';
                if (pCrawl.Children[index] == null)
                {
                    return false;
                }

                pCrawl = pCrawl.Children[index];
            }
            return true;
        }
    }
}

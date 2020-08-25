using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATASTRUCTURES.Common;
using DATASTRUCTURES.Tries;

namespace DATASTRUCTURES.LeetCode
{
    public class StreamChecker
    {
        private static TrieOperations _trie = null;
        private static Stack<char> History;
        public StreamChecker(string[] words)
        {
            _trie = new TrieOperations();
            _trie.BuildReverseTrie(words);
            History = new Stack<char>();
        }

        public bool Query(char letter)
        {
            History.Push(letter);
            return _trie.StreamCheck(History);
        }

        public static void MainMethod()
        {
            string[] words = new string[] { "cd", "f", "kl" };
            StreamChecker streamChecker = new StreamChecker(words);
            char[] letters = { 'f' };
            foreach (char letter in letters)
            {
                bool IsAvailable = streamChecker.Query(letter);
            }
        }
    }
}
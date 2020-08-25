using System;
using System.Collections.Generic;
using System.Linq;
using DATASTRUCTURES.Common;

namespace DATASTRUCTURES.Tries
{
    public class TrieOperations : Trie
    {
        public void BuildReverseTrie(string[] words)
        {
            string reverseWord = null;
            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                reverseWord = new string(charArray);
                Add(reverseWord);
            }
        }

        public bool StreamCheck(Stack<char> stack)
        {
            TrieNode currentNode = this.rootNode;
            foreach (char c in stack)
            {
                TrieNode child = null;
                bool exists = currentNode.Children.TryGetValue(c, out child);
                if (child == null) break;
                if (exists)
                {
                    if (child != null && child.Character == c)
                    {
                        if (child.IsComplete) { return true; }
                        else currentNode = child;
                    }
                    else break;
                }
            }
            return false;
        }

        /// <summary>Search the node's subtree for all complete words.</summary>
        /// <param name="startNode">The node to start the search at.</param>
        /// <param name="prefix">The prefix from the root to the start node.</param>
        /// <returns>A collection of words that start with a common prefix.</returns>
        private static IEnumerable<string> PrefixSearch(TrieNode startNode, string prefix)
        {
            var results = new List<string>();
            if (startNode.IsComplete)
            {
                results.Add(prefix);
            }
            foreach (var charAndNode in startNode.Children)
            {
                results.AddRange(PrefixSearch(charAndNode.Value, prefix + charAndNode.Key));
            }
            return results;
        }


        /// <summary>Search for the node in the trie that represents this prefix.</summary>
        /// <param name="prefix">The prefix to search for.</param>
        /// <returns>The node representing the last character in the given prefix. Null if it cannot be found.</returns>
        private TrieNode FindEndOfPrefix(string prefix)
        {
            TrieNode currentNode = this.rootNode;
            int currentCharIndex = 0;
            while (currentCharIndex < prefix.Length && currentNode != null)
            {
                TrieNode nextNode = null;
                currentNode.Children.TryGetValue(prefix[currentCharIndex], out nextNode);
                currentNode = nextNode;
                currentCharIndex++;
            }
            return currentNode;
        }

        /// <summary>Get all of the words in the trie that start with the given prefix.</summary>
        /// <param name="prefix">The prefix to search for. An empty string returns all words in the trie.</param>
        /// <returns>A collection of words that start with a common prefix.</returns>
        public IEnumerable<string> Find(string prefix)
        {
            if (prefix == null)
            {
                throw new NullReferenceException("The supplied prefix cannot be null.");
            }
            // If the prefix is empty, return all of the words in the trie.
            else if (prefix == string.Empty)
            {
                return this.rootNode.Children.Values.SelectMany(n => PrefixSearch(n, n.Character.ToString()));
            }
            else
            {
                // Find the node in the trie where the prefix ends.
                TrieNode prefixNode = FindEndOfPrefix(prefix);

                // Return an empty list if we didn't find this prefix in the trie.
                return prefixNode == null ? new List<string>() : PrefixSearch(prefixNode, prefix);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace DATASTRUCTURES.Common
{
    public class Trie
    {
        private readonly TrieNode _rootNode;
        public Trie()
        {
            _rootNode = new TrieNode(default(char));
        }

        public TrieNode rootNode
        {
            get
            {
                return this._rootNode;
            }
        }

        /// <summary>Add new string to Trie.</summary>
        /// <param name = "word">The string to be added to the Trie.</param>  
        public void Add(string word)
        {
            if (word == null)
            {
                throw new NullReferenceException("Cannot add a null string to Trie.");
            }
            else if (word == string.Empty)
            {
                throw new ArgumentException("Cannot add an empty string to Trie.");
            }
            var currentNode = _rootNode;
            foreach (char currentChar in word)
            {
                TrieNode nextNode = null;
                if (currentNode.Children.TryGetValue(currentChar, out nextNode))
                {
                    currentNode = nextNode;
                }
                else
                {
                    currentNode.Children.Add(currentChar, new TrieNode(currentChar));
                    currentNode = currentNode.Children[currentChar];
                }
            }
            currentNode.IsComplete = true;
        }

        public void BuildTrie(string[] words)
        {
            foreach (string word in words.ToList().Distinct().ToArray())
            {
                Add(word);
            }
        }
        public bool FindWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                throw new NullReferenceException("The supplied word cannot be null or empty.");
            }
            var currentNode = _rootNode;
            if (!currentNode.Children.Keys.Contains(word[0]))
            {
                return false;
            }
            for (int i = 0; i < word.Length; i++)
            {
                if (currentNode.Children.Keys.Contains(word[i]))
                {
                    currentNode = currentNode.Children[word[i]];
                }
                else
                {
                    return false;
                }
            }
            return currentNode.IsComplete;
        }
    }
}
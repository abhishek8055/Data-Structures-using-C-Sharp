namespace DATASTRUCTURES.Tries
{
    using System.Collections.Generic;
    public class TrieNode
    {
        public Dictionary<char, TrieNode> Children {get; }
        public char Character { get; set; }
        public bool IsComplete { get; set; }

        public TrieNode(char c)
		{
			this.Character = c;
			this.Children = new Dictionary<char, TrieNode>();
		}
    }
}
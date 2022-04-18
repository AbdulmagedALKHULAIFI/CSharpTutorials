using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTutorial.Algos
{
    public class AlgosReslover
    {
        private ListNode _head = null;

        public ListNode SwapNodes(int k)
        {
            // link : https://leetcode.com/problems/swapping-nodes-in-a-linked-list/submissions/

            List<ListNode> nodes = new List<ListNode>();


            ListNode tmp = _head;
            nodes.Add(tmp);

            while (tmp.next != null)
            {
                tmp = tmp.next;
                nodes.Add(tmp);
            }

            int val = nodes[k - 1].val;

            nodes[k - 1].val = nodes[nodes.Count - k].val;
            nodes[nodes.Count - k].val = val;

            return nodes[0];
        }

        public ListNode CreateLinkedListFromList(List<int> intList)
        {
            foreach (var item in intList)
            {
                Add(item);
            }

            return _head;
        }

        public void Add(int value)
        {
            var node = new ListNode { val = value };

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var current = _head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
        }
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 0)
                return 0;

            int length = 0;
            Dictionary<char, int> charDict = new Dictionary<char, int>();

            for (int CurrentCharIndex = 0, subStringStart = 0; CurrentCharIndex < s.Length; ++CurrentCharIndex)
            {
                if (charDict.ContainsKey(s[CurrentCharIndex]))
                {
                    subStringStart = Math.Max(subStringStart, charDict[s[CurrentCharIndex]] + 1);
                    charDict.Remove(s[CurrentCharIndex]);
                }

                charDict.Add(s[CurrentCharIndex], CurrentCharIndex);

                length = Math.Max(length, CurrentCharIndex - subStringStart + 1);
            }
            return length;
        }

        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            //https://leetcode.com/problems/subarrays-with-k-different-integers/

            return 0;
        }


        public string ZigZagConverter(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            int indexDistance = DistanceCalculator(numRows);
            string result = string.Empty;
            int leveldistance;
            int advance = 0;

            // rows
            for (int j = numRows; j > 0; j--)
            {
                leveldistance = DistanceCalculator(j);

                //columns
                for (int i = advance; i < s.Length; i = i + indexDistance)
                {
                    result += s[i];

                    if (i + leveldistance < s.Length && leveldistance != indexDistance && leveldistance > 0)
                        result += s[i + leveldistance];
                }
                advance++;
            }
            return result;
        }

        public int DistanceCalculator(int levelNumber)
        {
            return 2 * (levelNumber - 1);
        }
    }



    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}

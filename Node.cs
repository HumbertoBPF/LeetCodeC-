﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> neighbors;

        public Node() {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val) {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors) {
            val = _val;
            neighbors = _neighbors;
        }
    }
}

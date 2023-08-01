using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.BinarySearchTree
{
    public class TreeNode
    {
        public int key { get; set; }
        public string OgrenciAd { get; set; }
        public TreeNode leftChild { get; set; }
        public TreeNode rightChild { get; set; }
        public TreeNode(int key,string value)
        {
            this.key = key;
            this.OgrenciAd = value;
        }
    }
}

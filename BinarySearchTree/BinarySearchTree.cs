using ConsoleApp16.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;
        public void Insert(int key, string val)
        {
            Root = InsertItem(Root, key, val);
        }
        public TreeNode InsertItem(TreeNode node, int key, string val)
        {
            TreeNode newNode = new TreeNode(key, val);
            if (node == null)
            {
                node = newNode;
                return node;
            }
            if (key < node.key)
            {
                node.leftChild = InsertItem(node.leftChild, key, val);
            }
            else
            {
                node.rightChild = InsertItem(node.rightChild, key, val);
            }
            return node;
        }
        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.OgrenciAd;
        }
        private TreeNode? Find(TreeNode node, int key)
        {
            if (node == null || key == node.key)
            {
                return node;
            }
            else if (key < node.key)
            {
                return Find(node.leftChild, key);
            }
            else if (key > node.key)
            {
                return Find(node.rightChild, key);
            }
            else
            {
                return null;
            }
        }
    }
}

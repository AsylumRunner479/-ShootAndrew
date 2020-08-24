using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeNode
{
    public int data;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int d)
    {
        data = d;
        left = null;
        right = null;
    }

}
public class BinaryTree
{
    public TreeNode header;
    TreeNode current;
    public BinaryTree(TreeNode newNode)
    {
        header = newNode;
        current = header;
    }
    public void Insert(TreeNode newNode)
    {
        if (header == null)
        {
            header = newNode;

            return;
        }
        TreeNode current = header;
        TreeNode parent;
        while (true)
        {
            parent = current;
            if (newNode.data < current.data)
            {
                current = current.left;
                if (current == null)
                {
                    parent.left = newNode;
                    return;
                }
            }
            else
            {
                current = current.right;
                if (current == null)
                {
                    parent.right = newNode;
                    return;
                }
            }
        }
       
    }
    public void Ascending(TreeNode root)
    {
        if (root != null)
        {
            
            Ascending(root.left);
            Debug.Log(root.data);
            Ascending(root.right);
        }
    }
    public void Descending(TreeNode root)
    {
        if (root != null)
        {

            Descending(root.right);
            Debug.Log(root.data);
            Descending(root.left);
        }
    }
    public void DeleteLeaf(int number, TreeNode root)
    {
        if (root != null)
        {
            //loops down to the right most and deletes
            DeleteLeaf(number,root.right);
            if (root.right.data == number)
            {
                root.right = null;
            }
            if (root.left.data == number)
            {
                root.left = null;
            }
            DeleteLeaf(number,root.left);
        }
    }
}
public class BinaryTreeLinkedList : MonoBehaviour
{
    private void Start()
    {
        TreeNode newNode = new TreeNode(20);
        BinaryTree tree = new BinaryTree(newNode);
        newNode = new TreeNode(10);
        tree.Insert(newNode);
        newNode = new TreeNode(50);
        tree.Insert(newNode);
        newNode = new TreeNode(15);
        tree.Insert(newNode);
        newNode = new TreeNode(1);
        tree.Insert(newNode);
        newNode = new TreeNode(22);
        tree.Insert(newNode);
        tree.Ascending(tree.header);
        tree.DeleteLeaf(22, tree.header);
        tree.Descending(tree.header);

    }
}

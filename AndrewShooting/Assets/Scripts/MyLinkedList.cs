using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public int data;
    public Node next, prev;
    public Node(int d)
    {
        data = d;
        next = null;
        prev = null;
    }
}
public class InternalLinkedList
{
    Node header;
    Node current;
    
    
    public InternalLinkedList(Node node)
    {
        header = node;
        current = header;

        header.next = header;
        header.prev = header;
    }
    public void InsertNext(Node node)
    {
        node.prev = current.prev;
        node.next = current.next;
        current.next.prev = node;
        current.next = node;
        node.prev = current;
        
    }
    public void NextNode()
    {
        
        
        current.prev = current;
        current = current.next;
    }
    public void PrevNode()
    {


        current.next = current;
        current = current.prev;
    }
    public void PrintCurrentNode()
    {
        Debug.Log(current.data);
    }
    public void DeleteNext()
    {
        
        current.next.next = current.next;
    }
    public void DeletePrev()
    {

        current.prev.prev = current.prev;
    }
    public void InsertPrevious(Node node)
    {

        node.prev = current.prev;
        current.prev.next = node;
        current.prev = node;
        node.next = current;

    }
    public void PrintAllNodes()
    {
        Node currentPrint = header;

        if(currentPrint ==  null)
        {
            return;
        }

        do
        {
            Debug.Log(currentPrint.data);
            currentPrint = currentPrint.next;
        } while (currentPrint != header);


    }
}
public class MyLinkedList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Node node = new Node(20);
        InternalLinkedList linkedList = new InternalLinkedList(node);
        for (int loop = 0; loop < Random.Range(0, 50); loop++)
        {
            node = new Node(Random.Range(0, 50));
            linkedList.InsertNext(node);
        }
        linkedList.PrintCurrentNode();
        linkedList.NextNode();
        linkedList.PrevNode();
        linkedList.DeleteNext();
        linkedList.DeletePrev();
        linkedList.InsertNext(node);
        linkedList.PrintAllNodes();
    }

}

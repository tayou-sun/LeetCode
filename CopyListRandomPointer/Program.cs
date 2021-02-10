using System;
using System.Collections.Generic;

namespace CopyListRandomPointer
{

public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}

public class Solution {
    public Node CopyRandomList(Node head) {
        
        var originalToCopiedDict = new Dictionary<Node, Node>();
        if (head == null)
            return null;
        var pointer = head;
 
        while (pointer != null){           
            originalToCopiedDict.Add(pointer, new Node(pointer.val));
            pointer = pointer.next;
        }

         pointer = head;

        while (pointer != null){           
            
            if (pointer.next != null)
                originalToCopiedDict[pointer].next = originalToCopiedDict[pointer.next];
            if( pointer.random != null) 
                originalToCopiedDict[pointer].random = originalToCopiedDict[pointer.random];
             
            pointer = pointer.next;
          
        
        }
        return originalToCopiedDict[head];
    }
}

    class Program
    {
        static void Main(string[] args)
        {

            var n0 = new Node(7);
            var n2 = new Node(11);
    var n1 = new Node(13);
    var n3 = new Node(10);
    var n4 = new Node(1);
    n0.next = n1;
    n1.next = n2;
    n2.next = n3;
    n3.next = n4;

    n1.random = n1;
    n2.random = n4;
    n3.random = n2;
    n4.random = n0;
    var s = new Solution();
    s.CopyRandomList(n0);
            Console.WriteLine("Hello World!");
        }
    }
}
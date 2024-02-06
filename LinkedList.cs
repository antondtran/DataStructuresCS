public class LinkedList
{

    private Node head;
    private Node tail;

    private int length;

    public LinkedList()
    {

        head = null;
        tail = null;
        length = 0;

    }


    public LinkedList(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            length++;

        }
    }

    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }


    }

    public Node GetHead()
    {
        return head;
    }


    public Node GetTail()
    {
        return tail;
    }

    public int GetLength()
    {
        return length;
    }



    public void PrintList()
    {
        Node headTemp = head;

        Console.Write("Linked List: ");
        while (headTemp != null)
        {
            Console.Write(headTemp.value + " ");
            headTemp = headTemp.next;
        }
        Console.WriteLine();
        Console.WriteLine("Length of list is " + length);
    }

    public void Append(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            length++;
        }
        else
        {

            tail.next = newNode;
            tail = newNode;
            length++;

        }



    }

    public void Prepend(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }

        Node temp = head;
        head = newNode;
        head.next = temp;
        length++;


    }

    public Node RemoveFirst()
    {
        Node temp;


        if (head == null)
        {
            tail = null;
            length = 0;
        }

        if (length == 1)
        {
            temp = head;
            head = null;
            tail = null;
            length = 0;
            return temp;

        }

        temp = head;
        head = temp.next;
        temp.next = null;
        length--;
        return temp;





    }

    public Node RemoveLast()
    {

        Node temp = head;
        Node removeLast = head;

        if (head == null)
        {
            tail = null;
            length = 0;
        }

        if (length == 1)
        {
            temp = head;
            head = null;
            tail = null;
            length--;
            return temp;

        }

        while (removeLast.next != null)
        {
            temp = removeLast;
            removeLast = removeLast.next;
        }

        tail = temp;
        tail.next = null;
        length--;
        return removeLast;


    }

    public Node Get(int index)
    {
        Node temp = head;

        for (int i = 0; i < index; i++)
        {
            temp = temp.next;
        }

        return temp;
    }

    public bool Set(int index, int value)
    {
        Node temp = Get(index);

        if (temp == null)
        {
            return false;
        }
        else
        {
            temp.value = value;
            return true;

        }

    }

    public Node Remove(int index)
    {

        Node pre = Get(index - 1);
        Node toRemove = Get(index);
        Node post = Get(index + 1);

        if (index < 0 || index >= length)
        {
            return null;
        }

        if (index == 0)
        {
            RemoveFirst();
        }

        if (index == length - 1)
        {
            RemoveLast();
        }

        if (pre != null && post != null)
        {
            pre.next = post;
            toRemove.next = null;
            length--;
            return toRemove;

        }

        return null;




    }

    public void Reverse()
    {

        Node temp = head;
        head = tail;
        tail = temp;

        Node after = temp.next;
        Node before = null;


        for (int i = 0; i < length; i++)
        {
            after = temp.next;
            temp.next = before;
            before = temp;
            temp = after;

        }


    }


    public Node FindMiddleNode()
    {


        Node slow = head;
        Node fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }


        Console.WriteLine("Middle value is " + slow.value);

        return slow;


    }

    public bool hasLoop()
    {

        Node slow = head;
        Node fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (fast == slow)
            {
                return true;
            }
        }

        return false;

    }

    public Node FindKthFromEnd(int element)
    {
        Node slow = head;
        Node fast = head;


        for (int i = 0; i < element; i++)
        {

            if (fast == null)
            {
                return null;
            }

            fast = fast.next;
        }

        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }


        Console.WriteLine("The value is " + slow.value);
        return slow;


    }


    public void PartitionList(int x)
    {
        if (head == null)
        {
            return;
        }

        Node dummy1 = new Node(0);
        Node dummy2 = new Node(0);
        Node prev1 = dummy1;
        Node prev2 = dummy2;
        Node current = head;

        while (current != null)
        {
            if (current.value < x)
            {
                prev1.next = current;
                prev1 = current;
            }
            else
            {
                prev2.next = current;
                prev2 = current;
            }
            current = current.next;
        }

        prev2.next = null;
        prev1.next = dummy2.next;
        head = dummy1.next;
    }

    public void RemoveDuplicates()
    {
        Node current = head;

        while (current != null)
        {
            Node runner = current;

            while (runner.next != null)
            {
                if (runner.next.value == current.value)
                {
                    runner.next = runner.next.next;
                    length--;
                }
                else
                {
                    runner = runner.next;
                }
            }
            current = current.next;

        }
    }


}



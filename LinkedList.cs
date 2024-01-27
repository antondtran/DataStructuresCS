public class LinkedList{

    public Node head;
    public Node tail;

    public int length;

    public LinkedList(){

        head = null;
        tail = null;
        length = 0;
        
    }


    public LinkedList(int value){
        Node newNode = new Node(value);

        if (head == null){
            head = newNode;
            tail = newNode;
            length++;

        }
    }

    public class Node{
        public int value;
        public Node next;

        public Node(int value){
            this.value = value;
        }

        
    }

    

    public void PrintList(){
        Node headTemp = head;

        Console.Write("Linked List: ");
        while(headTemp != null){
            Console.Write(headTemp.value + " ");
            headTemp = headTemp.next;
        }
        Console.WriteLine();
        Console.WriteLine("Length of list is " + length);
    }

    public void Append(int value){
        Node newNode = new Node(value);

        if (head == null ){
            head = newNode;
            tail = newNode;
            length++;
        }

        tail.next = newNode;
        tail = newNode;
        length++;

    }

    public void Prepend(int value){
        Node newNode = new Node(value);

        if (head == null){
            head = newNode;
            tail = newNode;
        }

        Node temp = head;
        head = newNode;
        head.next = temp;
        length++;


    }

    public Node RemoveFirst(){
        Node temp;


        if (head == null){
            tail = null;
            length = 0;
        }

        if (length == 1){
            temp = head;
            head = null;
            tail = null;
            length--;
            return temp;
            
        }

        temp = head;
        head = temp.next;
        length--;
        return temp;
        

        


    }

    public Node RemoveLast(){

        Node temp = head;
        Node removeLast = head;

        if (head == null){
            tail = null;
            length = 0;
        }

        if (length == 1){
            temp = head;
            head = null;
            length--;
            return temp;

        }

        while (removeLast.next != null){
            temp = removeLast;
            removeLast = removeLast.next;
        }

        tail = temp;
        tail.next = null;
        length--;
        return removeLast;


    }



}



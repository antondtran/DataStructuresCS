public class LinkedList{

    private Node head;
    private Node tail;

    private int length;

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

    public Node GetHead(){
        return head;
    }


    public Node GetTail(){
        return tail;
    }

    public int GetLength(){
        return length;
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
        } else {

            tail.next = newNode;
        tail = newNode;
        length++;

        }

        

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
            length = 0;
            return temp;
            
        }

        temp = head;
        head = temp.next;
        temp.next = null;
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
            tail = null;
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

    public Node Get(int index){
        Node temp = head;

        for (int i = 0; i < index; i++){
            temp = temp.next;
        }

        return temp;
    }

    public bool Set(int index, int value){
        Node temp = Get(index);

        if (temp == null){
            return false;
        } else {
            temp.value = value;
        return true;

        }

    }

    public Node Remove(int index){

        Node pre = Get(index - 1);
        Node toRemove = Get(index);
        Node post = Get(index+1);

        if (index < 0 || index >= length){
            return null;
        }

        if (index == 0){
            RemoveFirst();
        } 
        
        if (index == length - 1){
            RemoveLast();
        } 

        if (pre != null && post != null){
            pre.next = post;
        toRemove.next = null;
        length--;
        return toRemove;

        }

        return null;
            
        

    
            

        
        

        






        
    }



}



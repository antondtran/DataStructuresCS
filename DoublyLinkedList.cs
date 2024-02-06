public class DoublyLinkedList{
    
    private Node head;
    private Node tail;
    private int length;

    class Node{
        public int value;
        public Node next;
        public Node prev;

        public Node(int value){
            this.value = value;

        }
    }


    public DoublyLinkedList(int value){
        Node newNode = new Node(value);
        head = newNode;
        tail = newNode;
        length++;
    }



    public void Append(int value){
        Node newNode = new Node(value);

        if (head == null){
            head = newNode;
            tail = newNode;
            
        } else{
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;

        }
        length++;
    }

}
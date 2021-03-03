namespace DATASTRUCTURES.LinkedList
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class LinkedListImplementation
    {
        private Node Head;
        private int Length;
        public LinkedListImplementation(){
            this.Head = null;
            this.Length = 0;
        }

        public LinkedListImplementation(int value){
            this.Head = new Node(value);
            this.Length = 1;
        }

        public Node AddLast(int value)
        {
            Node newNode = new Node(value);

            if(this.Head == null){
                this.Head = newNode;
            }
            else{
                Node current = this.Head;
                while(current.Next != null){
                    current = current.Next;
                }     
                current.Next = newNode;
            }

            Length++;
            return Head;
        }

        public Node AddFirst(int value)
        {
            Node newNode = new Node(value);

            if(this.Head == null){
                this.Head = newNode;
            }
            else{
                newNode.Next = this.Head;
                this.Head = newNode;
            }

            this.Length++;
            return this.Head;
        }

        public void Traverse(){
            Node current = this.Head;
            int i=0;
            while(current != null){
                i++;
                Console.WriteLine("Node {0}: {1}", i, current.Value);
                current = current.Next;
            }
        }

        public Node InsertAt(int index, int value){
            if(index < 0 || (index > 0 && index >= this.Length)){
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            
            Node newNode = new Node(value);

            if(this.Head == null){
                this.Head = newNode;
                this.Length++;
                return this.Head;
            }

            if(this.Head.Next == null){
                newNode.Next = this.Head;
                this.Head = newNode;
                this.Length++;
                return this.Head;
            }

            Node current = this.Head;
            while(index > 1){
                current = current.Next;
                index--;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            this.Length++;
            return this.Head;
        }

        public Node DeleteAt(int index){
            if(index < 0 || index >= this.Length){
                throw new KeyNotFoundException("Index "+ index +" not found.");
            }

            Node current = this.Head;
            while(index > 1){
                current = current.Next;
                index--;
            }

            if(current == this.Head){
                this.Head = current.Next;
            }
            else{
                current.Next = current.Next.Next != null ? current.Next.Next : null;
            }
        
            this.Length--;

            return this.Head;
        }
        public static void MainMethod(){
            LinkedListImplementation myList = new LinkedListImplementation();
            myList.AddLast(10);
            myList.AddLast(11);
            myList.AddLast(12);
            myList.AddFirst(9);
            myList.InsertAt(3, 14);
            myList.InsertAt(3, 13);
            myList.DeleteAt(0);
            myList.DeleteAt(2);
            myList.Traverse();
            Console.WriteLine("LinkedList Length: {0}", myList.Length);
        }
    }
}
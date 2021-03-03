namespace DATASTRUCTURES.HashTable
{
    using System;
    using System.Collections.Generic;
    public class Hash_Table : HashTableNode
    {
        private HashTableNode[] data;
        public Hash_Table(int size){
            this.data = new HashTableNode[size];
        }

        private int _Hash(string key){
            char[] keyComponents = key.ToCharArray();
            int hash = 0;
            for (int i =0; i < keyComponents.Length; i++){
                hash = (hash + keyComponents[i].GetHashCode() * i) % this.data.Length;
            }
            return hash;
        }

        public HashTableNode[] Set(string key, int value){
            int address = this._Hash(key);
            if(this.data[address] == null){
                this.data[address] = new HashTableNode();
                this.data[address].key = key;
                this.data[address].value = value;
            }
            else{
                HashTableNode currentItem = this.data[address];
                HashTableNode nextItem = this.data[address].next;
                while(nextItem != null){  
                    currentItem = nextItem;           
                    nextItem = nextItem.next;
                }

                nextItem = new HashTableNode();
                nextItem.key = key;
                nextItem.value = value;
                currentItem.next = nextItem;
            }

            return this.data;
        }

        public HashTableNode Get(string key){
            int address = this._Hash(key);
            if(this.data[address] != null){
                HashTableNode item = this.data[address];
                while(item.key != key){
                    item = item.next;
                    if(item.key == key){
                        return item;
                    }
                }
            }
            return null;     
        }

        public List<string> keys(){
            List<string> Keys = new List<string>();
            foreach(HashTableNode dataItem in this.data){
                HashTableNode item = dataItem;
                while(item != null){
                    Keys.Add(item.key);
                    item = item.next;
                }
            }
            return Keys;
        }

        public static void MainMethod()
        {
            Hash_Table hs = new Hash_Table(3);
            hs.Set("Apple", 20);
            hs.Set("Mango", 36);
            hs.Set("Banana", 56);
            hs.Set("Orange", 13);
            hs.Set("Strawbarry", 31);

            var item = hs.Get("Mango");
            Console.WriteLine("Key: {0}, Value: {1}", item.key, item.value);

            var keys = hs.keys();
            keys.ForEach(delegate(string name){
                Console.WriteLine(name);
            });
        }
    }
}
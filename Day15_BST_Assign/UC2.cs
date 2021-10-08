using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_BST_Assign
{
    class UC2<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        public UC1<T> leftTree { get; set; }
        public UC1<T> rightTree { get; set; }

        public UC2(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }


        int leftCount = 0, rightCount = 0;
        bool result = false;


        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new UC1<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new UC1<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }

        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));

        }
    }
}
        
    

using System;
using System.Collections.Generic;
using System.Text;

namespace Day15_BST_Assign
{
    class UC3<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        public UC3<T> leftTree { get; set; }
        public UC3<T> rightTree { get; set; }
        public UC3(T nodeData)
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
                    this.leftTree = new UC3<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new UC3<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }

        public bool Search(T element, UC3<T> node)
        {
            if (node == null)
                return false;

            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the Element \n" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.NodeData);

            if (element.CompareTo(node.NodeData) < 0)
                Search(element, node.leftTree);

            if (element.CompareTo(node.NodeData) > 0)
                Search(element, node.rightTree);

            return result;
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
        
    }
}
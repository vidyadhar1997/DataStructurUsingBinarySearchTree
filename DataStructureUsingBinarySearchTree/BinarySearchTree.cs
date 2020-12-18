﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingBinarySearchTree
{
    class BinarySearchTree<T>where T :IComparable
    {
        /// <summary>
        /// Gets or sets the node data.
        /// </summary>
        /// <value>
        /// The node data.
        /// </value>
        public T NodeData
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the left tree.
        /// </summary>
        /// <value>
        /// The left tree.
        /// </value>
        public BinarySearchTree<T> leftTree { get; set; }
        
        /// <summary>
        /// Gets or sets the right tree.
        /// </summary>
        /// <value>
        /// The right tree.
        /// </value>
        public BinarySearchTree<T> rightTree { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinarySearchTree{T}"/> class.
        /// </summary>
        /// <param name="nodeData">The node data.</param>
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        int leftCount = 0;
        int rightCount = 0;
        bool result = false;
        
        /// <summary>
        /// Insert method to add the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }

        /// <summary>
        /// Display methode to display the nodes.
        /// </summary>
        public void Display()
        {
            if(this.leftTree!=null)
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

        /// <summary>
        /// Size method for checking size of BST.
        /// </summary>
        public void getSize()
        {
            Console.WriteLine("Size of BST is = " + (1 + this.leftCount + this.rightCount));
        }

        /// <summary>
        /// If exists method check the specific element.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public bool ifExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found element in BST = " + node.NodeData);
                return true;
            }
            else
                Console.WriteLine("Current element is  in BST = " + node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                ifExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                ifExists(element, node.rightTree);
            return result;
        }
    }
}

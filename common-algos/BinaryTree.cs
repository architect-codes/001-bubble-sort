using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar.codes.common_algos
{
    /// <summary>
    /// implements binary tree concepts
    /// </summary>
    public class BinaryTree<T> where T : notnull, IComparable<T>
    {
        public Node<T>? Root { get; set; }

        public BinaryTree()
        {

        }

        /// <summary>
        /// adds new node
        /// </summary>
        /// <param name="value">value of a node</param>
        public void AddNode(T value)
        {
            // check if our tree is not initialized yet
            if (Root is null)
            {
                // let's create a root node, assign value to it and this is it
                Root = new Node<T>() { Value = value };
                return;
            }

            // ok, start traversing 
            Root.Add(value);
        }

        public Node<T> FindValue(T value)
        {
            return new Node<T>();
        }
    }

    public class Node<T> where T : notnull, IComparable<T>
    {
        public T? Value { get; set; } 

        public Node<T>? Left { get; set; }
        public Node<T>? Right { get; set; }

        public void Add(T newValue)
        {
            // determine if newValue should go left or right
            if (newValue.CompareTo(Value) < 0)
                if (Left is null)
                    Left = new Node<T>() { Value = newValue };
                else
                    Left.Add(newValue);

            if (newValue.CompareTo(Value) > 0)
                if (Right is null)
                    Right = new Node<T>() { Value = newValue };
                else
                    Right.Add(newValue);
        }

        /// <summary>
        /// Traverses a tree via depth-first algoritm and invokes action passed
        /// </summary>
        /// <param name="action"></param>
        public void TraverseDepth(Action<Node<T>> action)
        {
            
        }
    }
}
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
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = new Node<T>();
        }

        public void AddValue(T value)
        {
            
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
    }
}

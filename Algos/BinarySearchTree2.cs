using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Memerize this for Google
namespace AlgosBST
{
    //Insert best O(log2n), worst O(n) - eg. adding data already sorted
    //Delete best O(log2n), worst O(n) - eg. adding data already sorted
    //Lookup best O(log2n), worst O(n) - eg. adding data already sorted

    public class Node
    {
        private Node left; 
        private Node right; 
        private int value;
        
        public Node(Node left, Node right, int value) 
        { 
            this.left = left; 
            this.right = right; 
            this.value = value; 
        }
        
        public Node getLeft() 
        { 
            return left; 
        }    
        
        public Node getRight() 
        { 
            return right; 
        }    
        
        public int getValue() 
        { 
            return value; 
        }
        public void printValue()
        {
            Console.Write(value);
        }

        //Balanced BST eg. AVL and red-black trees
        public Node rotateRight()
        {
            Node newRoot = left;
            left = newRoot.right;
            newRoot.right = this;
            return newRoot;
        }
    }

    public class NodeStack 
    {
        Node n;
        public void push(Node n)
        {}    
        
        public Node pop() {
            return n;
        }

        public int size()
        {
            return 0;
        }
    }


    public class BST
    {
        private Node left; private Node right; private int value;
        public BST(Node left, Node right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }
        public Node getLeft()
        {
            return left;
        }

        public Node getRight()
        {
            return right;
        }

        public int getValue()
        {
            return value;
        }

        Node findNode(Node root, int value)
        {
            while (root != null)
            {
                int currval = root.getValue();

                if (currval == value) break;
                if (currval < value)
                {
                    root = root.getRight();
                }
                else
                {
                    // currval > value            
                    root = root.getLeft();
                }
            }

            return root;
        }

        Node findNodeRecursive(Node root, int value)
        {
            if (root == null)
                return null;
            int currval = root.getValue();

            if (currval == value) return root;
            if (currval < value)
            {
                return findNode(root.getRight(), value);
            }
            else
            {
                // currval > value        
                return findNode(root.getLeft(), value);
            }
        }

        //O(n)
        public int TreeHeight(Node n)
        {
            if (n == null)
                return 0;
            return 1 + Math.Max(
                TreeHeight(n.getLeft()), TreeHeight(n.getRight()));
        }


        //Preorder — Performs the operation first on the node itself, then on its left descendants, and finally on its right descendants. In other words, a node is always visited before any of its children
        //O(n)
        public void PreorderTraversal(Node root)
        {
            if (root == null) return;
            root.printValue();
            PreorderTraversal(root.getLeft());
            PreorderTraversal(root.getRight());
        }

        //Inorder — Performs the operation first on the node’s left descendants, then on the node itself, and finally on its right descendants. In other words, the left subtree is visited first, then the node itself, and then the node’s right subtree.
        public void InorderTraversal(Node root)
        {
            if (root == null) return;
            InorderTraversal(root.getLeft());
            root.printValue();
            InorderTraversal(root.getRight());
        }

        //Postorder — Performs the operation first on the node’s left descendants, then on the node’s right descendants, and finally on the node itself. In other words, a node is always visited after all its children.
        public void PostorderTraversal(Node root)
        {
            if (root == null) return;
            PostorderTraversal(root.getLeft());
            PostorderTraversal(root.getRight());
            root.printValue();
        }

        //No recursion
        void preorderTraversal(Node root)
        {
            NodeStack stack = new NodeStack();
            stack.push(root);

            while (stack.size() > 0)
            {
                Node curr = stack.pop();
                curr.printValue();
                Node n = curr.getRight();

                if (n != null)
                    stack.push(n); n = curr.getLeft();
                if (n != null)
                    stack.push(n);
            }
        }

        //Find Lowest common ancestor
        //O(log2n);
        Node findLowestCommonAncestor(Node root, int value1, int value2)
        {
            while (root != null)
            {
                int value = root.getValue();

                if (value > value1 && value > value2)
                {
                    root = root.getLeft();
                }
                else if (value < value1 && value < value2)
                {
                    root = root.getRight();
                }
                else
                {
                    return root;
                }
            }

            return null; // only if empty tree }
        }

        Node findLowestCommonAncestor(Node root, Node child1, Node child2)
        {
            if (root == null || child1 == null || child2 == null) { return null; }
                return findLowestCommonAncestor(root, child1.getValue(), child2.getValue());
        }




        ///////****************** Convert a binary tree to a heap

        //public static Node heapifyBinaryTree( Node root ){
        //    int size = traverse( root, 0, null ); 
        //    // Count nodes     
        //    Node[] nodeArray = new Node[size];    
        //    traverse( root, 0, nodeArray );       
        //    // Load nodes into array 
        //    // Sort array of nodes based on their values, using Comparator object    
        //    Arrays.sort( nodeArray, new Comparator<Node>()
        //    {            
        //        @Override public int compare(Node m, Node n)
        //        {                
        //            int mv = m.getValue(), nv = n.getValue();                
        //            return ( mv < nv ? -1 : ( mv == nv ? 0 : 1));            }        });
        //        // Reassign children for each node     
        //        for( int i = 0; i < size; i++ )
        //        {        
        //            int left = 2*i + 1;
        //            int right = left + 1;        
        //            nodeArray[i].setLeft( left >= size ? null : nodeArray[left] );        
        //            nodeArray[i].setRight( right >= size ? null : nodeArray[right] );    
        //        }    return nodeArray[0]; // Return new root node 
        //    }

        public static int traverse(Node node, int count, Node[] arr) 
        { 
            if (node == null)        
                return count; 
            if (arr != null)        
                arr[count] = node; 
            count++; 
            count = traverse(node.getLeft(), count, arr); 
            count = traverse(node.getRight(), count, arr); 
            return count; 
        }
    }
}

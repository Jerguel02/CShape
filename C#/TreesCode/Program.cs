namespace TreesCode;
class Program
{
     public class Node
    {
        public int element;
        public Node left;
        public Node right;

        public Node(int e, Node l, Node r)
        {
            element = e;
            left = l;
            right = r;
        }
    }

    
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {
            root = null;
        }


        public void insert(Node temproot, int e)
        {
            Node temp = null;
            while(temproot != null)
            {
                temp = temproot;
                if (e == temproot.element)
                    return;
                else if (e < temproot.element)
                    temproot = temproot.left;
                else if (e > temproot.element)
                    temproot = temproot.right;
            }
            Node n = new Node(e, null, null);
            if (root != null)
            {
                if (e < temp.element)
                    temp.left = n;
                else
                    temp.right = n;
            }
            else
                root = n;
        }

        public Node recursiveInsert (Node temproot, int e)
        {
            if(temproot != null)
            {
                if (e < temproot.element)
                    temproot.left = recursiveInsert(temproot.left, e);
                else if (e > temproot.element)
                    temproot.right = recursiveInsert(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }

        public void inorder(Node temproot)
        {
            if (temproot != null)
            {
                inorder(temproot.left);
                Console.Write(temproot.element + " ");
                inorder(temproot.right);
            }
        }

        public void preorder(Node temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }
        public void postorder(Node temproot)
        {
            if (temproot!= null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }
        public void levelorder(Node temproot)
        {
            if (temproot!= null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(temproot);
                while(queue.Count > 0)
                {
                    Node n = queue.Dequeue();
                    Console.Write(n.element + " ");
                    if (n.left != null)
                        queue.Enqueue(n.left);
                    if (n.right != null)
                        queue.Enqueue(n.right);
                }
            }
        }
       

        
        static void Main(string[] args)
        {
            BinarySearchTree B = new BinarySearchTree();

               
#if false
            B.insert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);
#endif

            B.root = B.recursiveInsert(B.root, 50);
            B.insert(B.root, 30);
            B.insert(B.root, 80);
            B.insert(B.root, 10);
            B.insert(B.root, 40);
            B.insert(B.root, 60);
            B.insert(B.root, 90);

            Console.WriteLine("Inorder Traversal");
            B.inorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal");
            B.preorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal");
            B.postorder(B.root);
            Console.WriteLine();
            Console.WriteLine("Levelorder Traversal");
            B.levelorder(B.root);
            Console.WriteLine();
            
        }
    }
}

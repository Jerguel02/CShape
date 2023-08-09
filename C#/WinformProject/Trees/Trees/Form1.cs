namespace Trees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioInorder.Checked = true;
        }
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
            public Node root;

            public BinarySearchTree()
            {
                root = null;
            }


            public void insert(Node temproot, int e)
            {
                Node temp = null;
                while (temproot != null)
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

            public Node recursiveInsert(Node temproot, int e)
            {
                if (temproot != null)
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

            public void inorder(Node temproot, Label lblKQ)
            {
                if (temproot != null)
                {
                    inorder(temproot.left, lblKQ);

                    lblKQ.Text += temproot.element.ToString() + " ";
                    inorder(temproot.right, lblKQ);
                }
            }

            public void preorder(Node temproot, Label lblKQ)
            {
                if (temproot != null)
                {
                    lblKQ.Text += temproot.element.ToString() + " ";
                    preorder(temproot.left, lblKQ);
                    preorder(temproot.right, lblKQ);
                }
            }
            public void postorder(Node temproot, Label lblKQ)
            {
                if (temproot != null)
                {
                    postorder(temproot.left, lblKQ);
                    postorder(temproot.right, lblKQ);
                    lblKQ.Text += temproot.element.ToString() + " ";
                }
            }
            public void levelorder(Node temproot, Label lblKQ)
            {
                if (temproot != null)
                {
                    Queue<Node> queue = new Queue<Node>();
                    queue.Enqueue(temproot);
                    while (queue.Count > 0)
                    {
                        Node n = queue.Dequeue();
                        lblKQ.Text += n.element.ToString() + " ";
                        if (n.left != null)
                            queue.Enqueue(n.left);
                        if (n.right != null)
                            queue.Enqueue(n.right);
                    }
                }
            }
        }
        BinarySearchTree B = new BinarySearchTree();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

            B.insert(B.root, int.Parse(txtAdd.Text));
            if (radioInorder.Checked == true)
            {
                lblKQ.Text = "";
                B.inorder(B.root, lblKQ);
            }
            else if (radioPost.Checked == true)
            {
                lblKQ.Text = "";
                B.postorder(B.root, lblKQ);
            }
            else if (radioLevel.Checked == true)
            {
                lblKQ.Text = "";
                B.levelorder(B.root, lblKQ);
            }
            else if (RadioPre.Checked == true)
            {
                lblKQ.Text = "";
                B.preorder(B.root, lblKQ);
            }


        }

        private void radioInorder_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            B.inorder(B.root, lblKQ);
        }

        private void RadioPre_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            B.preorder(B.root, lblKQ);
        }

        private void radioPost_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            B.postorder(B.root, lblKQ);
        }

        private void radioLevel_CheckedChanged(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            B.levelorder(B.root, lblKQ);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdd.Clear();
            txtAdd.Focus();
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
class Solution
{
    /* you only have to complete the function given below.  
    Node is defined as
    */

    public class Node
    {
        public Node(int data)
        {
            this.data = data;
        }
        public int data { get; set; }
        public Node? left { get; set; }
        public Node? right { get; set; }
    }

    public static void preOrder(Node? root)
    {
        /* Enter your code here. */
        if (root is null)
            return;
        Console.Write("{0} ", root.data);
        preOrder(root.left);
        preOrder(root.right);
    }

    public static Node insert(Node? root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        _ = Console.ReadLine();
        Node root = null;
        foreach (var item in Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse))
        {
            root = insert(root, item);
        }
        preOrder(root);
    }
}

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            var node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the mergeLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        var list = new List<int>();
        foreach (var item1 in new[] { head1, head2 })
        {
            var item = item1;
            do
            {
                list.Add(item.data);
                item = item.next;
            } while (item is not null);
        }

        SinglyLinkedListNode output = null;
        foreach (var item in list.OrderByDescending(s => s))
        {
            output = new SinglyLinkedListNode(item) { next = output };
        }
        return output;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var tests = Convert.ToInt32(Console.ReadLine());

        for (var testsItr = 0; testsItr < tests; testsItr++)
        {
            var llist1 = new SinglyLinkedList();

            var llist1Count = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < llist1Count; i++)
            {
                var llist1Item = Convert.ToInt32(Console.ReadLine());
                llist1.InsertNode(llist1Item);
            }

            var llist2 = new SinglyLinkedList();

            var llist2Count = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < llist2Count; i++)
            {
                var llist2Item = Convert.ToInt32(Console.ReadLine());
                llist2.InsertNode(llist2Item);
            }

            var llist3 = mergeLists(llist1.head, llist2.head);

            PrintSinglyLinkedList(llist3, " ", textWriter);
            textWriter.WriteLine();
        }

        textWriter.Flush();
        textWriter.Close();
    }
}

ListNode l1 = new(2, new(4, new(3)));
ListNode l2 = new(5, new(6, new(4)));
ListNode result = AddTwoNumbers(l1, l2);
Console.WriteLine(result.val);
Console.WriteLine(result.next.val);
Console.WriteLine(result.next.next.val);


ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummyHead = new(0);
    ListNode current = dummyHead;
    int carry = 0;

    while (l1 != null || l2 != null || carry != 0)
    {
        int x = l1 != null ? l1.val : 0;
        int y = l2 != null ? l2.val : 0;
        int sum = x + y + carry;
        carry = sum / 10;
        current.next = new(sum % 10);
        current = current.next;
        if (l1 != null) l1 = l1.next;
        if (l2 != null) l2 = l2.next;
    }

    return dummyHead.next;
}

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}
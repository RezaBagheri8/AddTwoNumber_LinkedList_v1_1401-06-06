﻿using AddTwoNumbers_LinkedList;


ListNode l1 = new ListNode();
int index = 7;
l1.val = 9;
l1.next = null;

while (index > 1)
{
    ListNode a = new ListNode();
    a.val = 9;
    a.next = l1;
    l1 = a;
    index--;
}



ListNode l2 = new ListNode();
int index2 = 4;
l2.val = 9;
l2.next = null;

while (index2 > 1)
{
    ListNode a = new ListNode();
    a.val = 9;
    a.next = l2;
    l2 = a;
    index2--;
}




Solution solution = new Solution();

solution.AddTwoNumbers(l1, l2);
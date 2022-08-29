using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers_LinkedList
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            int carry = 0;
            ListNode currnet = null;

            while (l1 != null && l2 != null)
            {
                int sum = l1.val + l2.val + carry;
                int fakeSum = l1.val + l2.val + carry;

                if (sum >= 10)
                {
                    sum = sum % 10;
                }

                if (head == null)
                {
                    ListNode t = new ListNode();
                    t.val = sum;
                    t.next = null;
                    head = t;
                    currnet = t;
                }
                else
                {
                    ListNode t = new ListNode();
                    t.val = sum;
                    currnet.next = t;
                    currnet = t;
                }

                if (fakeSum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }


                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null && l2 == null)
            {
                int sum = l1.val + carry;
                int fakeSum = l1.val + carry;

                if (sum >= 10)
                {
                    sum = sum % 10;
                }


                ListNode t = new ListNode();
                t.val = sum;
                currnet.next = t;


                currnet = t;
                l1 = l1.next;

                carry = fakeSum >= 10 ? 1 : 0;

                if (fakeSum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }


            while (l2 != null && l1 == null)
            {
                int sum = l2.val + carry;
                int fakeSum = l2.val + carry;

                if (sum >= 10)
                {
                    sum = sum % 10;
                }


                ListNode t = new ListNode();
                t.val = sum;
                currnet.next = t;
                currnet = t;
                l2 = l2.next;

                carry = fakeSum >= 10 ? 1 : 0;
                if (fakeSum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                ListNode t = new ListNode();
                t.val = carry;
                currnet.next = t;
                currnet = t;
            }


            return head;
        }
    }
}

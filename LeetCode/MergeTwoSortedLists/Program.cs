namespace MergeTwoSortedLists
{
    public class ListNode
    {
        public int val;

        public ListNode next;
        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            ListNode tail1 = new ListNode(1);
            ListNode tail2 = new ListNode(1);
            ListNode tail3 = new ListNode(2);
            ListNode tail4 = new ListNode(2);
            ListNode tail5 = new ListNode(3);
            ListNode tail6 = new ListNode(4);
            ListNode tail7 = new ListNode(5);
            ListNode tail8 = new ListNode(5);

            head1.next = tail1;
            tail1.next = tail2;
            tail2.next = tail3;
            tail3.next = tail4;
            tail4.next = tail5;
            tail5.next = tail6;
            tail6.next = tail7;
            tail7.next = tail8;


            ListNode head2 = new ListNode(1);
            ListNode tail21 = new ListNode(1);
            ListNode tail22 = new ListNode(2);
            ListNode tail23 = new ListNode(2);
            ListNode tail24 = new ListNode(2);
            ListNode tail25 = new ListNode(3);
            ListNode tail26 = new ListNode(4);
            ListNode tail27 = new ListNode(5);
            ListNode tail28 = new ListNode(6);

            head2.next = tail21;
            tail21.next = tail22;
            tail22.next = tail23;
            tail23.next = tail24;
            tail24.next = tail25;
            tail25.next = tail26;
            tail26.next = tail27;
            tail27.next = tail28;


            MergeTwoLists(head1, head2);
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(list1.val);

            ListNode list1Cur = list1.next;
            ListNode list2Cur = list2;
            ListNode headCur = head;


            while (list1Cur != null)
            {
                headCur.next = new ListNode(list1Cur.val);
                headCur = headCur.next;
                list1Cur = list1Cur.next;

                if (list1Cur.next == null || list1Cur.next.val > list1Cur.val)
                {
                    if (list1Cur.val == headCur.val)
                    {
                        headCur.next = new ListNode(list1Cur.val);
                        headCur = headCur.next;
                        list1Cur = list1Cur.next;
                    }
                   

                    while (list2Cur != null)
                    {
                        headCur.next = new ListNode(list2Cur.val);
                        headCur = headCur.next;
                        list2Cur = list2Cur.next;

                        if (list2Cur.next.val > list2Cur.val)
                        {
                            if (list2Cur.val == headCur.val)
                            {
                                headCur.next = new ListNode(list2Cur.val);
                                headCur = headCur.next;
                                list2Cur = list2Cur.next;
                            }

                            break;
                        }

                    }
                }


                //if (list1Cur.val == list1Cur.next.val)
                //{
                //    headCur.next = new ListNode(list1Cur.val);
                //    headCur = headCur.next;
                //    list1Cur = list1Cur.next;
                //}
                //else if (list1Cur.val == headCur.val)
                //{
                //    headCur.next = new ListNode(list1Cur.val);
                //    headCur = headCur.next;
                //    list1Cur = list1Cur.next;

                //    while (list2Cur != null)
                //    {
                //        if (list2Cur.val == list2Cur.next.val)
                //        {
                //            headCur.next = new ListNode(list2Cur.val);
                //            headCur = headCur.next;
                //            list2Cur = list2Cur.next;
                //        }
                //        else if (list2Cur.val == headCur.val)
                //        {
                //            headCur.next = new ListNode(list2Cur.val);
                //            headCur = headCur.next;
                //            list2Cur = list2Cur.next;

                //            if (list2Cur.val > headCur.val)
                //            {
                //                break;
                //            }
                //        }
                //        else
                //        {
                //            list2Cur = list2Cur.next;
                //            break;
                //        }
                //    }
                //}

            }

            return head;
        }
    }
}

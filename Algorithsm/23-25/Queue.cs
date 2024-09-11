using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm._23_25
{
    public class Queue<T>
    {
        // tạo con trỏ cho phía trước và phía sau của linked list
        Node<T> front,rear;

        //tạo hàm khởi tạo để khởi tạo trước và sau
        public Queue() { front = rear = null;}

        //hàm để check xem hàng đợi(Queue) có rỗng không
        //nếu trước và sau đều null thì Queue trống, else thì không
        public bool isEmpty() {return front == null && rear == null;}

        //hàm để thêm 1 phần tử vào hàng đợi(Queue)
        public void EnQueue(T new_data)
        {
            //tạo 1 linked list mới 
            Node<T> new_node = new Node<T>(new_data);
            //nếu Queue trống thì NEW NODE sẽ là cả phía trước và sau (vì queue k có gì )
            if (rear == null)
            {
                front = rear = new_node;
                return;
            }
            //thêm New Node ở vị trí cuối cùng của Queue và thay đổi mặt sau = New Node
            rear.Next = new_node;
            rear = new_node;
        }

        //Tạo hàm để xóa 1 phần tử ra khỏi Queue
        public void DeQueu()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue UnderFlow");
                return;
            }
            //di chuyển front hiện tại lên vị trí phía trước 1 bậc
            front = front.Next;
            //nếu phía trước trống thì sau cũng trống
            if (front == null)
                rear = null;
        }
        public T getFront()
        {
            if(isEmpty())
            {
                Console.WriteLine("QUEUE is EMPTY");
                return default(T);
            }
            return front.Data;
        }

        public T getRear()
        {
            if (isEmpty())
            {
                Console.WriteLine("QUEUE is EMPTY");
                return default(T);
            }
            return rear.Data;
        }
    }
}

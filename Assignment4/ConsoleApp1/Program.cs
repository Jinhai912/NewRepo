// 链表节点
public class Node<T>
{
    public Node<T> Next { get; set; }
    public T Data { get; set; }

    public Node(T t)
    {
        Next = null;
        Data = t;
    }
}
//泛型链表类
public class GenericList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public GenericList()
    {
        tail = head = null;
    }

    public Node<T> Head
    {
        get => head;
    }

    public void Add(T t)
    {
        Node<T> n = new Node<T>(t);
        if (tail == null)
        {
            head = tail = n;
        }
        else
        {
            tail.Next = n;
            tail = n;
        }
    }
    //PPT源码
    
    public void ForEach(Action<T> action)
    {
        Node<T> temp = head;
        while (temp.Next != null)
        {
            action(temp.Data);
            temp = temp.Next;
        }
        action(temp.Data);
    }//泛型链表的遍历方法
}
class Program
{
    static void Main(string[] args)
    {
        GenericList<int> list = new GenericList<int>();
        //随便赋一组值
        for (int i = 0; i < 20; i += 2)
        {
            list.Add(i);
        }

        //打印元素
        Console.WriteLine("打印所有元素：");
        list.ForEach(i => Console.WriteLine(i));

        //求最大值
        Console.WriteLine("求所有元素的最大值:");
        int max = 0;
        list.ForEach(i => {if (max < i) max = i; });
        Console.WriteLine(max);

        //求最小值
        Console.WriteLine("求所有元素的最小值:");
        int min = 0;
        list.ForEach(i => { if (min > i) min = i; });
        Console.WriteLine(min);

        //求和
        Console.WriteLine("求所有元素之和:");
        int sum = 0;
        list.ForEach(i => sum += i);
        Console.WriteLine(sum);
    }
}

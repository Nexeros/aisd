// CustomLinkedList.cs

using System;

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
        Previous = null;
    }
}

public class CustomLinkedList<T>
{
    public Node<T> Head { get; private set; }
    public Node<T> Tail { get; private set; }
    public int Count { get; private set; }

    public CustomLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public void AddFirst(T data)
    {
        var newNode = new Node<T>(data);
        if (Head == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }
        Count++;
    }

    public void AddLast(T data)
    {
        var newNode = new Node<T>(data);
        if (Tail == null)
        {
            Head = Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
        Count++;
    }

    public void AddAt(int index, T data)
    {
        if (index < 0 || index > Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index out of bounds");

        if (index == 0)
        {
            AddFirst(data);
            return;
        }

        if (index == Count)
        {
            AddLast(data);
            return;
        }

        var newNode = new Node<T>(data);
        var current = Head;

        for (var i = 0; i < index - 1; i++)
        {
            current = current.Next;
        }

        newNode.Next = current.Next;
        newNode.Previous = current;
        current.Next.Previous = newNode;
        current.Next = newNode;

        Count++;
    }

    public void RemoveFirst()
    {
        if (Head == null) return;

        if (Head == Tail)
        {
            Head = Tail = null;
        }
        else
        {
            Head = Head.Next;
            Head.Previous = null;
        }
        Count--;
    }

    public void RemoveLast()
    {
        if (Tail == null) return;

        if (Head == Tail)
        {
            Head = Tail = null;
        }
        else
        {
            Tail = Tail.Previous;
            Tail.Next = null;
        }
        Count--;
    }

    public override string ToString()
    {
        var current = Head;
        var result = "";
        while (current != null)
        {
            result += current.Data + (current.Next != null ? " -> " : "");
            current = current.Next;
        }
        return result;
    }

    public T[] ToArray()
    {
        T[] array = new T[Count];
        var current = Head;
        var index = 0;
        while (current != null)
        {
            array[index++] = current.Data;
            current = current.Next;
        }
        return array;
    }
}

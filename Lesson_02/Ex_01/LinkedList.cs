using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
    }

    public interface ILinkedList
    {
        int GetCount(); //возращает количество элементов в списке

        void AddNode(int value); //добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); //добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index); //удаляет элемент по порядковому номеру
        void RemoveNode(Node node); //улаляет указанный элемент
        Node FindNode(int serchValue); //ищет элемент по его значению
    }
    public class LinkedList : ILinkedList
    {
        private int _count = 0;
        private Node _startNode;
        private Node _endNode;
        public void AddNode(int value)
        {
            Node node = new Node(value);

            if (_startNode == null)
                _startNode = node;
            else
            {
                _endNode.NextNode = node;
                node.NextNode = _endNode;

            }
            _endNode = node;
            _count++;
        }

        public void AddNodeAfter(Node node, int value)
        {
            throw new NotImplementedException();
        }

        public Node FindNode(int serchValue)
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSA
{
    internal class Stack
    {
        int[] array;
        int topPointer = -1;
        int maxSize;
        public void Do()
        {
            Stack stack = new Stack();
            stack.maxSize = 5;
            stack.array = new int[5];
            stack.push(5);
            stack.push(2);
            stack.push(3);
            stack.Print();
            stack.Pop();
            stack.Pop();
            stack.Print();
            stack.push(7);
            stack.push(9);
            stack.Print();
        }
        void push(int num)
        {
            if (topPointer == maxSize - 1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                topPointer = topPointer + 1;
                array[topPointer] = num;
            }
        }
        int Pop()
        {
            //1.check if stack is empty
            if (topPointer == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else {
                int element = array[topPointer];
                topPointer--;
                return element;
            }
        }
        void Print()
        {
            for (int i = topPointer; i >= 0; i--)
            {
                Console.WriteLine(array[i]);

            }
            Console.WriteLine();
        }
    }
}

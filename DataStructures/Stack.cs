﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// implements an integer based stack
    /// </summary>
    class Stack
    {
        /// <summary>
        /// stack space
        /// </summary>
        int[] stack;
        /// <summary>
        /// stack pointer
        /// </summary>
        int sp;
        /// <summary>
        /// size set at construction
        /// </summary>
        int max;

        public Stack(int size)
        {
            max = size;
            stack = new int[max];
            sp = 0;
        }

        /// <summary>
        /// places an item if possible onto top of stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(int item)
        {
            if (sp < max)
            {
                stack[sp] = item;
                sp++;
            }
            throw new Exception("STACK FULL");
        }

        /// <summary>
        /// removes an item from the top of stack if possible
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            throw new Exception("STACK EMPTY");
        }

    }
}

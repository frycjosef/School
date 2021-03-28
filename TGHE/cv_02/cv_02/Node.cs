using System;
using System.Collections.Generic;
using System.Text;

namespace cv_02
{
    class Node
    {
        private string Name;
        private bool was_visited;
        private int Value;

        private int first;
        private int second;

        public Node(string name){
            Name = name.ToUpper();
            was_visited = false;
        }

        public string getName()
        {
            return Name.ToUpper();
        }

        public void setVisited()
        {
            was_visited = true;
        }

        public bool wasVisited()
        {
            return was_visited;
        }
        public int getValue()
        {
            return Value;
        }

        public void setFirst(int input)
        {
            first = input;
        }

        public void setSecond(int input)
        {
            second = input;
        }

        public int getFirst()
        {
            return first;
        }

        public int getSecond()
        {
            return second;
        }
    }
}

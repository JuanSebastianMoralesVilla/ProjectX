using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    public class Node
    {
        public int height;
        public double entropy;
        public string message;
        public int? answer;
        public Node parent;
        public int? value;
        public Node[] nodes;
        public int posX;
        public int posY;
        public int distX;

        public Node()
        {
            posY = 10;
            nodes = new Node[0];
            answer = null;
        }
    }
}

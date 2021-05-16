using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HeartAttackApp.Model
{
    public class Visualization
    {
        private Node root;
        private PictureBox ptb;
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;
        public const int DIST_Y = 130;
        private int rootX;
        private int rootY;
        public const int SIZE = 45;
      

        public Visualization(PictureBox ptb)
        {
            
            this.ptb = ptb;
            pen = new Pen(Color.Purple, 5);
            bitmap = new Bitmap(ptb.Width, ptb.Height);
            rootX = ptb.Width / 2;
            rootY = 20;
            ptb.Image = (Image)bitmap;
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
        }

        public void insert(Node root)
        {
            this.root = root;
            root.posX = rootX;
            root.posY = rootY;
        }
        
        public void visualize()
        {
            changeSonsSize(root);
            adjustSize();
            show(root,0);
        }

        private void adjustSize()
        {
            List<List<Node>> allNodes = new List<List<Node>>();
            addToList(allNodes, root);
            bool perfect = false;
            while (!perfect)
            {
                perfect = true;
                for (int i = allNodes.Count - 1; i >= 0; i--)
                {
                    List<Node> nodesHeight = allNodes[i];
                    Node before = null;
                    foreach (Node currentNode in nodesHeight)
                    {
                        if (before != null)
                        {
                            int xBefore = before.posX + 2 * SIZE;
                            while (xBefore >= currentNode.posX)
                            {
                                perfect = false;
                                Node parentBefore = before.parent;
                                Node parentCurrent = currentNode.parent;
                                while (parentBefore != parentCurrent)
                                {
                                    parentCurrent = parentCurrent.parent;
                                    parentBefore = parentBefore.parent;
                                }
                                parentCurrent.distX += 10;
                                changeSonsSize(parentCurrent);
                                xBefore = before.posX + 2 * SIZE;
                            }
                        }
                        before = currentNode;
                    }
                }
            }
        }

        private void addToList(List<List<Node>> allNodes,Node currentNode)
        {
            if (currentNode != null)
            {
                if (allNodes.Count < currentNode.height)
                {
                    allNodes.Add(new List<Node>());
                }
                List<Node> currentList = allNodes[currentNode.height-1];
                currentList.Add(currentNode);
                foreach(Node node in currentNode.nodes)
                {
                    addToList(allNodes, node);
                }
            }
        }
        private void changeSonsSize(Node parent)
        {
            int distX = parent.distX;
            if (parent.nodes.Length > 1)
            {
                int div = (2 * distX) / (parent.nodes.Length - 1);
                int start = parent.posX - distX - div;
                for (int i = 0; i < parent.nodes.Length; i++)
                {
                    Node node = parent.nodes[i];
                    if (node != null)
                    {
                        node.posX = start + div * (i + 1);
                        changeSonsSize(node);
                    }
                }
            }
            else if (parent.nodes.Length > 0)
            {
                parent.nodes[0].posX = parent.posX;
                changeSonsSize(parent.nodes[0]);
            }
        }

        private void show(Node node,int position)
        {
            if (node == root)
            {
                graphics.DrawString(Patient.getNamesColums(node.value) + "Entropy: " + node.entropy, new Font("Comic Sans", 8, FontStyle.Bold), new SolidBrush(Color.Black), node.posX - SIZE + 1, node.posY);
                graphics.DrawRectangle(new Pen(Color.Black, 1), new Rectangle(node.posX - SIZE, node.posY, 2 * SIZE, SIZE));
            }
            else
            {
                Rectangle rect = new Rectangle(node.posX - SIZE, node.posY, 2 * SIZE, SIZE);
                if (node.answer == 1)
                {
                    SolidBrush trueBrush = new SolidBrush(Color.Green);
                    graphics.FillRectangle(trueBrush, rect);
                }
                else if(node.answer == 0)
                {
                    SolidBrush trueBrush = new SolidBrush(Color.Red);
                    graphics.FillRectangle(trueBrush, rect);
                }
                else
                {
                    graphics.DrawString(Patient.getNamesColums(node.value) + "Entropy: " + node.entropy, new Font("Comic Sans", 8, FontStyle.Bold), new SolidBrush(Color.Black), node.posX - SIZE + 1, node.posY);
                    graphics.DrawRectangle(new Pen(Color.Black, 1), rect);
                }
                graphics.DrawLine(new Pen(Color.Black, 1), node.parent.posX, node.parent.posY + SIZE, node.posX, node.posY);
                int xMesssage = node.posX + (node.parent.posX-node.posX)/2;
                int yMessage = node.posY + (node.parent.posY + SIZE - node.posY) / 2;
                if ((position + 1) % 2 == 0 && node.height > 2)
                {
                    yMessage += 20;
                    xMesssage += 20;
                }
                
                graphics.DrawString(node.message, new Font("Comic Sans", 10, FontStyle.Italic), new SolidBrush(Color.DarkBlue), xMesssage-3*(node.message.Length),yMessage) ;

            }
            for (int i = 0; i< node.nodes.Length;i++)
            {
                Node nodeA = node.nodes[i];
                if (nodeA != null)
                {
                    show(nodeA,i);
                }
            }
        }
    }

}

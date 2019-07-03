using System;

namespace CodeSignalSolutions.Other
{
    public class TreeNode
    {
        public int Val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int val)
        {
            Val = val;
        }

    }

    public class InorderSuccessor
    {
        public TreeNode InorderSuccess(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            if (root.Right != null)
            {
                return FindMin(root.Right);
            }
            var ancestor = root;
            TreeNode successor = null;
            while (!ancestor.Equals(root))
            {
                if (root.Val < ancestor.Val)
                {
                    successor = ancestor;
                    ancestor = ancestor.Left;
                }
                else
                {
                    ancestor = ancestor.Right;
                }
            }

            return successor;
        }

        private TreeNode FindMin(TreeNode root)
        {
            if (root.Left != null)
            {
                return FindMin(root.Left);
            }

            return root;
        }
    }
}
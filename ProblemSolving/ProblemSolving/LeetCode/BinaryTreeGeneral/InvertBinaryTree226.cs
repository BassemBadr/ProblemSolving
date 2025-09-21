using ProblemSolving.Types;

namespace ProblemSolving.LeetCode.BinaryTreeGeneral
{
    public class InvertBinaryTree226
    {
        //https://leetcode.com/problems/invert-binary-tree
        public TreeNode InvertTree(TreeNode root)
        {
            //  time O(n)
            //  space O(n)
            if (root == null)
                return root;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                TreeNode temp = current.left;
                current.left = current.right;
                current.right = temp;

                if (current.left != null)
                    queue.Enqueue(current.left);

                if (current.right != null)
                    queue.Enqueue(current.right);
            }
            return root;
        }

        private TreeNode Solution1(TreeNode root)
        {
            //  time O(n)
            //  space O(h) where h is tree hight storing recursion stack
            if (root == null)
                return null;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}

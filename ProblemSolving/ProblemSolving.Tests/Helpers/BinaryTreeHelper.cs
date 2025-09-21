using ProblemSolving.Types;

namespace ProblemSolving.Tests.Helpers
{
    public static class BinaryTreeHelper
    {
        public static TreeNode CreateBinaryTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
                return null;

            TreeNode root = new TreeNode(arr[0].Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;

            while (queue.Count > 0 && index < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                // Only process left child if current node exists
                if (current != null)
                {
                    // Left child
                    if (index < arr.Length)
                    {
                        current.left = arr[index] != null ? new TreeNode(arr[index].Value) : null;
                        queue.Enqueue(current.left); // Enqueue even if null!
                        index++;
                    }

                    // Right child
                    if (index < arr.Length)
                    {
                        current.right = arr[index] != null ? new TreeNode(arr[index].Value) : null;
                        queue.Enqueue(current.right); // Enqueue even if null!
                        index++;
                    }
                }
                else
                {
                    //  for left
                    queue.Enqueue(null);
                    index++;

                    //  for right
                    queue.Enqueue(null);
                    index++;
                }
            }

            return root;
        }
    }
}

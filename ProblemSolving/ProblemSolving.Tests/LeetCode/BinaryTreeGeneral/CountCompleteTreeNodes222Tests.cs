using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.Tests.Helpers;
using ProblemSolving.Types;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class CountCompleteTreeNodes222Tests
    {
        private CountCompleteTreeNodes222 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new CountCompleteTreeNodes222();
        }

        [Test]
        public void CountNodes_Example1_ShouldReturn6()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6]);
            int expected = 6;

            //  Act
            int result = _solution.CountNodes(root);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CountNodes_Example2_ShouldReturn0()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([]);
            int expected = 0;

            //  Act
            int result = _solution.CountNodes(root);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CountNodes_Example3_ShouldReturn1()
        {
            //  Arrange
            TreeNode root = BinaryTreeHelper.CreateBinaryTree([1]);
            int expected = 1;

            //  Act
            int result = _solution.CountNodes(root);

            //  Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CountNodes_PerfectTreeHeight2_ReturnsThree()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2),
                new TreeNode(3));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(3));
        }

        [Test]
        public void CountNodes_PerfectTreeHeight3_ReturnsSeven()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(7)));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(7));
        }

        [Test]
        public void CountNodes_CompleteTreeLastLevelLeftAligned_ReturnsCorrectCount()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    null),
                new TreeNode(3));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(4));
        }

        [Test]
        public void CountNodes_CompleteTree5Nodes_ReturnsFive()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(5));
        }

        [Test]
        public void CountNodes_CompleteTree6Nodes_ReturnsSix()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    null));
            
            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(6));
        }

        [Test]
        public void CountNodes_LargerCompleteTree_ReturnsFifteen()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4,
                        new TreeNode(8),
                        new TreeNode(9)),
                    new TreeNode(5,
                        new TreeNode(10),
                        new TreeNode(11))),
                new TreeNode(3,
                    new TreeNode(6,
                        new TreeNode(12),
                        new TreeNode(13)),
                    new TreeNode(7,
                        new TreeNode(14),
                        new TreeNode(15))));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(15));
        }

        [Test]
        public void CountNodes_CompleteTree10Nodes_ReturnsTen()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4,
                        new TreeNode(8),
                        new TreeNode(9)),
                    new TreeNode(5,
                        new TreeNode(10),
                        null)),
                new TreeNode(3,
                    new TreeNode(6),
                    new TreeNode(7)));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(10));
        }

        [Test]
        public void CountNodes_LeftPerfectRightComplete_ReturnsCorrectCount()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    null));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(6));
        }

        [Test]
        public void CountNodes_LargeCompleteTree_ReturnsCorrectCount()
        {
            //  Arrange
            TreeNode root = CreateCompleteTree(28); 

            //  Act
            int count = _solution.CountNodes(root);

            //  Assert
            Assert.That(count, Is.GreaterThan(0));
        }

        [Test]
        public void CountNodes_LeftSkewedCompleteTree_ReturnsCorrectCount()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3,
                        new TreeNode(4))),
                null);

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(4));
        }

        [Test]
        public void CountNodes_TwoNodeTree_ReturnsTwo()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2),
                null);

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(2));
        }

        [Test]
        public void CountNodes_AlternatingCompleteTree_ReturnsCorrectCount()
        {
            //  Arrange
            TreeNode root = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6),
                    null));

            //  Act & Assert
            Assert.That(_solution.CountNodes(root), Is.EqualTo(6));
        }

        

        [Test]
        [Timeout(100)] // Should complete in under 100ms for largest input
        public void CountNodes_LargeTree_PerformsEfficiently()
        {
            //  Arrange
            TreeNode root = CreateLargeCompleteTree(5000);

            //  Act
            int count = _solution.CountNodes(root);

            //  Assert
            Assert.That(count, Is.GreaterThan(0));
        }

        private TreeNode CreateLargeCompleteTree(int approximateSize)
        {
            int height = (int)Math.Log(approximateSize, 2);
            return CreateCompleteTree((1 << height) - 1);
        }

        private TreeNode CreateCompleteTree(int nodeCount)
        {
            if (nodeCount <= 0) return null;

            TreeNode root = new TreeNode(1);
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int count = 1;

            while (count < nodeCount && queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();

                if (count < nodeCount)
                {
                    current.left = new TreeNode(++count);
                    queue.Enqueue(current.left);
                }
                if (count < nodeCount)
                {
                    current.right = new TreeNode(++count);
                    queue.Enqueue(current.right);
                }
            }

            return root;
        }
    }
}

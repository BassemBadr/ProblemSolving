using ProblemSolving.LeetCode.BinaryTreeGeneral;
using ProblemSolving.LeetCode.Types;
using ProblemSolving.Tests.Helpers;

namespace ProblemSolving.Tests.LeetCode.BinaryTreeGeneral
{
    [TestFixture]
    public class SameTree100Tests
    {
        private SameTree100 _solution;

        [SetUp]
        public void Setup()
        {
            _solution = new SameTree100();
        }

        [Test]
        public void IsSameTree_Example1_ShouldReturnTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_Example2_ShouldReturnFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, null, 2]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_Example3_ShouldReturnFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 1]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 1, 2]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_BothNull_ReturnsTrue()
        {
            //  Act
            bool result = _solution.IsSameTree(null, null);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_FirstNullSecondNotNull_ReturnsFalse()
        {
            //  Arrange
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1]);

            //  Act
            bool result = _solution.IsSameTree(null, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_FirstNotNullSecondNull_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1]);

            //  Act
            bool result = _solution.IsSameTree(p, null);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_SingleNodeSameValue_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([5]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([5]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_SingleNodeDifferentValue_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([5]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([10]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_DifferentStructure_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, null]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_MirrorTrees_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 3, 2]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_DifferentDepth_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3, null, null, null, 4]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, null, 3]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_SameStructureDifferentValues_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 4, 5]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_OneValueDifferent_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 4]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_IdenticalSimpleTrees_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 3]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_IdenticalComplexTrees_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, null, 6]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, null, 6]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_IdenticalUnbalancedTrees_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, null, 3, 4]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, null, 2, null, null, null, 3, 4]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_MinimumValue_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([-10000]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([-10000]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_MaximumValue_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([10000]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([10000]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_MinMaxValues_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([-10000]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([10000]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_LargeIdenticalTrees_ReturnsTrue()
        {
            //  Arrange
            int?[] largeTree = new int?[100];
            for (int i = 0; i < 100; i++)
            {
                largeTree[i] = i;
            }

            TreeNode p = BinaryTreeHelper.CreateBinaryTree(largeTree);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree(largeTree);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_LargeDifferentTrees_ReturnsFalse()
        {
            //  Arrange
            int?[] tree1 = new int?[100];
            int?[] tree2 = new int?[100];
            for (int i = 0; i < 100; i++)
            {
                tree1[i] = i;
                tree2[i] = i;
            }
            tree2[99] = -1;

            TreeNode p = BinaryTreeHelper.CreateBinaryTree(tree1);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree(tree2);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsSameTree_IdenticalSimpleLargeTrees_ReturnsTrue()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6, 7]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([1, 2, 3, 4, 5, 6, 7]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsSameTree_NormalCase1_ReturnsFalse()
        {
            //  Arrange
            TreeNode p = BinaryTreeHelper.CreateBinaryTree([2, null, 4]);
            TreeNode q = BinaryTreeHelper.CreateBinaryTree([2, 3, 4]);

            //  Act
            bool result = _solution.IsSameTree(p, q);

            //  Assert
            Assert.That(result, Is.False);
        }
    }
}

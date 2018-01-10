using System;
using Xunit;

namespace BinaryTree.Test
{
    public class TreeUnitTest
    {
        [Fact]
        public void Insert()
        {
            Tree<int> testClass = GetTree();

            Assert.Equal(testClass.Root.Value, 12);
            Assert.Equal(testClass.Root.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.Value, 13);
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.Value, 17);
            Assert.Equal(testClass.Root.RightNode.RightNode.Value, 19);
        }

        [Fact]
        public void Delete()
        {
            Tree<int> testClass = GetTree();
            testClass.Delete(12);

            Assert.Equal(testClass.Root.Value, 13);
            Assert.Equal(testClass.Root.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.Value, 17);
            Assert.Equal(testClass.Root.RightNode.RightNode.Value, 19);
        }

        [Fact]
        public void Search()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.Search(18);
            Assert.Equal(result.Value, 18);
            Assert.Equal(result.LeftNode.Value, 15);
            Assert.Equal(result.RightNode.Value, 19);
        }

        [Fact]
        public void Minimum()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.GetMinimum();
            Assert.Equal(result.Value, 2);
        }

        [Fact]
        public void Maximum()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.GetMaximum();
            Assert.Equal(result.Value, 19);
        }
        public Tree<int> GetTree()
        {
            Tree<int> testClass = new Tree<int>();
            testClass.Insert(12);
            testClass.Insert(5);
            testClass.Insert(9);
            testClass.Insert(2);
            testClass.Insert(18);
            testClass.Insert(15);
            testClass.Insert(19);
            testClass.Insert(17);
            testClass.Insert(13);

            return testClass;
        }
    }
}

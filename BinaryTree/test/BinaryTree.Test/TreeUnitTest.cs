using System;
using Xunit;

namespace BinaryTree.Test
{
    public class TreeUnitTest
    {
        [Fact]
        public void RightRotation()
        {
            Tree<int> testClass = GetTree();
            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            testClass.RightRotation(12);
            //   __5__
            //   2 _12_____
            //     9 ____18___
            //     __15__   19
            //     13  17


            Assert.Null(testClass.Root.ParentNode);
            Assert.Equal(testClass.Root.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.RightNode.Value, 12);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.RightNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.LeftNode.Value, 13);
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.RightNode.Value, 17);
            Assert.Equal(testClass.Root.RightNode.RightNode.RightNode.Value, 19);


            Assert.Equal(testClass.Root.LeftNode.ParentNode.Value, 5); //2
            Assert.Equal(testClass.Root.RightNode.ParentNode.Value, 5); //12
            Assert.Equal(testClass.Root.RightNode.LeftNode.ParentNode.Value, 12); //9
            Assert.Equal(testClass.Root.RightNode.RightNode.ParentNode.Value, 12); //18
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.ParentNode.Value, 18); //15
            Assert.Equal(testClass.Root.RightNode.RightNode.RightNode.ParentNode.Value, 18); //19
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.LeftNode.ParentNode.Value, 15); //13
            Assert.Equal(testClass.Root.RightNode.RightNode.LeftNode.RightNode.ParentNode.Value, 15); //17

            Assert.Null(testClass.Root.LeftNode.LeftNode); //2
            Assert.Null(testClass.Root.LeftNode.RightNode); //2
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode); //9
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode); //9
            Assert.Null(testClass.Root.RightNode.RightNode.RightNode.LeftNode); //19
            Assert.Null(testClass.Root.RightNode.RightNode.RightNode.RightNode); //19
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode.LeftNode.LeftNode); //13
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode.LeftNode.RightNode); //13
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode.RightNode.LeftNode); //17
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode.RightNode.RightNode); //17

        }


        [Fact]
        public void LeftRotation()
        {
            Tree<int> testClass = GetTree();
            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            testClass.LeftRotation(18);
            // ____12____   
            //_5_    __19 
            //2 9  __18
            //   __15__
            //   13  17  

            Assert.Equal(testClass.Root.Value, 12);
            Assert.Equal(testClass.Root.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.Value, 19);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.LeftNode.Value, 13);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.RightNode.Value, 17);


            Assert.Null(testClass.Root.ParentNode); //12
            Assert.Equal(testClass.Root.LeftNode.ParentNode.Value, 12); //5
            Assert.Equal(testClass.Root.RightNode.ParentNode.Value, 12); //19
            Assert.Equal(testClass.Root.LeftNode.LeftNode.ParentNode.Value, 5); //2
            Assert.Equal(testClass.Root.LeftNode.RightNode.ParentNode.Value, 5); //9
            Assert.Equal(testClass.Root.RightNode.LeftNode.ParentNode.Value, 19); //18
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.ParentNode.Value, 18); //15
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.LeftNode.ParentNode.Value, 15); //13
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.RightNode.ParentNode.Value, 15); //17

            Assert.Null(testClass.Root.RightNode.RightNode);      //19
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode);      //18
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.LeftNode.LeftNode);      //13
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.LeftNode.RightNode);      //13
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.RightNode.LeftNode);      //17
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.RightNode.RightNode);      //17
            Assert.Null(testClass.Root.LeftNode.LeftNode.LeftNode);     //2
            Assert.Null(testClass.Root.LeftNode.LeftNode.RightNode);    //2
            Assert.Null(testClass.Root.LeftNode.RightNode.LeftNode);     // 9
            Assert.Null(testClass.Root.LeftNode.RightNode.RightNode);    // 9
        }

        [Fact]
        public void LeftRotation_Root()
        {
            Tree<int> testClass = GetTree();
            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            testClass.LeftRotation(12);
            //    ____18____
            // ___12___   19
            //_5_  __15__ 
            //2 9  13  17

            Assert.Equal(testClass.Root.Value, 18);
            Assert.Equal(testClass.Root.RightNode.Value, 19);
            Assert.Equal(testClass.Root.LeftNode.Value, 12);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 15);
            Assert.Equal(testClass.Root.LeftNode.RightNode.LeftNode.Value, 13);
            Assert.Equal(testClass.Root.LeftNode.RightNode.RightNode.Value, 17);

            Assert.Null(testClass.Root.ParentNode); //18
            Assert.Equal(testClass.Root.LeftNode.ParentNode.Value, 18); //12
            Assert.Equal(testClass.Root.RightNode.ParentNode.Value, 18); //19
            Assert.Equal(testClass.Root.LeftNode.LeftNode.ParentNode.Value, 12); //5
            Assert.Equal(testClass.Root.LeftNode.RightNode.ParentNode.Value, 12); //15
            Assert.Equal(testClass.Root.LeftNode.LeftNode.LeftNode.ParentNode.Value, 5); //2
            Assert.Equal(testClass.Root.LeftNode.LeftNode.RightNode.ParentNode.Value, 5); //9
            Assert.Equal(testClass.Root.LeftNode.RightNode.LeftNode.ParentNode.Value, 15); //13
            Assert.Equal(testClass.Root.LeftNode.RightNode.RightNode.ParentNode.Value, 15); //17

            Assert.Null(testClass.Root.RightNode.LeftNode); //19
            Assert.Null(testClass.Root.RightNode.RightNode); //19
            Assert.Null(testClass.Root.LeftNode.LeftNode.LeftNode.LeftNode); //2
            Assert.Null(testClass.Root.LeftNode.LeftNode.LeftNode.RightNode); //2
            Assert.Null(testClass.Root.LeftNode.LeftNode.RightNode.LeftNode); //9
            Assert.Null(testClass.Root.LeftNode.LeftNode.RightNode.RightNode); //9
            Assert.Null(testClass.Root.LeftNode.RightNode.LeftNode.LeftNode); //13
            Assert.Null(testClass.Root.LeftNode.RightNode.LeftNode.RightNode); //13
            Assert.Null(testClass.Root.LeftNode.RightNode.RightNode.LeftNode); //17
            Assert.Null(testClass.Root.LeftNode.RightNode.RightNode.RightNode); //17
        }

        [Fact]
        public void Insert()
        {
            Tree<int> testClass = GetTree();

            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            Assert.Equal(testClass.Root.Value, 12);
            Assert.Equal(testClass.Root.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.Value, 13);
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.Value, 17);
            Assert.Equal(testClass.Root.RightNode.RightNode.Value, 19);
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.Value, 13);

            Assert.Equal(testClass.Root.LeftNode.ParentNode.Value, 12); //5
            Assert.Equal(testClass.Root.RightNode.ParentNode.Value, 12); //18
            Assert.Equal(testClass.Root.LeftNode.LeftNode.ParentNode.Value, 5); //2
            Assert.Equal(testClass.Root.LeftNode.RightNode.ParentNode.Value, 5); //9
            Assert.Equal(testClass.Root.RightNode.LeftNode.ParentNode.Value, 18); //15
            Assert.Equal(testClass.Root.RightNode.RightNode.ParentNode.Value, 18); //19
            Assert.Equal(testClass.Root.RightNode.LeftNode.LeftNode.ParentNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.ParentNode.Value, 15); //17

            Assert.Null(testClass.Root.LeftNode.LeftNode.LeftNode); //2
            Assert.Null(testClass.Root.LeftNode.LeftNode.RightNode); //2
            Assert.Null(testClass.Root.LeftNode.RightNode.LeftNode); //9
            Assert.Null(testClass.Root.LeftNode.RightNode.RightNode); //9
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode); //19
            Assert.Null(testClass.Root.RightNode.RightNode.RightNode); //19
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.LeftNode); //13
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode.RightNode); //13
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode.LeftNode); //17
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode.RightNode); //17
        }

        [Fact]
        public void Delete()
        {
            Tree<int> testClass = GetTree();

            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            testClass.Delete(12);

            //  ____13_____
            // _5_   ____18___
            // 2 9   15__   19
            //         17
            Assert.Null(testClass.Root.ParentNode);

            Assert.Equal(testClass.Root.Value, 13);
            Assert.Equal(testClass.Root.LeftNode.Value, 5);
            Assert.Equal(testClass.Root.LeftNode.LeftNode.Value, 2);
            Assert.Equal(testClass.Root.LeftNode.RightNode.Value, 9);
            Assert.Equal(testClass.Root.RightNode.Value, 18);
            Assert.Equal(testClass.Root.RightNode.LeftNode.Value, 15);
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.Value, 17);
            Assert.Equal(testClass.Root.RightNode.RightNode.Value, 19);

            Assert.Equal(testClass.Root.LeftNode.ParentNode.Value, 13); //5
            Assert.Equal(testClass.Root.RightNode.ParentNode.Value, 13); //18
            Assert.Equal(testClass.Root.LeftNode.LeftNode.ParentNode.Value, 5); //2
            Assert.Equal(testClass.Root.LeftNode.RightNode.ParentNode.Value, 5); //9
            Assert.Equal(testClass.Root.RightNode.LeftNode.ParentNode.Value, 18); //15
            Assert.Equal(testClass.Root.RightNode.RightNode.ParentNode.Value, 18); //19
            Assert.Equal(testClass.Root.RightNode.LeftNode.RightNode.ParentNode.Value, 15); //17

            Assert.Null(testClass.Root.LeftNode.LeftNode.LeftNode); //2
            Assert.Null(testClass.Root.LeftNode.LeftNode.RightNode); //2
            Assert.Null(testClass.Root.LeftNode.RightNode.LeftNode); //9
            Assert.Null(testClass.Root.LeftNode.RightNode.RightNode); //9
            Assert.Null(testClass.Root.RightNode.RightNode.LeftNode); //19
            Assert.Null(testClass.Root.RightNode.RightNode.RightNode); //19
            Assert.Null(testClass.Root.RightNode.LeftNode.LeftNode);//15
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode.LeftNode); //17
            Assert.Null(testClass.Root.RightNode.LeftNode.RightNode.RightNode); //17
        }

        [Fact]
        public void Search()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.Search(18);

            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            Assert.Equal(result.Value, 18);
            Assert.Equal(result.LeftNode.Value, 15);
            Assert.Equal(result.RightNode.Value, 19);
            Assert.Equal(result.ParentNode.Value, 12);
        }

        [Fact]
        public void Minimum()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.GetMinimum();

            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
            Assert.Equal(result.Value, 2);
            Assert.Equal(result.ParentNode.Value, 5);
            Assert.Null(result.LeftNode);
            Assert.Null(result.RightNode);
        }

        [Fact]
        public void Maximum()
        {
            Tree<int> testClass = GetTree();

            var result = testClass.GetMaximum();

            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17

            Assert.Equal(result.Value, 19);
            Assert.Equal(result.ParentNode.Value, 18);
            Assert.Null(result.LeftNode);
            Assert.Null(result.RightNode);
        }
        public Tree<int> GetTree()
        {
            //  ____12_____
            // _5_   ____18___
            // 2 9 __15__   19
            //     13  17
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

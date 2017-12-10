using Xunit;
using System;
using Queue.Priority;
using FluentAssertions;

namespace Queue.Test.Priority
{
    public class QueuePriorityUnitTest
    {

        [Fact]
        public void Get_MaxPriority()
        {
            var collection = new int[] { 9, 1, 2, 8, 7, 3, 5, 6, 4, 0 };
            var testClass = new QueuePriority<int>(collection);

            testClass.GetValue().Should().Be(0);
        }
        [Fact]
        public void Get_RepeatValue()
        {
            var collection = new int[] { 5, 1, 2, 8, 7, 3, 9, 6, 4, 0 };
            var testClass = new QueuePriority<int>(collection);

            testClass.GetValue().Should().Be(0);
            testClass.GetValue().Should().Be(0);
            testClass.GetValue().Should().Be(0);
        }


        [Fact]
        public void Extract_MaxPriority()
        {
            var collection = new int[] { 9, 1, 2, 8, 7, 3, 5, 6, 4, 0 };
            var testClass = new QueuePriority<int>(collection);

            var result = testClass.ExtractValue();
            result.Should().Be(0);
        }

        [Fact]
        public void Extract_NewValue()
        {
            var collection = new int[] { 5, 1, 2, 8, 7, 3, 4, 9, 6, 4, 0 };
            var testClass = new QueuePriority<int>(collection);

            testClass.ExtractValue().Should().Be(0);
            testClass.ExtractValue().Should().Be(1);
            testClass.ExtractValue().Should().Be(2);
            testClass.ExtractValue().Should().Be(3);
            testClass.ExtractValue().Should().Be(4);
            testClass.ExtractValue().Should().Be(4);
            testClass.ExtractValue().Should().Be(5);
            testClass.ExtractValue().Should().Be(6);
        }

        [Fact]
        public void InsertValue()
        {
            var testClass = new QueuePriority<int>();
            testClass.InsertValue(1);
            testClass.GetValue().Should().Be(1);
        }

        [Fact]
        public void InsertValue_Sorting()
        {
            var testClass = new QueuePriority<int>();
            testClass.InsertValue(5);
            testClass.InsertValue(9);
            testClass.InsertValue(1);
            testClass.InsertValue(4);
            testClass.InsertValue(3);
            testClass.ExtractValue().Should().Be(1);
            testClass.ExtractValue().Should().Be(3);
            testClass.ExtractValue().Should().Be(4);
            testClass.ExtractValue().Should().Be(5);
            testClass.ExtractValue().Should().Be(9);
        }

    }
}
using System;
using System.Collections.Generic;
using Xunit;

namespace christmas_tree_kata
{
    public class UnitTest1
    {
        [Fact]
        public void DrawMethod_GivingLessThan5ThenOutputShouldBe6()
        {
            var expectedCount = 6;
            var actualList = Christmastree.Draw(4);

            Assert.Equal(expectedCount, actualList.Count);
        }

        [Fact]
        public void DrawMethod_GivenAnyValueThenReturnsListOfObjects()
        {
            var expectedType = typeof(List<object>);
            var actualList = Christmastree.Draw(4);

            Assert.IsType(expectedType, actualList);
        }

        
    }
}

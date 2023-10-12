using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1laba.Models;

namespace AlexandrovKA_KT_42_20.UnitTests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT4220_True()
        {
            //arrange
            var testGroup = new Group
            {
                GroupName = "KT-41-20"
            };

            //act
            var result = testGroup.IsValidGroupName();

            //assert
            Assert.True(result);
        }
    }
}
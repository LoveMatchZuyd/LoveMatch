using LoveMatch.Models;

namespace LoveMatch.Tests
{
    public class MemberTests
    {
        // Created by B. Malasch. Edited by W. Smeets (Admin object i.v.m. REQUIRED relatie).
        [Fact]
        public void IsAdult_Should_Return_True_When_Age_Is_18_Or_Older()
        {
            //Arrange
            Admin TestAdmin = new Admin();
            var member = new Member
            {
                Id = 1,
                Name = "Brad",
                DateOfBirth = new DateTime(1990, 12, 25),
                Bio = "Houdt van voetballen en pizza eten.",
                Admin = TestAdmin
            };
            //Act
            var result = member.IsAdult();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAdult_Should_Return_False_When_Age_Is_Younger_Than_18()
        {
            Admin TestAdmin = new Admin();
            var member = new Member
            {
                Id = 2,
                Name = "Lisa",
                DateOfBirth = new DateTime(2018, 12, 25),
                Bio = "Houdt van koken.",
                Admin = TestAdmin,
            };

            var result = member.IsAdult();

            Assert.False(result);
        }
    }
}
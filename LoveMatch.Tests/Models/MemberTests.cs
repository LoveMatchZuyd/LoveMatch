using LoveMatch.Models;

namespace LoveMatch.Tests
{
    public class MemberTests
    {
        [Fact]
        public void IsAdult_Should_Return_True_When_Age_Is_18_Or_Older()
        {
            //Arrange
            var member = new Member
            {
                Id = 1,
                Name = "Brad",
                DateOfBirth = new DateTime(1990, 12, 25),
                Bio = "Houdt van voetballen en pizza eten."
            };
            //Act
            var result = member.IsAdult();
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void IsAdult_Should_Return_False_When_Age_Is_Younger_Than_18()
        {
            var member = new Member
            {
                Id = 2,
                Name = "Lisa",
                DateOfBirth = new DateTime(2008, 04, 16),
                Bio = "Houdt van koken."
            };

            var result = member.IsAdult();

            Assert.False(result);
        }
    }
}
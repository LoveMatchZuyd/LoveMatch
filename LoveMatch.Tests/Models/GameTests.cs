using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveMatch.Models;

namespace LoveMatch.Tests.Models
{
    // Created by W. Smeets
    public class GameTests
    {
        Member testMember = new Member
                    {
                Id = 1,
                Name = "Brad",
                DateOfBirth = new DateTime(1990, 12, 25),
                Bio = "Houdt van voetballen en pizza eten.",
                Admin = new Admin(),
                };

    [Fact]
        public void ChangeDifficulty_To_Easy_Returns_Easy()
        {
            //Arrange

            Game testGameDifficulty = new Game
            {
                Member = testMember,
                MemberId = testMember.Id
            };

            //Act
            testGameDifficulty.ChangeDifficulty("Easy");

            //Assert
            Assert.Equal("Easy", testGameDifficulty.Difficulty);
        }

        [Fact]

        public void ChangePlayTime_To_90_Returns_90()
        {
            //Arrange

            Game testGamePlayTime = new Game
            {
                Member = testMember,
                MemberId = testMember.Id
            };

            //Act
            testGamePlayTime.ChangePlayTime(90);

            //Assert
            Assert.Equal(90, testGamePlayTime.PlayTimeInMinutes);
        }
    }
}

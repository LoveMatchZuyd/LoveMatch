using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoveMatch.Models;

namespace LoveMatch.Tests.Models
{
    public class GameTests
    {
        [Fact]
        public void ChangeDifficulty_To_Easy_Returns_Easy()
        {
            //Arrange

            Game testGameDifficulty = new Game();

            //Act
            testGameDifficulty.ChangeDifficulty("Easy");

            //Assert
            Assert.Equal("Easy", testGameDifficulty.Difficulty);
        }

        [Fact]

        public void ChangePlayTime_To_90_Returns_90()
        {
            //Arrange

            Game testGamePlayTime = new Game();

            //Act
            testGamePlayTime.ChangePlayTime(90);

            //Assert
            Assert.Equal(90, testGamePlayTime.PlayTimeInMinutes);
        }
    }
}

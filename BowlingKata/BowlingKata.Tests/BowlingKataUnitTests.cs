using BowlingKataProject;
using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class BowlingKataUnitTests
    {
        private Game game;

        [SetUp]
        public void Init()
        {
            game = new Game();
        }


        [Test]
        public void doesGameExist()
        {
            //Arrange
            //Game game;

            //Act
            //game = new Game();
            //Assert
            Assert.NotNull(game);
        }

        [Test]
        public void GutterGameReturns0()
        {
            //Arrange
            //Game game = new Game();
            //int pins = 0;

            //Act
            /*for (int i = 0; i < 20; i++)
            {
                game.roll(pins);
            }*/

            rollMany(20, 0);

            //Assert
            Assert.AreEqual(0, game.scoreGame());
        }

        [Test]
        public void SinglePinGame_Returns20()
        {
            //Arrange
            //Game game = new Game();
            //int pins = 1;

            //Act
            rollMany(20,1);

            //Assert
            Assert.AreEqual(20, game.scoreGame());
        }


        [Test]
        public void OneSpareReturnsAppropiateValue()
        {
            //Act
            game.roll(5);
            game.roll(5);
            game.roll(3);
            rollMany(17, 0);

            //Assert
            Assert.AreEqual(16, game.scoreGame());
        }

        [Test]
        public void OneStrikeReturnsAppropiateValue()
        {
            //Act
            game.roll(10); //strike   
            game.roll(3);
            game.roll(4);

            rollMany(16, 0);

            //Assert  - 28 = 10+6+3 + (6+3)
            Assert.AreEqual(24, game.scoreGame());
        }

        [Test]
        public void perfertGame_Returns300()
        {
            //Arrange

            //Act
            rollMany(12, 10);
            //Assert
            Assert.AreEqual(300, game.scoreGame());
        }


        public void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.roll(pins);
            }
        }
    }
}

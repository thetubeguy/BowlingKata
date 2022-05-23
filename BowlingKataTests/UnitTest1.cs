using NUnit.Framework;
using FluentAssertions;
using BowlingKata;

namespace BowlingKataTests
{
    public class Tests
    {
        public Game MyGame;
        [SetUp]
        public void Setup()
        {
          
        }

        [Test]
        public void EveryFrameScores_7_and_1_ShouldBe_80()
        {

            MyGame = new Game("71717171717171717171");

            int ActualResult = MyGame.GetScore();

            int ExpectedResult = 80;

            Assert.That(ActualResult, Is.EqualTo(ExpectedResult));
         
        }

        [Test]
        public void Add_Strike_Should_Double_Next_2_Shots()
        {

            MyGame = new Game("7171X71717171717171");

            int ActualResult = MyGame.GetScore();

            int ExpectedResult = 90;

            Assert.That(ActualResult, Is.EqualTo(ExpectedResult));

        }

        [Test]
        public void Add_Spare_Should_Double_Next_1_Shot()
        {

            MyGame = new Game("7171X71717/71717171");

            int ActualResult = MyGame.GetScore();

            int ExpectedResult = 99;

            Assert.That(ActualResult, Is.EqualTo(ExpectedResult));

        }

        [Test]
        public void All_Strikes_Should_Be_300()
        {

   

            MyGame = new Game("XXXXXXXXXXXX");

            int ActualResult = MyGame.GetScore();

            int ExpectedResult = 300;

            Assert.That(ActualResult, Is.EqualTo(ExpectedResult));

        }
    }
}
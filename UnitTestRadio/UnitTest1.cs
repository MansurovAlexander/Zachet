using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zachet;

namespace UnitTestRadio
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void CheckMaxStation()
        {
            int MaxStation = 9;
            int expected = 9;
            Zachet.Radio FirstRadio = new Zachet.Radio();
            FirstRadio.SetNum(MaxStation);
            int actual = FirstRadio.StationNumber;
            Assert.AreEqual(expected, actual, 0, "Not correct station!");
        }
        [TestMethod]
        public void CheckMinStation()
        {
            int MinStation = 1;
            int expected = 1;
            Zachet.Radio FirstRadio = new Zachet.Radio();
            FirstRadio.SetNum(MinStation);
            int actual = FirstRadio.StationNumber;
            Assert.AreEqual(expected, actual, 0, "Not correct station!");
        }
        [TestMethod]
        public void CheckUpStation()
        {
            int CurrentStation = 1;
            int expected = 3;
            Zachet.Radio FirstRadio = new Zachet.Radio();
            FirstRadio.SetNum(CurrentStation);
            FirstRadio.StationNext();
            FirstRadio.StationNext();
            int actual = FirstRadio.StationNumber;
            Assert.AreEqual(expected, actual, 0, "Not correct station!");
        }
        [TestMethod]
        public void CheckDownStation()
        {
            int CurrentStation = 1;
            int expected = 9;
            Zachet.Radio FirstRadio = new Zachet.Radio();
            FirstRadio.SetNum(CurrentStation);
            FirstRadio.StationPrev();
            FirstRadio.StationPrev();
            int actual = FirstRadio.StationNumber;
            Assert.AreEqual(expected, actual, 0, "Not correct station!");
        }
        [TestMethod]
        public void CheckUpVolume()
        {
            int CurrentVolume = 9;
            int expected = 10;
            Zachet.Radio FirstRadio = new Zachet.Radio(0, CurrentVolume);
            FirstRadio.UpVolume();
            FirstRadio.UpVolume();
            int actual = FirstRadio.Vol;
            Assert.AreEqual(expected, actual, 0, "Not correct Volume!");
        }
        [TestMethod]
        public void CheckDownVolume()
        {
            int CurrentVolume = 1;
            int expected = 0;
            Zachet.Radio FirstRadio = new Zachet.Radio(0, CurrentVolume);
            FirstRadio.DownVolume();
            FirstRadio.DownVolume();
            int actual = FirstRadio.Vol;
            Assert.AreEqual(expected, actual, 0, "Not correct Volume!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zachet
{
    // В репозитории создать ветку dev сделать коомит в ветку dev класса Radio
    // В репозитории создать ветру test сделать коомит в ветку test класса UnitTest1
    // Слить ветку test в ветку dev
    // Слить ветку dev в master
    // push в репизиторрий на github
    // отправить ссылку на репизиторий 
    //change
    public class Radio
    {
        private int StationNum, Volume, SetNumber;
        public Radio()
            : this(0, 0)
        { }
        public Radio(int StationNum, int Volume)
        {
            this.StationNum = StationNum;
            this.Volume = Volume;
        }
        public int StationNumber
        {
            get => StationNum;
            set => StationNum = value;
        }
        public int Vol
        {
            get => Volume;
            set => Volume = value;
        }
        public void StationNext()
        {
            if (this.StationNum == 9) this.StationNum = 0;
            else this.StationNum++;
        }
        public void StationPrev()
        {
            if (this.StationNum == 0) this.StationNum = 9;
            else this.StationNum--;
        }

        public void SetNum(int SetNumber)
        {
            this.SetNumber = SetNumber;
            this.StationNumber = SetterNum;
        }
        public int SetterNum
        {
            get => SetNumber;
            set
            {
                if (SetNumber < 0 || SetNumber > 9)
                {
                    if (SetNumber < 0)
                    {
                        while (SetNumber < 0) SetNumber = SetNumber + 10;
                    }
                    else if (SetNumber > 9)
                    {
                        while (SetNumber > 9) SetNumber = SetNumber - 10;
                    }
                    SetNumber = value;
                }
                else SetNumber = value;
            }
        }
        public void UpVolume()
        {
            if (this.Volume < 10) this.Volume++;
        }
        public void DownVolume()
        {
            if (this.Volume > 0) this.Volume--;
        }
    }
}

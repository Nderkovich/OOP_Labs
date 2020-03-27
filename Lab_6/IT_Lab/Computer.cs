using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.IT_Lab
{
    public enum ComputerType
    {
        SERVER,
        WORKSTATION,
        NOTEBOOK
    }

    public enum RAMType { 
        DDR2,
        DDR3,
        DDR4
    }

    public enum DriveType
    {
        SSD,
        HDD
    }

    [Serializable]
    public class Computer
    {
        private ComputerType computerType;
        private Processor processor;
        private VideoCard videoCard;
        private RAMType ramType;
        private int ramCapacity;
        private int driveCapacity;
        private DriveType driveType;
        private DateTime purchaseDate;
        public readonly int price = new Random().Next(800, 2000);

        public int DriveCapacity { get => driveCapacity; set => driveCapacity = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public ComputerType ComputerType { get => computerType; set => computerType = value; }
        public Processor Processor { get => processor; set => processor = value; }
        public VideoCard VideoCard { get => videoCard; set => videoCard = value; }
        public RAMType RamType { get => ramType; set => ramType = value; }
        public DriveType DriveType { get => driveType; set => driveType = value; }
        public int RamCapacity { get => ramCapacity; set => ramCapacity = value; }

        public Computer() { }

        public Computer(ComputerType computerType, Processor processor, VideoCard videoCard, RAMType ramType, int driveCapacity, DriveType driveType, DateTime purchaseDate, int ramCapacity)
        {
            this.computerType = computerType;
            this.processor = processor;
            this.videoCard = videoCard;
            this.ramType = ramType;
            this.driveCapacity = driveCapacity;
            this.driveType = driveType;
            this.purchaseDate = purchaseDate;
            this.ramCapacity = ramCapacity;
        }


        public override string ToString()
        {
            return $"{computerType}; Ram and size: {ramType} - {ramCapacity}GB; Dirve and size {driveType} - {driveCapacity}GB; {processor}; {videoCard}; Purchase date{purchaseDate}; Price {price}";
        }
    }
}

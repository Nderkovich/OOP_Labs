using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.IT_Lab
{
    public enum InstructionSet
    {
        BIT32,
        BIT64
    }


    [Serializable]
    public class Processor
    {
        private String manufacturer;
        private String series;
        private String model;
        private int numberOfCores;
        private float baseFrequency;
        private float maxFrequency;
        private InstructionSet instructionSet;
        private int cacheSize;

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Series { get => series; set => series = value; }
        public string Model { get => model; set => model = value; }
        public int NumberOfCores { get => numberOfCores; set => numberOfCores = value; }
        public float BaseFrequency { get => baseFrequency; set => baseFrequency = value; }
        public float MaxFrequency { get => maxFrequency; set => maxFrequency = value; }
        public int CacheSize { get => cacheSize; set => cacheSize = value; }
        internal InstructionSet InstructionSet { get => instructionSet; set => instructionSet = value; }

        public Processor() { }

        public Processor(string manufacturer, string series, string model, int numberOfCores, float baseFrequency, float maxFrequency, InstructionSet instructionSet, int cacheSize)
        {
            this.manufacturer = manufacturer;
            this.series = series;
            this.model = model;
            this.numberOfCores = numberOfCores;
            this.baseFrequency = baseFrequency;
            this.maxFrequency = maxFrequency;
            this.instructionSet = instructionSet;
            this.cacheSize = cacheSize;
        }

        public override string ToString()
        {
            return $"{Manufacturer} {series} {model}; Cores {numberOfCores}; Frequency {baseFrequency}GHz - {maxFrequency}GHz; Cache {cacheSize}Mb; {instructionSet}";
        }
    }
}

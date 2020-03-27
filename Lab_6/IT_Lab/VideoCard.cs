using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5.IT_Lab
{

    [Serializable]
    public class VideoCard
    {
        private String manufacturer;
        private String series;
        private String model;
        private float frequency;
        private bool directXSupport;
        private int memorySize;

        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Series { get => series; set => series = value; }
        public string Model { get => model; set => model = value; }
        public float Frequency { get => frequency; set => frequency = value; }
        public bool DirectXSupport { get => directXSupport; set => directXSupport = value; }
        public int MemorySize { get => memorySize; set => memorySize = value; }

        public VideoCard() { }

        public VideoCard(string manufacturer, string series, string model, float frequency, bool directXSupport, int memorySize)
        {
            this.manufacturer = manufacturer;
            this.series = series;
            this.model = model;
            this.frequency = frequency;
            this.directXSupport = directXSupport;
            this.memorySize = memorySize;
        }

        public override string ToString()
        {
            return $"{manufacturer} {series} {model}; Frequency {frequency}GHz; Directx {directXSupport}; Memorysize {memorySize}GB";
        }
    }
}

using System;

namespace ConductorVerification
{
    class Program
    {
        static void Main(string[] args)
        {

            byte statusRegister = 0b0000_0100;
            ushort adcRawValue = 0x2A3C;

            double referencVoltage = 5.0;
            double measureVoltage = (adcRawValue / 65535.0) * referencVoltage;

            string logPath = @"C:\ATE_Logs\2026_Q3\Wafer_01.log";
            Console.WriteLine("===================================================================");
            Console.WriteLine($"LOG PATH\t: {logPath}");
            Console.WriteLine($"STATUS REG\t : 0x{statusRegister:X2}");
            Console.WriteLine($"ADC RAW\t\t : {adcRawValue} LSB");
            Console.WriteLine($"VOLTAGE\t\t : {measureVoltage:F4} V");
            Console.WriteLine("===================================================================");
        }
    }
}

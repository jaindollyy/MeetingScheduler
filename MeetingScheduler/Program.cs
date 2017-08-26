using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetingScheduler.Processor;
using MeetingScheduler.Processor.Bookings;
using MeetingScheduler.Processor.Entities;

namespace MeetingScheduler
{
    public class Program
    {
        public static Schedule[] schedules;
        static void Main(string[] args)
        {
            
            string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            bool InputFileFound = false;
            string[] Inputs = null;

            try
            {
                Inputs = System.IO.File.ReadAllLines(GetFilePath(true));
                InputFileFound = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input file - " + ex.Message.ToString());
                InputFileFound = false;
            }
            if (InputFileFound)
            {
                schedules= InputProcessor.Process(Inputs);

                if (schedules.Length > 0)
                {
                    WriteOutputToFile();
                    Console.WriteLine("Output file is available at " + GetFilePath(false));
                }
                else
                {
                    Console.WriteLine("No bookings found to schedule");
                }
               
            }
            Console.ReadLine();
        }

        static string GetFilePath(Boolean isInput = false)
        {
            var homePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(homePath, isInput ? Constants.InputFileName : Constants.OutputFileName);
            return filePath;
        }

        public static void WriteOutputToFile()
        {            
                string result = OutputProcessor.Process(schedules);
                if (!string.IsNullOrEmpty(result))
                {
                    string Directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                    string OutPutFile = @"" + Directory;

                    using (FileStream fs = File.OpenWrite((GetFilePath(false))))
                    {

                        Byte[] info = new UTF8Encoding(true).GetBytes(result);
                        fs.Write(info, 0, info.Length);
                        byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                        fs.Write(newline, 0, newline.Length);
                    }
                }
            }        
    }
}



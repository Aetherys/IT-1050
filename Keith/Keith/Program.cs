using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keith
{
    class Program
    {
        static void Main(string[] args)
        {
            bool started = false;
            int pid = 0;
            var process = new Process();
            string filename = "";
            

            filename = MyTTY.ReadString("Enter the name of the program you wish to run: ");
            

            ////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////   START THE PROGRAM   ////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            if (!MyTTY.ReadBool("Are you sure you want to run " + filename + " ?  Y/N "))
            {
                MyTTY.Show("Launch Scrub.");
                MyTTY.Continue();
            }

            else
            {
                process.StartInfo.FileName = filename;

                started = process.Start();

                try
                {
                    pid = process.Id;
                    Console.WriteLine("Ok, " + filename + " started with PID: " + pid);
                }

                catch (InvalidOperationException)
                {
                    started = false;
                }

                catch (Exception e)
                {
                    started = false;
                    Console.Write(e);
                }
            }

            
            ////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////   STOP THE PROGRAM   ////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////


            if (MyTTY.ReadBool("Ready to kill it now? "))  // Let me look at Task Manager...
            {
                MyTTY.Clear();
            }

            Process[] processByName = Process.GetProcessesByName(filename);
            int i = processByName.Length;

            MyTTY.Show("There are " + i + " processes with the name " + filename + ".\n");

            while (i > 0)
            {
                MyTTY.Show(processByName[i - 1].Id.ToString());
                i -= 1;
            }

            Process target;
            i = processByName.Length;

            while (i > 0)
            {
                string id = MyTTY.ReadString("Enter the PID to kill: ");

                if (id == "")
                    break;

                try
                {
                    target = Process.GetProcessById(Int32.Parse(id));
                }

                catch (Exception e)
                {
                    Console.WriteLine("Incorrect entry.");
                    Console.Write(e);
                    continue;
                }

                if (target.ProcessName == filename)
                {
                    target.Kill();
                    target.WaitForExit();
                }

                i -= 1;
            }
                
                   
        }
    }
}
using System;
using System.Diagnostics;

namespace bootable_usb
{
    class Program
    {
        static void Main(string[] args)
        {
        
          string usrinstruction="x";
          string usbdrive="";
          string isofile="";
          string yesno="";
         
            while (!usrinstruction.Equals("exit"))
            {
                Console.Clear();
                WriteHdr();
                
                usrinstruction = Console.ReadLine();
               
                  
                Console.WriteLine("Drive Information: Select carefully");
                System.Diagnostics.Process.Start("lsblk");
                
                Console.ReadLine();
                
                Console.WriteLine("Use the info above.");
                Console.WriteLine("Enter your USB drive. Example: /dev/sd{x}");
                usbdrive=Console.ReadLine(); 
                Console.WriteLine("ISO File (Full path)"); 
                isofile=Console.ReadLine(); 
                Console.WriteLine("ISO file" + isofile);
                Console.WriteLine("will overwrite USB "+ usbdrive);
                Console.WriteLine("USB drive will be overwritten, OK? (Y/y)");
                yesno=Console.ReadLine(); 
                if (yesno.Equals("Y") || yesno.Equals("y")) {
                    ProcessStartInfo info = new ProcessStartInfo("sudo", "dd bs=512k if="+isofile+" of="+usbdrive+" status=progress oflag=sync");
                    Process.Start(info);
            
                     usrinstruction="x";
                     usbdrive="";
                     isofile="";
                     yesno="";
                     Console.Read(); 
                } else {
                    usrinstruction="x";
                    usbdrive="";
                    isofile="";
                    yesno="";
                }
                
            
                
            }
       
        }

        static private void WriteHdr()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("             bootable-usb");
            Console.WriteLine("   Ctrl+C to quit  or ENTER to continue.");
            Console.WriteLine("===========================================");
        }

    }
}

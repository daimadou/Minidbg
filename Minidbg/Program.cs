using Minidbg.MinidbgShell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minidbg
{
    class Program
    {
        static void Main(string[] args)
        {
            MiniDbgShell shell = new MiniDbgShell();
            string []ags = new string[3];
            ags[0] = "run";
            ags[1] = @"E:\Test\HelloWorld\HelloWorld.exe";
            ags[2] = @"E:\Test\HelloWorld\HelloWorld";
            shell.RunCommand(ags);
            
        }
    }
}

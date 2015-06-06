using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minidbg.MinidbgShell
{
    using MinidbgEngine;
    public class MiniDbgShell
    {
        private MinidbgEngine m_MinidbgEngine;
        private Commands m_Commands;

        public MinidbgEngine Debugger
        {
            get
            {
                return m_MinidbgEngine;
            }

            set
            {
                m_MinidbgEngine = value;
            }
        }

        public void RunCommand(string []args)
        {
            string commands = args[0];
            switch(commands)
            {
                case "run":
                    m_Commands.Run(args.Skip(1).ToArray());
                    break;

                default:
                    Console.WriteLine("Can't find any things");
                    break;
            }
        }

        public MiniDbgShell()
        {
            Debugger = new MinidbgEngine();
            m_Commands = new Commands(this);
        }

        class Commands
        {
            private MiniDbgShell m_shell;

            public Commands(MiniDbgShell shell)
            {
                m_shell = shell;
            }
            public void Run(string[] args)
            {
                string appPath = args[0];
                string appArgs = args[1];
                m_shell.Debugger.CurrentProcess.CreateProcess(appPath, appArgs);
            }
        }
    }

}

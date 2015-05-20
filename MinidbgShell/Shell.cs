using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minidbg.MinidbgShell
{
    using MinidbgEngine;
    public class Shell
    {
        private MinidbgEngine m_MinidbgEngine;

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


        public void ShellInit()
        {
            Debugger = new MinidbgEngine();
        }

        class Commands
        {
            public static void Run(string[] args)
            {
                    
            }
        }
    }

}

using Microsoft.Samples.Debugging.CorDebug.NativeApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minidbg.MinidbgEngine
{
    public class MinidbgProcess
    {
        private MinidbgEngine m_engine;
        private MiniCorDebugger m_debugger;

        public MinidbgProcess(MinidbgEngine engine)
        {
            this.m_engine = engine;
            this.m_debugger = new MiniCorDebugger();
        }

        public ICorDebugProcess CreateProcess(string AppPath, string AppArgs)
        {
            return m_debugger.CreateProcess(AppPath, AppArgs);
        } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minidbg.MinidbgEngine
{
    public class MinidbgEngine
    {
        private MinidbgProcess m_MinidbgProcess;

        public MinidbgProcess CurrentProcess
        {
            get
            {
                return m_MinidbgProcess;
            }

            set
            {
                m_MinidbgProcess = value;
            }
        }
    }
}

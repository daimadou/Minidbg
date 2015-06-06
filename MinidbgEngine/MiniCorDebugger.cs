using Minidbg.raw.Utils;
using Microsoft.Samples.Debugging.CorDebug.NativeApi;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Minidbg.MinidbgEngine
{
    public class ManagedCallback : ICorDebugManagedCallback, ICorDebugManagedCallback2
    {
        // here all interface methods with nothing inside
        public void Break([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread thread)
        {
            throw new NotImplementedException();
        }

        public void Breakpoint([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugBreakpoint pBreakpoint)
        {
            throw new NotImplementedException();
        }

        public void BreakpointSetError([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugBreakpoint pBreakpoint, [In]uint dwError)
        {
            throw new NotImplementedException();
        }

        public void ChangeConnection([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In]uint dwConnectionId)
        {
            throw new NotImplementedException();
        }

        public void ControlCTrap([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess)
        {
            throw new NotImplementedException();
        }

        public void CreateAppDomain([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain)
        {
            throw new NotImplementedException();
        }

        public void CreateConnection([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In]uint dwConnectionId, [In]ref ushort pConnName)
        {
            throw new NotImplementedException();
        }

        public void CreateProcess([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess)
        {
            throw new NotImplementedException();
        }

        public void CreateThread([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread thread)
        {
            throw new NotImplementedException();
        }

        public void DebuggerError([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Error)]int errorHR, [In]uint errorCode)
        {
            throw new NotImplementedException();
        }

        public void DestroyConnection([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In]uint dwConnectionId)
        {
            throw new NotImplementedException();
        }

        public void EditAndContinueRemap([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugFunction pFunction, [In]int fAccurate)
        {
            throw new NotImplementedException();
        }

        public void EvalComplete([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugEval pEval)
        {
            throw new NotImplementedException();
        }

        public void EvalException([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugEval pEval)
        {
            throw new NotImplementedException();
        }

        public void Exception([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In]int unhandled)
        {
            throw new NotImplementedException();
        }

        public void Exception([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugFrame pFrame, [In]uint nOffset, [In]CorDebugExceptionCallbackType dwEventType, [In]uint dwFlags)
        {
            throw new NotImplementedException();
        }

        public void ExceptionUnwind([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In]CorDebugExceptionUnwindCallbackType dwEventType, [In]uint dwFlags)
        {
            throw new NotImplementedException();
        }

        public void ExitAppDomain([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain)
        {
            throw new NotImplementedException();
        }

        public void ExitProcess([In, MarshalAs(UnmanagedType.Interface)]ICorDebugProcess pProcess)
        {
            throw new NotImplementedException();
        }

        public void ExitThread([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread thread)
        {
            throw new NotImplementedException();
        }

        public void FunctionRemapComplete([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugFunction pFunction)
        {
            throw new NotImplementedException();
        }

        public void FunctionRemapOpportunity([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugFunction pOldFunction, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugFunction pNewFunction, [In]uint oldILOffset)
        {
            throw new NotImplementedException();
        }

        public void LoadAssembly([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugAssembly pAssembly)
        {
            throw new NotImplementedException();
        }

        public void LoadClass([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugClass c)
        {
            throw new NotImplementedException();
        }

        public void LoadModule([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugModule pModule)
        {
            throw new NotImplementedException();
        }

        public void LogMessage([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In]int lLevel, [In, MarshalAs(UnmanagedType.LPWStr)]string pLogSwitchName, [In, MarshalAs(UnmanagedType.LPWStr)]string pMessage)
        {
            throw new NotImplementedException();
        }

        public void LogSwitch([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In]int lLevel, [In]uint ulReason, [In, MarshalAs(UnmanagedType.LPWStr)]string pLogSwitchName, [In, MarshalAs(UnmanagedType.LPWStr)]string pParentName)
        {
            throw new NotImplementedException();
        }

        public void MDANotification([In, MarshalAs(UnmanagedType.Interface)]ICorDebugController pController, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugMDA pMDA)
        {
            throw new NotImplementedException();
        }

        public void NameChange([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread)
        {
            throw new NotImplementedException();
        }

        public void StepComplete([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugThread pThread, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugStepper pStepper, [In]CorDebugStepReason reason)
        {
            throw new NotImplementedException();
        }

        public void UnloadAssembly([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugAssembly pAssembly)
        {
            throw new NotImplementedException();
        }

        public void UnloadClass([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugClass c)
        {
            throw new NotImplementedException();
        }

        public void UnloadModule([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugModule pModule)
        {
            throw new NotImplementedException();
        }

        public void UpdateModuleSymbols([In, MarshalAs(UnmanagedType.Interface)]ICorDebugAppDomain pAppDomain, [In, MarshalAs(UnmanagedType.Interface)]ICorDebugModule pModule, [In, MarshalAs(UnmanagedType.Interface)]IStream pSymbolStream)
        {
            throw new NotImplementedException();
        }
    }
    internal class MiniCorDebugger
    {
        ICorDebug rawDebuggingAPI = null;
        public MiniCorDebugger()
        {
            CLRMetaHost mh = new CLRMetaHost();
            CLRRuntimeInfo rti = mh.GetRuntime("v4.0.30319");
            rawDebuggingAPI = rti.GetLegacyICorDebugInterface();
        }

        public ICorDebugProcess CreateProcess(string appPath, string appArgs)
        {
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();

            STARTUPINFO si = new STARTUPINFO();
            si.cb = Marshal.SizeOf(si);

            // initialize safe handles 
            si.hStdInput = new Microsoft.Win32.SafeHandles.SafeFileHandle(new IntPtr(0), false);
            si.hStdOutput = new Microsoft.Win32.SafeHandles.SafeFileHandle(new IntPtr(0), false);
            si.hStdError = new Microsoft.Win32.SafeHandles.SafeFileHandle(new IntPtr(0), false);

            ICorDebugProcess iproc = null;
            rawDebuggingAPI.Initialize();
            rawDebuggingAPI.SetManagedHandler(new ManagedCallback());
            rawDebuggingAPI.CreateProcess(appPath, appArgs, null, null, 1, 0, new System.IntPtr(0), ".", si, pi, CorDebugCreateProcessFlags.DEBUG_NO_SPECIAL_OPTIONS, out iproc);

            return iproc;
        }
    }
}
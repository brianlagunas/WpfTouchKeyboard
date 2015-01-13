using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WpfTouchKeyboard
{
    [Guid("41C81592-514C-48BD-A22E-E6AF638521A6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IInputPanelConfiguration
    {
        /// <summary>
        /// Enables a client process to opt-in to the focus tracking mechanism for Windows Store apps that controls the invoking and dismissing semantics of the touch keyboard.
        /// </summary>
        /// <returns>If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.</returns>
        int EnableFocusTracking();
    }

    [ComImport, Guid("2853ADD3-F096-4C63-A78F-7FA3EA837FB7")]
    class InputPanelConfiguration
    {
    }
}

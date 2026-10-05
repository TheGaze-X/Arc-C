using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B9 RID: 441
	// (Invoke) Token: 0x06000A25 RID: 2597
	[Token(Token = "0x20001B9")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
}

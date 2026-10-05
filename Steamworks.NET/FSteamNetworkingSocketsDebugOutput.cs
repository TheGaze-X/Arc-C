using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001D5 RID: 469
	// (Invoke) Token: 0x06000ACB RID: 2763
	[Token(Token = "0x20001D5")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FSteamNetworkingSocketsDebugOutput(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg);
}

using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200007D RID: 125
	// (Invoke) Token: 0x06000224 RID: 548
	[Token(Token = "0x200007D")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsSelectCallback(string[] acceptableIssuers);
}

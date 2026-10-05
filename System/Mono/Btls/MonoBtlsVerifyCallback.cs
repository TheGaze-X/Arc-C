using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200007C RID: 124
	// (Invoke) Token: 0x06000222 RID: 546
	[Token(Token = "0x200007C")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsVerifyCallback(MonoBtlsX509StoreCtx ctx);
}

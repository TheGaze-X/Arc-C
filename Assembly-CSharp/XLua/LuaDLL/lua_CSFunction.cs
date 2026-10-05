using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XLua.LuaDLL
{
	// Token: 0x02000308 RID: 776
	// (Invoke) Token: 0x0600381F RID: 14367
	[Token(Token = "0x2000308")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int lua_CSFunction(IntPtr L);
}

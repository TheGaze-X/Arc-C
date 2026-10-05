using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	internal static class SafeHandleCache<T> where T : System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x0600026B RID: 619 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x600026B")]
		internal static bool IsCachedInvalidHandle(System.Runtime.InteropServices.SafeHandle handle)
		{
			return default(bool);
		}

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T s_invalidHandle;
	}
}

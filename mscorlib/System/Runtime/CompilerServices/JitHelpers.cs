using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	internal static class JitHelpers
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002353")]
		internal static T UnsafeCast<T>(object o) where T : class
		{
			return null;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00014130 File Offset: 0x00012330
		[Token(Token = "0x6002354")]
		internal static int UnsafeEnumCast<T>(T val) where T : struct
		{
			return 0;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00014148 File Offset: 0x00012348
		[Token(Token = "0x6002355")]
		internal static long UnsafeEnumCastLong<T>(T val) where T : struct
		{
			return 0L;
		}
	}
}

using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	internal static class StringBuilderCache
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4F857B0", Offset = "0x4F843B0", VA = "0x184F857B0")]
		public static StringBuilder Acquire(int capacity = 16)
		{
			return null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4F85940", Offset = "0x4F84540", VA = "0x184F85940")]
		public static void Release(StringBuilder sb)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4F85890", Offset = "0x4F84490", VA = "0x184F85890")]
		public static string GetStringAndRelease(StringBuilder sb)
		{
			return null;
		}

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}

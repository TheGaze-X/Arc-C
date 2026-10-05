using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public static class ActionExtensions
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4E03610", Offset = "0x4E02210", VA = "0x184E03610")]
		private static void invoke(Delegate listener, object[] args)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4E033F0", Offset = "0x4E01FF0", VA = "0x184E033F0")]
		public static void fire(this Action handler)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		public static void fire<T>(this Action<T> handler, T param)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		public static void fire<T, U>(this Action<T, U> handler, T param1, U param2)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		public static void fire<T, U, V>(this Action<T, U, V> handler, T param1, U param2, V param3)
		{
		}
	}
}

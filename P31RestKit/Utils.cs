using System;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class Utils
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000005")]
		private static Random random
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4E16EE0", Offset = "0x4E15AE0", VA = "0x184E16EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4E170B0", Offset = "0x4E15CB0", VA = "0x184E170B0")]
		public static string randomString(int size = 38)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4E16F90", Offset = "0x4E15B90", VA = "0x184E16F90")]
		public static void logObject(object obj)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4E16FF0", Offset = "0x4E15BF0", VA = "0x184E16FF0")]
		public static void prettyPrintJson(string json)
		{
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		private static Random _random;
	}
}

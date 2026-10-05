using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	internal sealed class KeyBuilder
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700001D")]
		private static System.Security.Cryptography.RandomNumberGenerator Rng
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x4AC99A0", Offset = "0x4AC85A0", VA = "0x184AC99A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4AC9910", Offset = "0x4AC8510", VA = "0x184AC9910")]
		public static byte[] Key(int size)
		{
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4AC9880", Offset = "0x4AC8480", VA = "0x184AC9880")]
		public static byte[] IV(int size)
		{
			return null;
		}

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		private static System.Security.Cryptography.RandomNumberGenerator rng;
	}
}

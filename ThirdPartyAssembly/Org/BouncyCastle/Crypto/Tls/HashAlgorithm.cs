using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	public abstract class HashAlgorithm
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x524A0A0", Offset = "0x5248CA0", VA = "0x18524A0A0")]
		public static string GetName(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x524A1C0", Offset = "0x5248DC0", VA = "0x18524A1C0")]
		public static string GetText(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x524A320", Offset = "0x5248F20", VA = "0x18524A320")]
		public static bool IsPrivate(byte hashAlgorithm)
		{
			return default(bool);
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HashAlgorithm()
		{
		}

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		public const byte none = 0;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		public const byte md5 = 1;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		public const byte sha1 = 2;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		public const byte sha224 = 3;

		// Token: 0x04000B52 RID: 2898
		[Token(Token = "0x4000B52")]
		public const byte sha256 = 4;

		// Token: 0x04000B53 RID: 2899
		[Token(Token = "0x4000B53")]
		public const byte sha384 = 5;

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		public const byte sha512 = 6;
	}
}

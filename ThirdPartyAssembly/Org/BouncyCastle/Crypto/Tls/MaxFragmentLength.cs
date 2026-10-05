using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public abstract class MaxFragmentLength
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x524A9C0", Offset = "0x52495C0", VA = "0x18524A9C0")]
		public static bool IsValid(byte maxFragmentLength)
		{
			return default(bool);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MaxFragmentLength()
		{
		}

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		public const byte pow2_9 = 1;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		public const byte pow2_10 = 2;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		public const byte pow2_11 = 3;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		public const byte pow2_12 = 4;
	}
}

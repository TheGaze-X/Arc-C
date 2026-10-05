using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	public abstract class FiniteFieldDheGroup
	{
		// Token: 0x060014CB RID: 5323 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x524A090", Offset = "0x5248C90", VA = "0x18524A090")]
		public static bool IsValid(byte group)
		{
			return default(bool);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected FiniteFieldDheGroup()
		{
		}

		// Token: 0x04000B3A RID: 2874
		[Token(Token = "0x4000B3A")]
		public const byte ffdhe2432 = 0;

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		public const byte ffdhe3072 = 1;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		public const byte ffdhe4096 = 2;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		public const byte ffdhe6144 = 3;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		public const byte ffdhe8192 = 4;
	}
}

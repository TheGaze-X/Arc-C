using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000258 RID: 600
	[Token(Token = "0x2000258")]
	public abstract class ECBasisType
	{
		// Token: 0x060014C2 RID: 5314 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x5249FD0", Offset = "0x5248BD0", VA = "0x185249FD0")]
		public static bool IsValid(byte ecBasisType)
		{
			return default(bool);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ECBasisType()
		{
		}

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		public const byte ec_basis_trinomial = 1;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		public const byte ec_basis_pentanomial = 2;
	}
}

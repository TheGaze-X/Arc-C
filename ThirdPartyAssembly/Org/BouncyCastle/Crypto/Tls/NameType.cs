using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public abstract class NameType
	{
		// Token: 0x060014E8 RID: 5352 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x524A9D0", Offset = "0x52495D0", VA = "0x18524A9D0")]
		public static bool IsValid(byte nameType)
		{
			return default(bool);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected NameType()
		{
		}

		// Token: 0x04000BA3 RID: 2979
		[Token(Token = "0x4000BA3")]
		public const byte host_name = 0;
	}
}

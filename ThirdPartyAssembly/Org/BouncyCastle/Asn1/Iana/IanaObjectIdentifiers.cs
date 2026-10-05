using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Iana
{
	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	public abstract class IanaObjectIdentifiers
	{
		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IanaObjectIdentifiers()
		{
		}

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier IsakmpOakley;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier HmacMD5;

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier HmacSha1;

		// Token: 0x04001452 RID: 5202
		[Token(Token = "0x4001452")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier HmacTiger;

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier HmacRipeMD160;
	}
}

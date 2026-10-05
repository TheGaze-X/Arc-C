using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x0200045E RID: 1118
	[Token(Token = "0x200045E")]
	public class OcspResponseStatus : DerEnumerated
	{
		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x536DF50", Offset = "0x536CB50", VA = "0x18536DF50")]
		public OcspResponseStatus(int value)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x536DED0", Offset = "0x536CAD0", VA = "0x18536DED0")]
		public OcspResponseStatus(DerEnumerated value)
		{
		}

		// Token: 0x040013F3 RID: 5107
		[Token(Token = "0x40013F3")]
		public const int Successful = 0;

		// Token: 0x040013F4 RID: 5108
		[Token(Token = "0x40013F4")]
		public const int MalformedRequest = 1;

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		public const int InternalError = 2;

		// Token: 0x040013F6 RID: 5110
		[Token(Token = "0x40013F6")]
		public const int TryLater = 3;

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		public const int SignatureRequired = 5;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		public const int Unauthorized = 6;
	}
}

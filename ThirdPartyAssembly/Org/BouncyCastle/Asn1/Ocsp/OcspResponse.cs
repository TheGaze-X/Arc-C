using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	public class OcspResponse : Asn1Encodable
	{
		// Token: 0x060023CF RID: 9167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x536DFB0", Offset = "0x536CBB0", VA = "0x18536DFB0")]
		public static OcspResponse GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x536DFD0", Offset = "0x536CBD0", VA = "0x18536DFD0")]
		public static OcspResponse GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x536E3E0", Offset = "0x536CFE0", VA = "0x18536E3E0")]
		public OcspResponse(OcspResponseStatus responseStatus, ResponseBytes responseBytes)
		{
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x536E490", Offset = "0x536D090", VA = "0x18536E490")]
		private OcspResponse(Asn1Sequence seq)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B7")]
		public OcspResponseStatus ResponseStatus
		{
			[Token(Token = "0x60023D3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B8")]
		public ResponseBytes ResponseBytes
		{
			[Token(Token = "0x60023D4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x536E210", Offset = "0x536CE10", VA = "0x18536E210", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013F1 RID: 5105
		[Token(Token = "0x40013F1")]
		[FieldOffset(Offset = "0x10")]
		private readonly OcspResponseStatus responseStatus;

		// Token: 0x040013F2 RID: 5106
		[Token(Token = "0x40013F2")]
		[FieldOffset(Offset = "0x18")]
		private readonly ResponseBytes responseBytes;
	}
}

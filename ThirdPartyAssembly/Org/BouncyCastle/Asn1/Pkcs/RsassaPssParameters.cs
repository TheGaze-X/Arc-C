using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	public class RsassaPssParameters : Asn1Encodable
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x53731D0", Offset = "0x5371DD0", VA = "0x1853731D0")]
		public static RsassaPssParameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x5373EC0", Offset = "0x5372AC0", VA = "0x185373EC0")]
		public RsassaPssParameters()
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x514ABB0", Offset = "0x51497B0", VA = "0x18514ABB0")]
		public RsassaPssParameters(AlgorithmIdentifier hashAlgorithm, AlgorithmIdentifier maskGenAlgorithm, DerInteger saltLength, DerInteger trailerField)
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x5373BD0", Offset = "0x53727D0", VA = "0x185373BD0")]
		public RsassaPssParameters(Asn1Sequence seq)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060023B8 RID: 9144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AB")]
		public AlgorithmIdentifier HashAlgorithm
		{
			[Token(Token = "0x60023B8")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060023B9 RID: 9145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AC")]
		public AlgorithmIdentifier MaskGenAlgorithm
		{
			[Token(Token = "0x60023B9")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		public DerInteger SaltLength
		{
			[Token(Token = "0x60023BA")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060023BB RID: 9147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AE")]
		public DerInteger TrailerField
		{
			[Token(Token = "0x60023BB")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x5373410", Offset = "0x5372010", VA = "0x185373410", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013D5 RID: 5077
		[Token(Token = "0x40013D5")]
		[FieldOffset(Offset = "0x10")]
		private AlgorithmIdentifier hashAlgorithm;

		// Token: 0x040013D6 RID: 5078
		[Token(Token = "0x40013D6")]
		[FieldOffset(Offset = "0x18")]
		private AlgorithmIdentifier maskGenAlgorithm;

		// Token: 0x040013D7 RID: 5079
		[Token(Token = "0x40013D7")]
		[FieldOffset(Offset = "0x20")]
		private DerInteger saltLength;

		// Token: 0x040013D8 RID: 5080
		[Token(Token = "0x40013D8")]
		[FieldOffset(Offset = "0x28")]
		private DerInteger trailerField;

		// Token: 0x040013D9 RID: 5081
		[Token(Token = "0x40013D9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AlgorithmIdentifier DefaultHashAlgorithm;

		// Token: 0x040013DA RID: 5082
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AlgorithmIdentifier DefaultMaskGenFunction;

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerInteger DefaultSaltLength;

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerInteger DefaultTrailerField;
	}
}

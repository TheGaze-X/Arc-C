using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A8 RID: 936
	[Token(Token = "0x20003A8")]
	public class BerSequence : DerSequence
	{
		// Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB7")]
		[Address(RVA = "0x5317EA0", Offset = "0x5316AA0", VA = "0x185317EA0")]
		public new static BerSequence FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB8")]
		[Address(RVA = "0x53180C0", Offset = "0x5316CC0", VA = "0x1853180C0")]
		public BerSequence()
		{
		}

		// Token: 0x06001FB9 RID: 8121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB9")]
		[Address(RVA = "0x5318060", Offset = "0x5316C60", VA = "0x185318060")]
		public BerSequence(Asn1Encodable obj)
		{
		}

		// Token: 0x06001FBA RID: 8122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBA")]
		[Address(RVA = "0x5318110", Offset = "0x5316D10", VA = "0x185318110")]
		public BerSequence(params Asn1Encodable[] v)
		{
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBB")]
		[Address(RVA = "0x5318170", Offset = "0x5316D70", VA = "0x185318170")]
		public BerSequence(Asn1EncodableVector v)
		{
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FBC")]
		[Address(RVA = "0x5317A70", Offset = "0x5316670", VA = "0x185317A70", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly BerSequence Empty;
	}
}

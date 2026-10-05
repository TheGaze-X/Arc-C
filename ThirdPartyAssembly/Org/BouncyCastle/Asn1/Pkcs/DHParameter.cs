using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	public class DHParameter : Asn1Encodable
	{
		// Token: 0x060023AC RID: 9132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x53610B0", Offset = "0x535FCB0", VA = "0x1853610B0")]
		public DHParameter(BigInteger p, BigInteger g, int l)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x53611C0", Offset = "0x535FDC0", VA = "0x1853611C0")]
		public DHParameter(Asn1Sequence seq)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public BigInteger P
		{
			[Token(Token = "0x60023AE")]
			[Address(RVA = "0x53615E0", Offset = "0x53601E0", VA = "0x1853615E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A9")]
		public BigInteger G
		{
			[Token(Token = "0x60023AF")]
			[Address(RVA = "0x53615A0", Offset = "0x53601A0", VA = "0x1853615A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		public BigInteger L
		{
			[Token(Token = "0x60023B0")]
			[Address(RVA = "0x53615C0", Offset = "0x53601C0", VA = "0x1853615C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x5360ED0", Offset = "0x535FAD0", VA = "0x185360ED0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400134B RID: 4939
		[Token(Token = "0x400134B")]
		[FieldOffset(Offset = "0x10")]
		internal DerInteger p;

		// Token: 0x0400134C RID: 4940
		[Token(Token = "0x400134C")]
		[FieldOffset(Offset = "0x18")]
		internal DerInteger g;

		// Token: 0x0400134D RID: 4941
		[Token(Token = "0x400134D")]
		[FieldOffset(Offset = "0x20")]
		internal DerInteger l;
	}
}

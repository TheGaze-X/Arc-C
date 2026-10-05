using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public class X9ECPoint : Asn1Encodable
	{
		// Token: 0x060021B9 RID: 8633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x53547B0", Offset = "0x53533B0", VA = "0x1853547B0")]
		public X9ECPoint(ECPoint p)
		{
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x53546B0", Offset = "0x53532B0", VA = "0x1853546B0")]
		public X9ECPoint(ECPoint p, bool compressed)
		{
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x5354910", Offset = "0x5353510", VA = "0x185354910")]
		public X9ECPoint(ECCurve c, byte[] encoding)
		{
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x53548A0", Offset = "0x53534A0", VA = "0x1853548A0")]
		public X9ECPoint(ECCurve c, Asn1OctetString s)
		{
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x5354660", Offset = "0x5353260", VA = "0x185354660")]
		public byte[] GetPointEncoding()
		{
			return null;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		public ECPoint Point
		{
			[Token(Token = "0x60021BE")]
			[Address(RVA = "0x5354A30", Offset = "0x5353630", VA = "0x185354A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0000F768 File Offset: 0x0000D968
		[Token(Token = "0x17000455")]
		public bool IsPointCompressed
		{
			[Token(Token = "0x60021BF")]
			[Address(RVA = "0x53549B0", Offset = "0x53535B0", VA = "0x1853549B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001187 RID: 4487
		[Token(Token = "0x4001187")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1OctetString encoding;

		// Token: 0x04001188 RID: 4488
		[Token(Token = "0x4001188")]
		[FieldOffset(Offset = "0x18")]
		private ECCurve c;

		// Token: 0x04001189 RID: 4489
		[Token(Token = "0x4001189")]
		[FieldOffset(Offset = "0x20")]
		private ECPoint p;
	}
}

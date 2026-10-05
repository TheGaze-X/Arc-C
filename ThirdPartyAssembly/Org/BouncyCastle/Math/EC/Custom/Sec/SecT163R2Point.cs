using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	internal class SecT163R2Point : AbstractF2mPoint
	{
		// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x520C650", Offset = "0x520B250", VA = "0x18520C650")]
		public SecT163R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x520C6F0", Offset = "0x520B2F0", VA = "0x18520C6F0")]
		public SecT163R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT163R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x520B8A0", Offset = "0x520A4A0", VA = "0x18520B8A0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E9")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x170001EA")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x520B040", Offset = "0x5209C40", VA = "0x18520B040", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x520C1A0", Offset = "0x520ADA0", VA = "0x18520C1A0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x520BBD0", Offset = "0x520A7D0", VA = "0x18520BBD0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x520B9E0", Offset = "0x520A5E0", VA = "0x18520B9E0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

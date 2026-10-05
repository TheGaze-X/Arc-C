using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	internal class SecT163K1Point : AbstractF2mPoint
	{
		// Token: 0x06000F9E RID: 3998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x5208E30", Offset = "0x5207A30", VA = "0x185208E30")]
		public SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x5208D90", Offset = "0x5207990", VA = "0x185208D90")]
		public SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT163K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x5207FE0", Offset = "0x5206BE0", VA = "0x185207FE0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D5")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x170001D6")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x52077B0", Offset = "0x52063B0", VA = "0x1852077B0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x52088D0", Offset = "0x52074D0", VA = "0x1852088D0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x5208310", Offset = "0x5206F10", VA = "0x185208310", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x5208120", Offset = "0x5206D20", VA = "0x185208120", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

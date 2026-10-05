using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	internal class SecT233R1Point : AbstractF2mPoint
	{
		// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001097")]
		[Address(RVA = "0x5218B40", Offset = "0x5217740", VA = "0x185218B40")]
		public SecT233R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x5218AA0", Offset = "0x52176A0", VA = "0x185218AA0")]
		public SecT233R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT233R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x5217CF0", Offset = "0x52168F0", VA = "0x185217CF0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000223")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x17000224")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x600109C")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x5217490", Offset = "0x5216090", VA = "0x185217490", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x52185F0", Offset = "0x52171F0", VA = "0x1852185F0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x5218020", Offset = "0x5216C20", VA = "0x185218020", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x5217E30", Offset = "0x5216A30", VA = "0x185217E30", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

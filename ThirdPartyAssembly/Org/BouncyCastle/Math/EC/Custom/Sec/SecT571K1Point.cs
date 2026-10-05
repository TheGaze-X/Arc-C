using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000200 RID: 512
	[Token(Token = "0x2000200")]
	internal class SecT571K1Point : AbstractF2mPoint
	{
		// Token: 0x060011FD RID: 4605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x5237950", Offset = "0x5236550", VA = "0x185237950")]
		public SecT571K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x52379F0", Offset = "0x52365F0", VA = "0x1852379F0")]
		public SecT571K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT571K1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x5236BA0", Offset = "0x52357A0", VA = "0x185236BA0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000283")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x6001201")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x17000284")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x5236370", Offset = "0x5234F70", VA = "0x185236370", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x5237480", Offset = "0x5236080", VA = "0x185237480", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x5236ED0", Offset = "0x5235AD0", VA = "0x185236ED0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x5236CE0", Offset = "0x52358E0", VA = "0x185236CE0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

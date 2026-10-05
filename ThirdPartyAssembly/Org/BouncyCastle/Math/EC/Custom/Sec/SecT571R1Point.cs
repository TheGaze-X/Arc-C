using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	internal class SecT571R1Point : AbstractF2mPoint
	{
		// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x5239760", Offset = "0x5238360", VA = "0x185239760")]
		public SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x5239800", Offset = "0x5238400", VA = "0x185239800")]
		public SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecT571R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x52389A0", Offset = "0x52375A0", VA = "0x1852389A0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028D")]
		public override ECFieldElement YCoord
		{
			[Token(Token = "0x600121A")]
			[Address(RVA = "0x51FC6F0", Offset = "0x51FB2F0", VA = "0x1851FC6F0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x1700028E")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x600121B")]
			[Address(RVA = "0x51FC620", Offset = "0x51FB220", VA = "0x1851FC620", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x5238140", Offset = "0x5236D40", VA = "0x185238140", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121D")]
		[Address(RVA = "0x52392B0", Offset = "0x5237EB0", VA = "0x1852392B0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121E")]
		[Address(RVA = "0x5238CD0", Offset = "0x52378D0", VA = "0x185238CD0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121F")]
		[Address(RVA = "0x5238AE0", Offset = "0x52376E0", VA = "0x185238AE0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

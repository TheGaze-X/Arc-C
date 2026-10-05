using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	internal class SecP224R1Point : AbstractFpPoint
	{
		// Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x51E8430", Offset = "0x51E7030", VA = "0x1851E8430")]
		public SecP224R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x51E8370", Offset = "0x51E6F70", VA = "0x1851E8370")]
		public SecP224R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP224R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x51E78B0", Offset = "0x51E64B0", VA = "0x1851E78B0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x51E71D0", Offset = "0x51E5DD0", VA = "0x1851E71D0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x51E7CD0", Offset = "0x51E68D0", VA = "0x1851E7CD0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x51E79F0", Offset = "0x51E65F0", VA = "0x1851E79F0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

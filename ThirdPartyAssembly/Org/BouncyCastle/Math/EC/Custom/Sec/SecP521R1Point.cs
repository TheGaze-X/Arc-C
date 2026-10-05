using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	internal class SecP521R1Point : AbstractFpPoint
	{
		// Token: 0x06000E8A RID: 3722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x51F7D70", Offset = "0x51F6970", VA = "0x1851F7D70")]
		public SecP521R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x51F7CD0", Offset = "0x51F68D0", VA = "0x1851F7CD0")]
		public SecP521R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP521R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x51F7160", Offset = "0x51F5D60", VA = "0x1851F7160", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x51F6810", Offset = "0x51F5410", VA = "0x1851F6810", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x51F73D0", Offset = "0x51F5FD0", VA = "0x1851F73D0", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E91")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E92")]
		[Address(RVA = "0x51F72A0", Offset = "0x51F5EA0", VA = "0x1851F72A0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	internal class SecP160R1Point : AbstractFpPoint
	{
		// Token: 0x06000C6C RID: 3180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x54C01F0", Offset = "0x54BEDF0", VA = "0x1854C01F0")]
		public SecP160R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x54C0290", Offset = "0x54BEE90", VA = "0x1854C0290")]
		public SecP160R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP160R1Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x54BF7A0", Offset = "0x54BE3A0", VA = "0x1854BF7A0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x54BEF60", Offset = "0x54BDB60", VA = "0x1854BEF60", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x54BFA10", Offset = "0x54BE610", VA = "0x1854BFA10", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x54BF8E0", Offset = "0x54BE4E0", VA = "0x1854BF8E0", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

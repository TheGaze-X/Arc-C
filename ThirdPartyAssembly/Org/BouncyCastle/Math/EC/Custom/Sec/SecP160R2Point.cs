using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	internal class SecP160R2Point : AbstractFpPoint
	{
		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x54C3C30", Offset = "0x54C2830", VA = "0x1854C3C30")]
		public SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y)
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x54C3B90", Offset = "0x54C2790", VA = "0x1854C3B90")]
		public SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x51E8410", Offset = "0x51E7010", VA = "0x1851E8410")]
		internal SecP160R2Point(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x54C31E0", Offset = "0x54C1DE0", VA = "0x1854C31E0", Slot = "6")]
		protected override ECPoint Detach()
		{
			return null;
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x54C2AA0", Offset = "0x54C16A0", VA = "0x1854C2AA0", Slot = "27")]
		public override ECPoint Add(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x54C3450", Offset = "0x54C2050", VA = "0x1854C3450", Slot = "31")]
		public override ECPoint Twice()
		{
			return null;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x51E7BF0", Offset = "0x51E67F0", VA = "0x1851E7BF0", Slot = "33")]
		public override ECPoint TwicePlus(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x51E7B20", Offset = "0x51E6720", VA = "0x1851E7B20", Slot = "34")]
		public override ECPoint ThreeTimes()
		{
			return null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x54C3320", Offset = "0x54C1F20", VA = "0x1854C3320", Slot = "29")]
		public override ECPoint Negate()
		{
			return null;
		}
	}
}

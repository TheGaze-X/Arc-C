using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	public abstract class AbstractF2mPoint : ECPointBase
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x5498520", Offset = "0x5497120", VA = "0x185498520")]
		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x5498500", Offset = "0x5497100", VA = "0x185498500")]
		protected AbstractF2mPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x5497300", Offset = "0x5495F00", VA = "0x185497300", Slot = "4")]
		protected override bool SatisfiesCurveEquation()
		{
			return default(bool);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x54978D0", Offset = "0x54964D0", VA = "0x1854978D0", Slot = "21")]
		public override ECPoint ScaleX(ECFieldElement scale)
		{
			return null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x5497CA0", Offset = "0x54968A0", VA = "0x185497CA0", Slot = "22")]
		public override ECPoint ScaleY(ECFieldElement scale)
		{
			return null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x5497EE0", Offset = "0x5496AE0", VA = "0x185497EE0", Slot = "28")]
		public override ECPoint Subtract(ECPoint b)
		{
			return null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x5498250", Offset = "0x5496E50", VA = "0x185498250", Slot = "35")]
		public virtual AbstractF2mPoint Tau()
		{
			return null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x5497F80", Offset = "0x5496B80", VA = "0x185497F80", Slot = "36")]
		public virtual AbstractF2mPoint TauPow(int pow)
		{
			return null;
		}
	}
}

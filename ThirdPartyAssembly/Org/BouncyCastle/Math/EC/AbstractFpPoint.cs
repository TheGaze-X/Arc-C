using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public abstract class AbstractFpPoint : ECPointBase
	{
		// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x5498520", Offset = "0x5497120", VA = "0x185498520")]
		protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, bool withCompression)
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x5498500", Offset = "0x5497100", VA = "0x185498500")]
		protected AbstractFpPoint(ECCurve curve, ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x17000125")]
		protected internal override bool CompressionYTilde
		{
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x5498F90", Offset = "0x5497B90", VA = "0x185498F90", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x5498A90", Offset = "0x5497690", VA = "0x185498A90", Slot = "4")]
		protected override bool SatisfiesCurveEquation()
		{
			return default(bool);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5497EE0", Offset = "0x5496AE0", VA = "0x185497EE0", Slot = "28")]
		public override ECPoint Subtract(ECPoint b)
		{
			return null;
		}
	}
}

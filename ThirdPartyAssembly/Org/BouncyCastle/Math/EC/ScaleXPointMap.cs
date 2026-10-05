using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public class ScaleXPointMap : ECPointMap
	{
		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public ScaleXPointMap(ECFieldElement scale)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x54B70A0", Offset = "0x54B5CA0", VA = "0x1854B70A0", Slot = "5")]
		public virtual ECPoint Map(ECPoint p)
		{
			return null;
		}

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ECFieldElement scale;
	}
}

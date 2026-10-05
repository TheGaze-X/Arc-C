using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Endo;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	public class GlvMultiplier : AbstractECMultiplier
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x54B6970", Offset = "0x54B5570", VA = "0x1854B6970")]
		public GlvMultiplier(ECCurve curve, GlvEndomorphism glvEndomorphism)
		{
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x54B6560", Offset = "0x54B5160", VA = "0x1854B6560", Slot = "6")]
		protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ECCurve curve;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x18")]
		protected readonly GlvEndomorphism glvEndomorphism;
	}
}

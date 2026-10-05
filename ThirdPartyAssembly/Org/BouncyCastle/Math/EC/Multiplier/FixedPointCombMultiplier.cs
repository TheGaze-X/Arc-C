using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000191 RID: 401
	[Token(Token = "0x2000191")]
	public class FixedPointCombMultiplier : AbstractECMultiplier
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x54B59D0", Offset = "0x54B45D0", VA = "0x1854B59D0", Slot = "6")]
		protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x54B59C0", Offset = "0x54B45C0", VA = "0x1854B59C0", Slot = "7")]
		protected virtual int GetWidthForCombSize(int combSize)
		{
			return 0;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FixedPointCombMultiplier()
		{
		}
	}
}

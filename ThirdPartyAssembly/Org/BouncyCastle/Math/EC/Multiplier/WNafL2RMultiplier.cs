using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public class WNafL2RMultiplier : AbstractECMultiplier
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x54D11B0", Offset = "0x54CFDB0", VA = "0x1854D11B0", Slot = "6")]
		protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x54D10F0", Offset = "0x54CFCF0", VA = "0x1854D10F0", Slot = "7")]
		protected virtual int GetWindowSize(int bits)
		{
			return 0;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WNafL2RMultiplier()
		{
		}
	}
}

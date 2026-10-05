using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Abc;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public class WTauNafMultiplier : AbstractECMultiplier
	{
		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x54D4080", Offset = "0x54D2C80", VA = "0x1854D4080", Slot = "6")]
		protected override ECPoint MultiplyPositive(ECPoint point, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x54D4520", Offset = "0x54D3120", VA = "0x1854D4520")]
		private AbstractF2mPoint MultiplyWTnaf(AbstractF2mPoint p, ZTauElement lambda, PreCompInfo preCompInfo, sbyte a, sbyte mu)
		{
			return null;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x54D3940", Offset = "0x54D2540", VA = "0x1854D3940")]
		private static AbstractF2mPoint MultiplyFromWTnaf(AbstractF2mPoint p, sbyte[] u, PreCompInfo preCompInfo)
		{
			return null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WTauNafMultiplier()
		{
		}

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly string PRECOMP_NAME;
	}
}

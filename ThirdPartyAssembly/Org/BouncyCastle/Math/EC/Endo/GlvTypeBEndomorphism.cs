using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	public class GlvTypeBEndomorphism : GlvEndomorphism, ECEndomorphism
	{
		// Token: 0x06000BDD RID: 3037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x54B6ED0", Offset = "0x54B5AD0", VA = "0x1854B6ED0")]
		public GlvTypeBEndomorphism(ECCurve curve, GlvTypeBParameters parameters)
		{
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x54B6B60", Offset = "0x54B5760", VA = "0x1854B6B60", Slot = "7")]
		public virtual BigInteger[] DecomposeScalar(BigInteger k)
		{
			return null;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		public virtual ECPointMap PointMap
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x17000132")]
		public virtual bool HasEfficientPointMap
		{
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x54B6A50", Offset = "0x54B5650", VA = "0x1854B6A50", Slot = "10")]
		protected virtual BigInteger CalculateB(BigInteger k, BigInteger g, int t)
		{
			return null;
		}

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0x10")]
		protected readonly ECCurve m_curve;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0x18")]
		protected readonly GlvTypeBParameters m_parameters;

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x20")]
		protected readonly ECPointMap m_pointMap;
	}
}

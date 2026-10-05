using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	public class FixedPointPreCompInfo : PreCompInfo
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000129")]
		public virtual ECPoint[] PreComp
		{
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x00007B78 File Offset: 0x00005D78
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012A")]
		public virtual int Width
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BAE")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x5A4AB0", Offset = "0x5A36B0", VA = "0x1805A4AB0")]
		public FixedPointPreCompInfo()
		{
		}

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x10")]
		protected ECPoint[] m_preComp;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x18")]
		protected int m_width;
	}
}

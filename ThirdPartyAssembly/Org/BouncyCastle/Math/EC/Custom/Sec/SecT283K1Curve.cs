using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F3 RID: 499
	[Token(Token = "0x20001F3")]
	internal class SecT283K1Curve : AbstractF2mCurve
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x5228CD0", Offset = "0x52278D0", VA = "0x185228CD0")]
		public SecT283K1Curve()
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x5228A20", Offset = "0x5227620", VA = "0x185228A20", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x5228A70", Offset = "0x5227670", VA = "0x185228A70", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000241")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6001127")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x17000242")]
		public override int FieldSize
		{
			[Token(Token = "0x6001128")]
			[Address(RVA = "0x52289F0", Offset = "0x52275F0", VA = "0x1852289F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x5228C70", Offset = "0x5227870", VA = "0x185228C70", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x5228AC0", Offset = "0x52276C0", VA = "0x185228AC0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x5228BC0", Offset = "0x52277C0", VA = "0x185228BC0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x17000243")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x600112C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00009A80 File Offset: 0x00007C80
		[Token(Token = "0x17000244")]
		public virtual int M
		{
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x52289F0", Offset = "0x52275F0", VA = "0x1852289F0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x17000245")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x17000246")]
		public virtual int K1
		{
			[Token(Token = "0x600112F")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x17000247")]
		public virtual int K2
		{
			[Token(Token = "0x6001130")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x17000248")]
		public virtual int K3
		{
			[Token(Token = "0x6001131")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		private const int SecT283K1_DEFAULT_COORDS = 6;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT283K1Point m_infinity;
	}
}

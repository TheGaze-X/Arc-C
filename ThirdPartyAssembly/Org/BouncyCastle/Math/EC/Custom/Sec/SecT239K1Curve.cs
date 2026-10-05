using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001EF RID: 495
	[Token(Token = "0x20001EF")]
	internal class SecT239K1Curve : AbstractF2mCurve
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x521B710", Offset = "0x521A310", VA = "0x18521B710")]
		public SecT239K1Curve()
		{
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x521B370", Offset = "0x5219F70", VA = "0x18521B370", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x521B3C0", Offset = "0x5219FC0", VA = "0x18521B3C0", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700022E")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x1700022F")]
		public override int FieldSize
		{
			[Token(Token = "0x60010DA")]
			[Address(RVA = "0x5219CD0", Offset = "0x52188D0", VA = "0x185219CD0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x521B5C0", Offset = "0x521A1C0", VA = "0x18521B5C0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x521B410", Offset = "0x521A010", VA = "0x18521B410", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x521B510", Offset = "0x521A110", VA = "0x18521B510", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x17000230")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x60010DE")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x17000231")]
		public virtual int M
		{
			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x5219CD0", Offset = "0x52188D0", VA = "0x185219CD0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x17000232")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x17000233")]
		public virtual int K1
		{
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x5219CE0", Offset = "0x52188E0", VA = "0x185219CE0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x17000234")]
		public virtual int K2
		{
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x17000235")]
		public virtual int K3
		{
			[Token(Token = "0x60010E3")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		private const int SecT239K1_DEFAULT_COORDS = 6;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT239K1Point m_infinity;
	}
}

using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	internal class SecT113R2Curve : AbstractF2mCurve
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x51FCAB0", Offset = "0x51FB6B0", VA = "0x1851FCAB0")]
		public SecT113R2Curve()
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x51FC850", Offset = "0x51FB450", VA = "0x1851FC850", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019D")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x1700019E")]
		public override int FieldSize
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x51F9150", Offset = "0x51F7D50", VA = "0x1851F9150", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x51FCA50", Offset = "0x51FB650", VA = "0x1851FCA50", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x51FC950", Offset = "0x51FB550", VA = "0x1851FC950", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EE6")]
		[Address(RVA = "0x51FC8A0", Offset = "0x51FB4A0", VA = "0x1851FC8A0", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x1700019F")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x170001A0")]
		public virtual int M
		{
			[Token(Token = "0x6000EE8")]
			[Address(RVA = "0x51F9150", Offset = "0x51F7D50", VA = "0x1851F9150", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x170001A1")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x170001A2")]
		public virtual int K1
		{
			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x54AFD0", Offset = "0x549BD0", VA = "0x18054AFD0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000EEB RID: 3819 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x170001A3")]
		public virtual int K2
		{
			[Token(Token = "0x6000EEB")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000EEC RID: 3820 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x170001A4")]
		public virtual int K3
		{
			[Token(Token = "0x6000EEC")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x40008F4")]
		private const int SecT113R2_DEFAULT_COORDS = 6;

		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT113R2Point m_infinity;
	}
}

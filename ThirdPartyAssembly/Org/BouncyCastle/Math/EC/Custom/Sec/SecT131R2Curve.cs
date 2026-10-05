using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	internal class SecT131R2Curve : AbstractF2mCurve
	{
		// Token: 0x06000F43 RID: 3907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x5202F90", Offset = "0x5201B90", VA = "0x185202F90")]
		public SecT131R2Curve()
		{
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x5202D30", Offset = "0x5201930", VA = "0x185202D30", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x170001BA")]
		public override int FieldSize
		{
			[Token(Token = "0x6000F46")]
			[Address(RVA = "0x51FF920", Offset = "0x51FE520", VA = "0x1851FF920", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x5202F30", Offset = "0x5201B30", VA = "0x185202F30", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x5202D80", Offset = "0x5201980", VA = "0x185202D80", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x5202E80", Offset = "0x5201A80", VA = "0x185202E80", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000F4A RID: 3914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x170001BC")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000F4C RID: 3916 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x170001BD")]
		public virtual int M
		{
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x51FF920", Offset = "0x51FE520", VA = "0x1851FF920", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x170001BE")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000F4D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x170001BF")]
		public virtual int K1
		{
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x170001C0")]
		public virtual int K2
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x170001C1")]
		public virtual int K3
		{
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040008FC RID: 2300
		[Token(Token = "0x40008FC")]
		private const int SecT131R2_DEFAULT_COORDS = 6;

		// Token: 0x040008FD RID: 2301
		[Token(Token = "0x40008FD")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT131R2Point m_infinity;
	}
}

using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	internal class SecT571K1Curve : AbstractF2mCurve
	{
		// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x5236170", Offset = "0x5234D70", VA = "0x185236170")]
		public SecT571K1Curve()
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x5235EC0", Offset = "0x5234AC0", VA = "0x185235EC0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x5235F10", Offset = "0x5234B10", VA = "0x185235F10", Slot = "15")]
		protected override ECMultiplier CreateDefaultMultiplier()
		{
			return null;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x60011F2")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x1700027C")]
		public override int FieldSize
		{
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x5233FC0", Offset = "0x5232BC0", VA = "0x185233FC0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x5236110", Offset = "0x5234D10", VA = "0x185236110", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x5236010", Offset = "0x5234C10", VA = "0x185236010", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x5235F60", Offset = "0x5234B60", VA = "0x185235F60", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x1700027D")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x60011F7")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x1700027E")]
		public virtual int M
		{
			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x5233FC0", Offset = "0x5232BC0", VA = "0x185233FC0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x1700027F")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x17000280")]
		public virtual int K1
		{
			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x17000281")]
		public virtual int K2
		{
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x17000282")]
		public virtual int K3
		{
			[Token(Token = "0x60011FC")]
			[Address(RVA = "0x2114980", Offset = "0x2113580", VA = "0x182114980", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		private const int SecT571K1_DEFAULT_COORDS = 6;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT571K1Point m_infinity;
	}
}

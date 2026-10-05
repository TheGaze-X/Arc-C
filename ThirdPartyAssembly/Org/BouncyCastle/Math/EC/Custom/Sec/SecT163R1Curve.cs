using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	internal class SecT163R1Curve : AbstractF2mCurve
	{
		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x5209130", Offset = "0x5207D30", VA = "0x185209130")]
		public SecT163R1Curve()
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x5208ED0", Offset = "0x5207AD0", VA = "0x185208ED0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D7")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x170001D8")]
		public override int FieldSize
		{
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x52090D0", Offset = "0x5207CD0", VA = "0x1852090D0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x5208FD0", Offset = "0x5207BD0", VA = "0x185208FD0", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x5208F20", Offset = "0x5207B20", VA = "0x185208F20", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x170001D9")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x170001DA")]
		public virtual int M
		{
			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x5205D30", Offset = "0x5204930", VA = "0x185205D30", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x170001DB")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x170001DC")]
		public virtual int K1
		{
			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x170001DD")]
		public virtual int K2
		{
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x170001DE")]
		public virtual int K3
		{
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000904 RID: 2308
		[Token(Token = "0x4000904")]
		private const int SecT163R1_DEFAULT_COORDS = 6;

		// Token: 0x04000905 RID: 2309
		[Token(Token = "0x4000905")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT163R1Point m_infinity;
	}
}

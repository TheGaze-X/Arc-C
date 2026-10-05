using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020001F5 RID: 501
	[Token(Token = "0x20001F5")]
	internal class SecT283R1Curve : AbstractF2mCurve
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x522A840", Offset = "0x5229440", VA = "0x18522A840")]
		public SecT283R1Curve()
		{
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x522A5E0", Offset = "0x52291E0", VA = "0x18522A5E0", Slot = "12")]
		protected override ECCurve CloneCurve()
		{
			return null;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x51FABA0", Offset = "0x51F97A0", VA = "0x1851FABA0", Slot = "16")]
		public override bool SupportsCoordinateSystem(int coord)
		{
			return default(bool);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024B")]
		public override ECPoint Infinity
		{
			[Token(Token = "0x600113F")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x1700024C")]
		public override int FieldSize
		{
			[Token(Token = "0x6001140")]
			[Address(RVA = "0x52289F0", Offset = "0x52275F0", VA = "0x1852289F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x522A7E0", Offset = "0x52293E0", VA = "0x18522A7E0", Slot = "5")]
		public override ECFieldElement FromBigInteger(BigInteger x)
		{
			return null;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x522A630", Offset = "0x5229230", VA = "0x18522A630", Slot = "13")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, bool withCompression)
		{
			return null;
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x522A730", Offset = "0x5229330", VA = "0x18522A730", Slot = "14")]
		protected internal override ECPoint CreateRawPoint(ECFieldElement x, ECFieldElement y, ECFieldElement[] zs, bool withCompression)
		{
			return null;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001144 RID: 4420 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x1700024D")]
		public override bool IsKoblitz
		{
			[Token(Token = "0x6001144")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x1700024E")]
		public virtual int M
		{
			[Token(Token = "0x6001145")]
			[Address(RVA = "0x52289F0", Offset = "0x52275F0", VA = "0x1852289F0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x1700024F")]
		public virtual bool IsTrinomial
		{
			[Token(Token = "0x6001146")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x17000250")]
		public virtual int K1
		{
			[Token(Token = "0x6001147")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x17000251")]
		public virtual int K2
		{
			[Token(Token = "0x6001148")]
			[Address(RVA = "0x54AC30", Offset = "0x549830", VA = "0x18054AC30", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x17000252")]
		public virtual int K3
		{
			[Token(Token = "0x6001149")]
			[Address(RVA = "0x21127B0", Offset = "0x21113B0", VA = "0x1821127B0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000921 RID: 2337
		[Token(Token = "0x4000921")]
		private const int SecT283R1_DEFAULT_COORDS = 6;

		// Token: 0x04000922 RID: 2338
		[Token(Token = "0x4000922")]
		[FieldOffset(Offset = "0x58")]
		protected readonly SecT283R1Point m_infinity;
	}
}

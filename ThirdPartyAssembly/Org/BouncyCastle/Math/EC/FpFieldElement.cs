using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public class FpFieldElement : ECFieldElement
	{
		// Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x54A6AA0", Offset = "0x54A56A0", VA = "0x1854A6AA0")]
		internal static BigInteger CalculateResidue(BigInteger p)
		{
			return null;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x54A90C0", Offset = "0x54A7CC0", VA = "0x1854A90C0")]
		public FpFieldElement(BigInteger q, BigInteger x)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x54A9110", Offset = "0x54A7D10", VA = "0x1854A9110")]
		internal FpFieldElement(BigInteger q, BigInteger r, BigInteger x)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "4")]
		public override BigInteger ToBigInteger()
		{
			return null;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010A")]
		public override string FieldName
		{
			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x54A9200", Offset = "0x54A7E00", VA = "0x1854A9200", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x1700010B")]
		public override int FieldSize
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x54A9230", Offset = "0x54A7E30", VA = "0x1854A9230", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010C")]
		public BigInteger Q
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x54A69A0", Offset = "0x54A55A0", VA = "0x1854A69A0", Slot = "7")]
		public override ECFieldElement Add(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x54A6880", Offset = "0x54A5480", VA = "0x1854A6880", Slot = "8")]
		public override ECFieldElement AddOne()
		{
			return null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x54A8FC0", Offset = "0x54A7BC0", VA = "0x1854A8FC0", Slot = "9")]
		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x54A8280", Offset = "0x54A6E80", VA = "0x1854A8280", Slot = "10")]
		public override ECFieldElement Multiply(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x54A7E90", Offset = "0x54A6A90", VA = "0x1854A7E90", Slot = "19")]
		public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x54A8050", Offset = "0x54A6C50", VA = "0x1854A8050", Slot = "20")]
		public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x54A6C90", Offset = "0x54A5890", VA = "0x1854A6C90", Slot = "11")]
		public override ECFieldElement Divide(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x54A8380", Offset = "0x54A6F80", VA = "0x1854A8380", Slot = "12")]
		public override ECFieldElement Negate()
		{
			return null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x54A8F00", Offset = "0x54A7B00", VA = "0x1854A8F00", Slot = "13")]
		public override ECFieldElement Square()
		{
			return null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x54A8B90", Offset = "0x54A7790", VA = "0x1854A8B90", Slot = "21")]
		public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x54A8D10", Offset = "0x54A7910", VA = "0x1854A8D10", Slot = "22")]
		public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x54A70A0", Offset = "0x54A5CA0", VA = "0x1854A70A0", Slot = "14")]
		public override ECFieldElement Invert()
		{
			return null;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x54A8430", Offset = "0x54A7030", VA = "0x1854A8430", Slot = "15")]
		public override ECFieldElement Sqrt()
		{
			return null;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x54A6BF0", Offset = "0x54A57F0", VA = "0x1854A6BF0")]
		private ECFieldElement CheckSqrt(ECFieldElement z)
		{
			return null;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x54A7160", Offset = "0x54A5D60", VA = "0x1854A7160")]
		private BigInteger[] LucasSequence(BigInteger P, BigInteger Q, BigInteger k)
		{
			return null;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x54A77A0", Offset = "0x54A63A0", VA = "0x1854A77A0", Slot = "27")]
		protected virtual BigInteger ModAdd(BigInteger x1, BigInteger x2)
		{
			return null;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x54A7810", Offset = "0x54A6410", VA = "0x1854A7810", Slot = "28")]
		protected virtual BigInteger ModDouble(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x54A78F0", Offset = "0x54A64F0", VA = "0x1854A78F0", Slot = "29")]
		protected virtual BigInteger ModHalf(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x54A7880", Offset = "0x54A6480", VA = "0x1854A7880", Slot = "30")]
		protected virtual BigInteger ModHalfAbs(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x54A7960", Offset = "0x54A6560", VA = "0x1854A7960", Slot = "31")]
		protected virtual BigInteger ModInverse(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x54A7A40", Offset = "0x54A6640", VA = "0x1854A7A40", Slot = "32")]
		protected virtual BigInteger ModMult(BigInteger x1, BigInteger x2)
		{
			return null;
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x54A7AB0", Offset = "0x54A66B0", VA = "0x1854A7AB0", Slot = "33")]
		protected virtual BigInteger ModReduce(BigInteger x)
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x54A7E40", Offset = "0x54A6A40", VA = "0x1854A7E40", Slot = "34")]
		protected virtual BigInteger ModSubtract(BigInteger x1, BigInteger x2)
		{
			return null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x54A6EE0", Offset = "0x54A5AE0", VA = "0x1854A6EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x54A6DC0", Offset = "0x54A59C0", VA = "0x1854A6DC0", Slot = "35")]
		public virtual bool Equals(FpFieldElement other)
		{
			return default(bool);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x54A6FE0", Offset = "0x54A5BE0", VA = "0x1854A6FE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x10")]
		private readonly BigInteger q;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x18")]
		private readonly BigInteger r;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x20")]
		private readonly BigInteger x;
	}
}

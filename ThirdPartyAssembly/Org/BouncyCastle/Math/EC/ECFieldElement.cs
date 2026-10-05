using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	public abstract class ECFieldElement
	{
		// Token: 0x06000AA3 RID: 2723
		[Token(Token = "0x6000AA3")]
		public abstract BigInteger ToBigInteger();

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000AA4 RID: 2724
		[Token(Token = "0x17000105")]
		public abstract string FieldName { [Token(Token = "0x6000AA4")] get; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000AA5 RID: 2725
		[Token(Token = "0x17000106")]
		public abstract int FieldSize { [Token(Token = "0x6000AA5")] get; }

		// Token: 0x06000AA6 RID: 2726
		[Token(Token = "0x6000AA6")]
		public abstract ECFieldElement Add(ECFieldElement b);

		// Token: 0x06000AA7 RID: 2727
		[Token(Token = "0x6000AA7")]
		public abstract ECFieldElement AddOne();

		// Token: 0x06000AA8 RID: 2728
		[Token(Token = "0x6000AA8")]
		public abstract ECFieldElement Subtract(ECFieldElement b);

		// Token: 0x06000AA9 RID: 2729
		[Token(Token = "0x6000AA9")]
		public abstract ECFieldElement Multiply(ECFieldElement b);

		// Token: 0x06000AAA RID: 2730
		[Token(Token = "0x6000AAA")]
		public abstract ECFieldElement Divide(ECFieldElement b);

		// Token: 0x06000AAB RID: 2731
		[Token(Token = "0x6000AAB")]
		public abstract ECFieldElement Negate();

		// Token: 0x06000AAC RID: 2732
		[Token(Token = "0x6000AAC")]
		public abstract ECFieldElement Square();

		// Token: 0x06000AAD RID: 2733
		[Token(Token = "0x6000AAD")]
		public abstract ECFieldElement Invert();

		// Token: 0x06000AAE RID: 2734
		[Token(Token = "0x6000AAE")]
		public abstract ECFieldElement Sqrt();

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x17000107")]
		public virtual int BitLength
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x549EB10", Offset = "0x549D710", VA = "0x18549EB10", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x17000108")]
		public virtual bool IsOne
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x549EB60", Offset = "0x549D760", VA = "0x18549EB60", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x17000109")]
		public virtual bool IsZero
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x549EBA0", Offset = "0x549D7A0", VA = "0x18549EBA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x549E6E0", Offset = "0x549D2E0", VA = "0x18549E6E0", Slot = "19")]
		public virtual ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x549E7B0", Offset = "0x549D3B0", VA = "0x18549E7B0", Slot = "20")]
		public virtual ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x549E880", Offset = "0x549D480", VA = "0x18549E880", Slot = "21")]
		public virtual ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x549E940", Offset = "0x549D540", VA = "0x18549E940", Slot = "22")]
		public virtual ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x549EA00", Offset = "0x549D600", VA = "0x18549EA00", Slot = "23")]
		public virtual ECFieldElement SquarePow(int pow)
		{
			return null;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x549EA70", Offset = "0x549D670", VA = "0x18549EA70", Slot = "24")]
		public virtual bool TestBitZero()
		{
			return default(bool);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x549E440", Offset = "0x549D040", VA = "0x18549E440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x549E500", Offset = "0x549D100", VA = "0x18549E500", Slot = "25")]
		public virtual bool Equals(ECFieldElement other)
		{
			return default(bool);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x549E670", Offset = "0x549D270", VA = "0x18549E670", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x549EAC0", Offset = "0x549D6C0", VA = "0x18549EAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x549E5E0", Offset = "0x549D1E0", VA = "0x18549E5E0", Slot = "26")]
		public virtual byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ECFieldElement()
		{
		}
	}
}

using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public class F2mFieldElement : ECFieldElement
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x54A2AE0", Offset = "0x54A16E0", VA = "0x1854A2AE0")]
		public F2mFieldElement(int m, int k1, int k2, int k3, BigInteger x)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x54A2D70", Offset = "0x54A1970", VA = "0x1854A2D70")]
		public F2mFieldElement(int m, int k, BigInteger x)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x54A2A60", Offset = "0x54A1660", VA = "0x1854A2A60")]
		private F2mFieldElement(int m, int[] ks, LongArray x)
		{
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x1700010D")]
		public override int BitLength
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x54A2DA0", Offset = "0x54A19A0", VA = "0x1854A2DA0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x1700010E")]
		public override bool IsOne
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x54A2DF0", Offset = "0x54A19F0", VA = "0x1854A2DF0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x1700010F")]
		public override bool IsZero
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x54A2E60", Offset = "0x54A1A60", VA = "0x1854A2E60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x54A29F0", Offset = "0x54A15F0", VA = "0x1854A29F0", Slot = "24")]
		public override bool TestBitZero()
		{
			return default(bool);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x54A2A40", Offset = "0x54A1640", VA = "0x1854A2A40", Slot = "4")]
		public override BigInteger ToBigInteger()
		{
			return null;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		public override string FieldName
		{
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x54A2DC0", Offset = "0x54A19C0", VA = "0x1854A2DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x17000111")]
		public override int FieldSize
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x54A18E0", Offset = "0x54A04E0", VA = "0x1854A18E0")]
		public static void CheckFieldElements(ECFieldElement a, ECFieldElement b)
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x54A1780", Offset = "0x54A0380", VA = "0x1854A1780", Slot = "7")]
		public override ECFieldElement Add(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x54A15B0", Offset = "0x54A01B0", VA = "0x1854A15B0", Slot = "8")]
		public override ECFieldElement AddOne()
		{
			return null;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x51F8F40", Offset = "0x51F7B40", VA = "0x1851F8F40", Slot = "9")]
		public override ECFieldElement Subtract(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x54A2280", Offset = "0x54A0E80", VA = "0x1854A2280", Slot = "10")]
		public override ECFieldElement Multiply(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x51F8370", Offset = "0x51F6F70", VA = "0x1851F8370", Slot = "19")]
		public override ECFieldElement MultiplyMinusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x54A1E90", Offset = "0x54A0A90", VA = "0x1854A1E90", Slot = "20")]
		public override ECFieldElement MultiplyPlusProduct(ECFieldElement b, ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x51F80A0", Offset = "0x51F6CA0", VA = "0x1851F80A0", Slot = "11")]
		public override ECFieldElement Divide(ECFieldElement b)
		{
			return null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "12")]
		public override ECFieldElement Negate()
		{
			return null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x54A2920", Offset = "0x54A1520", VA = "0x1854A2920", Slot = "13")]
		public override ECFieldElement Square()
		{
			return null;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x51F8A00", Offset = "0x51F7600", VA = "0x1851F8A00", Slot = "21")]
		public override ECFieldElement SquareMinusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x54A2520", Offset = "0x54A1120", VA = "0x1854A2520", Slot = "22")]
		public override ECFieldElement SquarePlusProduct(ECFieldElement x, ECFieldElement y)
		{
			return null;
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x54A2830", Offset = "0x54A1430", VA = "0x1854A2830", Slot = "23")]
		public override ECFieldElement SquarePow(int pow)
		{
			return null;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x54A1DC0", Offset = "0x54A09C0", VA = "0x1854A1DC0", Slot = "14")]
		public override ECFieldElement Invert()
		{
			return null;
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x54A2440", Offset = "0x54A1040", VA = "0x1854A2440", Slot = "15")]
		public override ECFieldElement Sqrt()
		{
			return null;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x17000112")]
		public int Representation
		{
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x17000113")]
		public int M
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x17000114")]
		public int K1
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x54A2EC0", Offset = "0x54A1AC0", VA = "0x1854A2EC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x17000115")]
		public int K2
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x54A2EF0", Offset = "0x54A1AF0", VA = "0x1854A2EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x17000116")]
		public int K3
		{
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x54A2F30", Offset = "0x54A1B30", VA = "0x1854A2F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x54A1C50", Offset = "0x54A0850", VA = "0x1854A1C50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x54A1BE0", Offset = "0x54A07E0", VA = "0x1854A1BE0", Slot = "27")]
		public virtual bool Equals(F2mFieldElement other)
		{
			return default(bool);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x54A1D50", Offset = "0x54A0950", VA = "0x1854A1D50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		public const int Gnb = 1;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		public const int Tpb = 2;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		public const int Ppb = 3;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x10")]
		private int representation;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x14")]
		private int m;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x18")]
		private int[] ks;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x20")]
		private LongArray x;
	}
}

using System;
using System.Text;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[Serializable]
	public class BigInteger
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x5470030", Offset = "0x546EC30", VA = "0x185470030")]
		private static int GetByteLength(int nBits)
		{
			return 0;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x546DAF0", Offset = "0x546C6F0", VA = "0x18546DAF0")]
		internal static BigInteger Arbitrary(int sizeInBits)
		{
			return null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x5479E80", Offset = "0x5478A80", VA = "0x185479E80")]
		private BigInteger(int signum, int[] mag, bool checkMag)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x5479E70", Offset = "0x5478A70", VA = "0x185479E70")]
		public BigInteger(string value)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x5479FF0", Offset = "0x5478BF0", VA = "0x185479FF0")]
		public BigInteger(string str, int radix)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x5479B80", Offset = "0x5478780", VA = "0x185479B80")]
		public BigInteger(byte[] bytes)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x547AAF0", Offset = "0x54796F0", VA = "0x18547AAF0")]
		public BigInteger(byte[] bytes, int offset, int length)
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x5470A70", Offset = "0x546F670", VA = "0x185470A70")]
		private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
		{
			return null;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x5479D10", Offset = "0x5478910", VA = "0x185479D10")]
		public BigInteger(int sign, byte[] bytes)
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x5479BB0", Offset = "0x54787B0", VA = "0x185479BB0")]
		public BigInteger(int sign, byte[] bytes, int offset, int length)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x5479990", Offset = "0x5478590", VA = "0x185479990")]
		public BigInteger(int sizeInBits, Random random)
		{
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x547A760", Offset = "0x5479360", VA = "0x18547A760")]
		public BigInteger(int bitLength, int certainty, Random random)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x546D3A0", Offset = "0x546BFA0", VA = "0x18546D3A0")]
		public BigInteger Abs()
		{
			return null;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x546D3C0", Offset = "0x546BFC0", VA = "0x18546D3C0")]
		private static int[] AddMagnitudes(int[] a, int[] b)
		{
			return null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x546D680", Offset = "0x546C280", VA = "0x18546D680")]
		public BigInteger Add(BigInteger value)
		{
			return null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x546D480", Offset = "0x546C080", VA = "0x18546D480")]
		private BigInteger AddToMagnitude(int[] magToAdd)
		{
			return null;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x546D780", Offset = "0x546C380", VA = "0x18546D780")]
		public BigInteger And(BigInteger value)
		{
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x546D730", Offset = "0x546C330", VA = "0x18546D730")]
		public BigInteger AndNot(BigInteger val)
		{
			return null;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x170000DE")]
		public int BitCount
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x547AEF0", Offset = "0x5479AF0", VA = "0x18547AEF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x546DB80", Offset = "0x546C780", VA = "0x18546DB80")]
		public static int BitCnt(int i)
		{
			return 0;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x546DD30", Offset = "0x546C930", VA = "0x18546DD30")]
		private static int CalcBitLength(int sign, int indx, int[] mag)
		{
			return 0;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x170000DF")]
		public int BitLength
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x547B030", Offset = "0x5479C30", VA = "0x18547B030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x546DBC0", Offset = "0x546C7C0", VA = "0x18546DBC0")]
		internal static int BitLen(int w)
		{
			return 0;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x5473660", Offset = "0x5472260", VA = "0x185473660")]
		private bool QuickPow2Check()
		{
			return default(bool);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x546E230", Offset = "0x546CE30", VA = "0x18546E230")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x546E430", Offset = "0x546D030", VA = "0x18546E430")]
		private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
		{
			return 0;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x546E190", Offset = "0x546CD90", VA = "0x18546E190")]
		private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
		{
			return 0;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x546E2E0", Offset = "0x546CEE0", VA = "0x18546E2E0")]
		public int CompareTo(BigInteger value)
		{
			return 0;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x546F100", Offset = "0x546DD00", VA = "0x18546F100")]
		private int[] Divide(int[] x, int[] y)
		{
			return null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x546EEE0", Offset = "0x546DAE0", VA = "0x18546EEE0")]
		public BigInteger Divide(BigInteger val)
		{
			return null;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x546E840", Offset = "0x546D440", VA = "0x18546E840")]
		public BigInteger[] DivideAndRemainder(BigInteger val)
		{
			return null;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x546FA40", Offset = "0x546E640", VA = "0x18546FA40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5470560", Offset = "0x546F160", VA = "0x185470560")]
		private bool IsEqualMagnitude(BigInteger x)
		{
			return default(bool);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x546FED0", Offset = "0x546EAD0", VA = "0x18546FED0")]
		public BigInteger Gcd(BigInteger value)
		{
			return null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x5470040", Offset = "0x546EC40", VA = "0x185470040", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x5470430", Offset = "0x546F030", VA = "0x185470430")]
		private BigInteger Inc()
		{
			return null;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x170000E0")]
		public int IntValue
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x547B0C0", Offset = "0x5479CC0", VA = "0x18547B0C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x54705E0", Offset = "0x546F1E0", VA = "0x1854705E0")]
		public bool IsProbablePrime(int certainty)
		{
			return default(bool);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x5470770", Offset = "0x546F370", VA = "0x185470770")]
		internal bool IsProbablePrime(int certainty, bool randomlySelected)
		{
			return default(bool);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x546DE30", Offset = "0x546CA30", VA = "0x18546DE30")]
		private bool CheckProbablePrime(int certainty, Random random, bool randomlySelected)
		{
			return default(bool);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x5473AB0", Offset = "0x54726B0", VA = "0x185473AB0")]
		public bool RabinMillerTest(int certainty, Random random)
		{
			return default(bool);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5473680", Offset = "0x5472280", VA = "0x185473680")]
		internal bool RabinMillerTest(int certainty, Random random, bool randomlySelected)
		{
			return default(bool);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x170000E1")]
		public long LongValue
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x547B110", Offset = "0x5479D10", VA = "0x18547B110")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5470BE0", Offset = "0x546F7E0", VA = "0x185470BE0")]
		public BigInteger Max(BigInteger value)
		{
			return null;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5470C10", Offset = "0x546F810", VA = "0x185470C10")]
		public BigInteger Min(BigInteger value)
		{
			return null;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x54721F0", Offset = "0x5470DF0", VA = "0x1854721F0")]
		public BigInteger Mod(BigInteger m)
		{
			return null;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x5470FB0", Offset = "0x546FBB0", VA = "0x185470FB0")]
		public BigInteger ModInverse(BigInteger m)
		{
			return null;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x5470CF0", Offset = "0x546F8F0", VA = "0x185470CF0")]
		private BigInteger ModInversePow2(BigInteger m)
		{
			return null;
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x5470C40", Offset = "0x546F840", VA = "0x185470C40")]
		private static int ModInverse32(int d)
		{
			return 0;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x5470C90", Offset = "0x546F890", VA = "0x185470C90")]
		private static long ModInverse64(long d)
		{
			return 0L;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x546FB50", Offset = "0x546E750", VA = "0x18546FB50")]
		private static BigInteger ExtEuclid(BigInteger a, BigInteger b, out BigInteger u1Out)
		{
			return null;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x5476E60", Offset = "0x5475A60", VA = "0x185476E60")]
		private static void ZeroOut(int[] x)
		{
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x5471F60", Offset = "0x5470B60", VA = "0x185471F60")]
		public BigInteger ModPow(BigInteger e, BigInteger m)
		{
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x5471270", Offset = "0x546FE70", VA = "0x185471270")]
		private static BigInteger ModPowBarrett(BigInteger b, BigInteger e, BigInteger m)
		{
			return null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x5473AD0", Offset = "0x54726D0", VA = "0x185473AD0")]
		private static BigInteger ReduceBarrett(BigInteger x, BigInteger m, BigInteger mr, BigInteger yu)
		{
			return null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x54717B0", Offset = "0x54703B0", VA = "0x1854717B0")]
		private static BigInteger ModPowMonty(BigInteger b, BigInteger e, BigInteger m, bool convert)
		{
			return null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x5470200", Offset = "0x546EE00", VA = "0x185470200")]
		private static int[] GetWindowList(int[] mag, int extraBits)
		{
			return null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x546E820", Offset = "0x546D420", VA = "0x18546E820")]
		private static int CreateWindowEntry(int mult, int zeroes)
		{
			return 0;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088D")]
		[Address(RVA = "0x5475670", Offset = "0x5474270", VA = "0x185475670")]
		private static int[] Square(int[] w, int[] x)
		{
			return null;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x54728F0", Offset = "0x54714F0", VA = "0x1854728F0")]
		private static int[] Multiply(int[] x, int[] y, int[] z)
		{
			return null;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x5470140", Offset = "0x546ED40", VA = "0x185470140")]
		private int GetMQuote()
		{
			return 0;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x5472290", Offset = "0x5470E90", VA = "0x185472290")]
		private static void MontgomeryReduce(int[] x, int[] m, uint mDash)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x5472450", Offset = "0x5471050", VA = "0x185472450")]
		private static void MultiplyMonty(int[] a, int[] x, int[] y, int[] m, uint mDash, bool smallMontyModulus)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x5475020", Offset = "0x5473C20", VA = "0x185475020")]
		private static void SquareMonty(int[] a, int[] x, int[] m, uint mDash, bool smallMontyModulus)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x5472410", Offset = "0x5471010", VA = "0x185472410")]
		private static uint MultiplyMontyNIsOne(uint x, uint y, uint m, uint mDash)
		{
			return 0U;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x5472A20", Offset = "0x5471620", VA = "0x185472A20")]
		public BigInteger Multiply(BigInteger val)
		{
			return null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x54754F0", Offset = "0x54740F0", VA = "0x1854754F0")]
		public BigInteger Square()
		{
			return null;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x5472CC0", Offset = "0x54718C0", VA = "0x185472CC0")]
		public BigInteger Negate()
		{
			return null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x5472D90", Offset = "0x5471990", VA = "0x185472D90")]
		public BigInteger NextProbablePrime()
		{
			return null;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x54730B0", Offset = "0x5471CB0", VA = "0x1854730B0")]
		public BigInteger Not()
		{
			return null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x54733B0", Offset = "0x5471FB0", VA = "0x1854733B0")]
		public BigInteger Pow(int exp)
		{
			return null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x54735E0", Offset = "0x54721E0", VA = "0x1854735E0")]
		public static BigInteger ProbablePrime(int bitLength, Random random)
		{
			return null;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x5474390", Offset = "0x5472F90", VA = "0x185474390")]
		private int Remainder(int m)
		{
			return 0;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x5473D70", Offset = "0x5472970", VA = "0x185473D70")]
		private static int[] Remainder(int[] x, int[] y)
		{
			return null;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x54743F0", Offset = "0x5472FF0", VA = "0x1854743F0")]
		public BigInteger Remainder(BigInteger n)
		{
			return null;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x5470920", Offset = "0x546F520", VA = "0x185470920")]
		private int[] LastNBits(int n)
		{
			return null;
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x546ED90", Offset = "0x546D990", VA = "0x18546ED90")]
		private BigInteger DivideWords(int w)
		{
			return null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x5473C60", Offset = "0x5472860", VA = "0x185473C60")]
		private BigInteger RemainderWords(int w)
		{
			return null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x54748B0", Offset = "0x54734B0", VA = "0x1854748B0")]
		private static int[] ShiftLeft(int[] mag, int n)
		{
			return null;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x5474850", Offset = "0x5473450", VA = "0x185474850")]
		private static int ShiftLeftOneInPlace(int[] x, int carry)
		{
			return 0;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x5474A60", Offset = "0x5473660", VA = "0x185474A60")]
		public BigInteger ShiftLeft(int n)
		{
			return null;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x5474BB0", Offset = "0x54737B0", VA = "0x185474BB0")]
		private static void ShiftRightInPlace(int start, int[] mag, int n)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x5474CF0", Offset = "0x54738F0", VA = "0x185474CF0")]
		private static void ShiftRightOneInPlace(int start, int[] mag)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x5474D80", Offset = "0x5473980", VA = "0x185474D80")]
		public BigInteger ShiftRight(int n)
		{
			return null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x170000E2")]
		public int SignValue
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x5475810", Offset = "0x5474410", VA = "0x185475810")]
		private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
		{
			return null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x54758E0", Offset = "0x54744E0", VA = "0x1854758E0")]
		public BigInteger Subtract(BigInteger n)
		{
			return null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x547AD80", Offset = "0x5479980", VA = "0x18547AD80")]
		private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
		{
			return null;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x5475F60", Offset = "0x5474B60", VA = "0x185475F60")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x5475BE0", Offset = "0x54747E0", VA = "0x185475BE0")]
		public byte[] ToByteArrayUnsigned()
		{
			return null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x5475BF0", Offset = "0x54747F0", VA = "0x185475BF0")]
		private byte[] ToByteArray(bool unsigned)
		{
			return null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x5475F70", Offset = "0x5474B70", VA = "0x185475F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x5475F80", Offset = "0x5474B80", VA = "0x185475F80")]
		public string ToString(int radix)
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x546DA70", Offset = "0x546C670", VA = "0x18546DA70")]
		private static void AppendZeroExtendedString(StringBuilder sb, string s, int minLength)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x546E550", Offset = "0x546D150", VA = "0x18546E550")]
		private static BigInteger CreateUValueOf(ulong value)
		{
			return null;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x546E750", Offset = "0x546D350", VA = "0x18546E750")]
		private static BigInteger CreateValueOf(long value)
		{
			return null;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x5476AC0", Offset = "0x54756C0", VA = "0x185476AC0")]
		public static BigInteger ValueOf(long value)
		{
			return null;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x5470120", Offset = "0x546ED20", VA = "0x185470120")]
		public int GetLowestSetBit()
		{
			return 0;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x54700A0", Offset = "0x546ECA0", VA = "0x1854700A0")]
		private int GetLowestSetBitMaskFirst(int firstWordMask)
		{
			return 0;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x5475AF0", Offset = "0x54746F0", VA = "0x185475AF0")]
		public bool TestBit(int n)
		{
			return default(bool);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x54730E0", Offset = "0x5471CE0", VA = "0x1854730E0")]
		public BigInteger Or(BigInteger value)
		{
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x5476B90", Offset = "0x5475790", VA = "0x185476B90")]
		public BigInteger Xor(BigInteger value)
		{
			return null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x5474720", Offset = "0x5473320", VA = "0x185474720")]
		public BigInteger SetBit(int n)
		{
			return null;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x546E030", Offset = "0x546CC30", VA = "0x18546E030")]
		public BigInteger ClearBit(int n)
		{
			return null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x546FC70", Offset = "0x546E870", VA = "0x18546FC70")]
		public BigInteger FlipBit(int n)
		{
			return null;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x546FD80", Offset = "0x546E980", VA = "0x18546FD80")]
		private BigInteger FlipExistingBit(int n)
		{
			return null;
		}

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int[][] primeLists;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] primeProducts;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		private const long IMASK = 4294967295L;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		private const ulong UIMASK = 4294967295UL;

		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] ZeroMagnitude;

		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] ZeroEncoding;

		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x20")]
		private static readonly BigInteger[] SMALL_CONSTANTS;

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x28")]
		public static readonly BigInteger Zero;

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[FieldOffset(Offset = "0x30")]
		public static readonly BigInteger One;

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[FieldOffset(Offset = "0x38")]
		public static readonly BigInteger Two;

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[FieldOffset(Offset = "0x40")]
		public static readonly BigInteger Three;

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x48")]
		public static readonly BigInteger Ten;

		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x50")]
		private static readonly byte[] BitLengthTable;

		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		private const int chunk2 = 1;

		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		private const int chunk8 = 1;

		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		private const int chunk10 = 19;

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		private const int chunk16 = 16;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x58")]
		private static readonly BigInteger radix2;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x60")]
		private static readonly BigInteger radix2E;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x68")]
		private static readonly BigInteger radix8;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x70")]
		private static readonly BigInteger radix8E;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x78")]
		private static readonly BigInteger radix10;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x80")]
		private static readonly BigInteger radix10E;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x88")]
		private static readonly BigInteger radix16;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x90")]
		private static readonly BigInteger radix16E;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x98")]
		private static readonly SecureRandom RandomSource;

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0xA0")]
		private static readonly int[] ExpWindowThresholds;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		private const int BitsPerByte = 8;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		private const int BitsPerInt = 32;

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		private const int BytesPerInt = 4;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x10")]
		private int[] magnitude;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x18")]
		private int sign;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x1C")]
		private int nBits;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x20")]
		private int nBitLength;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x24")]
		private int mQuote;
	}
}

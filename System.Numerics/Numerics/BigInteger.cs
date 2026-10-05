using System;
using Il2CppDummyDll;

namespace System.Numerics
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[Serializable]
	public readonly struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger>
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x4F6BA20", Offset = "0x4F6A620", VA = "0x184F6BA20")]
		public BigInteger(int value)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4F6B160", Offset = "0x4F69D60", VA = "0x184F6B160")]
		public BigInteger(long value)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4F6B070", Offset = "0x4F69C70", VA = "0x184F6B070")]
		[CLSCompliant(false)]
		public BigInteger(byte[] value)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4F6B300", Offset = "0x4F69F00", VA = "0x184F6B300")]
		public BigInteger(ReadOnlySpan<byte> value, bool isUnsigned = false, bool isBigEndian = false)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
		internal BigInteger(int n, uint[] rgu)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4F6AE80", Offset = "0x4F69A80", VA = "0x184F6AE80")]
		internal BigInteger(uint[] value, bool negative)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x17000001")]
		public static BigInteger MinusOne
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x4F6BAA0", Offset = "0x4F6A6A0", VA = "0x184F6BAA0")]
			get
			{
				return default(BigInteger);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4F6A090", Offset = "0x4F68C90", VA = "0x184F6A090", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4F69F80", Offset = "0x4F68B80", VA = "0x184F69F80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F69E80", Offset = "0x4F68A80", VA = "0x184F69E80", Slot = "7")]
		public bool Equals(BigInteger other)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4F69C10", Offset = "0x4F68810", VA = "0x184F69C10", Slot = "6")]
		public int CompareTo(BigInteger other)
		{
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F69D70", Offset = "0x4F68970", VA = "0x184F69D70", Slot = "5")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4F6AA90", Offset = "0x4F69690", VA = "0x184F6AA90")]
		public bool TryWriteBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4F6AB50", Offset = "0x4F69750", VA = "0x184F6AB50")]
		internal bool TryWriteOrCountBytes(Span<byte> destination, out int bytesWritten, bool isUnsigned = false, bool isBigEndian = false)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4F6A570", Offset = "0x4F69170", VA = "0x184F6A570")]
		private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten)
		{
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4F6A3B0", Offset = "0x4F68FB0", VA = "0x184F6A3B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002112 File Offset: 0x00000312
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4F6A470", Offset = "0x4F69070", VA = "0x184F6A470", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4F69A50", Offset = "0x4F68650", VA = "0x184F69A50")]
		private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			return default(BigInteger);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4F6A1B0", Offset = "0x4F68DB0", VA = "0x184F6A1B0")]
		private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign)
		{
			return default(BigInteger);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4F6BFE0", Offset = "0x4F6ABE0", VA = "0x184F6BFE0")]
		public static implicit operator BigInteger(byte value)
		{
			return default(BigInteger);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4F6BFC0", Offset = "0x4F6ABC0", VA = "0x184F6BFC0")]
		public static implicit operator BigInteger(int value)
		{
			return default(BigInteger);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4F6C010", Offset = "0x4F6AC10", VA = "0x184F6C010")]
		public static implicit operator BigInteger(long value)
		{
			return default(BigInteger);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4F6BE80", Offset = "0x4F6AA80", VA = "0x184F6BE80")]
		public static explicit operator int(BigInteger value)
		{
			return 0;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4F6C030", Offset = "0x4F6AC30", VA = "0x184F6C030")]
		public static BigInteger operator <<(BigInteger value, int shift)
		{
			return default(BigInteger);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4F6C350", Offset = "0x4F6AF50", VA = "0x184F6C350")]
		public static BigInteger operator >>(BigInteger value, int shift)
		{
			return default(BigInteger);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4F6BB00", Offset = "0x4F6A700", VA = "0x184F6BB00")]
		public static BigInteger operator +(BigInteger left, BigInteger right)
		{
			return default(BigInteger);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F6A0E0", Offset = "0x4F68CE0", VA = "0x184F6A0E0")]
		private static bool GetPartsForBitManipulation(ref BigInteger x, out uint[] xd, out int xl)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F6A030", Offset = "0x4F68C30", VA = "0x184F6A030")]
		internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu)
		{
			return 0;
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		internal readonly int _sign;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		internal readonly uint[] _bits;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		private static readonly BigInteger s_bnMinInt;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		private static readonly BigInteger s_bnOneInt;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x20")]
		private static readonly BigInteger s_bnZeroInt;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		private static readonly BigInteger s_bnMinusOneInt;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		private static readonly byte[] s_success;

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		private enum GetBytesMode
		{
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			AllocateArray,
			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			Count,
			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			Span
		}
	}
}

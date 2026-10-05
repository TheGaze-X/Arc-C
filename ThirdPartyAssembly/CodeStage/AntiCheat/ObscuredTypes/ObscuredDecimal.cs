using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200056C RID: 1388
	[Token(Token = "0x200056C")]
	[Serializable]
	public struct ObscuredDecimal : IFormattable, IEquatable<ObscuredDecimal>, IComparable<ObscuredDecimal>, IComparable<decimal>, IComparable
	{
		// Token: 0x06002E11 RID: 11793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E11")]
		[Address(RVA = "0x53FDE00", Offset = "0x53FCA00", VA = "0x1853FDE00")]
		private ObscuredDecimal(decimal value)
		{
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E12")]
		[Address(RVA = "0x53FDAE0", Offset = "0x53FC6E0", VA = "0x1853FDAE0")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x6002E13")]
		[Address(RVA = "0x53FD050", Offset = "0x53FBC50", VA = "0x1853FD050")]
		public static decimal Encrypt(decimal value)
		{
			return 0m;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x6002E14")]
		[Address(RVA = "0x53FD020", Offset = "0x53FBC20", VA = "0x1853FD020")]
		public static decimal Encrypt(decimal value, long key)
		{
			return 0m;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x6002E15")]
		[Address(RVA = "0x53FD690", Offset = "0x53FC290", VA = "0x1853FD690")]
		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return default(ACTkByte16);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x53FD5F0", Offset = "0x53FC1F0", VA = "0x1853FD5F0")]
		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x53FCF90", Offset = "0x53FBB90", VA = "0x1853FCF90")]
		public static decimal Decrypt(decimal value)
		{
			return 0m;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x53FD020", Offset = "0x53FBC20", VA = "0x1853FD020")]
		public static decimal Decrypt(decimal value, long key)
		{
			return 0m;
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E19")]
		[Address(RVA = "0x53FCC70", Offset = "0x53FB870", VA = "0x1853FCC70")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1A")]
		[Address(RVA = "0x53FD750", Offset = "0x53FC350", VA = "0x1853FD750")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x6002E1B")]
		[Address(RVA = "0x53FD2E0", Offset = "0x53FBEE0", VA = "0x1853FD2E0")]
		public decimal GetEncrypted()
		{
			return 0m;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E1C")]
		[Address(RVA = "0x53FD830", Offset = "0x53FC430", VA = "0x1853FD830")]
		public void SetEncrypted(decimal encrypted)
		{
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x6002E1D")]
		[Address(RVA = "0x53FD270", Offset = "0x53FBE70", VA = "0x1853FD270")]
		public decimal GetDecrypted()
		{
			return 0m;
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x6002E1E")]
		[Address(RVA = "0x53FD3D0", Offset = "0x53FBFD0", VA = "0x1853FD3D0")]
		private decimal InternalDecrypt()
		{
			return 0m;
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x53FE260", Offset = "0x53FCE60", VA = "0x1853FE260")]
		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x53FE2A0", Offset = "0x53FCEA0", VA = "0x1853FE2A0")]
		public static implicit operator decimal(ObscuredDecimal value)
		{
			return 0m;
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x53FE0F0", Offset = "0x53FCCF0", VA = "0x1853FE0F0")]
		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x53FE310", Offset = "0x53FCF10", VA = "0x1853FE310")]
		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x53FDF60", Offset = "0x53FCB60", VA = "0x1853FDF60")]
		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x53FD340", Offset = "0x53FBF40", VA = "0x1853FD340", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x53FDB40", Offset = "0x53FC740", VA = "0x1853FDB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x53FDD20", Offset = "0x53FC920", VA = "0x1853FDD20")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x53FDC80", Offset = "0x53FC880", VA = "0x1853FDC80")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x53FDBD0", Offset = "0x53FC7D0", VA = "0x1853FDBD0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00013458 File Offset: 0x00011658
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x53FD0E0", Offset = "0x53FBCE0", VA = "0x1853FD0E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x53FD1B0", Offset = "0x53FBDB0", VA = "0x1853FD1B0", Slot = "5")]
		public bool Equals(ObscuredDecimal obj)
		{
			return default(bool);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x53FCED0", Offset = "0x53FBAD0", VA = "0x1853FCED0", Slot = "6")]
		public int CompareTo(ObscuredDecimal other)
		{
			return 0;
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x53FCD90", Offset = "0x53FB990", VA = "0x1853FCD90", Slot = "7")]
		public int CompareTo(decimal other)
		{
			return 0;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x53FCE30", Offset = "0x53FBA30", VA = "0x1853FCE30", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019D1 RID: 6609
		[Token(Token = "0x40019D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x040019D2 RID: 6610
		[Token(Token = "0x40019D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ACTkByte16 hiddenValue;

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private decimal fakeValue;

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x0200056D RID: 1389
		[Token(Token = "0x200056D")]
		[StructLayout(2)]
		private struct DecimalLongBytesUnion
		{
			// Token: 0x040019D7 RID: 6615
			[Token(Token = "0x40019D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public decimal d;

			// Token: 0x040019D8 RID: 6616
			[Token(Token = "0x40019D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l1;

			// Token: 0x040019D9 RID: 6617
			[Token(Token = "0x40019D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long l2;

			// Token: 0x040019DA RID: 6618
			[Token(Token = "0x40019DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte16 b16;
		}
	}
}

using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	[Serializable]
	public struct ObscuredDouble : IFormattable, IEquatable<ObscuredDouble>, IComparable<ObscuredDouble>, IComparable<double>, IComparable
	{
		// Token: 0x06002E2F RID: 11823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x53FF3E0", Offset = "0x53FDFE0", VA = "0x1853FF3E0")]
		private ObscuredDouble(double value)
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x53FF180", Offset = "0x53FDD80", VA = "0x1853FF180")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x53FE810", Offset = "0x53FD410", VA = "0x1853FE810")]
		public static long Encrypt(double value)
		{
			return 0L;
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x6002E32")]
		[Address(RVA = "0x53FE7E0", Offset = "0x53FD3E0", VA = "0x1853FE7E0")]
		public static long Encrypt(double value, long key)
		{
			return 0L;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x6002E33")]
		[Address(RVA = "0x53FEDA0", Offset = "0x53FD9A0", VA = "0x1853FEDA0")]
		private static long InternalEncrypt(double value, long key = 0L)
		{
			return 0L;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x6002E34")]
		[Address(RVA = "0x53FE760", Offset = "0x53FD360", VA = "0x1853FE760")]
		public static double Decrypt(long value)
		{
			return 0.0;
		}

		// Token: 0x06002E35 RID: 11829 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x53FE730", Offset = "0x53FD330", VA = "0x1853FE730")]
		public static double Decrypt(long value, long key)
		{
			return 0.0;
		}

		// Token: 0x06002E36 RID: 11830 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x53FEE30", Offset = "0x53FDA30", VA = "0x1853FEE30")]
		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return 0L;
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x53FE4A0", Offset = "0x53FD0A0", VA = "0x1853FE4A0")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x53FEE70", Offset = "0x53FDA70", VA = "0x1853FEE70")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x53FEA80", Offset = "0x53FD680", VA = "0x1853FEA80")]
		public long GetEncrypted()
		{
			return 0L;
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x53FEEF0", Offset = "0x53FDAF0", VA = "0x1853FEEF0")]
		public void SetEncrypted(long encrypted)
		{
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x6002E3B")]
		[Address(RVA = "0x53FEA30", Offset = "0x53FD630", VA = "0x1853FEA30")]
		public double GetDecrypted()
		{
			return 0.0;
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x6002E3C")]
		[Address(RVA = "0x53FEB90", Offset = "0x53FD790", VA = "0x1853FEB90")]
		private double InternalDecrypt()
		{
			return 0.0;
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x000135A8 File Offset: 0x000117A8
		[Token(Token = "0x6002E3D")]
		[Address(RVA = "0x53FF6A0", Offset = "0x53FE2A0", VA = "0x1853FF6A0")]
		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x000135C0 File Offset: 0x000117C0
		[Token(Token = "0x6002E3E")]
		[Address(RVA = "0x53FF6D0", Offset = "0x53FE2D0", VA = "0x1853FF6D0")]
		public static implicit operator double(ObscuredDouble value)
		{
			return 0.0;
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x000135D8 File Offset: 0x000117D8
		[Token(Token = "0x6002E3F")]
		[Address(RVA = "0x53FF590", Offset = "0x53FE190", VA = "0x1853FF590")]
		public static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000135F0 File Offset: 0x000117F0
		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x53FF720", Offset = "0x53FE320", VA = "0x1853FF720")]
		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00013608 File Offset: 0x00011808
		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x53FF4E0", Offset = "0x53FE0E0", VA = "0x1853FF4E0")]
		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00013620 File Offset: 0x00011820
		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x53FEAD0", Offset = "0x53FD6D0", VA = "0x1853FEAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x53FF340", Offset = "0x53FDF40", VA = "0x1853FF340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x53FF260", Offset = "0x53FDE60", VA = "0x1853FF260")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E45")]
		[Address(RVA = "0x53FF2D0", Offset = "0x53FDED0", VA = "0x1853FF2D0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x53FF1E0", Offset = "0x53FDDE0", VA = "0x1853FF1E0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x53FE910", Offset = "0x53FD510", VA = "0x1853FE910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x53FE890", Offset = "0x53FD490", VA = "0x1853FE890", Slot = "5")]
		public bool Equals(ObscuredDouble obj)
		{
			return default(bool);
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x53FE5D0", Offset = "0x53FD1D0", VA = "0x1853FE5D0", Slot = "6")]
		public int CompareTo(ObscuredDouble other)
		{
			return 0;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x6002E4A")]
		[Address(RVA = "0x53FE6C0", Offset = "0x53FD2C0", VA = "0x1853FE6C0", Slot = "7")]
		public int CompareTo(double other)
		{
			return 0;
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x53FE650", Offset = "0x53FD250", VA = "0x1853FE650", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019DB RID: 6619
		[Token(Token = "0x40019DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x040019DC RID: 6620
		[Token(Token = "0x40019DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x040019DD RID: 6621
		[Token(Token = "0x40019DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		// Token: 0x040019DE RID: 6622
		[Token(Token = "0x40019DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte8 hiddenValueOldByte8;

		// Token: 0x040019DF RID: 6623
		[Token(Token = "0x40019DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double fakeValue;

		// Token: 0x040019E1 RID: 6625
		[Token(Token = "0x40019E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x0200056F RID: 1391
		[Token(Token = "0x200056F")]
		[StructLayout(2)]
		private struct DoubleLongBytesUnion
		{
			// Token: 0x040019E2 RID: 6626
			[Token(Token = "0x40019E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double d;

			// Token: 0x040019E3 RID: 6627
			[Token(Token = "0x40019E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long l;

			// Token: 0x040019E4 RID: 6628
			[Token(Token = "0x40019E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ACTkByte8 b8;
		}
	}
}

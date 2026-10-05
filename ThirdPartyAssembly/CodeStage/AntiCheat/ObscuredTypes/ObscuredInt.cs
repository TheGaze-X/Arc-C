using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	[Serializable]
	public struct ObscuredInt : IFormattable, IEquatable<ObscuredInt>, IComparable<ObscuredInt>, IComparable<int>, IComparable
	{
		// Token: 0x06002E6A RID: 11882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6A")]
		[Address(RVA = "0x5401620", Offset = "0x5400220", VA = "0x185401620")]
		private ObscuredInt(int value)
		{
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E6B")]
		[Address(RVA = "0x54013C0", Offset = "0x53FFFC0", VA = "0x1854013C0")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x5400D30", Offset = "0x53FF930", VA = "0x185400D30")]
		public static int Encrypt(int value)
		{
			return 0;
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x5400CB0", Offset = "0x53FF8B0", VA = "0x185400CB0")]
		public static int Encrypt(int value, int key)
		{
			return 0;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x5400C20", Offset = "0x53FF820", VA = "0x185400C20")]
		public static int Decrypt(int value)
		{
			return 0;
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x5400BA0", Offset = "0x53FF7A0", VA = "0x185400BA0")]
		public static int Decrypt(int value, int key)
		{
			return 0;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x5400940", Offset = "0x53FF540", VA = "0x185400940")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x5401190", Offset = "0x53FFD90", VA = "0x185401190")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000138D8 File Offset: 0x00011AD8
		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x5400FE0", Offset = "0x53FFBE0", VA = "0x185400FE0")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x5401240", Offset = "0x53FFE40", VA = "0x185401240")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000138F0 File Offset: 0x00011AF0
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x5400F90", Offset = "0x53FFB90", VA = "0x185400F90")]
		public int GetDecrypted()
		{
			return 0;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x5401090", Offset = "0x53FFC90", VA = "0x185401090")]
		private int InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x5401920", Offset = "0x5400520", VA = "0x185401920")]
		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x6002E77")]
		[Address(RVA = "0x5401A10", Offset = "0x5400610", VA = "0x185401A10")]
		public static implicit operator int(ObscuredInt value)
		{
			return 0;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00013950 File Offset: 0x00011B50
		[Token(Token = "0x6002E78")]
		[Address(RVA = "0x5401950", Offset = "0x5400550", VA = "0x185401950")]
		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00013968 File Offset: 0x00011B68
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x5401860", Offset = "0x5400460", VA = "0x185401860")]
		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x6002E7A")]
		[Address(RVA = "0x5401750", Offset = "0x5400350", VA = "0x185401750")]
		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x5401A60", Offset = "0x5400660", VA = "0x185401A60")]
		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x54016B0", Offset = "0x54002B0", VA = "0x1854016B0")]
		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6002E7D")]
		[Address(RVA = "0x5401030", Offset = "0x53FFC30", VA = "0x185401030", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x5401420", Offset = "0x5400020", VA = "0x185401420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x5401570", Offset = "0x5400170", VA = "0x185401570")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x5401500", Offset = "0x5400100", VA = "0x185401500")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x5401480", Offset = "0x5400080", VA = "0x185401480", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x5400DC0", Offset = "0x53FF9C0", VA = "0x185400DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x5400F00", Offset = "0x53FFB00", VA = "0x185400F00", Slot = "5")]
		public bool Equals(ObscuredInt obj)
		{
			return default(bool);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x5400AB0", Offset = "0x53FF6B0", VA = "0x185400AB0", Slot = "6")]
		public int CompareTo(ObscuredInt other)
		{
			return 0;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x6002E85")]
		[Address(RVA = "0x5400A40", Offset = "0x53FF640", VA = "0x185400A40", Slot = "7")]
		public int CompareTo(int other)
		{
			return 0;
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x5400B30", Offset = "0x53FF730", VA = "0x185400B30", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019EF RID: 6639
		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0x0")]
		private static int cryptoKey;

		// Token: 0x040019F0 RID: 6640
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x040019F1 RID: 6641
		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		// Token: 0x040019F2 RID: 6642
		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private int fakeValue;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

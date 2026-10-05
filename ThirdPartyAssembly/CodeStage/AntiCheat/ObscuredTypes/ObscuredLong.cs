using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000573 RID: 1395
	[Token(Token = "0x2000573")]
	[Serializable]
	public struct ObscuredLong : IFormattable, IEquatable<ObscuredLong>, IComparable<ObscuredLong>, IComparable<long>, IComparable
	{
		// Token: 0x06002E88 RID: 11912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x54027F0", Offset = "0x54013F0", VA = "0x1854027F0")]
		private ObscuredLong(long value)
		{
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E89")]
		[Address(RVA = "0x5402590", Offset = "0x5401190", VA = "0x185402590")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x5401EF0", Offset = "0x5400AF0", VA = "0x185401EF0")]
		public static long Encrypt(long value)
		{
			return 0L;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x5401D60", Offset = "0x5400960", VA = "0x185401D60")]
		public static long Decrypt(long value)
		{
			return 0L;
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x5401E70", Offset = "0x5400A70", VA = "0x185401E70")]
		public static long Encrypt(long value, long key)
		{
			return 0L;
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00013AA0 File Offset: 0x00011CA0
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0x5401DF0", Offset = "0x54009F0", VA = "0x185401DF0")]
		public static long Decrypt(long value, long key)
		{
			return 0L;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x5401B00", Offset = "0x5400700", VA = "0x185401B00")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x5402350", Offset = "0x5400F50", VA = "0x185402350")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00013AB8 File Offset: 0x00011CB8
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x54021A0", Offset = "0x5400DA0", VA = "0x1854021A0")]
		public long GetEncrypted()
		{
			return 0L;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x5402400", Offset = "0x5401000", VA = "0x185402400")]
		public void SetEncrypted(long encrypted)
		{
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00013AD0 File Offset: 0x00011CD0
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x5402150", Offset = "0x5400D50", VA = "0x185402150")]
		public long GetDecrypted()
		{
			return 0L;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x5402250", Offset = "0x5400E50", VA = "0x185402250")]
		private long InternalDecrypt()
		{
			return 0L;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x5402930", Offset = "0x5401530", VA = "0x185402930")]
		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x5402960", Offset = "0x5401560", VA = "0x185402960")]
		public static implicit operator long(ObscuredLong value)
		{
			return 0L;
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00013B30 File Offset: 0x00011D30
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x54029B0", Offset = "0x54015B0", VA = "0x1854029B0")]
		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x5402880", Offset = "0x5401480", VA = "0x185402880")]
		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x6002E98")]
		[Address(RVA = "0x54021F0", Offset = "0x5400DF0", VA = "0x1854021F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x5402750", Offset = "0x5401350", VA = "0x185402750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x54025F0", Offset = "0x54011F0", VA = "0x1854025F0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x54026E0", Offset = "0x54012E0", VA = "0x1854026E0")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x5402660", Offset = "0x5401260", VA = "0x185402660", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00013B78 File Offset: 0x00011D78
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0x5401F80", Offset = "0x5400B80", VA = "0x185401F80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0x54020B0", Offset = "0x5400CB0", VA = "0x1854020B0", Slot = "5")]
		public bool Equals(ObscuredLong obj)
		{
			return default(bool);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00013BA8 File Offset: 0x00011DA8
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0x5401CE0", Offset = "0x54008E0", VA = "0x185401CE0", Slot = "6")]
		public int CompareTo(ObscuredLong other)
		{
			return 0;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0x5401C00", Offset = "0x5400800", VA = "0x185401C00", Slot = "7")]
		public int CompareTo(long other)
		{
			return 0;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x6002EA1")]
		[Address(RVA = "0x5401C70", Offset = "0x5400870", VA = "0x185401C70", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x0")]
		private static long cryptoKey;

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private long hiddenValue;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private long fakeValue;

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

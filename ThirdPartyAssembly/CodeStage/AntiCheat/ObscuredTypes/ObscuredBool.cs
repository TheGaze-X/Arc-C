using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000569 RID: 1385
	[Token(Token = "0x2000569")]
	[Serializable]
	public struct ObscuredBool : IEquatable<ObscuredBool>, IComparable<ObscuredBool>, IComparable<bool>, IComparable
	{
		// Token: 0x06002DC9 RID: 11721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x53F0890", Offset = "0x53EF490", VA = "0x1853F0890")]
		private ObscuredBool(bool value)
		{
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x53F0770", Offset = "0x53EF370", VA = "0x1853F0770")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00012EB8 File Offset: 0x000110B8
		[Token(Token = "0x6002DCB")]
		[Address(RVA = "0x53F00D0", Offset = "0x53EECD0", VA = "0x1853F00D0")]
		public static int Encrypt(bool value)
		{
			return 0;
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x00012ED0 File Offset: 0x000110D0
		[Token(Token = "0x6002DCC")]
		[Address(RVA = "0x53F0050", Offset = "0x53EEC50", VA = "0x1853F0050")]
		public static int Encrypt(bool value, byte key)
		{
			return 0;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x00012EE8 File Offset: 0x000110E8
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x53EFF50", Offset = "0x53EEB50", VA = "0x1853EFF50")]
		public static bool Decrypt(int value)
		{
			return default(bool);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00012F00 File Offset: 0x00011100
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x53EFFE0", Offset = "0x53EEBE0", VA = "0x1853EFFE0")]
		public static bool Decrypt(int value, byte key)
		{
			return default(bool);
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DCF")]
		[Address(RVA = "0x53EFC80", Offset = "0x53EE880", VA = "0x1853EFC80")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x53F0560", Offset = "0x53EF160", VA = "0x1853F0560")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00012F18 File Offset: 0x00011118
		[Token(Token = "0x6002DD1")]
		[Address(RVA = "0x53F0390", Offset = "0x53EEF90", VA = "0x1853F0390")]
		public int GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x53F05E0", Offset = "0x53EF1E0", VA = "0x1853F05E0")]
		public void SetEncrypted(int encrypted)
		{
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00012F30 File Offset: 0x00011130
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x53F0340", Offset = "0x53EEF40", VA = "0x1853F0340")]
		public bool GetDecrypted()
		{
			return default(bool);
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x53F0460", Offset = "0x53EF060", VA = "0x1853F0460")]
		private bool InternalDecrypt()
		{
			return default(bool);
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x53F0920", Offset = "0x53EF520", VA = "0x1853F0920")]
		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x53F0950", Offset = "0x53EF550", VA = "0x1853F0950")]
		public static implicit operator bool(ObscuredBool value)
		{
			return default(bool);
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x53F03E0", Offset = "0x53EEFE0", VA = "0x1853F03E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x53F07D0", Offset = "0x53EF3D0", VA = "0x1853F07D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x53F0200", Offset = "0x53EEE00", VA = "0x1853F0200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x53F0160", Offset = "0x53EED60", VA = "0x1853F0160", Slot = "4")]
		public bool Equals(ObscuredBool obj)
		{
			return default(bool);
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x53EFD90", Offset = "0x53EE990", VA = "0x1853EFD90", Slot = "5")]
		public int CompareTo(ObscuredBool other)
		{
			return 0;
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x53EFEC0", Offset = "0x53EEAC0", VA = "0x1853EFEC0", Slot = "6")]
		public int CompareTo(bool other)
		{
			return 0;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x53EFE30", Offset = "0x53EEA30", VA = "0x1853EFE30", Slot = "7")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x040019BF RID: 6591
		[Token(Token = "0x40019BF")]
		[FieldOffset(Offset = "0x0")]
		private static byte cryptoKey;

		// Token: 0x040019C0 RID: 6592
		[Token(Token = "0x40019C0")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private byte currentCryptoKey;

		// Token: 0x040019C1 RID: 6593
		[Token(Token = "0x40019C1")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private int hiddenValue;

		// Token: 0x040019C2 RID: 6594
		[Token(Token = "0x40019C2")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		// Token: 0x040019C3 RID: 6595
		[Token(Token = "0x40019C3")]
		[FieldOffset(Offset = "0x9")]
		[SerializeField]
		private bool fakeValue;

		// Token: 0x040019C4 RID: 6596
		[Token(Token = "0x40019C4")]
		[FieldOffset(Offset = "0xA")]
		[SerializeField]
		[FormerlySerializedAs("fakeValueChanged")]
		private bool fakeValueActive;
	}
}

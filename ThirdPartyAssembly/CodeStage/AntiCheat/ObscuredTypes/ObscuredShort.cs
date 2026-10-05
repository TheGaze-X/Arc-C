using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	[Serializable]
	public struct ObscuredShort : IFormattable, IEquatable<ObscuredShort>, IComparable<ObscuredShort>, IComparable<short>, IComparable
	{
		// Token: 0x06002F3C RID: 12092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x540D500", Offset = "0x540C100", VA = "0x18540D500")]
		private ObscuredShort(short value)
		{
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x540D2A0", Offset = "0x540BEA0", VA = "0x18540D2A0")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00014280 File Offset: 0x00012480
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x540CBF0", Offset = "0x540B7F0", VA = "0x18540CBF0")]
		public static short EncryptDecrypt(short value)
		{
			return 0;
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x540CB70", Offset = "0x540B770", VA = "0x18540CB70")]
		public static short EncryptDecrypt(short value, short key)
		{
			return 0;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x540C910", Offset = "0x540B510", VA = "0x18540C910")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x540D060", Offset = "0x540BC60", VA = "0x18540D060")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x540CEB0", Offset = "0x540BAB0", VA = "0x18540CEB0")]
		public short GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x540D110", Offset = "0x540BD10", VA = "0x18540D110")]
		public void SetEncrypted(short encrypted)
		{
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6002F44")]
		[Address(RVA = "0x540CE60", Offset = "0x540BA60", VA = "0x18540CE60")]
		public short GetDecrypted()
		{
			return 0;
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x540CF60", Offset = "0x540BB60", VA = "0x18540CF60")]
		private short InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x540D630", Offset = "0x540C230", VA = "0x18540D630")]
		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x540D660", Offset = "0x540C260", VA = "0x18540D660")]
		public static implicit operator short(ObscuredShort value)
		{
			return 0;
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x6002F48")]
		[Address(RVA = "0x540D6B0", Offset = "0x540C2B0", VA = "0x18540D6B0")]
		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x540D590", Offset = "0x540C190", VA = "0x18540D590")]
		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x540CF00", Offset = "0x540BB00", VA = "0x18540CF00", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x540D300", Offset = "0x540BF00", VA = "0x18540D300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x540D450", Offset = "0x540C050", VA = "0x18540D450")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x540D360", Offset = "0x540BF60", VA = "0x18540D360")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x540D3D0", Offset = "0x540BFD0", VA = "0x18540D3D0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x540CC80", Offset = "0x540B880", VA = "0x18540CC80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00014388 File Offset: 0x00012588
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x540CDC0", Offset = "0x540B9C0", VA = "0x18540CDC0", Slot = "5")]
		public bool Equals(ObscuredShort obj)
		{
			return default(bool);
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x540CAF0", Offset = "0x540B6F0", VA = "0x18540CAF0", Slot = "6")]
		public int CompareTo(ObscuredShort other)
		{
			return 0;
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x540CA80", Offset = "0x540B680", VA = "0x18540CA80", Slot = "7")]
		public int CompareTo(short other)
		{
			return 0;
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x540CA10", Offset = "0x540B610", VA = "0x18540CA10", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x0")]
		private static short cryptoKey;

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private short currentCryptoKey;

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x2")]
		[SerializeField]
		private short hiddenValue;

		// Token: 0x04001A33 RID: 6707
		[Token(Token = "0x4001A33")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A34 RID: 6708
		[Token(Token = "0x4001A34")]
		[FieldOffset(Offset = "0x6")]
		[SerializeField]
		private short fakeValue;

		// Token: 0x04001A35 RID: 6709
		[Token(Token = "0x4001A35")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

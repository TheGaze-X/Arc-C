using System;
using Il2CppDummyDll;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	[Serializable]
	public struct ObscuredUShort : IFormattable, IEquatable<ObscuredUShort>, IComparable<ObscuredUShort>, IComparable<ushort>, IComparable
	{
		// Token: 0x06002FAA RID: 12202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAA")]
		[Address(RVA = "0x54117F0", Offset = "0x54103F0", VA = "0x1854117F0")]
		private ObscuredUShort(ushort value)
		{
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAB")]
		[Address(RVA = "0x5411590", Offset = "0x5410190", VA = "0x185411590")]
		public static void SetNewCryptoKey(ushort newKey)
		{
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00014838 File Offset: 0x00012A38
		[Token(Token = "0x6002FAC")]
		[Address(RVA = "0x5410E90", Offset = "0x540FA90", VA = "0x185410E90")]
		public static ushort EncryptDecrypt(ushort value)
		{
			return 0;
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00014850 File Offset: 0x00012A50
		[Token(Token = "0x6002FAD")]
		[Address(RVA = "0x5410F20", Offset = "0x540FB20", VA = "0x185410F20")]
		public static ushort EncryptDecrypt(ushort value, ushort key)
		{
			return 0;
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAE")]
		[Address(RVA = "0x5410C30", Offset = "0x540F830", VA = "0x185410C30")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x5411380", Offset = "0x540FF80", VA = "0x185411380")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00014868 File Offset: 0x00012A68
		[Token(Token = "0x6002FB0")]
		[Address(RVA = "0x54111D0", Offset = "0x540FDD0", VA = "0x1854111D0")]
		public ushort GetEncrypted()
		{
			return 0;
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x5411400", Offset = "0x5410000", VA = "0x185411400")]
		public void SetEncrypted(ushort encrypted)
		{
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x00014880 File Offset: 0x00012A80
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x5411180", Offset = "0x540FD80", VA = "0x185411180")]
		public ushort GetDecrypted()
		{
			return 0;
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00014898 File Offset: 0x00012A98
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x5411280", Offset = "0x540FE80", VA = "0x185411280")]
		private ushort InternalDecrypt()
		{
			return 0;
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x000148B0 File Offset: 0x00012AB0
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x5411920", Offset = "0x5410520", VA = "0x185411920")]
		public static implicit operator ObscuredUShort(ushort value)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x000148C8 File Offset: 0x00012AC8
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x5411950", Offset = "0x5410550", VA = "0x185411950")]
		public static implicit operator ushort(ObscuredUShort value)
		{
			return 0;
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000148E0 File Offset: 0x00012AE0
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x54119A0", Offset = "0x54105A0", VA = "0x1854119A0")]
		public static ObscuredUShort operator ++(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x000148F8 File Offset: 0x00012AF8
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x5411880", Offset = "0x5410480", VA = "0x185411880")]
		public static ObscuredUShort operator --(ObscuredUShort input)
		{
			return default(ObscuredUShort);
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00014910 File Offset: 0x00012B10
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x5411220", Offset = "0x540FE20", VA = "0x185411220", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x54116E0", Offset = "0x54102E0", VA = "0x1854116E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x5411670", Offset = "0x5410270", VA = "0x185411670")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x5411740", Offset = "0x5410340", VA = "0x185411740")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x54115F0", Offset = "0x54101F0", VA = "0x1854115F0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00014928 File Offset: 0x00012B28
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x5411040", Offset = "0x540FC40", VA = "0x185411040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00014940 File Offset: 0x00012B40
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x5410FA0", Offset = "0x540FBA0", VA = "0x185410FA0", Slot = "5")]
		public bool Equals(ObscuredUShort obj)
		{
			return default(bool);
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00014958 File Offset: 0x00012B58
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x5410D30", Offset = "0x540F930", VA = "0x185410D30", Slot = "6")]
		public int CompareTo(ObscuredUShort other)
		{
			return 0;
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x5410E20", Offset = "0x540FA20", VA = "0x185410E20", Slot = "7")]
		public int CompareTo(ushort other)
		{
			return 0;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x5410DB0", Offset = "0x540F9B0", VA = "0x185410DB0", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04001A48 RID: 6728
		[Token(Token = "0x4001A48")]
		[FieldOffset(Offset = "0x0")]
		private static ushort cryptoKey;

		// Token: 0x04001A49 RID: 6729
		[Token(Token = "0x4001A49")]
		[FieldOffset(Offset = "0x0")]
		private ushort currentCryptoKey;

		// Token: 0x04001A4A RID: 6730
		[Token(Token = "0x4001A4A")]
		[FieldOffset(Offset = "0x2")]
		private ushort hiddenValue;

		// Token: 0x04001A4B RID: 6731
		[Token(Token = "0x4001A4B")]
		[FieldOffset(Offset = "0x4")]
		private bool inited;

		// Token: 0x04001A4C RID: 6732
		[Token(Token = "0x4001A4C")]
		[FieldOffset(Offset = "0x6")]
		private ushort fakeValue;

		// Token: 0x04001A4D RID: 6733
		[Token(Token = "0x4001A4D")]
		[FieldOffset(Offset = "0x8")]
		private bool fakeValueActive;
	}
}

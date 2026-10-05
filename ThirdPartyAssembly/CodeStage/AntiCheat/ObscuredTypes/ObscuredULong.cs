using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057E RID: 1406
	[Token(Token = "0x200057E")]
	[Serializable]
	public struct ObscuredULong : IFormattable, IEquatable<ObscuredULong>, IComparable<ObscuredULong>, IComparable<ulong>, IComparable
	{
		// Token: 0x06002F8F RID: 12175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x54109C0", Offset = "0x540F5C0", VA = "0x1854109C0")]
		private ObscuredULong(ulong value)
		{
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0x5410760", Offset = "0x540F360", VA = "0x185410760")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000146A0 File Offset: 0x000128A0
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x5410140", Offset = "0x540ED40", VA = "0x185410140")]
		public static ulong Encrypt(ulong value)
		{
			return 0UL;
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000146B8 File Offset: 0x000128B8
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x5410030", Offset = "0x540EC30", VA = "0x185410030")]
		public static ulong Decrypt(ulong value)
		{
			return 0UL;
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000146D0 File Offset: 0x000128D0
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x54100C0", Offset = "0x540ECC0", VA = "0x1854100C0")]
		public static ulong Encrypt(ulong value, ulong key)
		{
			return 0UL;
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000146E8 File Offset: 0x000128E8
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x540FFB0", Offset = "0x540EBB0", VA = "0x18540FFB0")]
		public static ulong Decrypt(ulong value, ulong key)
		{
			return 0UL;
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x540FD50", Offset = "0x540E950", VA = "0x18540FD50")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F96")]
		[Address(RVA = "0x5410550", Offset = "0x540F150", VA = "0x185410550")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00014700 File Offset: 0x00012900
		[Token(Token = "0x6002F97")]
		[Address(RVA = "0x54103A0", Offset = "0x540EFA0", VA = "0x1854103A0")]
		public ulong GetEncrypted()
		{
			return 0UL;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F98")]
		[Address(RVA = "0x54105D0", Offset = "0x540F1D0", VA = "0x1854105D0")]
		public void SetEncrypted(ulong encrypted)
		{
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00014718 File Offset: 0x00012918
		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x5410350", Offset = "0x540EF50", VA = "0x185410350")]
		public ulong GetDecrypted()
		{
			return 0UL;
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x00014730 File Offset: 0x00012930
		[Token(Token = "0x6002F9A")]
		[Address(RVA = "0x5410450", Offset = "0x540F050", VA = "0x185410450")]
		private ulong InternalDecrypt()
		{
			return 0UL;
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00014748 File Offset: 0x00012948
		[Token(Token = "0x6002F9B")]
		[Address(RVA = "0x5410B00", Offset = "0x540F700", VA = "0x185410B00")]
		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00014760 File Offset: 0x00012960
		[Token(Token = "0x6002F9C")]
		[Address(RVA = "0x5410B30", Offset = "0x540F730", VA = "0x185410B30")]
		public static implicit operator ulong(ObscuredULong value)
		{
			return 0UL;
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x6002F9D")]
		[Address(RVA = "0x5410B80", Offset = "0x540F780", VA = "0x185410B80")]
		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00014790 File Offset: 0x00012990
		[Token(Token = "0x6002F9E")]
		[Address(RVA = "0x5410A50", Offset = "0x540F650", VA = "0x185410A50")]
		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x6002F9F")]
		[Address(RVA = "0x54103F0", Offset = "0x540EFF0", VA = "0x1854103F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA0")]
		[Address(RVA = "0x54108A0", Offset = "0x540F4A0", VA = "0x1854108A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA1")]
		[Address(RVA = "0x54107C0", Offset = "0x540F3C0", VA = "0x1854107C0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA2")]
		[Address(RVA = "0x5410830", Offset = "0x540F430", VA = "0x185410830")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA3")]
		[Address(RVA = "0x5410900", Offset = "0x540F500", VA = "0x185410900", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000147C0 File Offset: 0x000129C0
		[Token(Token = "0x6002FA4")]
		[Address(RVA = "0x54101D0", Offset = "0x540EDD0", VA = "0x1854101D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000147D8 File Offset: 0x000129D8
		[Token(Token = "0x6002FA5")]
		[Address(RVA = "0x5410290", Offset = "0x540EE90", VA = "0x185410290", Slot = "5")]
		public bool Equals(ObscuredULong obj)
		{
			return default(bool);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000147F0 File Offset: 0x000129F0
		[Token(Token = "0x6002FA6")]
		[Address(RVA = "0x540FE50", Offset = "0x540EA50", VA = "0x18540FE50", Slot = "6")]
		public int CompareTo(ObscuredULong other)
		{
			return 0;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x6002FA7")]
		[Address(RVA = "0x540FF40", Offset = "0x540EB40", VA = "0x18540FF40", Slot = "7")]
		public int CompareTo(ulong other)
		{
			return 0;
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00014820 File Offset: 0x00012A20
		[Token(Token = "0x6002FA8")]
		[Address(RVA = "0x540FED0", Offset = "0x540EAD0", VA = "0x18540FED0", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04001A42 RID: 6722
		[Token(Token = "0x4001A42")]
		[FieldOffset(Offset = "0x0")]
		private static ulong cryptoKey;

		// Token: 0x04001A43 RID: 6723
		[Token(Token = "0x4001A43")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private ulong currentCryptoKey;

		// Token: 0x04001A44 RID: 6724
		[Token(Token = "0x4001A44")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private ulong hiddenValue;

		// Token: 0x04001A45 RID: 6725
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A46 RID: 6726
		[Token(Token = "0x4001A46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ulong fakeValue;

		// Token: 0x04001A47 RID: 6727
		[Token(Token = "0x4001A47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

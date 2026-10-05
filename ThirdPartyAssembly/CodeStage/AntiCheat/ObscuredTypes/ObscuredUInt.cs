using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	[Serializable]
	public struct ObscuredUInt : IFormattable, IEquatable<ObscuredUInt>, IComparable<ObscuredUInt>, IComparable<uint>, IComparable
	{
		// Token: 0x06002F73 RID: 12147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F73")]
		[Address(RVA = "0x540F9F0", Offset = "0x540E5F0", VA = "0x18540F9F0")]
		private ObscuredUInt(uint value)
		{
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F74")]
		[Address(RVA = "0x540F790", Offset = "0x540E390", VA = "0x18540F790")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x000144F0 File Offset: 0x000126F0
		[Token(Token = "0x6002F75")]
		[Address(RVA = "0x540F0B0", Offset = "0x540DCB0", VA = "0x18540F0B0")]
		public static uint Encrypt(uint value)
		{
			return 0U;
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x00014508 File Offset: 0x00012708
		[Token(Token = "0x6002F76")]
		[Address(RVA = "0x540F020", Offset = "0x540DC20", VA = "0x18540F020")]
		public static uint Decrypt(uint value)
		{
			return 0U;
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x00014520 File Offset: 0x00012720
		[Token(Token = "0x6002F77")]
		[Address(RVA = "0x540F140", Offset = "0x540DD40", VA = "0x18540F140")]
		public static uint Encrypt(uint value, uint key)
		{
			return 0U;
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x00014538 File Offset: 0x00012738
		[Token(Token = "0x6002F78")]
		[Address(RVA = "0x540EFA0", Offset = "0x540DBA0", VA = "0x18540EFA0")]
		public static uint Decrypt(uint value, uint key)
		{
			return 0U;
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x540ED40", Offset = "0x540D940", VA = "0x18540ED40")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x540F590", Offset = "0x540E190", VA = "0x18540F590")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x540F3E0", Offset = "0x540DFE0", VA = "0x18540F3E0")]
		public uint GetEncrypted()
		{
			return 0U;
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x540F610", Offset = "0x540E210", VA = "0x18540F610")]
		public void SetEncrypted(uint encrypted)
		{
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00014568 File Offset: 0x00012768
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x540F390", Offset = "0x540DF90", VA = "0x18540F390")]
		public uint GetDecrypted()
		{
			return 0U;
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x540F490", Offset = "0x540E090", VA = "0x18540F490")]
		private uint InternalDecrypt()
		{
			return 0U;
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00014598 File Offset: 0x00012798
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x540FC80", Offset = "0x540E880", VA = "0x18540FC80")]
		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000145B0 File Offset: 0x000127B0
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x540FC30", Offset = "0x540E830", VA = "0x18540FC30")]
		public static implicit operator uint(ObscuredUInt value)
		{
			return 0U;
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000145C8 File Offset: 0x000127C8
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x540FB20", Offset = "0x540E720", VA = "0x18540FB20")]
		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000145E0 File Offset: 0x000127E0
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x540FCB0", Offset = "0x540E8B0", VA = "0x18540FCB0")]
		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x540FA80", Offset = "0x540E680", VA = "0x18540FA80")]
		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00014610 File Offset: 0x00012810
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x540F430", Offset = "0x540E030", VA = "0x18540F430", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x540F950", Offset = "0x540E550", VA = "0x18540F950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x540F7F0", Offset = "0x540E3F0", VA = "0x18540F7F0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x540F860", Offset = "0x540E460", VA = "0x18540F860")]
		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x540F8D0", Offset = "0x540E4D0", VA = "0x18540F8D0", Slot = "4")]
		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00014628 File Offset: 0x00012828
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x540F1C0", Offset = "0x540DDC0", VA = "0x18540F1C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00014640 File Offset: 0x00012840
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x540F2F0", Offset = "0x540DEF0", VA = "0x18540F2F0", Slot = "5")]
		public bool Equals(ObscuredUInt obj)
		{
			return default(bool);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00014658 File Offset: 0x00012858
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x540EF20", Offset = "0x540DB20", VA = "0x18540EF20", Slot = "6")]
		public int CompareTo(ObscuredUInt other)
		{
			return 0;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00014670 File Offset: 0x00012870
		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x540EEB0", Offset = "0x540DAB0", VA = "0x18540EEB0", Slot = "7")]
		public int CompareTo(uint other)
		{
			return 0;
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x00014688 File Offset: 0x00012888
		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x540EE40", Offset = "0x540DA40", VA = "0x18540EE40", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x04001A3C RID: 6716
		[Token(Token = "0x4001A3C")]
		[FieldOffset(Offset = "0x0")]
		private static uint cryptoKey;

		// Token: 0x04001A3D RID: 6717
		[Token(Token = "0x4001A3D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private uint currentCryptoKey;

		// Token: 0x04001A3E RID: 6718
		[Token(Token = "0x4001A3E")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		private uint hiddenValue;

		// Token: 0x04001A3F RID: 6719
		[Token(Token = "0x4001A3F")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A40 RID: 6720
		[Token(Token = "0x4001A40")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private uint fakeValue;

		// Token: 0x04001A41 RID: 6721
		[Token(Token = "0x4001A41")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

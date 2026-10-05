using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057C RID: 1404
	[Token(Token = "0x200057C")]
	[Serializable]
	public sealed class ObscuredString : IComparable<ObscuredString>, IComparable<string>, IComparable
	{
		// Token: 0x06002F55 RID: 12117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private ObscuredString()
		{
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x540E8D0", Offset = "0x540D4D0", VA = "0x18540E8D0")]
		private ObscuredString(string value)
		{
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x540E7F0", Offset = "0x540D3F0", VA = "0x18540E7F0")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x540D990", Offset = "0x540C590", VA = "0x18540D990")]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x540DA10", Offset = "0x540C610", VA = "0x18540DA10")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x540D750", Offset = "0x540C350", VA = "0x18540D750")]
		public void ApplyNewCryptoKey()
		{
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5B")]
		[Address(RVA = "0x540E5E0", Offset = "0x540D1E0", VA = "0x18540E5E0")]
		public void RandomizeCryptoKey()
		{
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x540DFB0", Offset = "0x540CBB0", VA = "0x18540DFB0")]
		public string GetEncrypted()
		{
			return null;
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5D")]
		[Address(RVA = "0x540E6A0", Offset = "0x540D2A0", VA = "0x18540E6A0")]
		public void SetEncrypted(string encrypted)
		{
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5E")]
		[Address(RVA = "0x540DFA0", Offset = "0x540CBA0", VA = "0x18540DFA0")]
		public string GetDecrypted()
		{
			return null;
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F5F")]
		[Address(RVA = "0x540E4B0", Offset = "0x540D0B0", VA = "0x18540E4B0")]
		private static byte[] InternalEncrypt(string value)
		{
			return null;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F60")]
		[Address(RVA = "0x540E510", Offset = "0x540D110", VA = "0x18540E510")]
		private static byte[] InternalEncrypt(string value, string key)
		{
			return null;
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F61")]
		[Address(RVA = "0x540E250", Offset = "0x540CE50", VA = "0x18540E250")]
		private string InternalDecrypt()
		{
			return null;
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000143E8 File Offset: 0x000125E8
		[Token(Token = "0x170006EA")]
		public int Length
		{
			[Token(Token = "0x6002F62")]
			[Address(RVA = "0x540E9E0", Offset = "0x540D5E0", VA = "0x18540E9E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F63")]
		[Address(RVA = "0x540EB90", Offset = "0x540D790", VA = "0x18540EB90")]
		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F64")]
		[Address(RVA = "0x540EB10", Offset = "0x540D710", VA = "0x18540EB10")]
		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x00014400 File Offset: 0x00012600
		[Token(Token = "0x6002F65")]
		[Address(RVA = "0x540EA00", Offset = "0x540D600", VA = "0x18540EA00")]
		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x6002F66")]
		[Address(RVA = "0x540ECE0", Offset = "0x540D8E0", VA = "0x18540ECE0")]
		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return default(bool);
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x6002F67")]
		[Address(RVA = "0x540E170", Offset = "0x540CD70", VA = "0x18540E170", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x540DFA0", Offset = "0x540CBA0", VA = "0x18540DFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x540DCC0", Offset = "0x540C8C0", VA = "0x18540DCC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x540DB80", Offset = "0x540C780", VA = "0x18540DB80")]
		public bool Equals(ObscuredString value)
		{
			return default(bool);
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00014478 File Offset: 0x00012678
		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x540DE50", Offset = "0x540CA50", VA = "0x18540DE50")]
		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return default(bool);
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x540D910", Offset = "0x540C510", VA = "0x18540D910", Slot = "4")]
		public int CompareTo(ObscuredString other)
		{
			return 0;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x540D960", Offset = "0x540C560", VA = "0x18540D960", Slot = "5")]
		public int CompareTo(string other)
		{
			return 0;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000144C0 File Offset: 0x000126C0
		[Token(Token = "0x6002F6E")]
		[Address(RVA = "0x540D8E0", Offset = "0x540C4E0", VA = "0x18540D8E0", Slot = "6")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F6F")]
		[Address(RVA = "0x540DF10", Offset = "0x540CB10", VA = "0x18540DF10")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F70")]
		[Address(RVA = "0x540E1C0", Offset = "0x540CDC0", VA = "0x18540E1C0")]
		private static string GetString(byte[] bytes)
		{
			return null;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000144D8 File Offset: 0x000126D8
		[Token(Token = "0x6002F71")]
		[Address(RVA = "0x540D870", Offset = "0x540C470", VA = "0x18540D870")]
		private static bool ArraysEquals(byte[] a1, byte[] a2)
		{
			return default(bool);
		}

		// Token: 0x04001A36 RID: 6710
		[Token(Token = "0x4001A36")]
		[FieldOffset(Offset = "0x0")]
		private static string cryptoKey;

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string currentCryptoKey;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private byte[] hiddenValue;

		// Token: 0x04001A39 RID: 6713
		[Token(Token = "0x4001A39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool inited;

		// Token: 0x04001A3A RID: 6714
		[Token(Token = "0x4001A3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string fakeValue;

		// Token: 0x04001A3B RID: 6715
		[Token(Token = "0x4001A3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool fakeValueActive;
	}
}

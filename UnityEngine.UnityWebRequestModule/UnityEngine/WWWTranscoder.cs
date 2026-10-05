using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[VisibleToOtherModules(new string[]
	{
		"UnityEngine.UnityWebRequestWWWModule"
	})]
	internal class WWWTranscoder
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5B9E630", Offset = "0x5B9D230", VA = "0x185B9E630")]
		private static byte Hex2Byte(byte[] b, int offset)
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5B9DC50", Offset = "0x5B9C850", VA = "0x185B9DC50")]
		private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5B9E9E0", Offset = "0x5B9D5E0", VA = "0x185B9E9E0")]
		public static byte[] URLEncode(byte[] toEncode)
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5B9DDF0", Offset = "0x5B9C9F0", VA = "0x185B9DDF0")]
		public static string DataEncode(string toEncode, Encoding e)
		{
			return null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5B9DD70", Offset = "0x5B9C970", VA = "0x185B9DD70")]
		public static byte[] DataEncode(byte[] toEncode)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5B9E6C0", Offset = "0x5B9D2C0", VA = "0x185B9E6C0")]
		public static string QPEncode(string toEncode, Encoding e)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5B9E250", Offset = "0x5B9CE50", VA = "0x185B9E250")]
		public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5B9DC90", Offset = "0x5B9C890", VA = "0x185B9DC90")]
		private static bool ByteArrayContains(byte[] array, byte b)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B9E970", Offset = "0x5B9D570", VA = "0x185B9E970")]
		public static byte[] URLDecode(byte[] toEncode)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x5B9DCE0", Offset = "0x5B9C8E0", VA = "0x185B9DCE0")]
		private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand)
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5B9DF30", Offset = "0x5B9CB30", VA = "0x185B9DF30")]
		public static byte[] Decode(byte[] input, byte escapeChar, byte[] space)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5B9E830", Offset = "0x5B9D430", VA = "0x185B9E830")]
		public static bool SevenBitClean(string s, Encoding e)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5B9E800", Offset = "0x5B9D400", VA = "0x185B9E800")]
		public unsafe static bool SevenBitClean(byte* input, int inputLength)
		{
			return default(bool);
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] ucHexChars;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x8")]
		private static byte[] lcHexChars;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		private static byte urlEscapeChar;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] urlSpace;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		private static byte[] dataSpace;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] urlForbidden;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x30")]
		private static byte qpEscapeChar;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		private static byte[] qpSpace;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x40")]
		private static byte[] qpForbidden;
	}
}

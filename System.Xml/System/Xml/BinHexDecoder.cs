using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000001")]
		internal override bool IsFull
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x369D9D0", Offset = "0x369C5D0", VA = "0x18369D9D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4F733F0", Offset = "0x4F71FF0", VA = "0x184F733F0", Slot = "5")]
		internal override int Decode(char[] chars, int startPos, int len)
		{
			return 0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F73030", Offset = "0x4F71C30", VA = "0x184F73030")]
		public static byte[] Decode(char[] chars, bool allowOddChars)
		{
			return null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4F73260", Offset = "0x4F71E60", VA = "0x184F73260")]
		private unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buffer;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private int curIndex;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x1C")]
		private int endIndex;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		private bool hasHalfByteCached;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x21")]
		private byte cachedHalfByte;
	}
}

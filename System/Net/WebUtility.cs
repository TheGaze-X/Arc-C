using System;
using System.IO;
using System.Net.Configuration;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public static class WebUtility
	{
		// Token: 0x060013F8 RID: 5112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013F8")]
		[Address(RVA = "0x50673D0", Offset = "0x5065FD0", VA = "0x1850673D0")]
		public static string HtmlEncode(string value)
		{
			return null;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013F9")]
		[Address(RVA = "0x5066FC0", Offset = "0x5065BC0", VA = "0x185066FC0")]
		public static void HtmlEncode(string value, TextWriter output)
		{
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x60013FA")]
		[Address(RVA = "0x5067500", Offset = "0x5066100", VA = "0x185067500")]
		private static int IndexOfHtmlEncodingChars(string s, int startPos)
		{
			return 0;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x1700042B")]
		private static UnicodeEncodingConformance HtmlEncodeConformance
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x50679E0", Offset = "0x50665E0", VA = "0x1850679E0")]
			get
			{
				return UnicodeEncodingConformance.Auto;
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FC")]
		[Address(RVA = "0x5067620", Offset = "0x5066220", VA = "0x185067620")]
		private static string UrlDecodeInternal(string value, Encoding encoding)
		{
			return null;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013FD")]
		[Address(RVA = "0x50678A0", Offset = "0x50664A0", VA = "0x1850678A0")]
		public static string UrlDecode(string encodedValue)
		{
			return null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x60013FE")]
		[Address(RVA = "0x5066ED0", Offset = "0x5065AD0", VA = "0x185066ED0")]
		private unsafe static int GetNextUnicodeScalarValueFromUtf16Surrogate(ref char* pch, ref int charsRemaining)
		{
			return 0;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x60013FF")]
		[Address(RVA = "0x5066F80", Offset = "0x5065B80", VA = "0x185066F80")]
		private static int HexToInt(char h)
		{
			return 0;
		}

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] _htmlEntityEndingChars;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[FieldOffset(Offset = "0x8")]
		private static UnicodeDecodingConformance _htmlDecodeConformance;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		[FieldOffset(Offset = "0xC")]
		private static UnicodeEncodingConformance _htmlEncodeConformance;

		// Token: 0x020002CD RID: 717
		[Token(Token = "0x20002CD")]
		private class UrlDecoder
		{
			// Token: 0x06001401 RID: 5121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x505FB80", Offset = "0x505E780", VA = "0x18505FB80")]
			private void FlushBytes()
			{
			}

			// Token: 0x06001402 RID: 5122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001402")]
			[Address(RVA = "0x505FCB0", Offset = "0x505E8B0", VA = "0x18505FCB0")]
			internal UrlDecoder(int bufferSize, Encoding encoding)
			{
			}

			// Token: 0x06001403 RID: 5123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x505FB20", Offset = "0x505E720", VA = "0x18505FB20")]
			internal void AddChar(char ch)
			{
			}

			// Token: 0x06001404 RID: 5124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001404")]
			[Address(RVA = "0x505FA90", Offset = "0x505E690", VA = "0x18505FA90")]
			internal void AddByte(byte b)
			{
			}

			// Token: 0x06001405 RID: 5125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x505FC30", Offset = "0x505E830", VA = "0x18505FC30")]
			internal string GetString()
			{
				return null;
			}

			// Token: 0x04000AC6 RID: 2758
			[Token(Token = "0x4000AC6")]
			[FieldOffset(Offset = "0x10")]
			private int _bufferSize;

			// Token: 0x04000AC7 RID: 2759
			[Token(Token = "0x4000AC7")]
			[FieldOffset(Offset = "0x14")]
			private int _numChars;

			// Token: 0x04000AC8 RID: 2760
			[Token(Token = "0x4000AC8")]
			[FieldOffset(Offset = "0x18")]
			private char[] _charBuffer;

			// Token: 0x04000AC9 RID: 2761
			[Token(Token = "0x4000AC9")]
			[FieldOffset(Offset = "0x20")]
			private int _numBytes;

			// Token: 0x04000ACA RID: 2762
			[Token(Token = "0x4000ACA")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _byteBuffer;

			// Token: 0x04000ACB RID: 2763
			[Token(Token = "0x4000ACB")]
			[FieldOffset(Offset = "0x30")]
			private Encoding _encoding;
		}
	}
}

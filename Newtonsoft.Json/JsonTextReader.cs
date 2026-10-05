using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[Preserve]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4D7A0E0", Offset = "0x4D78CE0", VA = "0x184D7A0E0")]
		public JsonTextReader(TextReader reader)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000038")]
		public IArrayPool<char> ArrayPool
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x4D7A200", Offset = "0x4D78E00", VA = "0x184D7A200")]
			set
			{
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4D71650", Offset = "0x4D70250", VA = "0x184D71650")]
		private void EnsureBufferNotEmpty()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4D71D80", Offset = "0x4D70980", VA = "0x184D71D80")]
		private void OnNewLine(int pos)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4D74790", Offset = "0x4D73390", VA = "0x184D74790")]
		private void ParseString(char quote, ReadType readType)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4D712F0", Offset = "0x4D6FEF0", VA = "0x184D712F0")]
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4D79F30", Offset = "0x4D78B30", VA = "0x184D79F30")]
		private void ShiftBufferIfNeeded()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4D776A0", Offset = "0x4D762A0", VA = "0x184D776A0")]
		private int ReadData(bool append)
		{
			return 0;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4D776B0", Offset = "0x4D762B0", VA = "0x184D776B0")]
		private int ReadData(bool append, int charsRequired)
		{
			return 0;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4D71720", Offset = "0x4D70320", VA = "0x184D71720")]
		private bool EnsureChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x4D77610", Offset = "0x4D76210", VA = "0x184D77610")]
		private bool ReadChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x4D79C60", Offset = "0x4D78860", VA = "0x184D79C60", Slot = "12")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x4D77520", Offset = "0x4D76120", VA = "0x184D77520", Slot = "13")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x4D77330", Offset = "0x4D75F30", VA = "0x184D77330", Slot = "19")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4D775B0", Offset = "0x4D761B0", VA = "0x184D775B0", Slot = "14")]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4D769D0", Offset = "0x4D755D0", VA = "0x184D769D0", Slot = "15")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4D78E80", Offset = "0x4D77A80", VA = "0x184D78E80")]
		private object ReadStringValue(ReadType readType)
		{
			return null;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4D713F0", Offset = "0x4D6FFF0", VA = "0x184D713F0")]
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4D75D90", Offset = "0x4D74990", VA = "0x184D75D90", Slot = "17")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4D75D30", Offset = "0x4D74930", VA = "0x184D75D30")]
		private void ProcessValueComma()
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4D77D20", Offset = "0x4D76920", VA = "0x184D77D20")]
		private object ReadNumberValue(ReadType readType)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4D77280", Offset = "0x4D75E80", VA = "0x184D77280", Slot = "20")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4D773D0", Offset = "0x4D75FD0", VA = "0x184D773D0", Slot = "18")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4D77480", Offset = "0x4D76080", VA = "0x184D77480", Slot = "16")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4D717C0", Offset = "0x4D703C0", VA = "0x184D717C0")]
		private void HandleNull()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4D77930", Offset = "0x4D76530", VA = "0x184D77930")]
		private void ReadFinished()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4D77AA0", Offset = "0x4D766A0", VA = "0x184D77AA0")]
		private bool ReadNullChar()
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4D716C0", Offset = "0x4D702C0", VA = "0x184D716C0")]
		private void EnsureBuffer()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4D78800", Offset = "0x4D77400", VA = "0x184D78800")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4D7A070", Offset = "0x4D78C70", VA = "0x184D7A070")]
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4D74E30", Offset = "0x4D73A30", VA = "0x184D74E30")]
		private char ParseUnicode()
		{
			return '\0';
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4D77AF0", Offset = "0x4D766F0", VA = "0x184D77AF0")]
		private void ReadNumberIntoBuffer()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4D71310", Offset = "0x4D6FF10", VA = "0x184D71310")]
		private void ClearRecentString()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4D740F0", Offset = "0x4D72CF0", VA = "0x184D740F0")]
		private bool ParsePostValue()
		{
			return default(bool);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4D73F10", Offset = "0x4D72B10", VA = "0x184D73F10")]
		private bool ParseObject()
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4D74440", Offset = "0x4D73040", VA = "0x184D74440")]
		private bool ParseProperty()
		{
			return default(bool);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4D7A000", Offset = "0x4D78C00", VA = "0x184D7A000")]
		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4D74F20", Offset = "0x4D73B20", VA = "0x184D74F20")]
		private void ParseUnquotedProperty()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4D75170", Offset = "0x4D73D70", VA = "0x184D75170")]
		private bool ParseValue()
		{
			return default(bool);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4D75D10", Offset = "0x4D74910", VA = "0x184D75D10")]
		private void ProcessLineFeed()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4D75C30", Offset = "0x4D74830", VA = "0x184D75C30")]
		private void ProcessCarriageReturn(bool append)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4D714B0", Offset = "0x4D700B0", VA = "0x184D714B0")]
		private bool EatWhitespace(bool oneOrMore)
		{
			return default(bool);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4D72180", Offset = "0x4D70D80", VA = "0x184D72180")]
		private void ParseConstructor()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4D72ED0", Offset = "0x4D71AD0", VA = "0x184D72ED0")]
		private void ParseNumber(ReadType readType)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4D71D90", Offset = "0x4D70990", VA = "0x184D71D90")]
		private void ParseComment(bool setToken)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4D715E0", Offset = "0x4D701E0", VA = "0x184D715E0")]
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4D71CA0", Offset = "0x4D708A0", VA = "0x184D71CA0")]
		private bool MatchValue(string value)
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4D71A00", Offset = "0x4D70600", VA = "0x184D71A00")]
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default(bool);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4D718C0", Offset = "0x4D704C0", VA = "0x184D718C0")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4D74C00", Offset = "0x4D73800", VA = "0x184D74C00")]
		private void ParseTrue()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4D726E0", Offset = "0x4D712E0", VA = "0x184D726E0")]
		private void ParseNull()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4D74D30", Offset = "0x4D73930", VA = "0x184D74D30")]
		private void ParseUndefined()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x4D725B0", Offset = "0x4D711B0", VA = "0x184D725B0")]
		private void ParseFalse()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4D72A30", Offset = "0x4D71630", VA = "0x184D72A30")]
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x4D72C80", Offset = "0x4D71880", VA = "0x184D72C80")]
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4D727E0", Offset = "0x4D713E0", VA = "0x184D727E0")]
		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4D71330", Offset = "0x4D6FF30", VA = "0x184D71330", Slot = "22")]
		public override void Close()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "23")]
		public bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x17000039")]
		public int LineNumber
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x4D7A190", Offset = "0x4D78D90", VA = "0x184D7A190", Slot = "24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x1700003A")]
		public int LinePosition
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x4D7A1F0", Offset = "0x4D78DF0", VA = "0x184D7A1F0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		private const char UnicodeReplacementChar = '�';

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		private const int MaximumJavascriptIntegerCharacterLength = 380;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x78")]
		private readonly TextReader _reader;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x80")]
		private char[] _chars;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x88")]
		private int _charsUsed;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x8C")]
		private int _charPos;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x90")]
		private int _lineStartPos;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x94")]
		private int _lineNumber;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x98")]
		private bool _isEndOfFile;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuffer _stringBuffer;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0xB0")]
		private StringReference _stringReference;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0xC0")]
		private IArrayPool<char> _arrayPool;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0xC8")]
		internal PropertyNameTable NameTable;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace GCloud.UQM.MiniJSON
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public static class Json
	{
		// Token: 0x06000101 RID: 257 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x559E770", Offset = "0x559D370", VA = "0x18559E770")]
		public static object Deserialize(string json)
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x559E780", Offset = "0x559D380", VA = "0x18559E780")]
		public static string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		private sealed class Parser : IDisposable
		{
			// Token: 0x06000103 RID: 259 RVA: 0x000021D8 File Offset: 0x000003D8
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x559EB90", Offset = "0x559D790", VA = "0x18559EB90")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x559F7E0", Offset = "0x559E3E0", VA = "0x18559F7E0")]
			private Parser(string jsonString)
			{
			}

			// Token: 0x06000105 RID: 261 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x559F680", Offset = "0x559E280", VA = "0x18559F680")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x4A2A6B0", Offset = "0x4A292B0", VA = "0x184A2A6B0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000107 RID: 263 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x559F1E0", Offset = "0x559DDE0", VA = "0x18559F1E0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			// Token: 0x06000108 RID: 264 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x559EC20", Offset = "0x559D820", VA = "0x18559EC20")]
			private List<object> ParseArray()
			{
				return null;
			}

			// Token: 0x06000109 RID: 265 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x559F650", Offset = "0x559E250", VA = "0x18559F650")]
			private object ParseValue()
			{
				return null;
			}

			// Token: 0x0600010A RID: 266 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x559ED30", Offset = "0x559D930", VA = "0x18559ED30")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			// Token: 0x0600010B RID: 267 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x559F360", Offset = "0x559DF60", VA = "0x18559F360")]
			private string ParseString()
			{
				return null;
			}

			// Token: 0x0600010C RID: 268 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x559F110", Offset = "0x559DD10", VA = "0x18559F110")]
			private object ParseNumber()
			{
				return null;
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x559EAB0", Offset = "0x559D6B0", VA = "0x18559EAB0")]
			private void EatWhitespace()
			{
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600010E RID: 270 RVA: 0x000021F0 File Offset: 0x000003F0
			[Token(Token = "0x17000008")]
			private char PeekChar
			{
				[Token(Token = "0x600010E")]
				[Address(RVA = "0x559FD60", Offset = "0x559E960", VA = "0x18559FD60")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x17000009")]
			private char NextChar
			{
				[Token(Token = "0x600010F")]
				[Address(RVA = "0x559F870", Offset = "0x559E470", VA = "0x18559F870")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000110 RID: 272 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x1700000A")]
			private string NextWord
			{
				[Token(Token = "0x6000110")]
				[Address(RVA = "0x559FC00", Offset = "0x559E800", VA = "0x18559FC00")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000111 RID: 273 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x1700000B")]
			private Json.Parser.TOKEN NextToken
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0x559F8F0", Offset = "0x559E4F0", VA = "0x18559F8F0")]
				get
				{
					return Json.Parser.TOKEN.NONE;
				}
			}

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			private const string WORD_BREAK = "{}[],:\"";

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			// Token: 0x02000019 RID: 25
			[Token(Token = "0x2000019")]
			private enum TOKEN
			{
				// Token: 0x0400003E RID: 62
				[Token(Token = "0x400003E")]
				NONE,
				// Token: 0x0400003F RID: 63
				[Token(Token = "0x400003F")]
				CURLY_OPEN,
				// Token: 0x04000040 RID: 64
				[Token(Token = "0x4000040")]
				CURLY_CLOSE,
				// Token: 0x04000041 RID: 65
				[Token(Token = "0x4000041")]
				SQUARED_OPEN,
				// Token: 0x04000042 RID: 66
				[Token(Token = "0x4000042")]
				SQUARED_CLOSE,
				// Token: 0x04000043 RID: 67
				[Token(Token = "0x4000043")]
				COLON,
				// Token: 0x04000044 RID: 68
				[Token(Token = "0x4000044")]
				COMMA,
				// Token: 0x04000045 RID: 69
				[Token(Token = "0x4000045")]
				STRING,
				// Token: 0x04000046 RID: 70
				[Token(Token = "0x4000046")]
				NUMBER,
				// Token: 0x04000047 RID: 71
				[Token(Token = "0x4000047")]
				TRUE,
				// Token: 0x04000048 RID: 72
				[Token(Token = "0x4000048")]
				FALSE,
				// Token: 0x04000049 RID: 73
				[Token(Token = "0x4000049")]
				NULL
			}
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		private sealed class Serializer
		{
			// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x55A0B50", Offset = "0x559F750", VA = "0x1855A0B50")]
			private Serializer()
			{
			}

			// Token: 0x06000113 RID: 275 RVA: 0x0000209A File Offset: 0x0000029A
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x559E780", Offset = "0x559D380", VA = "0x18559E780")]
			public static string Serialize(object obj)
			{
				return null;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x55A0920", Offset = "0x559F520", VA = "0x1855A0920")]
			private void SerializeValue(object value)
			{
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x55A0060", Offset = "0x559EC60", VA = "0x1855A0060")]
			private void SerializeObject(IDictionary obj)
			{
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x559FDE0", Offset = "0x559E9E0", VA = "0x18559FDE0")]
			private void SerializeArray(IList anArray)
			{
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x55A0610", Offset = "0x559F210", VA = "0x1855A0610")]
			private void SerializeString(string str)
			{
			}

			// Token: 0x06000118 RID: 280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x55A0370", Offset = "0x559EF70", VA = "0x1855A0370")]
			private void SerializeOther(object value)
			{
			}

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;
		}
	}
}

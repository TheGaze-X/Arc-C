using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace U8.SDK.MiniJSON
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public static class Json
	{
		// Token: 0x060002CE RID: 718 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x4A2A5A0", Offset = "0x4A291A0", VA = "0x184A2A5A0")]
		public static object Deserialize(string json)
		{
			return null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x4A2A5B0", Offset = "0x4A291B0", VA = "0x184A2A5B0")]
		public static string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		private sealed class Parser : IDisposable
		{
			// Token: 0x060002D0 RID: 720 RVA: 0x00002984 File Offset: 0x00000B84
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x4A2A7C0", Offset = "0x4A293C0", VA = "0x184A2A7C0")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x4A2B4C0", Offset = "0x4A2A0C0", VA = "0x184A2B4C0")]
			private Parser(string jsonString)
			{
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x4A2B360", Offset = "0x4A29F60", VA = "0x184A2B360")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x4A2A6B0", Offset = "0x4A292B0", VA = "0x184A2A6B0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x4A2AEC0", Offset = "0x4A29AC0", VA = "0x184A2AEC0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x4A2A850", Offset = "0x4A29450", VA = "0x184A2A850")]
			private List<object> ParseArray()
			{
				return null;
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x4A2B330", Offset = "0x4A29F30", VA = "0x184A2B330")]
			private object ParseValue()
			{
				return null;
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x4A2A9C0", Offset = "0x4A295C0", VA = "0x184A2A9C0")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x4A2B040", Offset = "0x4A29C40", VA = "0x184A2B040")]
			private string ParseString()
			{
				return null;
			}

			// Token: 0x060002D9 RID: 729 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x4A2ADF0", Offset = "0x4A299F0", VA = "0x184A2ADF0")]
			private object ParseNumber()
			{
				return null;
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x4A2A6F0", Offset = "0x4A292F0", VA = "0x184A2A6F0")]
			private void EatWhitespace()
			{
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060002DB RID: 731 RVA: 0x0000299C File Offset: 0x00000B9C
			[Token(Token = "0x1700004A")]
			private char PeekChar
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x4A2BA50", Offset = "0x4A2A650", VA = "0x184A2BA50")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060002DC RID: 732 RVA: 0x000029B4 File Offset: 0x00000BB4
			[Token(Token = "0x1700004B")]
			private char NextChar
			{
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x4A2B550", Offset = "0x4A2A150", VA = "0x184A2B550")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060002DD RID: 733 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x1700004C")]
			private string NextWord
			{
				[Token(Token = "0x60002DD")]
				[Address(RVA = "0x4A2B8E0", Offset = "0x4A2A4E0", VA = "0x184A2B8E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060002DE RID: 734 RVA: 0x000029CC File Offset: 0x00000BCC
			[Token(Token = "0x1700004D")]
			private Json.Parser.TOKEN NextToken
			{
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0x4A2B5D0", Offset = "0x4A2A1D0", VA = "0x184A2B5D0")]
				get
				{
					return Json.Parser.TOKEN.NONE;
				}
			}

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			private const string WORD_BREAK = "{}[],:\"";

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			// Token: 0x02000099 RID: 153
			[Token(Token = "0x2000099")]
			private enum TOKEN
			{
				// Token: 0x04000280 RID: 640
				[Token(Token = "0x4000280")]
				NONE,
				// Token: 0x04000281 RID: 641
				[Token(Token = "0x4000281")]
				CURLY_OPEN,
				// Token: 0x04000282 RID: 642
				[Token(Token = "0x4000282")]
				CURLY_CLOSE,
				// Token: 0x04000283 RID: 643
				[Token(Token = "0x4000283")]
				SQUARED_OPEN,
				// Token: 0x04000284 RID: 644
				[Token(Token = "0x4000284")]
				SQUARED_CLOSE,
				// Token: 0x04000285 RID: 645
				[Token(Token = "0x4000285")]
				COLON,
				// Token: 0x04000286 RID: 646
				[Token(Token = "0x4000286")]
				COMMA,
				// Token: 0x04000287 RID: 647
				[Token(Token = "0x4000287")]
				STRING,
				// Token: 0x04000288 RID: 648
				[Token(Token = "0x4000288")]
				NUMBER,
				// Token: 0x04000289 RID: 649
				[Token(Token = "0x4000289")]
				TRUE,
				// Token: 0x0400028A RID: 650
				[Token(Token = "0x400028A")]
				FALSE,
				// Token: 0x0400028B RID: 651
				[Token(Token = "0x400028B")]
				NULL
			}
		}

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		private sealed class Serializer
		{
			// Token: 0x060002DF RID: 735 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x4A2C910", Offset = "0x4A2B510", VA = "0x184A2C910")]
			private Serializer()
			{
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x4A2A5B0", Offset = "0x4A291B0", VA = "0x184A2A5B0")]
			public static string Serialize(object obj)
			{
				return null;
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x4A2C6E0", Offset = "0x4A2B2E0", VA = "0x184A2C6E0")]
			private void SerializeValue(object value)
			{
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x4A2BE20", Offset = "0x4A2AA20", VA = "0x184A2BE20")]
			private void SerializeObject(IDictionary obj)
			{
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x4A2BBA0", Offset = "0x4A2A7A0", VA = "0x184A2BBA0")]
			private void SerializeArray(IList anArray)
			{
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x4A2C3D0", Offset = "0x4A2AFD0", VA = "0x184A2C3D0")]
			private void SerializeString(string str)
			{
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x4A2C130", Offset = "0x4A2AD30", VA = "0x184A2C130")]
			private void SerializeOther(object value)
			{
			}

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;
		}
	}
}

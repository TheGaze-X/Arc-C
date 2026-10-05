using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public class Json
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4E06FB0", Offset = "0x4E05BB0", VA = "0x184E06FB0")]
		public static object decode(string json)
		{
			return null;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000089")]
		public static T decode<T>(string json, [Optional] string rootElement) where T : new()
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008A")]
		public static T decodeObject<T>(object jsonObject, [Optional] string rootElement) where T : new()
		{
			return null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4E07130", Offset = "0x4E05D30", VA = "0x184E07130")]
		public static string encode(object obj)
		{
			return null;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4E071D0", Offset = "0x4E05DD0", VA = "0x184E071D0")]
		public static object jsonDecode(string json)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4E07220", Offset = "0x4E05E20", VA = "0x184E07220")]
		public static string jsonEncode(object obj)
		{
			return null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Json()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool useSimpleJson;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		internal class ObjectDecoder
		{
			// Token: 0x06000090 RID: 144 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000090")]
			public static object decode<T>(string json, [Optional] string rootElement) where T : new()
			{
				return null;
			}

			// Token: 0x06000091 RID: 145 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000091")]
			private object decode<T>(object decodedJsonObject, [Optional] string rootElement) where T : new()
			{
				return null;
			}

			// Token: 0x06000092 RID: 146 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x4E0D850", Offset = "0x4E0C450", VA = "0x184E0D850")]
			private Dictionary<string, Action<object, object>> getMemberInfoForObject(object obj)
			{
				return null;
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4E0D890", Offset = "0x4E0C490", VA = "0x184E0D890")]
			private static Dictionary<string, Action<object, object>> getMembersWithSetters(object obj)
			{
				return null;
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4E0D600", Offset = "0x4E0C200", VA = "0x184E0D600")]
			public object createAndPopulateObjectFromDictionary(Type objectType, Dictionary<string, object> dict)
			{
				return null;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ObjectDecoder()
			{
			}

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, Action<object, object>> _memberInfo;
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		internal class Deserializer
		{
			// Token: 0x0600009A RID: 154 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4E05170", Offset = "0x4E03D70", VA = "0x184E05170")]
			public static object deserialize(string json)
			{
				return null;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4E050F0", Offset = "0x4E03CF0", VA = "0x184E050F0")]
			private Deserializer(string json)
			{
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4E05140", Offset = "0x4E03D40", VA = "0x184E05140")]
			private object deserialize()
			{
				return null;
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4E05FB0", Offset = "0x4E04BB0", VA = "0x184E05FB0")]
			protected object parseValue(char[] json, ref int index)
			{
				return null;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x4E059C0", Offset = "0x4E045C0", VA = "0x184E059C0")]
			private IDictionary parseObject(char[] json, ref int index)
			{
				return null;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4E05650", Offset = "0x4E04250", VA = "0x184E05650")]
			private IList parseArray(char[] json, ref int index)
			{
				return null;
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4E05B10", Offset = "0x4E04710", VA = "0x184E05B10")]
			private string parseString(char[] json, ref int index)
			{
				return null;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x4E05760", Offset = "0x4E04360", VA = "0x184E05760")]
			private object parseNumber(char[] json, ref int index)
			{
				return null;
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x4E05290", Offset = "0x4E03E90", VA = "0x184E05290")]
			private int getLastIndexOfNumber(char[] json, int index)
			{
				return 0;
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x4E05210", Offset = "0x4E03E10", VA = "0x184E05210")]
			private void eatWhitespace(char[] json, ref int index)
			{
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4E05310", Offset = "0x4E03F10", VA = "0x184E05310")]
			private Json.Deserializer.JsonToken lookAhead(char[] json, int index)
			{
				return Json.Deserializer.JsonToken.None;
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00002238 File Offset: 0x00000438
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4E05330", Offset = "0x4E03F30", VA = "0x184E05330")]
			private Json.Deserializer.JsonToken nextToken(char[] json, ref int index)
			{
				return Json.Deserializer.JsonToken.None;
			}

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private char[] charArray;

			// Token: 0x0200001A RID: 26
			[Token(Token = "0x200001A")]
			private enum JsonToken
			{
				// Token: 0x04000048 RID: 72
				[Token(Token = "0x4000048")]
				None,
				// Token: 0x04000049 RID: 73
				[Token(Token = "0x4000049")]
				CurlyOpen,
				// Token: 0x0400004A RID: 74
				[Token(Token = "0x400004A")]
				CurlyClose,
				// Token: 0x0400004B RID: 75
				[Token(Token = "0x400004B")]
				SquaredOpen,
				// Token: 0x0400004C RID: 76
				[Token(Token = "0x400004C")]
				SquaredClose,
				// Token: 0x0400004D RID: 77
				[Token(Token = "0x400004D")]
				Colon,
				// Token: 0x0400004E RID: 78
				[Token(Token = "0x400004E")]
				Comma,
				// Token: 0x0400004F RID: 79
				[Token(Token = "0x400004F")]
				String,
				// Token: 0x04000050 RID: 80
				[Token(Token = "0x4000050")]
				Number,
				// Token: 0x04000051 RID: 81
				[Token(Token = "0x4000051")]
				True,
				// Token: 0x04000052 RID: 82
				[Token(Token = "0x4000052")]
				False,
				// Token: 0x04000053 RID: 83
				[Token(Token = "0x4000053")]
				Null
			}
		}

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		internal class Serializer
		{
			// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4E11F30", Offset = "0x4E10B30", VA = "0x184E11F30")]
			private Serializer()
			{
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4E13270", Offset = "0x4E11E70", VA = "0x184E13270")]
			public static string serialize(object obj)
			{
				return null;
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x4E12AC0", Offset = "0x4E116C0", VA = "0x184E12AC0")]
			private void serializeObject(object value)
			{
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x4E12850", Offset = "0x4E11450", VA = "0x184E12850")]
			private void serializeIList(IList anArray)
			{
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x4E12510", Offset = "0x4E11110", VA = "0x184E12510")]
			private void serializeIDictionary(IDictionary dict)
			{
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x4E122C0", Offset = "0x4E10EC0", VA = "0x184E122C0")]
			private void serializeDictionary(Dictionary<string, object> dict)
			{
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x4E12ED0", Offset = "0x4E11AD0", VA = "0x184E12ED0")]
			private void serializeString(string str)
			{
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x4E11FA0", Offset = "0x4E10BA0", VA = "0x184E11FA0")]
			private void serializeClass(object value)
			{
			}

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder _builder;
		}
	}
}

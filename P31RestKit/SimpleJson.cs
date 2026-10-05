using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class SimpleJson
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x4E137C0", Offset = "0x4E123C0", VA = "0x184E137C0")]
		public static string encode(object obj)
		{
			return null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4E15C40", Offset = "0x4E14840", VA = "0x184E15C40")]
		public static bool tryDeserializeObject(string json, out object obj)
		{
			return default(bool);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4E13640", Offset = "0x4E12240", VA = "0x184E13640")]
		public static object decode(string json)
		{
			return null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4E13730", Offset = "0x4E12330", VA = "0x184E13730")]
		private static object decode(string json, Type type)
		{
			return null;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C0")]
		public static T decode<T>(string json)
		{
			return null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C1")]
		public static T decode<T>(string json, string rootElement) where T : new()
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4E13370", Offset = "0x4E11F70", VA = "0x184E13370")]
		private static object decode(string json, Type type, [Optional] string rootElement)
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C3")]
		public static T decodeObject<T>(object jsonObject, [Optional] string rootElement)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4E14360", Offset = "0x4E12F60", VA = "0x184E14360")]
		protected static IDictionary<string, object> parseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4E13F60", Offset = "0x4E12B60", VA = "0x184E13F60")]
		protected static JsonArray parseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4E14950", Offset = "0x4E13550", VA = "0x184E14950")]
		protected static object parseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4E144D0", Offset = "0x4E130D0", VA = "0x184E144D0")]
		protected static string parseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4E140A0", Offset = "0x4E12CA0", VA = "0x184E140A0")]
		protected static object parseNumber(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4E13870", Offset = "0x4E12470", VA = "0x184E13870")]
		protected static int getLastIndexOfNumber(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4E13740", Offset = "0x4E12340", VA = "0x184E13740")]
		protected static void eatWhitespace(char[] json, ref int index)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4E13C20", Offset = "0x4E12820", VA = "0x184E13C20")]
		protected static int lookAhead(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4E13C40", Offset = "0x4E12840", VA = "0x184E13C40")]
		protected static int nextToken(char[] json, ref int index)
		{
			return 0;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4E157A0", Offset = "0x4E143A0", VA = "0x184E157A0")]
		protected static bool serializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4E15370", Offset = "0x4E13F70", VA = "0x184E15370")]
		protected static bool serializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4E14D10", Offset = "0x4E13910", VA = "0x184E14D10")]
		protected static bool serializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4E155B0", Offset = "0x4E141B0", VA = "0x184E155B0")]
		protected static bool serializeString(string aString, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4E14F60", Offset = "0x4E13B60", VA = "0x184E14F60")]
		protected static bool serializeNumber(object number, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4E13A90", Offset = "0x4E12690", VA = "0x184E13A90")]
		protected static bool isNumeric(object value)
		{
			return default(bool);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public static IJsonSerializerStrategy currentJsonSerializerStrategy
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x4E138F0", Offset = "0x4E124F0", VA = "0x184E138F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x4E15BE0", Offset = "0x4E147E0", VA = "0x184E15BE0")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000012")]
		public static PocoJsonSerializerStrategy pocoJsonSerializerStrategy
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x4E139F0", Offset = "0x4E125F0", VA = "0x184E139F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SimpleJson()
		{
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		private const int TOKEN_NONE = 0;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		private const int TOKEN_CURLY_OPEN = 1;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		private const int TOKEN_CURLY_CLOSE = 2;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		private const int TOKEN_SQUARED_OPEN = 3;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		private const int TOKEN_SQUARED_CLOSE = 4;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		private const int TOKEN_COLON = 5;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		private const int TOKEN_COMMA = 6;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		private const int TOKEN_STRING = 7;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		private const int TOKEN_NUMBER = 8;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		private const int TOKEN_TRUE = 9;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		private const int TOKEN_FALSE = 10;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		private const int TOKEN_NULL = 11;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		private const int BUILDER_CAPACITY = 2000;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;
	}
}

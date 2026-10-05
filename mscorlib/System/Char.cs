using System;
using System.Globalization;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C0 RID: 192
	[Token(Token = "0x20000C0")]
	[System.Serializable]
	public readonly struct Char : System.IComparable, System.IComparable<char>, System.IEquatable<char>, System.IConvertible
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x4CA96B0", Offset = "0x4CA82B0", VA = "0x184CA96B0")]
		private static bool IsLatin1(char ch)
		{
			return default(bool);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x4CA9430", Offset = "0x4CA8030", VA = "0x184CA9430")]
		private static bool IsAscii(char ch)
		{
			return default(bool);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x4CA9100", Offset = "0x4CA7D00", VA = "0x184CA9100")]
		private static System.Globalization.UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			return System.Globalization.UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x4CA90F0", Offset = "0x4CA7CF0", VA = "0x184CA90F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x4CA9050", Offset = "0x4CA7C50", VA = "0x184CA9050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x4CA90E0", Offset = "0x4CA7CE0", VA = "0x184CA90E0", Slot = "6")]
		[NonVersionable]
		public bool Equals(char obj)
		{
			return default(bool);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x4CA8CD0", Offset = "0x4CA78D0", VA = "0x184CA8CD0", Slot = "4")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x4CA8CC0", Offset = "0x4CA78C0", VA = "0x184CA8CC0", Slot = "5")]
		public int CompareTo(char value)
		{
			return 0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x4CAADE0", Offset = "0x4CA99E0", VA = "0x184CAADE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x4CAAE30", Offset = "0x4CA9A30", VA = "0x184CAAE30", Slot = "22")]
		public string ToString(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x4CAAE80", Offset = "0x4CA9A80", VA = "0x184CAAE80")]
		public static string ToString(char c)
		{
			return null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x4CAA430", Offset = "0x4CA9030", VA = "0x184CAA430")]
		public static char Parse(string s)
		{
			return '\0';
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x4CAB0F0", Offset = "0x4CA9CF0", VA = "0x184CAB0F0")]
		public static bool TryParse(string s, out char result)
		{
			return default(bool);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x4CA94D0", Offset = "0x4CA80D0", VA = "0x184CA94D0")]
		public static bool IsDigit(char c)
		{
			return default(bool);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x4CA8C70", Offset = "0x4CA7870", VA = "0x184CA8C70")]
		internal static bool CheckLetter(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x4CA9900", Offset = "0x4CA8500", VA = "0x184CA9900")]
		public static bool IsLetter(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x4CAA1D0", Offset = "0x4CA8DD0", VA = "0x184CAA1D0")]
		private static bool IsWhiteSpaceLatin1(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x4CAA200", Offset = "0x4CA8E00", VA = "0x184CAA200")]
		public static bool IsWhiteSpace(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x4CAA110", Offset = "0x4CA8D10", VA = "0x184CAA110")]
		public static bool IsUpper(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x4CA9A00", Offset = "0x4CA8600", VA = "0x184CA9A00")]
		public static bool IsLower(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x4CA8C90", Offset = "0x4CA7890", VA = "0x184CA8C90")]
		internal static bool CheckPunctuation(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x4CA9D60", Offset = "0x4CA8960", VA = "0x184CA9D60")]
		public static bool IsPunctuation(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x4CA8C60", Offset = "0x4CA7860", VA = "0x184CA8C60")]
		internal static bool CheckLetterOrDigit(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x4CA96C0", Offset = "0x4CA82C0", VA = "0x184CA96C0")]
		public static bool IsLetterOrDigit(char c)
		{
			return default(bool);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x4CAB010", Offset = "0x4CA9C10", VA = "0x184CAB010")]
		public static char ToUpper(char c, System.Globalization.CultureInfo culture)
		{
			return '\0';
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x4CAAF50", Offset = "0x4CA9B50", VA = "0x184CAAF50")]
		public static char ToUpper(char c)
		{
			return '\0';
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x4CAAE90", Offset = "0x4CA9A90", VA = "0x184CAAE90")]
		public static char ToUpperInvariant(char c)
		{
			return '\0';
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x4CAAC40", Offset = "0x4CA9840", VA = "0x184CAAC40")]
		public static char ToLower(char c, System.Globalization.CultureInfo culture)
		{
			return '\0';
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4CAAD20", Offset = "0x4CA9920", VA = "0x184CAAD20")]
		public static char ToLower(char c)
		{
			return '\0';
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4CAAB80", Offset = "0x4CA9780", VA = "0x184CAAB80")]
		public static char ToLowerInvariant(char c)
		{
			return '\0';
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "7")]
		public System.TypeCode GetTypeCode()
		{
			return System.TypeCode.Empty;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x4CAA500", Offset = "0x4CA9100", VA = "0x184CAA500", Slot = "8")]
		private bool ToBoolean(System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x3D28B50", Offset = "0x3D27750", VA = "0x183D28B50", Slot = "9")]
		private char ToChar(System.IFormatProvider provider)
		{
			return '\0';
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x4CAA8E0", Offset = "0x4CA94E0", VA = "0x184CAA8E0", Slot = "10")]
		private sbyte ToSByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x4CAA590", Offset = "0x4CA9190", VA = "0x184CAA590", Slot = "11")]
		private byte ToByte(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x4CAA7C0", Offset = "0x4CA93C0", VA = "0x184CAA7C0", Slot = "12")]
		private short ToInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x4CAAA90", Offset = "0x4CA9690", VA = "0x184CAAA90", Slot = "13")]
		private ushort ToUInt16(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x4CAA840", Offset = "0x4CA9440", VA = "0x184CAA840", Slot = "14")]
		private int ToInt32(System.IFormatProvider provider)
		{
			return 0;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x4CAAAE0", Offset = "0x4CA96E0", VA = "0x184CAAAE0", Slot = "15")]
		private uint ToUInt32(System.IFormatProvider provider)
		{
			return 0U;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x4CAA890", Offset = "0x4CA9490", VA = "0x184CAA890", Slot = "16")]
		private long ToInt64(System.IFormatProvider provider)
		{
			return 0L;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x4CAAB30", Offset = "0x4CA9730", VA = "0x184CAAB30", Slot = "17")]
		private ulong ToUInt64(System.IFormatProvider provider)
		{
			return 0UL;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x4CAA960", Offset = "0x4CA9560", VA = "0x184CAA960", Slot = "18")]
		private float ToSingle(System.IFormatProvider provider)
		{
			return 0f;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x4CAA730", Offset = "0x4CA9330", VA = "0x184CAA730", Slot = "19")]
		private double ToDouble(System.IFormatProvider provider)
		{
			return 0.0;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x4CAA6A0", Offset = "0x4CA92A0", VA = "0x184CAA6A0", Slot = "20")]
		private decimal ToDecimal(System.IFormatProvider provider)
		{
			return 0m;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x4CAA610", Offset = "0x4CA9210", VA = "0x184CAA610", Slot = "21")]
		private System.DateTime ToDateTime(System.IFormatProvider provider)
		{
			return default(System.DateTime);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x4CAA9F0", Offset = "0x4CA95F0", VA = "0x184CAA9F0", Slot = "23")]
		private object ToType(System.Type type, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x4CA9440", Offset = "0x4CA8040", VA = "0x184CA9440")]
		public static bool IsControl(char c)
		{
			return default(bool);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4CA9770", Offset = "0x4CA8370", VA = "0x184CA9770")]
		public static bool IsLetterOrDigit(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x4CA8C80", Offset = "0x4CA7880", VA = "0x184CA8C80")]
		internal static bool CheckNumber(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x4CA9AC0", Offset = "0x4CA86C0", VA = "0x184CA9AC0")]
		public static bool IsNumber(char c)
		{
			return default(bool);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x4CA9BA0", Offset = "0x4CA87A0", VA = "0x184CA9BA0")]
		public static bool IsNumber(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4CA8CA0", Offset = "0x4CA78A0", VA = "0x184CA8CA0")]
		internal static bool CheckSeparator(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x4CA9E10", Offset = "0x4CA8A10", VA = "0x184CA9E10")]
		private static bool IsSeparatorLatin1(char c)
		{
			return default(bool);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x4CA9E30", Offset = "0x4CA8A30", VA = "0x184CA9E30")]
		public static bool IsSeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x4CAA040", Offset = "0x4CA8C40", VA = "0x184CAA040")]
		public static bool IsSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x4CA9F10", Offset = "0x4CA8B10", VA = "0x184CA9F10")]
		public static bool IsSurrogate(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x4CA8CB0", Offset = "0x4CA78B0", VA = "0x184CA8CB0")]
		internal static bool CheckSymbol(System.Globalization.UnicodeCategory uc)
		{
			return default(bool);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x4CAA060", Offset = "0x4CA8C60", VA = "0x184CAA060")]
		public static bool IsSymbol(char c)
		{
			return default(bool);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4CAA2A0", Offset = "0x4CA8EA0", VA = "0x184CAA2A0")]
		public static bool IsWhiteSpace(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4CA9240", Offset = "0x4CA7E40", VA = "0x184CA9240")]
		public static System.Globalization.UnicodeCategory GetUnicodeCategory(char c)
		{
			return System.Globalization.UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x4CA92C0", Offset = "0x4CA7EC0", VA = "0x184CA92C0")]
		public static System.Globalization.UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			return System.Globalization.UnicodeCategory.UppercaseLetter;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x4CA9170", Offset = "0x4CA7D70", VA = "0x184CA9170")]
		public static double GetNumericValue(char c)
		{
			return 0.0;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x4CA9180", Offset = "0x4CA7D80", VA = "0x184CA9180")]
		public static double GetNumericValue(string s, int index)
		{
			return 0.0;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4CA9690", Offset = "0x4CA8290", VA = "0x184CA9690")]
		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x4CA9550", Offset = "0x4CA8150", VA = "0x184CA9550")]
		public static bool IsHighSurrogate(string s, int index)
		{
			return default(bool);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x4CA99E0", Offset = "0x4CA85E0", VA = "0x184CA99E0")]
		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x4CA9EE0", Offset = "0x4CA8AE0", VA = "0x184CA9EE0")]
		public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			return default(bool);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x4CA8DB0", Offset = "0x4CA79B0", VA = "0x184CA8DB0")]
		public static string ConvertFromUtf32(int utf32)
		{
			return null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x4CA8EF0", Offset = "0x4CA7AF0", VA = "0x184CA8EF0")]
		public static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			return 0;
		}

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x0")]
		private readonly char m_value;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		public const char MaxValue = '￿';

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		public const char MinValue = '\0';

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] s_categoryForLatin1;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		internal const int UNICODE_PLANE00_END = 65535;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		internal const int UNICODE_PLANE01_START = 65536;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		internal const int UNICODE_PLANE16_END = 1114111;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		internal const int HIGH_SURROGATE_START = 55296;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		internal const int LOW_SURROGATE_END = 57343;
	}
}

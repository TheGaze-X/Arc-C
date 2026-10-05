using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace BestHTTP.JSON
{
	// Token: 0x020004D1 RID: 1233
	[Token(Token = "0x20004D1")]
	public class Json
	{
		// Token: 0x060028D0 RID: 10448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x53AB100", Offset = "0x53A9D00", VA = "0x1853AB100")]
		public static object Decode(string json)
		{
			return null;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x53AB140", Offset = "0x53A9D40", VA = "0x1853AB140")]
		public static object Decode(string json, ref bool success)
		{
			return null;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x53AB210", Offset = "0x53A9E10", VA = "0x1853AB210")]
		public static string Encode(object json)
		{
			return null;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x53AB900", Offset = "0x53AA500", VA = "0x1853AB900")]
		protected static Dictionary<string, object> ParseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x53AB660", Offset = "0x53AA260", VA = "0x1853AB660")]
		protected static List<object> ParseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x53ABDC0", Offset = "0x53AA9C0", VA = "0x1853ABDC0")]
		protected static object ParseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x53ABA60", Offset = "0x53AA660", VA = "0x1853ABA60")]
		protected static string ParseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00011508 File Offset: 0x0000F708
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x53AB770", Offset = "0x53AA370", VA = "0x1853AB770")]
		protected static double ParseNumber(char[] json, ref int index, ref bool success)
		{
			return 0.0;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00011520 File Offset: 0x0000F720
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x53AB2C0", Offset = "0x53A9EC0", VA = "0x1853AB2C0")]
		protected static int GetLastIndexOfNumber(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x53AB190", Offset = "0x53A9D90", VA = "0x1853AB190")]
		protected static void EatWhitespace(char[] json, ref int index)
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00011538 File Offset: 0x0000F738
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x53AB340", Offset = "0x53A9F40", VA = "0x1853AB340")]
		protected static int LookAhead(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x53AB360", Offset = "0x53A9F60", VA = "0x1853AB360")]
		protected static int NextToken(char[] json, ref int index)
		{
			return 0;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x53AC970", Offset = "0x53AB570", VA = "0x1853AC970")]
		protected static bool SerializeValue(object value, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x60028DD")]
		[Address(RVA = "0x53AC490", Offset = "0x53AB090", VA = "0x1853AC490")]
		protected static bool SerializeObject(IDictionary anObject, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x60028DE")]
		[Address(RVA = "0x53AC170", Offset = "0x53AAD70", VA = "0x1853AC170")]
		protected static bool SerializeArray(IList anArray, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x60028DF")]
		[Address(RVA = "0x53AC670", Offset = "0x53AB270", VA = "0x1853AC670")]
		protected static bool SerializeString(string aString, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[Token(Token = "0x60028E0")]
		[Address(RVA = "0x53AC3E0", Offset = "0x53AAFE0", VA = "0x1853AC3E0")]
		protected static bool SerializeNumber(double number, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Json()
		{
		}

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		private const int TOKEN_NONE = 0;

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		private const int TOKEN_CURLY_OPEN = 1;

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		private const int TOKEN_CURLY_CLOSE = 2;

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		private const int TOKEN_SQUARED_OPEN = 3;

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		private const int TOKEN_SQUARED_CLOSE = 4;

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		private const int TOKEN_COLON = 5;

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		private const int TOKEN_COMMA = 6;

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		private const int TOKEN_STRING = 7;

		// Token: 0x0400169E RID: 5790
		[Token(Token = "0x400169E")]
		private const int TOKEN_NUMBER = 8;

		// Token: 0x0400169F RID: 5791
		[Token(Token = "0x400169F")]
		private const int TOKEN_TRUE = 9;

		// Token: 0x040016A0 RID: 5792
		[Token(Token = "0x40016A0")]
		private const int TOKEN_FALSE = 10;

		// Token: 0x040016A1 RID: 5793
		[Token(Token = "0x40016A1")]
		private const int TOKEN_NULL = 11;

		// Token: 0x040016A2 RID: 5794
		[Token(Token = "0x40016A2")]
		private const int BUILDER_CAPACITY = 2000;
	}
}

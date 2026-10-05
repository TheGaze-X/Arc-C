using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Preserve]
	internal static class EnumUtils
	{
		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4D874D0", Offset = "0x4D860D0", VA = "0x184D874D0")]
		private static BidirectionalDictionary<string, string> InitializeEnumType(Type type)
		{
			return null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		public static IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			return null;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		public static IList<EnumValue<ulong>> GetNamesAndValues<T>() where T : struct
		{
			return null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		public static IList<EnumValue<TUnderlyingType>> GetNamesAndValues<TUnderlyingType>(Type enumType) where TUnderlyingType : struct
		{
			return null;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4D87090", Offset = "0x4D85C90", VA = "0x184D87090")]
		public static IList<object> GetValues(Type enumType)
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4D86C70", Offset = "0x4D85870", VA = "0x184D86C70")]
		public static IList<string> GetNames(Type enumType)
		{
			return null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4D87950", Offset = "0x4D86550", VA = "0x184D87950")]
		public static object ParseEnumName(string enumText, bool isNullable, Type t)
		{
			return null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4D87D00", Offset = "0x4D86900", VA = "0x184D87D00")]
		public static string ToEnumName(Type enumType, string enumText, bool camelCaseText)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4D87C80", Offset = "0x4D86880", VA = "0x184D87C80")]
		private static string ResolvedEnumName(BidirectionalDictionary<string, string> map, string enumText)
		{
			return null;
		}

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, BidirectionalDictionary<string, string>> EnumMemberNamesPerType;
	}
}

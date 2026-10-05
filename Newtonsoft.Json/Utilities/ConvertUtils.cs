using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	[Preserve]
	internal static class ConvertUtils
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x4D7EFF0", Offset = "0x4D7DBF0", VA = "0x184D7EFF0")]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return PrimitiveTypeCode.Empty;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x4D7F050", Offset = "0x4D7DC50", VA = "0x184D7F050")]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return PrimitiveTypeCode.Empty;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x4D7F310", Offset = "0x4D7DF10", VA = "0x184D7F310")]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4D7F8D0", Offset = "0x4D7E4D0", VA = "0x184D7F8D0")]
		public static bool IsConvertible(Type t)
		{
			return default(bool);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x4D7FA80", Offset = "0x4D7E680", VA = "0x184D7FA80")]
		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x4D7EA50", Offset = "0x4D7D650", VA = "0x184D7EA50")]
		private static Func<object, object> CreateCastConverter(ConvertUtils.TypeConvertKey t)
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x4D7E790", Offset = "0x4D7D390", VA = "0x184D7E790")]
		public static object Convert(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x4D80630", Offset = "0x4D7F230", VA = "0x184D80630")]
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return default(bool);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4D7FC20", Offset = "0x4D7E820", VA = "0x184D7FC20")]
		private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return ConvertUtils.ConvertResult.Success;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x4D7E580", Offset = "0x4D7D180", VA = "0x184D7E580")]
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4D7ECA0", Offset = "0x4D7D8A0", VA = "0x184D7ECA0")]
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4D7EFA0", Offset = "0x4D7DBA0", VA = "0x184D7EFA0")]
		internal static TypeConverter GetConverter(Type t)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x4D806E0", Offset = "0x4D7F2E0", VA = "0x184D806E0")]
		public static bool VersionTryParse(string input, out Version result)
		{
			return default(bool);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x4D7F970", Offset = "0x4D7E570", VA = "0x184D7F970")]
		public static bool IsInteger(object value)
		{
			return default(bool);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x4D7F600", Offset = "0x4D7E200", VA = "0x184D7F600")]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return ParseResult.None;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4D7F770", Offset = "0x4D7E370", VA = "0x184D7F770")]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return ParseResult.None;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x4D7FAD0", Offset = "0x4D7E6D0", VA = "0x184D7FAD0")]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default(bool);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x4D7F490", Offset = "0x4D7E090", VA = "0x184D7F490")]
		public static int HexTextToInt(char[] text, int start, int end)
		{
			return 0;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x4D7F3B0", Offset = "0x4D7DFB0", VA = "0x184D7F3B0")]
		private static int HexCharToInt(char ch)
		{
			return 0;
		}

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<ConvertUtils.TypeConvertKey, Func<object, object>> CastConverters;

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		internal struct TypeConvertKey
		{
			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000099")]
			public Type InitialType
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700009A")]
			public Type TargetType
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
			public TypeConvertKey(Type initialType, Type targetType)
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00003090 File Offset: 0x00001290
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x4D9AFD0", Offset = "0x4D99BD0", VA = "0x184D9AFD0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06000336 RID: 822 RVA: 0x000030A8 File Offset: 0x000012A8
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x4D9AF10", Offset = "0x4D99B10", VA = "0x184D9AF10", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000337 RID: 823 RVA: 0x000030C0 File Offset: 0x000012C0
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x4D9AFB0", Offset = "0x4D99BB0", VA = "0x184D9AFB0")]
			public bool Equals(ConvertUtils.TypeConvertKey other)
			{
				return default(bool);
			}

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x0")]
			private readonly Type _initialType;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x8")]
			private readonly Type _targetType;
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		internal enum ConvertResult
		{
			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			Success,
			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			CannotConvertNull,
			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			NotInstantiableType,
			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			NoValidConversion
		}
	}
}

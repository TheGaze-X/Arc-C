using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	internal sealed class RegexCharClass
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x50F9900", Offset = "0x50F8500", VA = "0x1850F9900")]
		public RegexCharClass()
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x50F99D0", Offset = "0x50F85D0", VA = "0x1850F99D0")]
		private RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x170000F3")]
		public bool CanMerge
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x50F9A50", Offset = "0x50F8650", VA = "0x1850F9A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F4")]
		public bool Negate
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			set
			{
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x50EDEC0", Offset = "0x50ECAC0", VA = "0x1850EDEC0")]
		public void AddChar(char c)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x50EDC90", Offset = "0x50EC890", VA = "0x1850EDC90")]
		public void AddCharClass(RegexCharClass cc)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x50EE430", Offset = "0x50ED030", VA = "0x1850EE430")]
		private void AddSet(string set)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
		public void AddSubtraction(RegexCharClass sub)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x50EE330", Offset = "0x50ECF30", VA = "0x1850EE330")]
		public void AddRange(char first, char last)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x50ED9E0", Offset = "0x50EC5E0", VA = "0x1850ED9E0")]
		public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x50EDC70", Offset = "0x50EC870", VA = "0x1850EDC70")]
		private void AddCategory(string category)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x50EE1F0", Offset = "0x50ECDF0", VA = "0x1850EE1F0")]
		public void AddLowercase(CultureInfo culture)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x50EDF80", Offset = "0x50ECB80", VA = "0x1850EDF80")]
		private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x50EE780", Offset = "0x50ED380", VA = "0x1850EE780")]
		public void AddWord(bool ecma, bool negate)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x50EE650", Offset = "0x50ED250", VA = "0x1850EE650")]
		public void AddSpace(bool ecma, bool negate)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x50EDED0", Offset = "0x50ECAD0", VA = "0x1850EDED0")]
		public void AddDigit(bool ecma, bool negate, string pattern)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x50EFCF0", Offset = "0x50EE8F0", VA = "0x1850EFCF0")]
		public static char SingletonChar(string set)
		{
			return '\0';
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x50EF2A0", Offset = "0x50EDEA0", VA = "0x1850EF2A0")]
		public static bool IsMergeable(string charClass)
		{
			return default(bool);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x50EF1C0", Offset = "0x50EDDC0", VA = "0x1850EF1C0")]
		public static bool IsEmpty(string charClass)
		{
			return default(bool);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x50EF4D0", Offset = "0x50EE0D0", VA = "0x1850EF4D0")]
		public static bool IsSingleton(string set)
		{
			return default(bool);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x50EF3A0", Offset = "0x50EDFA0", VA = "0x1850EF3A0")]
		public static bool IsSingletonInverse(string set)
		{
			return default(bool);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x50EF600", Offset = "0x50EE200", VA = "0x1850EF600")]
		private static bool IsSubtraction(string charClass)
		{
			return default(bool);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x50EF370", Offset = "0x50EDF70", VA = "0x1850EF370")]
		private static bool IsNegated(string set)
		{
			return default(bool);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x50EF120", Offset = "0x50EDD20", VA = "0x1850EF120")]
		public static bool IsECMAWordChar(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x50EF660", Offset = "0x50EE260", VA = "0x1850EF660")]
		public static bool IsWordChar(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x50EF060", Offset = "0x50EDC60", VA = "0x1850EF060")]
		public static bool CharInClass(char ch, string set)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x50EEF20", Offset = "0x50EDB20", VA = "0x1850EEF20")]
		private static bool CharInClassRecursive(char ch, string set, int start)
		{
			return default(bool);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x50EED20", Offset = "0x50ED920", VA = "0x1850EED20")]
		private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			return default(bool);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x50EEBB0", Offset = "0x50ED7B0", VA = "0x1850EEBB0")]
		private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			return default(bool);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x50EEAE0", Offset = "0x50ED6E0", VA = "0x1850EEAE0")]
		private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			return default(bool);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x50EF730", Offset = "0x50EE330", VA = "0x1850EF730")]
		private static string NegateCategory(string category)
		{
			return null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x50EFA10", Offset = "0x50EE610", VA = "0x1850EFA10")]
		public static RegexCharClass Parse(string charClass)
		{
			return null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x50EF7C0", Offset = "0x50EE3C0", VA = "0x1850EF7C0")]
		private static RegexCharClass ParseRecursive(string charClass, int start)
		{
			return null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x50EFA60", Offset = "0x50EE660", VA = "0x1850EFA60")]
		private int RangeCount()
		{
			return 0;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x50EFD10", Offset = "0x50EE910", VA = "0x1850EFD10")]
		public string ToStringClass()
		{
			return null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x50EF0C0", Offset = "0x50EDCC0", VA = "0x1850EF0C0")]
		private RegexCharClass.SingleRange GetRangeAt(int i)
		{
			return default(RegexCharClass.SingleRange);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x50EE8B0", Offset = "0x50ED4B0", VA = "0x1850EE8B0")]
		private void Canonicalize()
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x50EFAA0", Offset = "0x50EE6A0", VA = "0x1850EFAA0")]
		private static string SetFromProperty(string capname, bool invert, string pattern)
		{
			return null;
		}

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_internalRegexIgnoreCase;

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_space;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_notSpace;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_word;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string s_notWord;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string SpaceClass;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string NotSpaceClass;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string WordClass;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string NotWordClass;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string DigitClass;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string NotDigitClass;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x58")]
		private static readonly Dictionary<string, string> s_definedCategories;

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x60")]
		private static readonly string[][] s_propTable;

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x68")]
		private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable;

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x10")]
		private List<RegexCharClass.SingleRange> _rangelist;

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x18")]
		private StringBuilder _categories;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x20")]
		private bool _canonical;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x21")]
		private bool _negate;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x28")]
		private RegexCharClass _subtractor;

		// Token: 0x020000ED RID: 237
		[Token(Token = "0x20000ED")]
		private readonly struct LowerCaseMapping
		{
			// Token: 0x06000576 RID: 1398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x50EAC90", Offset = "0x50E9890", VA = "0x1850EAC90")]
			internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
			}

			// Token: 0x040003AF RID: 943
			[Token(Token = "0x40003AF")]
			[FieldOffset(Offset = "0x0")]
			public readonly char ChMin;

			// Token: 0x040003B0 RID: 944
			[Token(Token = "0x40003B0")]
			[FieldOffset(Offset = "0x2")]
			public readonly char ChMax;

			// Token: 0x040003B1 RID: 945
			[Token(Token = "0x40003B1")]
			[FieldOffset(Offset = "0x4")]
			public readonly int LcOp;

			// Token: 0x040003B2 RID: 946
			[Token(Token = "0x40003B2")]
			[FieldOffset(Offset = "0x8")]
			public readonly int Data;
		}

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x20000EE")]
		private sealed class SingleRangeComparer : IComparer<RegexCharClass.SingleRange>
		{
			// Token: 0x06000577 RID: 1399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private SingleRangeComparer()
			{
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00004170 File Offset: 0x00002370
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x5103190", Offset = "0x5101D90", VA = "0x185103190", Slot = "4")]
			public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				return 0;
			}

			// Token: 0x040003B3 RID: 947
			[Token(Token = "0x40003B3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly RegexCharClass.SingleRangeComparer Instance;
		}

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x20000EF")]
		private readonly struct SingleRange
		{
			// Token: 0x0600057A RID: 1402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x4009790", Offset = "0x4008390", VA = "0x184009790")]
			internal SingleRange(char first, char last)
			{
			}

			// Token: 0x040003B4 RID: 948
			[Token(Token = "0x40003B4")]
			[FieldOffset(Offset = "0x0")]
			public readonly char First;

			// Token: 0x040003B5 RID: 949
			[Token(Token = "0x40003B5")]
			[FieldOffset(Offset = "0x2")]
			public readonly char Last;
		}
	}
}

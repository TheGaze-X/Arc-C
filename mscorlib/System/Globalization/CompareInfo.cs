using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200055A RID: 1370
	[Token(Token = "0x200055A")]
	[System.Serializable]
	public class CompareInfo : System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x06002857 RID: 10327 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x4C0EDB0", Offset = "0x4C0D9B0", VA = "0x184C0EDB0")]
		internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x4C0EE90", Offset = "0x4C0DA90", VA = "0x184C0EE90")]
		internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x4C0E9D0", Offset = "0x4C0D5D0", VA = "0x184C0E9D0")]
		private unsafe static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start)
		{
			return 0;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x4C0EF80", Offset = "0x4C0DB80", VA = "0x184C0EF80")]
		private static char InvariantToUpper(char c)
		{
			return '\0';
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x4C0E700", Offset = "0x4C0D300", VA = "0x184C0E700")]
		private SortKey InvariantCreateSortKey(string source, CompareOptions options)
		{
			return null;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x4C0FF20", Offset = "0x4C0EB20", VA = "0x184C0FF20")]
		internal CompareInfo(CultureInfo culture)
		{
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x4C0D5D0", Offset = "0x4C0C1D0", VA = "0x184C0D5D0")]
		public static CompareInfo GetCompareInfo(string name)
		{
			return null;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285F")]
		[Address(RVA = "0x4C0FBF0", Offset = "0x4C0E7F0", VA = "0x184C0FBF0", Slot = "4")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002860")]
		[Address(RVA = "0x4C0FBF0", Offset = "0x4C0E7F0", VA = "0x184C0FBF0")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002861")]
		[Address(RVA = "0x4C0FB40", Offset = "0x4C0E740", VA = "0x184C0FB40")]
		private void OnDeserialized()
		{
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x4C0FC00", Offset = "0x4C0E800", VA = "0x184C0FC00")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005D7")]
		public virtual string Name
		{
			[Token(Token = "0x6002863")]
			[Address(RVA = "0x4C0FF70", Offset = "0x4C0EB70", VA = "0x184C0FF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000162C0 File Offset: 0x000144C0
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x4C0C790", Offset = "0x4C0B390", VA = "0x184C0C790", Slot = "6")]
		public virtual int Compare(string string1, string string2)
		{
			return 0;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x000162D8 File Offset: 0x000144D8
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x4C0BF30", Offset = "0x4C0AB30", VA = "0x184C0BF30", Slot = "7")]
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x000162F0 File Offset: 0x000144F0
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x4C0C7F0", Offset = "0x4C0B3F0", VA = "0x184C0C7F0")]
		internal int Compare(System.ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x6002867")]
		[Address(RVA = "0x4C0B5D0", Offset = "0x4C0A1D0", VA = "0x184C0B5D0")]
		internal int CompareOptionIgnoreCase(System.ReadOnlySpan<char> string1, System.ReadOnlySpan<char> string2)
		{
			return 0;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00016320 File Offset: 0x00014520
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x4C0C1E0", Offset = "0x4C0ADE0", VA = "0x184C0C1E0", Slot = "8")]
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00016338 File Offset: 0x00014538
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x4C0B9F0", Offset = "0x4C0A5F0", VA = "0x184C0B9F0")]
		internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB)
		{
			return 0;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00016350 File Offset: 0x00014550
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x4C0B800", Offset = "0x4C0A400", VA = "0x184C0B800")]
		internal static int CompareOrdinalIgnoreCase(System.ReadOnlySpan<char> strA, System.ReadOnlySpan<char> strB)
		{
			return 0;
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00016368 File Offset: 0x00014568
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x4C0EFA0", Offset = "0x4C0DBA0", VA = "0x184C0EFA0", Slot = "9")]
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x4C0F230", Offset = "0x4C0DE30", VA = "0x184C0F230", Slot = "10")]
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x4C0D110", Offset = "0x4C0BD10", VA = "0x184C0D110")]
		internal bool IsSuffix(System.ReadOnlySpan<char> source, System.ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x000163B0 File Offset: 0x000145B0
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x4C0E2A0", Offset = "0x4C0CEA0", VA = "0x184C0E2A0", Slot = "11")]
		public virtual int IndexOf(string source, string value, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x4C0E340", Offset = "0x4C0CF40", VA = "0x184C0E340", Slot = "12")]
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x000163E0 File Offset: 0x000145E0
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x4C0E0E0", Offset = "0x4C0CCE0", VA = "0x184C0E0E0")]
		internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x4C0FAA0", Offset = "0x4C0E6A0", VA = "0x184C0FAA0", Slot = "13")]
		public virtual int LastIndexOf(string source, string value, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00016410 File Offset: 0x00014610
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x4C0F5D0", Offset = "0x4C0E1D0", VA = "0x184C0F5D0", Slot = "14")]
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00016428 File Offset: 0x00014628
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x4C0F490", Offset = "0x4C0E090", VA = "0x184C0F490")]
		internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x4C0DF40", Offset = "0x4C0CB40", VA = "0x184C0DF40", Slot = "15")]
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			return null;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00016440 File Offset: 0x00014640
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x4C0D190", Offset = "0x4C0BD90", VA = "0x184C0D190", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00016458 File Offset: 0x00014658
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x4C0DAA0", Offset = "0x4C0C6A0", VA = "0x184C0DAA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00016470 File Offset: 0x00014670
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x4C0DB10", Offset = "0x4C0C710", VA = "0x184C0DB10")]
		internal static int GetIgnoreCaseHash(string source)
		{
			return 0;
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00016488 File Offset: 0x00014688
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x4C0D740", Offset = "0x4C0C340", VA = "0x184C0D740")]
		internal int GetHashCodeOfString(string source, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000164A0 File Offset: 0x000146A0
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x4C0D970", Offset = "0x4C0C570", VA = "0x184C0D970", Slot = "16")]
		public virtual int GetHashCode(string source, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x4C0FDD0", Offset = "0x4C0E9D0", VA = "0x184C0FDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600287B RID: 10363 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x170005D8")]
		private static bool UseManagedCollation
		{
			[Token(Token = "0x600287B")]
			[Address(RVA = "0x4C0FFF0", Offset = "0x4C0EBF0", VA = "0x184C0FFF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x4C0D2A0", Offset = "0x4C0BEA0", VA = "0x184C0D2A0")]
		private ISimpleCollator GetCollator()
		{
			return null;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x4C0CC50", Offset = "0x4C0B850", VA = "0x184C0CC50")]
		private SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			return null;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x4C106E0", Offset = "0x4C0F2E0", VA = "0x184C106E0")]
		private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			return 0;
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x000164E8 File Offset: 0x000146E8
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x4C10350", Offset = "0x4C0EF50", VA = "0x184C10350")]
		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x4C10230", Offset = "0x4C0EE30", VA = "0x184C10230")]
		private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x4C10630", Offset = "0x4C0F230", VA = "0x184C10630")]
		private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			return 0;
		}

		// Token: 0x06002882 RID: 10370
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x4C10170", Offset = "0x4C0ED70", VA = "0x184C10170")]
		[MethodImpl(4096)]
		private unsafe static extern int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options);

		// Token: 0x06002883 RID: 10371 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x4C10180", Offset = "0x4C0ED80", VA = "0x184C10180")]
		private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002884 RID: 10372
		[Token(Token = "0x6002884")]
		[Address(RVA = "0x4C10560", Offset = "0x4C0F160", VA = "0x184C10560")]
		[MethodImpl(4096)]
		private unsafe static extern int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first);

		// Token: 0x06002885 RID: 10373 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x6002885")]
		[Address(RVA = "0x4C10570", Offset = "0x4C0F170", VA = "0x184C10570")]
		private static int internal_index(string source, int sindex, int count, string value, bool first)
		{
			return 0;
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x4C0E6D0", Offset = "0x4C0D2D0", VA = "0x184C0E6D0")]
		private void InitSort(CultureInfo culture)
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x4C0BB90", Offset = "0x4C0A790", VA = "0x184C0BB90")]
		private unsafe static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2)
		{
			return 0;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x4C0E0A0", Offset = "0x4C0CCA0", VA = "0x184C0E0A0")]
		internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x4C0F450", Offset = "0x4C0E050", VA = "0x184C0F450")]
		internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			return 0;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000165A8 File Offset: 0x000147A8
		[Token(Token = "0x600288A")]
		[Address(RVA = "0x4C0F410", Offset = "0x4C0E010", VA = "0x184C0F410")]
		private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x600288B")]
		[Address(RVA = "0x4C0E010", Offset = "0x4C0CC10", VA = "0x184C0E010")]
		private unsafe int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr)
		{
			return 0;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000165D8 File Offset: 0x000147D8
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x4C0BEB0", Offset = "0x4C0AAB0", VA = "0x184C0BEB0")]
		private int CompareString(System.ReadOnlySpan<char> string1, string string2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000165F0 File Offset: 0x000147F0
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x4C0BD80", Offset = "0x4C0A980", VA = "0x184C0BD80")]
		private int CompareString(System.ReadOnlySpan<char> string1, System.ReadOnlySpan<char> string2, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x4C0CDC0", Offset = "0x4C0B9C0", VA = "0x184C0CDC0")]
		private SortKey CreateSortKey(string source, CompareOptions options)
		{
			return null;
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00016608 File Offset: 0x00014808
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x4C0FCC0", Offset = "0x4C0E8C0", VA = "0x184C0FCC0")]
		private bool StartsWith(string source, string prefix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00016620 File Offset: 0x00014820
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x4C0D000", Offset = "0x4C0BC00", VA = "0x184C0D000")]
		private bool EndsWith(string source, string suffix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00016638 File Offset: 0x00014838
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x4C0D110", Offset = "0x4C0BD10", VA = "0x184C0D110")]
		private bool EndsWith(System.ReadOnlySpan<char> source, System.ReadOnlySpan<char> suffix, CompareOptions options)
		{
			return default(bool);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00016650 File Offset: 0x00014850
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x4C0D6B0", Offset = "0x4C0C2B0", VA = "0x184C0D6B0")]
		internal int GetHashCodeOfStringCore(string source, CompareOptions options)
		{
			return 0;
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x4C0FEF0", Offset = "0x4C0EAF0", VA = "0x184C0FEF0")]
		internal CompareInfo()
		{
		}

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		private const CompareOptions ValidIndexMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		private const CompareOptions ValidCompareMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		private const CompareOptions ValidHashCodeOfStringMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth);

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		private const CompareOptions ValidSortkeyCtorMaskOffFlags = ~(CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort);

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly CompareInfo Invariant;

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x10")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		private string m_name;

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		private string _sortName;

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x20")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 3)]
		private SortVersion m_SortVersion;

		// Token: 0x04001699 RID: 5785
		[Token(Token = "0x4001699")]
		[FieldOffset(Offset = "0x28")]
		private int culture;

		// Token: 0x0400169A RID: 5786
		[Token(Token = "0x400169A")]
		[FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		private ISimpleCollator collator;

		// Token: 0x0400169B RID: 5787
		[Token(Token = "0x400169B")]
		[FieldOffset(Offset = "0x8")]
		private static System.Collections.Generic.Dictionary<string, ISimpleCollator> collators;

		// Token: 0x0400169C RID: 5788
		[Token(Token = "0x400169C")]
		[FieldOffset(Offset = "0x10")]
		private static bool managedCollation;

		// Token: 0x0400169D RID: 5789
		[Token(Token = "0x400169D")]
		[FieldOffset(Offset = "0x11")]
		private static bool managedCollationChecked;
	}
}

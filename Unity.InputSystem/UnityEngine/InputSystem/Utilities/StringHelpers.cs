using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	internal static class StringHelpers
	{
		// Token: 0x060015D7 RID: 5591 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x56159D0", Offset = "0x56145D0", VA = "0x1856159D0")]
		public static string Escape(this string str, string chars = "\n\t\r\\\"", string replacements = "ntr\\\"")
		{
			return null;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x56166B0", Offset = "0x56152B0", VA = "0x1856166B0")]
		public static string Unescape(this string str, string chars = "ntr\\\"", string replacements = "\n\t\r\\\"")
		{
			return null;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x5615930", Offset = "0x5614530", VA = "0x185615930")]
		public static bool Contains(this string str, char ch)
		{
			return default(bool);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x5615900", Offset = "0x5614500", VA = "0x185615900")]
		public static bool Contains(this string str, string text, StringComparison comparison)
		{
			return default(bool);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x5615EC0", Offset = "0x5614AC0", VA = "0x185615EC0")]
		public static string GetPlural(this string str)
		{
			return null;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x5616120", Offset = "0x5614D20", VA = "0x185616120")]
		public static string NicifyMemorySize(long numBytes)
		{
			return null;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x5615D30", Offset = "0x5614930", VA = "0x185615D30")]
		public static bool FromNicifiedMemorySize(string text, out long result, long defaultMultiplier = 1L)
		{
			return default(bool);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x5615960", Offset = "0x5614560", VA = "0x185615960")]
		public static int CountOccurrences(this string str, char ch)
		{
			return 0;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x5616630", Offset = "0x5615230", VA = "0x185616630")]
		public static IEnumerable<Substring> Tokenize(this string str)
		{
			return null;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x5616590", Offset = "0x5615190", VA = "0x185616590")]
		public static IEnumerable<string> Split(this string str, Func<char, bool> predicate)
		{
			return null;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E1")]
		public static string Join<TValue>(string separator, params TValue[] values)
		{
			return null;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E2")]
		public static string Join<TValue>(IEnumerable<TValue> values, string separator)
		{
			return null;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E3")]
		public static string MakeUniqueName<TExisting>(string baseName, IEnumerable<TExisting> existingSet, Func<TExisting, string> getNameFunc)
		{
			return null;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x5615660", Offset = "0x5614260", VA = "0x185615660")]
		public static bool CharacterSeparatedListsHaveAtLeastOneCommonElement(string firstList, string secondList, char separator)
		{
			return default(bool);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x56162C0", Offset = "0x5614EC0", VA = "0x1856162C0")]
		public static int ParseInt(string str, int pos)
		{
			return 0;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x5616B10", Offset = "0x5615710", VA = "0x185616B10")]
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters)
		{
			return default(bool);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x5616910", Offset = "0x5615510", VA = "0x185616910")]
		public static bool WriteStringToBuffer(string text, IntPtr buffer, int bufferSizeInCharacters, ref uint offset)
		{
			return default(bool);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x5616480", Offset = "0x5615080", VA = "0x185616480")]
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize)
		{
			return null;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x5616350", Offset = "0x5614F50", VA = "0x185616350")]
		public static string ReadStringFromBuffer(IntPtr buffer, int bufferSize, ref uint offset)
		{
			return null;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x56160A0", Offset = "0x5614CA0", VA = "0x1856160A0")]
		public static bool IsPrintable(this char ch)
		{
			return default(bool);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x5616810", Offset = "0x5615410", VA = "0x185616810")]
		public static string WithAllWhitespaceStripped(this string str)
		{
			return null;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x5616050", Offset = "0x5614C50", VA = "0x185616050")]
		public static bool InvariantEqualsIgnoreCase(this string left, string right)
		{
			return default(bool);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x5615B40", Offset = "0x5614740", VA = "0x185615B40")]
		public static string ExpandTemplateString(string template, Func<string, string> mapFunc)
		{
			return null;
		}
	}
}

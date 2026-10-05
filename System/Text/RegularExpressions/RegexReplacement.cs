using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	internal sealed class RegexReplacement
	{
		// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5115640", Offset = "0x5114240", VA = "0x185115640")]
		public RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5114920", Offset = "0x5113520", VA = "0x185114920")]
		public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
		{
			return null;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FC")]
		public string Pattern
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x5115450", Offset = "0x5114050", VA = "0x185115450")]
		private void ReplacementImpl(StringBuilder sb, Match match)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x5115230", Offset = "0x5113E30", VA = "0x185115230")]
		private void ReplacementImplRTL(List<string> al, Match match)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5114B80", Offset = "0x5113780", VA = "0x185114B80")]
		public string Replace(Regex regex, string input, int count, int startat)
		{
			return null;
		}

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		private const int Specials = 4;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		public const int LeftPortion = -1;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		public const int RightPortion = -2;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		public const int LastGroup = -3;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		public const int WholeString = -4;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<string> _strings;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> _rules;
	}
}

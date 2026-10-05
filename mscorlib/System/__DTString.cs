using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000DE RID: 222
	[Token(Token = "0x20000DE")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct __DTString
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x17000091")]
		internal int Length
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x4CD7390", Offset = "0x4CD5F90", VA = "0x184CD7390")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x4CD7190", Offset = "0x4CD5D90", VA = "0x184CD7190")]
		internal __DTString(System.ReadOnlySpan<char> str, System.Globalization.DateTimeFormatInfo dtfi, bool checkDigitToken)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x4CD72A0", Offset = "0x4CD5EA0", VA = "0x184CD72A0")]
		internal __DTString(System.ReadOnlySpan<char> str, System.Globalization.DateTimeFormatInfo dtfi)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000092")]
		internal System.Globalization.CompareInfo CompareInfo
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x4CD5780", Offset = "0x4CD4380", VA = "0x184CD5780")]
		internal bool GetNext()
		{
			return default(bool);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4CD5560", Offset = "0x4CD4160", VA = "0x184CD5560")]
		internal bool AtEnd()
		{
			return default(bool);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x4CD54C0", Offset = "0x4CD40C0", VA = "0x184CD54C0")]
		internal bool Advance(int count)
		{
			return default(bool);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x4CD5820", Offset = "0x4CD4420", VA = "0x184CD5820")]
		internal void GetRegularToken(out TokenType tokenType, out int tokenValue, System.Globalization.DateTimeFormatInfo dtfi)
		{
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x4CD5BE0", Offset = "0x4CD47E0", VA = "0x184CD5BE0")]
		internal TokenType GetSeparatorToken(System.Globalization.DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			return (TokenType)0;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x4CD6050", Offset = "0x4CD4C50", VA = "0x184CD6050")]
		[MethodImpl(256)]
		internal bool MatchSpecifiedWord(string target)
		{
			return default(bool);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x4CD6190", Offset = "0x4CD4D90", VA = "0x184CD6190")]
		internal bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4CD6650", Offset = "0x4CD5250", VA = "0x184CD6650")]
		internal bool Match(string str)
		{
			return default(bool);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x4CD67B0", Offset = "0x4CD53B0", VA = "0x184CD67B0")]
		internal bool Match(char ch)
		{
			return default(bool);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x4CD5F70", Offset = "0x4CD4B70", VA = "0x184CD5F70")]
		internal int MatchLongestWords(string[] words, ref int maxMatchStrLen)
		{
			return 0;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x4CD5B10", Offset = "0x4CD4710", VA = "0x184CD5B10")]
		internal int GetRepeatCount()
		{
			return 0;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x4CD56C0", Offset = "0x4CD42C0", VA = "0x184CD56C0")]
		[MethodImpl(256)]
		internal bool GetNextDigit()
		{
			return default(bool);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x4CD5670", Offset = "0x4CD4270", VA = "0x184CD5670")]
		internal char GetChar()
		{
			return '\0';
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x4CD5690", Offset = "0x4CD4290", VA = "0x184CD5690")]
		internal int GetDigit()
		{
			return 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x4CD6F10", Offset = "0x4CD5B10", VA = "0x184CD6F10")]
		internal void SkipWhiteSpaces()
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x4CD6DD0", Offset = "0x4CD59D0", VA = "0x184CD6DD0")]
		internal bool SkipWhiteSpaceCurrent()
		{
			return default(bool);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x4CD6FD0", Offset = "0x4CD5BD0", VA = "0x184CD6FD0")]
		internal void TrimTail()
		{
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x4CD6B50", Offset = "0x4CD5750", VA = "0x184CD6B50")]
		internal void RemoveTrailingInQuoteSpaces()
		{
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x4CD6870", Offset = "0x4CD5470", VA = "0x184CD6870")]
		internal void RemoveLeadingInQuoteSpaces()
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x4CD5E00", Offset = "0x4CD4A00", VA = "0x184CD5E00")]
		internal DTSubString GetSubString()
		{
			return default(DTSubString);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x4CD55D0", Offset = "0x4CD41D0", VA = "0x184CD55D0")]
		internal void ConsumeSubString(DTSubString sub)
		{
		}

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x0")]
		internal System.ReadOnlySpan<char> Value;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x10")]
		internal int Index;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x14")]
		internal char m_current;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x18")]
		private System.Globalization.CompareInfo m_info;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x20")]
		private bool m_checkDigitToken;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] WhiteSpaceChecks;
	}
}

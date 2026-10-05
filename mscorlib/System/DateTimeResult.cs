using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct DateTimeResult
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x4CD1FE0", Offset = "0x4CD0BE0", VA = "0x184CD1FE0")]
		internal void Init(System.ReadOnlySpan<char> originalDateTimeString)
		{
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x4CD2130", Offset = "0x4CD0D30", VA = "0x184CD2130")]
		internal void SetDate(int year, int month, int day)
		{
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x4CD20B0", Offset = "0x4CD0CB0", VA = "0x184CD20B0")]
		internal void SetBadFormatSpecifierFailure()
		{
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x4CD2060", Offset = "0x4CD0C60", VA = "0x184CD2060")]
		internal void SetBadFormatSpecifierFailure(System.ReadOnlySpan<char> failedFormatSpecifier)
		{
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x4CD2010", Offset = "0x4CD0C10", VA = "0x184CD2010")]
		internal void SetBadDateTimeFailure()
		{
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x4CD2170", Offset = "0x4CD0D70", VA = "0x184CD2170")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x4CD2140", Offset = "0x4CD0D40", VA = "0x184CD2140")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x4CD2150", Offset = "0x4CD0D50", VA = "0x184CD2150")]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName)
		{
		}

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x0")]
		internal int Year;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x4")]
		internal int Month;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x8")]
		internal int Day;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0xC")]
		internal int Hour;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x10")]
		internal int Minute;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x14")]
		internal int Second;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x18")]
		internal double fraction;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x20")]
		internal int era;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x24")]
		internal ParseFlags flags;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x28")]
		internal System.TimeSpan timeZoneOffset;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x30")]
		internal System.Globalization.Calendar calendar;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x38")]
		internal System.DateTime parsedDate;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x40")]
		internal ParseFailureKind failure;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x48")]
		internal string failureMessageID;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x50")]
		internal object failureMessageFormatArgument;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x58")]
		internal string failureArgumentName;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x60")]
		internal System.ReadOnlySpan<char> originalDateTimeString;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x70")]
		internal System.ReadOnlySpan<char> failedFormatSpecifier;
	}
}

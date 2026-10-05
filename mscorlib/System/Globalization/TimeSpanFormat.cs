using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2000571")]
	internal static class TimeSpanFormat
	{
		// Token: 0x0600291C RID: 10524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600291C")]
		[Address(RVA = "0x4C3AEE0", Offset = "0x4C39AE0", VA = "0x184C3AEE0")]
		private static void AppendNonNegativeInt32(System.Text.StringBuilder sb, int n, int digits)
		{
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600291D")]
		[Address(RVA = "0x4C3BFF0", Offset = "0x4C3ABF0", VA = "0x184C3BFF0")]
		internal static string Format(System.TimeSpan value, string format, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00016950 File Offset: 0x00014B50
		[Token(Token = "0x600291E")]
		[Address(RVA = "0x4C3C0C0", Offset = "0x4C3ACC0", VA = "0x184C3C0C0")]
		internal static bool TryFormat(System.TimeSpan value, System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider)
		{
			return default(bool);
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600291F")]
		[Address(RVA = "0x4C3BCF0", Offset = "0x4C3A8F0", VA = "0x184C3BCF0")]
		private static System.Text.StringBuilder FormatToBuilder(System.TimeSpan value, System.ReadOnlySpan<char> format, System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002920")]
		[Address(RVA = "0x4C3B7B0", Offset = "0x4C3A3B0", VA = "0x184C3B7B0")]
		private static System.Text.StringBuilder FormatStandard(System.TimeSpan value, bool isInvariant, System.ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern)
		{
			return null;
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002921")]
		[Address(RVA = "0x4C3AFD0", Offset = "0x4C39BD0", VA = "0x184C3AFD0")]
		private static System.Text.StringBuilder FormatCustomized(System.TimeSpan value, System.ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, System.Text.StringBuilder result)
		{
			return null;
		}

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals;

		// Token: 0x02000572 RID: 1394
		[Token(Token = "0x2000572")]
		internal enum Pattern
		{
			// Token: 0x04001794 RID: 6036
			[Token(Token = "0x4001794")]
			None,
			// Token: 0x04001795 RID: 6037
			[Token(Token = "0x4001795")]
			Minimum,
			// Token: 0x04001796 RID: 6038
			[Token(Token = "0x4001796")]
			Full
		}

		// Token: 0x02000573 RID: 1395
		[Token(Token = "0x2000573")]
		internal struct FormatLiterals
		{
			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06002923 RID: 10531 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000616")]
			internal string Start
			{
				[Token(Token = "0x6002923")]
				[Address(RVA = "0x35EEE60", Offset = "0x35EDA60", VA = "0x1835EEE60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06002924 RID: 10532 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000617")]
			internal string DayHourSep
			{
				[Token(Token = "0x6002924")]
				[Address(RVA = "0x4C2FA60", Offset = "0x4C2E660", VA = "0x184C2FA60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06002925 RID: 10533 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000618")]
			internal string HourMinuteSep
			{
				[Token(Token = "0x6002925")]
				[Address(RVA = "0x4C2FAC0", Offset = "0x4C2E6C0", VA = "0x184C2FAC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06002926 RID: 10534 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000619")]
			internal string MinuteSecondSep
			{
				[Token(Token = "0x6002926")]
				[Address(RVA = "0x4C2FAF0", Offset = "0x4C2E6F0", VA = "0x184C2FAF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06002927 RID: 10535 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700061A")]
			internal string SecondFractionSep
			{
				[Token(Token = "0x6002927")]
				[Address(RVA = "0x4C2FB20", Offset = "0x4C2E720", VA = "0x184C2FB20")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x06002928 RID: 10536 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700061B")]
			internal string End
			{
				[Token(Token = "0x6002928")]
				[Address(RVA = "0x4C2FA90", Offset = "0x4C2E690", VA = "0x184C2FA90")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002929 RID: 10537 RVA: 0x00016968 File Offset: 0x00014B68
			[Token(Token = "0x6002929")]
			[Address(RVA = "0x4C2F2A0", Offset = "0x4C2DEA0", VA = "0x184C2F2A0")]
			internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				return default(TimeSpanFormat.FormatLiterals);
			}

			// Token: 0x0600292A RID: 10538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600292A")]
			[Address(RVA = "0x4C2F640", Offset = "0x4C2E240", VA = "0x184C2F640")]
			internal void Init(System.ReadOnlySpan<char> format, bool useInvariantFieldLengths)
			{
			}

			// Token: 0x04001797 RID: 6039
			[Token(Token = "0x4001797")]
			[FieldOffset(Offset = "0x0")]
			internal string AppCompatLiteral;

			// Token: 0x04001798 RID: 6040
			[Token(Token = "0x4001798")]
			[FieldOffset(Offset = "0x8")]
			internal int dd;

			// Token: 0x04001799 RID: 6041
			[Token(Token = "0x4001799")]
			[FieldOffset(Offset = "0xC")]
			internal int hh;

			// Token: 0x0400179A RID: 6042
			[Token(Token = "0x400179A")]
			[FieldOffset(Offset = "0x10")]
			internal int mm;

			// Token: 0x0400179B RID: 6043
			[Token(Token = "0x400179B")]
			[FieldOffset(Offset = "0x14")]
			internal int ss;

			// Token: 0x0400179C RID: 6044
			[Token(Token = "0x400179C")]
			[FieldOffset(Offset = "0x18")]
			internal int ff;

			// Token: 0x0400179D RID: 6045
			[Token(Token = "0x400179D")]
			[FieldOffset(Offset = "0x20")]
			private string[] _literals;
		}
	}
}

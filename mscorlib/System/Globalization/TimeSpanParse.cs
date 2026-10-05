using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	internal static class TimeSpanParse
	{
		// Token: 0x0600292B RID: 10539 RVA: 0x00016980 File Offset: 0x00014B80
		[Token(Token = "0x600292B")]
		[Address(RVA = "0x4C3C2D0", Offset = "0x4C3AED0", VA = "0x184C3C2D0")]
		internal static long Pow10(int pow)
		{
			return 0L;
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x600292C")]
		[Address(RVA = "0x4C41340", Offset = "0x4C3FF40", VA = "0x184C41340")]
		private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result)
		{
			return default(bool);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000169B0 File Offset: 0x00014BB0
		[Token(Token = "0x600292D")]
		[Address(RVA = "0x4C3C290", Offset = "0x4C3AE90", VA = "0x184C3C290")]
		internal static System.TimeSpan Parse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000169C8 File Offset: 0x00014BC8
		[Token(Token = "0x600292E")]
		[Address(RVA = "0x4C412E0", Offset = "0x4C3FEE0", VA = "0x184C412E0")]
		internal static bool TryParse(System.ReadOnlySpan<char> input, System.IFormatProvider formatProvider, out System.TimeSpan result)
		{
			return default(bool);
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000169E0 File Offset: 0x00014BE0
		[Token(Token = "0x600292F")]
		[Address(RVA = "0x4C40060", Offset = "0x4C3EC60", VA = "0x184C40060")]
		private static bool TryParseTimeSpan(System.ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, System.IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x000169F8 File Offset: 0x00014BF8
		[Token(Token = "0x6002930")]
		[Address(RVA = "0x4C3C3C0", Offset = "0x4C3AFC0", VA = "0x184C3C3C0")]
		private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002931 RID: 10545 RVA: 0x00016A10 File Offset: 0x00014C10
		[Token(Token = "0x6002931")]
		[Address(RVA = "0x4C3C520", Offset = "0x4C3B120", VA = "0x184C3C520")]
		private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x00016A28 File Offset: 0x00014C28
		[Token(Token = "0x6002932")]
		[Address(RVA = "0x4C3CC60", Offset = "0x4C3B860", VA = "0x184C3CC60")]
		private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x6002933")]
		[Address(RVA = "0x4C3E680", Offset = "0x4C3D280", VA = "0x184C3E680")]
		private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00016A58 File Offset: 0x00014C58
		[Token(Token = "0x6002934")]
		[Address(RVA = "0x4C3FD00", Offset = "0x4C3E900", VA = "0x184C3FD00")]
		private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x6002935")]
		[Address(RVA = "0x4C3C940", Offset = "0x4C3B540", VA = "0x184C3C940")]
		private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result)
		{
			return default(bool);
		}

		// Token: 0x02000575 RID: 1397
		[Token(Token = "0x2000575")]
		private enum ParseFailureKind : byte
		{
			// Token: 0x0400179F RID: 6047
			[Token(Token = "0x400179F")]
			None,
			// Token: 0x040017A0 RID: 6048
			[Token(Token = "0x40017A0")]
			ArgumentNull,
			// Token: 0x040017A1 RID: 6049
			[Token(Token = "0x40017A1")]
			Format,
			// Token: 0x040017A2 RID: 6050
			[Token(Token = "0x40017A2")]
			FormatWithParameter,
			// Token: 0x040017A3 RID: 6051
			[Token(Token = "0x40017A3")]
			Overflow
		}

		// Token: 0x02000576 RID: 1398
		[Token(Token = "0x2000576")]
		[System.Flags]
		private enum TimeSpanStandardStyles : byte
		{
			// Token: 0x040017A5 RID: 6053
			[Token(Token = "0x40017A5")]
			None = 0,
			// Token: 0x040017A6 RID: 6054
			[Token(Token = "0x40017A6")]
			Invariant = 1,
			// Token: 0x040017A7 RID: 6055
			[Token(Token = "0x40017A7")]
			Localized = 2,
			// Token: 0x040017A8 RID: 6056
			[Token(Token = "0x40017A8")]
			RequireFull = 4,
			// Token: 0x040017A9 RID: 6057
			[Token(Token = "0x40017A9")]
			Any = 3
		}

		// Token: 0x02000577 RID: 1399
		[Token(Token = "0x2000577")]
		private enum TTT : byte
		{
			// Token: 0x040017AB RID: 6059
			[Token(Token = "0x40017AB")]
			None,
			// Token: 0x040017AC RID: 6060
			[Token(Token = "0x40017AC")]
			End,
			// Token: 0x040017AD RID: 6061
			[Token(Token = "0x40017AD")]
			Num,
			// Token: 0x040017AE RID: 6062
			[Token(Token = "0x40017AE")]
			Sep,
			// Token: 0x040017AF RID: 6063
			[Token(Token = "0x40017AF")]
			NumOverflow
		}

		// Token: 0x02000578 RID: 1400
		[Token(Token = "0x2000578")]
		[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		private ref struct TimeSpanToken
		{
			// Token: 0x06002936 RID: 10550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002936")]
			[Address(RVA = "0x4C434F0", Offset = "0x4C420F0", VA = "0x184C434F0")]
			public TimeSpanToken(TimeSpanParse.TTT type)
			{
			}

			// Token: 0x06002937 RID: 10551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002937")]
			[Address(RVA = "0x4C43520", Offset = "0x4C42120", VA = "0x184C43520")]
			public TimeSpanToken(int number)
			{
			}

			// Token: 0x06002938 RID: 10552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002938")]
			[Address(RVA = "0x4C43500", Offset = "0x4C42100", VA = "0x184C43500")]
			public TimeSpanToken(TimeSpanParse.TTT type, int number, int leadingZeroes, System.ReadOnlySpan<char> separator)
			{
			}

			// Token: 0x06002939 RID: 10553 RVA: 0x00016A88 File Offset: 0x00014C88
			[Token(Token = "0x6002939")]
			[Address(RVA = "0x4C43490", Offset = "0x4C42090", VA = "0x184C43490")]
			public bool IsInvalidFraction()
			{
				return default(bool);
			}

			// Token: 0x040017B0 RID: 6064
			[Token(Token = "0x40017B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TimeSpanParse.TTT _ttt;

			// Token: 0x040017B1 RID: 6065
			[Token(Token = "0x40017B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal int _num;

			// Token: 0x040017B2 RID: 6066
			[Token(Token = "0x40017B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int _zeroes;

			// Token: 0x040017B3 RID: 6067
			[Token(Token = "0x40017B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal System.ReadOnlySpan<char> _sep;
		}

		// Token: 0x02000579 RID: 1401
		[Token(Token = "0x2000579")]
		[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
		private ref struct TimeSpanTokenizer
		{
			// Token: 0x0600293A RID: 10554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600293A")]
			[Address(RVA = "0x4C43780", Offset = "0x4C42380", VA = "0x184C43780")]
			internal TimeSpanTokenizer(System.ReadOnlySpan<char> input)
			{
			}

			// Token: 0x0600293B RID: 10555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600293B")]
			[Address(RVA = "0x4C43770", Offset = "0x4C42370", VA = "0x184C43770")]
			internal TimeSpanTokenizer(System.ReadOnlySpan<char> input, int startPosition)
			{
			}

			// Token: 0x0600293C RID: 10556 RVA: 0x00016AA0 File Offset: 0x00014CA0
			[Token(Token = "0x600293C")]
			[Address(RVA = "0x4C43540", Offset = "0x4C42140", VA = "0x184C43540")]
			internal TimeSpanParse.TimeSpanToken GetNextToken()
			{
				return default(TimeSpanParse.TimeSpanToken);
			}

			// Token: 0x040017B4 RID: 6068
			[Token(Token = "0x40017B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private System.ReadOnlySpan<char> _value;

			// Token: 0x040017B5 RID: 6069
			[Token(Token = "0x40017B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _pos;
		}

		// Token: 0x0200057A RID: 1402
		[Token(Token = "0x200057A")]
		private ref struct TimeSpanRawInfo
		{
			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x0600293D RID: 10557 RVA: 0x00016AB8 File Offset: 0x00014CB8
			[Token(Token = "0x1700061C")]
			internal TimeSpanFormat.FormatLiterals PositiveInvariant
			{
				[Token(Token = "0x600293D")]
				[Address(RVA = "0x4C431B0", Offset = "0x4C41DB0", VA = "0x184C431B0")]
				get
				{
					return default(TimeSpanFormat.FormatLiterals);
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x0600293E RID: 10558 RVA: 0x00016AD0 File Offset: 0x00014CD0
			[Token(Token = "0x1700061D")]
			internal TimeSpanFormat.FormatLiterals NegativeInvariant
			{
				[Token(Token = "0x600293E")]
				[Address(RVA = "0x4C43070", Offset = "0x4C41C70", VA = "0x184C43070")]
				get
				{
					return default(TimeSpanFormat.FormatLiterals);
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x0600293F RID: 10559 RVA: 0x00016AE8 File Offset: 0x00014CE8
			[Token(Token = "0x1700061E")]
			internal TimeSpanFormat.FormatLiterals PositiveLocalized
			{
				[Token(Token = "0x600293F")]
				[Address(RVA = "0x4C43220", Offset = "0x4C41E20", VA = "0x184C43220")]
				get
				{
					return default(TimeSpanFormat.FormatLiterals);
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06002940 RID: 10560 RVA: 0x00016B00 File Offset: 0x00014D00
			[Token(Token = "0x1700061F")]
			internal TimeSpanFormat.FormatLiterals NegativeLocalized
			{
				[Token(Token = "0x6002940")]
				[Address(RVA = "0x4C430E0", Offset = "0x4C41CE0", VA = "0x184C430E0")]
				get
				{
					return default(TimeSpanFormat.FormatLiterals);
				}
			}

			// Token: 0x06002941 RID: 10561 RVA: 0x00016B18 File Offset: 0x00014D18
			[Token(Token = "0x6002941")]
			[Address(RVA = "0x4C417E0", Offset = "0x4C403E0", VA = "0x184C417E0")]
			internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002942 RID: 10562 RVA: 0x00016B30 File Offset: 0x00014D30
			[Token(Token = "0x6002942")]
			[Address(RVA = "0x4C42BF0", Offset = "0x4C417F0", VA = "0x184C42BF0")]
			internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002943 RID: 10563 RVA: 0x00016B48 File Offset: 0x00014D48
			[Token(Token = "0x6002943")]
			[Address(RVA = "0x4C42840", Offset = "0x4C41440", VA = "0x184C42840")]
			internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002944 RID: 10564 RVA: 0x00016B60 File Offset: 0x00014D60
			[Token(Token = "0x6002944")]
			[Address(RVA = "0x4C41FD0", Offset = "0x4C40BD0", VA = "0x184C41FD0")]
			internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002945 RID: 10565 RVA: 0x00016B78 File Offset: 0x00014D78
			[Token(Token = "0x6002945")]
			[Address(RVA = "0x4C42140", Offset = "0x4C40D40", VA = "0x184C42140")]
			internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002946 RID: 10566 RVA: 0x00016B90 File Offset: 0x00014D90
			[Token(Token = "0x6002946")]
			[Address(RVA = "0x4C41AB0", Offset = "0x4C406B0", VA = "0x184C41AB0")]
			internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002947 RID: 10567 RVA: 0x00016BA8 File Offset: 0x00014DA8
			[Token(Token = "0x6002947")]
			[Address(RVA = "0x4C425F0", Offset = "0x4C411F0", VA = "0x184C425F0")]
			internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002948 RID: 10568 RVA: 0x00016BC0 File Offset: 0x00014DC0
			[Token(Token = "0x6002948")]
			[Address(RVA = "0x4C41D00", Offset = "0x4C40900", VA = "0x184C41D00")]
			internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x06002949 RID: 10569 RVA: 0x00016BD8 File Offset: 0x00014DD8
			[Token(Token = "0x6002949")]
			[Address(RVA = "0x4C42320", Offset = "0x4C40F20", VA = "0x184C42320")]
			internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
			{
				return default(bool);
			}

			// Token: 0x0600294A RID: 10570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600294A")]
			[Address(RVA = "0x4C42B90", Offset = "0x4C41790", VA = "0x184C42B90")]
			internal void Init(DateTimeFormatInfo dtfi)
			{
			}

			// Token: 0x0600294B RID: 10571 RVA: 0x00016BF0 File Offset: 0x00014DF0
			[Token(Token = "0x600294B")]
			[Address(RVA = "0x4C42E50", Offset = "0x4C41A50", VA = "0x184C42E50")]
			internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result)
			{
				return default(bool);
			}

			// Token: 0x0600294C RID: 10572 RVA: 0x00016C08 File Offset: 0x00014E08
			[Token(Token = "0x600294C")]
			[Address(RVA = "0x4C41670", Offset = "0x4C40270", VA = "0x184C41670")]
			private bool AddSep(System.ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result)
			{
				return default(bool);
			}

			// Token: 0x0600294D RID: 10573 RVA: 0x00016C20 File Offset: 0x00014E20
			[Token(Token = "0x600294D")]
			[Address(RVA = "0x4C41510", Offset = "0x4C40110", VA = "0x184C41510")]
			private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result)
			{
				return default(bool);
			}

			// Token: 0x040017B6 RID: 6070
			[Token(Token = "0x40017B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TimeSpanParse.TTT _lastSeenTTT;

			// Token: 0x040017B7 RID: 6071
			[Token(Token = "0x40017B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal int _tokenCount;

			// Token: 0x040017B8 RID: 6072
			[Token(Token = "0x40017B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal int _sepCount;

			// Token: 0x040017B9 RID: 6073
			[Token(Token = "0x40017B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int _numCount;

			// Token: 0x040017BA RID: 6074
			[Token(Token = "0x40017BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TimeSpanFormat.FormatLiterals _posLoc;

			// Token: 0x040017BB RID: 6075
			[Token(Token = "0x40017BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TimeSpanFormat.FormatLiterals _negLoc;

			// Token: 0x040017BC RID: 6076
			[Token(Token = "0x40017BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool _posLocInit;

			// Token: 0x040017BD RID: 6077
			[Token(Token = "0x40017BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
			private bool _negLocInit;

			// Token: 0x040017BE RID: 6078
			[Token(Token = "0x40017BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private string _fullPosPattern;

			// Token: 0x040017BF RID: 6079
			[Token(Token = "0x40017BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private string _fullNegPattern;

			// Token: 0x040017C0 RID: 6080
			[Token(Token = "0x40017C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal TimeSpanParse.TimeSpanToken _numbers0;

			// Token: 0x040017C1 RID: 6081
			[Token(Token = "0x40017C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			internal TimeSpanParse.TimeSpanToken _numbers1;

			// Token: 0x040017C2 RID: 6082
			[Token(Token = "0x40017C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal TimeSpanParse.TimeSpanToken _numbers2;

			// Token: 0x040017C3 RID: 6083
			[Token(Token = "0x40017C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			internal TimeSpanParse.TimeSpanToken _numbers3;

			// Token: 0x040017C4 RID: 6084
			[Token(Token = "0x40017C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			internal TimeSpanParse.TimeSpanToken _numbers4;

			// Token: 0x040017C5 RID: 6085
			[Token(Token = "0x40017C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			internal System.ReadOnlySpan<char> _literals0;

			// Token: 0x040017C6 RID: 6086
			[Token(Token = "0x40017C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			internal System.ReadOnlySpan<char> _literals1;

			// Token: 0x040017C7 RID: 6087
			[Token(Token = "0x40017C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			internal System.ReadOnlySpan<char> _literals2;

			// Token: 0x040017C8 RID: 6088
			[Token(Token = "0x40017C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			internal System.ReadOnlySpan<char> _literals3;

			// Token: 0x040017C9 RID: 6089
			[Token(Token = "0x40017C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			internal System.ReadOnlySpan<char> _literals4;

			// Token: 0x040017CA RID: 6090
			[Token(Token = "0x40017CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			internal System.ReadOnlySpan<char> _literals5;
		}

		// Token: 0x0200057B RID: 1403
		[Token(Token = "0x200057B")]
		private struct TimeSpanResult
		{
			// Token: 0x0600294E RID: 10574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600294E")]
			[Address(RVA = "0x4C43480", Offset = "0x4C42080", VA = "0x184C43480")]
			internal TimeSpanResult(bool throwOnFailure)
			{
			}

			// Token: 0x0600294F RID: 10575 RVA: 0x00016C38 File Offset: 0x00014E38
			[Token(Token = "0x600294F")]
			[Address(RVA = "0x4C432F0", Offset = "0x4C41EF0", VA = "0x184C432F0")]
			internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, [System.Runtime.InteropServices.Optional] object messageArgument, [System.Runtime.InteropServices.Optional] string argumentName)
			{
				return default(bool);
			}

			// Token: 0x040017CB RID: 6091
			[Token(Token = "0x40017CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal System.TimeSpan parsedTimeSpan;

			// Token: 0x040017CC RID: 6092
			[Token(Token = "0x40017CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly bool _throwOnFailure;
		}
	}
}

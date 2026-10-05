using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E8 RID: 232
	[Token(Token = "0x20000E8")]
	[NonVersionable]
	[System.Serializable]
	public struct Guid : System.IFormattable, System.IComparable, System.IComparable<System.Guid>, System.IEquatable<System.Guid>, ISpanFormattable
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x4CD2940", Offset = "0x4CD1540", VA = "0x184CD2940")]
		public static System.Guid NewGuid()
		{
			return default(System.Guid);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x4CD4F50", Offset = "0x4CD3B50", VA = "0x184CD4F50")]
		public Guid(byte[] b)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x4CD4DF0", Offset = "0x4CD39F0", VA = "0x184CD4DF0")]
		public Guid(System.ReadOnlySpan<byte> b)
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x4CD5140", Offset = "0x4CD3D40", VA = "0x184CD5140")]
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4CD5010", Offset = "0x4CD3C10", VA = "0x184CD5010")]
		public Guid(string g)
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x4CD2A10", Offset = "0x4CD1610", VA = "0x184CD2A10")]
		public static System.Guid Parse(string input)
		{
			return default(System.Guid);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x4CD2980", Offset = "0x4CD1580", VA = "0x184CD2980")]
		public static System.Guid Parse(System.ReadOnlySpan<char> input)
		{
			return default(System.Guid);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x4CD4CB0", Offset = "0x4CD38B0", VA = "0x184CD4CB0")]
		public static bool TryParse(string input, out System.Guid result)
		{
			return default(bool);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x4CD4D90", Offset = "0x4CD3990", VA = "0x184CD4D90")]
		public static bool TryParse(System.ReadOnlySpan<char> input, out System.Guid result)
		{
			return default(bool);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x4CD4AE0", Offset = "0x4CD36E0", VA = "0x184CD4AE0")]
		private static bool TryParseGuid(System.ReadOnlySpan<char> guidString, System.Guid.GuidStyles flags, ref System.Guid.GuidResult result)
		{
			return default(bool);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x4CD3FB0", Offset = "0x4CD2BB0", VA = "0x184CD3FB0")]
		private static bool TryParseGuidWithHexPrefix(System.ReadOnlySpan<char> guidString, ref System.Guid.GuidResult result)
		{
			return default(bool);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x4CD4730", Offset = "0x4CD3330", VA = "0x184CD4730")]
		private static bool TryParseGuidWithNoStyle(System.ReadOnlySpan<char> guidString, ref System.Guid.GuidResult result)
		{
			return default(bool);
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x4CD3CB0", Offset = "0x4CD28B0", VA = "0x184CD3CB0")]
		private static bool TryParseGuidWithDashes(System.ReadOnlySpan<char> guidString, ref System.Guid.GuidResult result)
		{
			return default(bool);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x4CD2E70", Offset = "0x4CD1A70", VA = "0x184CD2E70")]
		private static bool StringToShort(System.ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref System.Guid.GuidResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x4CD2E10", Offset = "0x4CD1A10", VA = "0x184CD2E10")]
		private static bool StringToShort(System.ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref System.Guid.GuidResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x4CD2B40", Offset = "0x4CD1740", VA = "0x184CD2B40")]
		private static bool StringToInt(System.ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref System.Guid.GuidResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x4CD2B90", Offset = "0x4CD1790", VA = "0x184CD2B90")]
		private static bool StringToInt(System.ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref System.Guid.GuidResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x4CD2D10", Offset = "0x4CD1910", VA = "0x184CD2D10")]
		private static bool StringToLong(System.ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref System.Guid.GuidResult parseResult)
		{
			return default(bool);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x4CD23C0", Offset = "0x4CD0FC0", VA = "0x184CD23C0")]
		private static System.ReadOnlySpan<char> EatAllWhitespace(System.ReadOnlySpan<char> str)
		{
			return default(System.ReadOnlySpan<char>);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x4CD2880", Offset = "0x4CD1480", VA = "0x184CD2880")]
		private static bool IsHexPrefix(System.ReadOnlySpan<char> str, int i)
		{
			return default(bool);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x4CC5050", Offset = "0x4CC3C50", VA = "0x184CC5050")]
		[MethodImpl(256)]
		private void WriteByteHelper(System.Span<byte> destination)
		{
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x4CD2F10", Offset = "0x4CD1B10", VA = "0x184CD2F10")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x4CD2FA0", Offset = "0x4CD1BA0", VA = "0x184CD2FA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x4CD2710", Offset = "0x4CD1310", VA = "0x184CD2710", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x4CD2660", Offset = "0x4CD1260", VA = "0x184CD2660", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x4CD2630", Offset = "0x4CD1230", VA = "0x184CD2630", Slot = "7")]
		public bool Equals(System.Guid g)
		{
			return default(bool);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4CD2720", Offset = "0x4CD1320", VA = "0x184CD2720")]
		private int GetResult(uint me, uint them)
		{
			return 0;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x4CD2180", Offset = "0x4CD0D80", VA = "0x184CD2180", Slot = "5")]
		public int CompareTo(object value)
		{
			return 0;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x4CD2330", Offset = "0x4CD0F30", VA = "0x184CD2330", Slot = "6")]
		public int CompareTo(System.Guid value)
		{
			return 0;
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x4CD5190", Offset = "0x4CD3D90", VA = "0x184CD5190")]
		public static bool operator ==(System.Guid a, System.Guid b)
		{
			return default(bool);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x4CD51C0", Offset = "0x4CD3DC0", VA = "0x184CD51C0")]
		public static bool operator !=(System.Guid a, System.Guid b)
		{
			return default(bool);
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x4CD3270", Offset = "0x4CD1E70", VA = "0x184CD3270")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x4CD2740", Offset = "0x4CD1340", VA = "0x184CD2740")]
		[MethodImpl(256)]
		private static char HexToChar(int a)
		{
			return '\0';
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x4CD2800", Offset = "0x4CD1400", VA = "0x184CD2800")]
		private unsafe static int HexsToChars(char* guidChars, int a, int b)
		{
			return 0;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x4CD2760", Offset = "0x4CD1360", VA = "0x184CD2760")]
		private unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
		{
			return 0;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x4CD2FE0", Offset = "0x4CD1BE0", VA = "0x184CD2FE0", Slot = "4")]
		public string ToString(string format, System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x4CD3280", Offset = "0x4CD1E80", VA = "0x184CD3280")]
		public bool TryFormat(System.Span<char> destination, out int charsWritten, [System.Runtime.InteropServices.Optional] System.ReadOnlySpan<char> format)
		{
			return default(bool);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x4CD2ED0", Offset = "0x4CD1AD0", VA = "0x184CD2ED0", Slot = "8")]
		private bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider provider)
		{
			return default(bool);
		}

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly System.Guid Empty;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _a;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private short _b;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		private short _c;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte _d;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private byte _e;

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		private byte _f;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
		private byte _g;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private byte _h;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private byte _i;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		private byte _j;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		private byte _k;

		// Token: 0x020000E9 RID: 233
		[Token(Token = "0x20000E9")]
		[System.Flags]
		private enum GuidStyles
		{
			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			None = 0,
			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			AllowParenthesis = 1,
			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			AllowBraces = 2,
			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			AllowDashes = 4,
			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			AllowHexPrefix = 8,
			// Token: 0x0400040F RID: 1039
			[Token(Token = "0x400040F")]
			RequireParenthesis = 16,
			// Token: 0x04000410 RID: 1040
			[Token(Token = "0x4000410")]
			RequireBraces = 32,
			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			RequireDashes = 64,
			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			RequireHexPrefix = 128,
			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			HexFormat = 160,
			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			NumberFormat = 0,
			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			DigitFormat = 64,
			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			BraceFormat = 96,
			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			ParenthesisFormat = 80,
			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			Any = 15
		}

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000EA")]
		private enum GuidParseThrowStyle
		{
			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			None,
			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			All,
			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			AllButOverflow
		}

		// Token: 0x020000EB RID: 235
		[Token(Token = "0x20000EB")]
		private enum ParseFailureKind
		{
			// Token: 0x0400041E RID: 1054
			[Token(Token = "0x400041E")]
			None,
			// Token: 0x0400041F RID: 1055
			[Token(Token = "0x400041F")]
			ArgumentNull,
			// Token: 0x04000420 RID: 1056
			[Token(Token = "0x4000420")]
			Format,
			// Token: 0x04000421 RID: 1057
			[Token(Token = "0x4000421")]
			FormatWithParameter,
			// Token: 0x04000422 RID: 1058
			[Token(Token = "0x4000422")]
			NativeException,
			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x4000423")]
			FormatWithInnerException
		}

		// Token: 0x020000EC RID: 236
		[Token(Token = "0x20000EC")]
		private struct GuidResult
		{
			// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			internal void Init(System.Guid.GuidParseThrowStyle canThrow)
			{
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x4CD79C0", Offset = "0x4CD65C0", VA = "0x184CD79C0")]
			internal void SetFailure(System.Exception nativeException)
			{
			}

			// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x4CD79E0", Offset = "0x4CD65E0", VA = "0x184CD79E0")]
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID)
			{
			}

			// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x4CD7930", Offset = "0x4CD6530", VA = "0x184CD7930")]
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument)
			{
			}

			// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x4CD78A0", Offset = "0x4CD64A0", VA = "0x184CD78A0")]
			internal void SetFailure(System.Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, System.Exception innerException)
			{
			}

			// Token: 0x060007E2 RID: 2018 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x4CD76D0", Offset = "0x4CD62D0", VA = "0x184CD76D0")]
			internal System.Exception GetGuidParseException()
			{
				return null;
			}

			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal System.Guid _parsedGuid;

			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal System.Guid.GuidParseThrowStyle _throwStyle;

			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private System.Guid.ParseFailureKind _failure;

			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string _failureMessageID;

			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _failureMessageFormatArgument;

			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string _failureArgumentName;

			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private System.Exception _innerException;
		}
	}
}

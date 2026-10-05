using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	internal class FormatProvider
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4F6DDA0", Offset = "0x4F6C9A0", VA = "0x184F6DDA0")]
		internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex)
		{
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		private class Number
		{
			// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x4F6F200", Offset = "0x4F6DE00", VA = "0x184F6F200")]
			internal unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
			{
			}

			// Token: 0x06000031 RID: 49 RVA: 0x000022B0 File Offset: 0x000004B0
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x4F705F0", Offset = "0x4F6F1F0", VA = "0x184F705F0")]
			internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
			{
				return '\0';
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x4F6FF20", Offset = "0x4F6EB20", VA = "0x184F6FF20")]
			internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
			{
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x4F6E130", Offset = "0x4F6CD30", VA = "0x184F6E130")]
			private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			// Token: 0x06000034 RID: 52 RVA: 0x000022C8 File Offset: 0x000004C8
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x4F71990", Offset = "0x4F70590", VA = "0x184F71990")]
			private unsafe static int wcslen(char* s)
			{
				return 0;
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x4F6E530", Offset = "0x4F6D130", VA = "0x184F6E530")]
			private static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
			{
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x4F6EC70", Offset = "0x4F6D870", VA = "0x184F6EC70")]
			private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4F6F080", Offset = "0x4F6DC80", VA = "0x184F6F080")]
			private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
			{
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4F6E350", Offset = "0x4F6CF50", VA = "0x184F6E350")]
			private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
			{
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x4F6E9D0", Offset = "0x4F6D5D0", VA = "0x184F6E9D0")]
			private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
			{
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x4F6EE50", Offset = "0x4F6DA50", VA = "0x184F6EE50")]
			private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
			{
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4F70750", Offset = "0x4F6F350", VA = "0x184F70750")]
			private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos)
			{
			}

			// Token: 0x0600003C RID: 60 RVA: 0x000022E0 File Offset: 0x000004E0
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4F6E010", Offset = "0x4F6CC10", VA = "0x184F6E010")]
			private static int FindSection(ReadOnlySpan<char> format, int section)
			{
				return 0;
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4F6F260", Offset = "0x4F6DE60", VA = "0x184F6F260")]
			internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
			{
			}

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x0")]
			private static string[] s_posCurrencyFormats;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x8")]
			private static string[] s_negCurrencyFormats;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x10")]
			private static string[] s_posPercentFormats;

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x18")]
			private static string[] s_negPercentFormats;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x20")]
			private static string[] s_negNumberFormats;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x28")]
			private static string s_posNumberFormat;

			// Token: 0x02000009 RID: 9
			[Token(Token = "0x2000009")]
			internal struct NumberBuffer
			{
				// Token: 0x17000002 RID: 2
				// (get) Token: 0x0600003F RID: 63 RVA: 0x00002112 File Offset: 0x00000312
				[Token(Token = "0x17000002")]
				public unsafe char* digits
				{
					[Token(Token = "0x600003F")]
					[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
					get
					{
						return null;
					}
				}

				// Token: 0x04000016 RID: 22
				[Token(Token = "0x4000016")]
				[FieldOffset(Offset = "0x0")]
				public int precision;

				// Token: 0x04000017 RID: 23
				[Token(Token = "0x4000017")]
				[FieldOffset(Offset = "0x4")]
				public int scale;

				// Token: 0x04000018 RID: 24
				[Token(Token = "0x4000018")]
				[FieldOffset(Offset = "0x8")]
				public bool sign;

				// Token: 0x04000019 RID: 25
				[Token(Token = "0x4000019")]
				[FieldOffset(Offset = "0x10")]
				public unsafe char* overrideDigits;
			}
		}
	}
}

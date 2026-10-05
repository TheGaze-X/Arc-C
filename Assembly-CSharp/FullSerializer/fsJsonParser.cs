using System;
using System.Text;
using Il2CppDummyDll;

namespace FullSerializer
{
	// Token: 0x02007B75 RID: 31605
	[Token(Token = "0x2007B75")]
	public class fsJsonParser
	{
		// Token: 0x0602C3B1 RID: 181169 RVA: 0x000DE8D0 File Offset: 0x000DCAD0
		[Token(Token = "0x602C3B1")]
		[Address(RVA = "0x282AFA0", Offset = "0x2829BA0", VA = "0x18282AFA0")]
		private fsResult MakeFailure(string message)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3B2 RID: 181170 RVA: 0x000DE8E8 File Offset: 0x000DCAE8
		[Token(Token = "0x602C3B2")]
		[Address(RVA = "0x282C0E0", Offset = "0x282ACE0", VA = "0x18282C0E0")]
		private bool TryMoveNext()
		{
			return default(bool);
		}

		// Token: 0x0602C3B3 RID: 181171 RVA: 0x000DE900 File Offset: 0x000DCB00
		[Token(Token = "0x602C3B3")]
		[Address(RVA = "0x282AEA0", Offset = "0x2829AA0", VA = "0x18282AEA0")]
		private bool HasValue()
		{
			return default(bool);
		}

		// Token: 0x0602C3B4 RID: 181172 RVA: 0x000DE918 File Offset: 0x000DCB18
		[Token(Token = "0x602C3B4")]
		[Address(RVA = "0x282AED0", Offset = "0x2829AD0", VA = "0x18282AED0")]
		private bool HasValue(int offset)
		{
			return default(bool);
		}

		// Token: 0x0602C3B5 RID: 181173 RVA: 0x000DE930 File Offset: 0x000DCB30
		[Token(Token = "0x602C3B5")]
		[Address(RVA = "0x282AE40", Offset = "0x2829A40", VA = "0x18282AE40")]
		private char Character()
		{
			return '\0';
		}

		// Token: 0x0602C3B6 RID: 181174 RVA: 0x000DE948 File Offset: 0x000DCB48
		[Token(Token = "0x602C3B6")]
		[Address(RVA = "0x282AE70", Offset = "0x2829A70", VA = "0x18282AE70")]
		private char Character(int offset)
		{
			return '\0';
		}

		// Token: 0x0602C3B7 RID: 181175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3B7")]
		[Address(RVA = "0x282BE10", Offset = "0x282AA10", VA = "0x18282BE10")]
		private void SkipSpace()
		{
		}

		// Token: 0x0602C3B8 RID: 181176 RVA: 0x000DE960 File Offset: 0x000DCB60
		[Token(Token = "0x602C3B8")]
		[Address(RVA = "0x282AF00", Offset = "0x2829B00", VA = "0x18282AF00")]
		private bool IsHex(char c)
		{
			return default(bool);
		}

		// Token: 0x0602C3B9 RID: 181177 RVA: 0x000DE978 File Offset: 0x000DCB78
		[Token(Token = "0x602C3B9")]
		[Address(RVA = "0x282B310", Offset = "0x2829F10", VA = "0x18282B310")]
		private uint ParseSingleChar(char c1, uint multipliyer)
		{
			return 0U;
		}

		// Token: 0x0602C3BA RID: 181178 RVA: 0x000DE990 File Offset: 0x000DCB90
		[Token(Token = "0x602C3BA")]
		[Address(RVA = "0x282B350", Offset = "0x2829F50", VA = "0x18282B350")]
		private uint ParseUnicode(char c1, char c2, char c3, char c4)
		{
			return 0U;
		}

		// Token: 0x0602C3BB RID: 181179 RVA: 0x000DE9A8 File Offset: 0x000DCBA8
		[Token(Token = "0x602C3BB")]
		[Address(RVA = "0x282D5C0", Offset = "0x282C1C0", VA = "0x18282D5C0")]
		private fsResult TryUnescapeChar(out char escaped)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3BC RID: 181180 RVA: 0x000DE9C0 File Offset: 0x000DCBC0
		[Token(Token = "0x602C3BC")]
		[Address(RVA = "0x282C4C0", Offset = "0x282B0C0", VA = "0x18282C4C0")]
		private fsResult TryParseExact(string content)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3BD RID: 181181 RVA: 0x000DE9D8 File Offset: 0x000DCBD8
		[Token(Token = "0x602C3BD")]
		[Address(RVA = "0x282D460", Offset = "0x282C060", VA = "0x18282D460")]
		private fsResult TryParseTrue(out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3BE RID: 181182 RVA: 0x000DE9F0 File Offset: 0x000DCBF0
		[Token(Token = "0x602C3BE")]
		[Address(RVA = "0x282C640", Offset = "0x282B240", VA = "0x18282C640")]
		private fsResult TryParseFalse(out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3BF RID: 181183 RVA: 0x000DEA08 File Offset: 0x000DCC08
		[Token(Token = "0x602C3BF")]
		[Address(RVA = "0x282C7A0", Offset = "0x282B3A0", VA = "0x18282C7A0")]
		private fsResult TryParseNull(out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C0 RID: 181184 RVA: 0x000DEA20 File Offset: 0x000DCC20
		[Token(Token = "0x602C3C0")]
		[Address(RVA = "0x282AF30", Offset = "0x2829B30", VA = "0x18282AF30")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		// Token: 0x0602C3C1 RID: 181185 RVA: 0x000DEA38 File Offset: 0x000DCC38
		[Token(Token = "0x602C3C1")]
		[Address(RVA = "0x282C8D0", Offset = "0x282B4D0", VA = "0x18282C8D0")]
		private fsResult TryParseNumber(out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C2 RID: 181186 RVA: 0x000DEA50 File Offset: 0x000DCC50
		[Token(Token = "0x602C3C2")]
		[Address(RVA = "0x282D150", Offset = "0x282BD50", VA = "0x18282D150")]
		private fsResult TryParseString(out string str)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C3 RID: 181187 RVA: 0x000DEA68 File Offset: 0x000DCC68
		[Token(Token = "0x602C3C3")]
		[Address(RVA = "0x282C110", Offset = "0x282AD10", VA = "0x18282C110")]
		private fsResult TryParseArray(out fsData arr)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C4 RID: 181188 RVA: 0x000DEA80 File Offset: 0x000DCC80
		[Token(Token = "0x602C3C4")]
		[Address(RVA = "0x282CC30", Offset = "0x282B830", VA = "0x18282CC30")]
		private fsResult TryParseObject(out fsData obj)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C5 RID: 181189 RVA: 0x000DEA98 File Offset: 0x000DCC98
		[Token(Token = "0x602C3C5")]
		[Address(RVA = "0x282B830", Offset = "0x282A430", VA = "0x18282B830")]
		private fsResult RunParse(out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C6 RID: 181190 RVA: 0x000DEAB0 File Offset: 0x000DCCB0
		[Token(Token = "0x602C3C6")]
		[Address(RVA = "0x282B6A0", Offset = "0x282A2A0", VA = "0x18282B6A0")]
		public static fsResult Parse(string input, out fsData data)
		{
			return default(fsResult);
		}

		// Token: 0x0602C3C7 RID: 181191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C3C7")]
		[Address(RVA = "0x282B490", Offset = "0x282A090", VA = "0x18282B490")]
		public static fsData Parse(string input)
		{
			return null;
		}

		// Token: 0x0602C3C8 RID: 181192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C3C8")]
		[Address(RVA = "0x282DE30", Offset = "0x282CA30", VA = "0x18282DE30")]
		private fsJsonParser(string input)
		{
		}

		// Token: 0x040401A7 RID: 262567
		[Token(Token = "0x40401A7")]
		[FieldOffset(Offset = "0x10")]
		private int _start;

		// Token: 0x040401A8 RID: 262568
		[Token(Token = "0x40401A8")]
		[FieldOffset(Offset = "0x18")]
		private string _input;

		// Token: 0x040401A9 RID: 262569
		[Token(Token = "0x40401A9")]
		[FieldOffset(Offset = "0x20")]
		private readonly StringBuilder _cachedStringBuilder;
	}
}

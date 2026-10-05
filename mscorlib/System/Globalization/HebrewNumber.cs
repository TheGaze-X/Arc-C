using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	internal class HebrewNumber
	{
		// Token: 0x06002917 RID: 10519 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002917")]
		[Address(RVA = "0x4C33160", Offset = "0x4C31D60", VA = "0x184C33160")]
		internal static string ToString(int Number)
		{
			return null;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00016920 File Offset: 0x00014B20
		[Token(Token = "0x6002918")]
		[Address(RVA = "0x4C32FB0", Offset = "0x4C31BB0", VA = "0x184C32FB0")]
		internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
		{
			return HebrewNumberParsingState.InvalidHebrewNumber;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00016938 File Offset: 0x00014B38
		[Token(Token = "0x6002919")]
		[Address(RVA = "0x4C32EE0", Offset = "0x4C31AE0", VA = "0x184C32EE0")]
		internal static bool IsDigit(char ch)
		{
			return default(bool);
		}

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x0")]
		private static readonly HebrewNumber.HebrewValue[] s_hebrewValues;

		// Token: 0x04001759 RID: 5977
		[Token(Token = "0x4001759")]
		[FieldOffset(Offset = "0x8")]
		private static char s_maxHebrewNumberCh;

		// Token: 0x0400175A RID: 5978
		[Token(Token = "0x400175A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly HebrewNumber.HS[] s_numberPasingState;

		// Token: 0x0200056C RID: 1388
		[Token(Token = "0x200056C")]
		private enum HebrewToken : short
		{
			// Token: 0x0400175C RID: 5980
			[Token(Token = "0x400175C")]
			Invalid = -1,
			// Token: 0x0400175D RID: 5981
			[Token(Token = "0x400175D")]
			Digit400,
			// Token: 0x0400175E RID: 5982
			[Token(Token = "0x400175E")]
			Digit200_300,
			// Token: 0x0400175F RID: 5983
			[Token(Token = "0x400175F")]
			Digit100,
			// Token: 0x04001760 RID: 5984
			[Token(Token = "0x4001760")]
			Digit10,
			// Token: 0x04001761 RID: 5985
			[Token(Token = "0x4001761")]
			Digit1,
			// Token: 0x04001762 RID: 5986
			[Token(Token = "0x4001762")]
			Digit6_7,
			// Token: 0x04001763 RID: 5987
			[Token(Token = "0x4001763")]
			Digit7,
			// Token: 0x04001764 RID: 5988
			[Token(Token = "0x4001764")]
			Digit9,
			// Token: 0x04001765 RID: 5989
			[Token(Token = "0x4001765")]
			SingleQuote,
			// Token: 0x04001766 RID: 5990
			[Token(Token = "0x4001766")]
			DoubleQuote
		}

		// Token: 0x0200056D RID: 1389
		[Token(Token = "0x200056D")]
		private struct HebrewValue
		{
			// Token: 0x0600291B RID: 10523 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600291B")]
			[Address(RVA = "0x4009790", Offset = "0x4008390", VA = "0x184009790")]
			internal HebrewValue(HebrewNumber.HebrewToken token, short value)
			{
			}

			// Token: 0x04001767 RID: 5991
			[Token(Token = "0x4001767")]
			[FieldOffset(Offset = "0x0")]
			internal HebrewNumber.HebrewToken token;

			// Token: 0x04001768 RID: 5992
			[Token(Token = "0x4001768")]
			[FieldOffset(Offset = "0x2")]
			internal short value;
		}

		// Token: 0x0200056E RID: 1390
		[Token(Token = "0x200056E")]
		internal enum HS : sbyte
		{
			// Token: 0x0400176A RID: 5994
			[Token(Token = "0x400176A")]
			_err = -1,
			// Token: 0x0400176B RID: 5995
			[Token(Token = "0x400176B")]
			Start,
			// Token: 0x0400176C RID: 5996
			[Token(Token = "0x400176C")]
			S400,
			// Token: 0x0400176D RID: 5997
			[Token(Token = "0x400176D")]
			S400_400,
			// Token: 0x0400176E RID: 5998
			[Token(Token = "0x400176E")]
			S400_X00,
			// Token: 0x0400176F RID: 5999
			[Token(Token = "0x400176F")]
			S400_X0,
			// Token: 0x04001770 RID: 6000
			[Token(Token = "0x4001770")]
			X00_DQ,
			// Token: 0x04001771 RID: 6001
			[Token(Token = "0x4001771")]
			S400_X00_X0,
			// Token: 0x04001772 RID: 6002
			[Token(Token = "0x4001772")]
			X0_DQ,
			// Token: 0x04001773 RID: 6003
			[Token(Token = "0x4001773")]
			X,
			// Token: 0x04001774 RID: 6004
			[Token(Token = "0x4001774")]
			X0,
			// Token: 0x04001775 RID: 6005
			[Token(Token = "0x4001775")]
			X00,
			// Token: 0x04001776 RID: 6006
			[Token(Token = "0x4001776")]
			S400_DQ,
			// Token: 0x04001777 RID: 6007
			[Token(Token = "0x4001777")]
			S400_400_DQ,
			// Token: 0x04001778 RID: 6008
			[Token(Token = "0x4001778")]
			S400_400_100,
			// Token: 0x04001779 RID: 6009
			[Token(Token = "0x4001779")]
			S9,
			// Token: 0x0400177A RID: 6010
			[Token(Token = "0x400177A")]
			X00_S9,
			// Token: 0x0400177B RID: 6011
			[Token(Token = "0x400177B")]
			S9_DQ,
			// Token: 0x0400177C RID: 6012
			[Token(Token = "0x400177C")]
			END = 100
		}
	}
}

using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	internal struct DateTimeRawInfo
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x4CD1FB0", Offset = "0x4CD0BB0", VA = "0x184CD1FB0")]
		internal unsafe void Init(int* numberBuffer)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x4CD1F80", Offset = "0x4CD0B80", VA = "0x184CD1F80")]
		internal void AddNumber(int value)
		{
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x4CD1FA0", Offset = "0x4CD0BA0", VA = "0x184CD1FA0")]
		internal int GetNumber(int index)
		{
			return 0;
		}

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x0")]
		private unsafe int* num;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x8")]
		internal int numCount;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0xC")]
		internal int month;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x10")]
		internal int year;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x14")]
		internal int dayOfWeek;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x18")]
		internal int era;

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x1C")]
		internal DateTimeParse.TM timeMark;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x20")]
		internal double fraction;

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x28")]
		internal bool hasSameDateAndTimeSeparators;
	}
}

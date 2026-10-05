using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[Preserve]
	internal struct DateTimeParser
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4D825F0", Offset = "0x4D811F0", VA = "0x184D825F0")]
		public bool Parse(char[] text, int startIndex, int length)
		{
			return default(bool);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x4D81C70", Offset = "0x4D80870", VA = "0x184D81C70")]
		private bool ParseDate(int start)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4D81F20", Offset = "0x4D80B20", VA = "0x184D81F20")]
		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4D81FA0", Offset = "0x4D80BA0", VA = "0x184D81FA0")]
		private bool ParseTime(ref int start)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4D823C0", Offset = "0x4D80FC0", VA = "0x184D823C0")]
		private bool ParseZone(int start)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4D81B70", Offset = "0x4D80770", VA = "0x184D81B70")]
		private bool Parse4Digit(int start, out int num)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4D81B00", Offset = "0x4D80700", VA = "0x184D81B00")]
		private bool Parse2Digit(int start, out int num)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4D81C30", Offset = "0x4D80830", VA = "0x184D81C30")]
		private bool ParseChar(int start, char ch)
		{
			return default(bool);
		}

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		public int Year;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x4")]
		public int Month;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x8")]
		public int Day;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xC")]
		public int Hour;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x10")]
		public int Minute;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x14")]
		public int Second;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x18")]
		public int Fraction;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x1C")]
		public int ZoneHour;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x20")]
		public int ZoneMinute;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x24")]
		public ParserTimeZone Zone;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x28")]
		private char[] _text;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x30")]
		private int _end;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] Power10;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int Lzyyyy;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int Lzyyyy_;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int Lzyyyy_MM;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int Lzyyyy_MM_;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int Lzyyyy_MM_dd;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int Lzyyyy_MM_ddT;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int LzHH;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int LzHH_;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int LzHH_mm;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int LzHH_mm_;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int LzHH_mm_ss;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x34")]
		private static readonly int Lz_;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int Lz_zz;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		private const short MaxFractionDigits = 7;
	}
}

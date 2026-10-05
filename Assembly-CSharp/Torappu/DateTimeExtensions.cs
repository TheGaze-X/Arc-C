using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020004CB RID: 1227
	[Token(Token = "0x20004CB")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class DateTimeExtensions
	{
		// Token: 0x06004DAE RID: 19886 RVA: 0x0002DAF8 File Offset: 0x0002BCF8
		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x18811B0", Offset = "0x187FDB0", VA = "0x1818811B0")]
		public static bool IsEmpty(this DateTime dateTime)
		{
			return default(bool);
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0x1881230", Offset = "0x187FE30", VA = "0x181881230")]
		public static DateTime StartOfGameDay(this DateTime dateTime)
		{
			return default(DateTime);
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x0002DB28 File Offset: 0x0002BD28
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0x1880D20", Offset = "0x187F920", VA = "0x181880D20")]
		public static DateTime EndOfGameDay(this DateTime dateTime)
		{
			return default(DateTime);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x0002DB40 File Offset: 0x0002BD40
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x1881360", Offset = "0x187FF60", VA = "0x181881360")]
		public static DateTime StartOfGameWeek(this DateTime dateTime)
		{
			return default(DateTime);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x0002DB58 File Offset: 0x0002BD58
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x1880E60", Offset = "0x187FA60", VA = "0x181880E60")]
		public static DateTime EndOfGameWeek(this DateTime dateTime)
		{
			return default(DateTime);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x0002DB70 File Offset: 0x0002BD70
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x1881040", Offset = "0x187FC40", VA = "0x181881040")]
		public static GameDayOfWeek GameDayOfWeek(this DateTime dateTime)
		{
			return Torappu.GameDayOfWeek.NONE;
		}

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StartOfGameDay;

		// Token: 0x040011CF RID: 4559
		[Token(Token = "0x40011CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EndOfGameDay;

		// Token: 0x040011D0 RID: 4560
		[Token(Token = "0x40011D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StartOfGameWeek;

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EndOfGameWeek;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GameDayOfWeek;
	}
}

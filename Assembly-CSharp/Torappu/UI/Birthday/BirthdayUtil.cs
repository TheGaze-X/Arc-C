using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Birthday
{
	// Token: 0x020061DA RID: 25050
	[Token(Token = "0x20061DA")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BirthdayUtil
	{
		// Token: 0x06024247 RID: 148039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024247")]
		[Address(RVA = "0x1EDE3A0", Offset = "0x1EDCFA0", VA = "0x181EDE3A0")]
		public static PlayerBirthday GetRewardBirthDay(int year)
		{
			return null;
		}

		// Token: 0x06024248 RID: 148040 RVA: 0x000C3378 File Offset: 0x000C1578
		[Token(Token = "0x6024248")]
		[Address(RVA = "0x1EDE5E0", Offset = "0x1EDD1E0", VA = "0x181EDE5E0")]
		public static bool IsLeapDay(int month, int day)
		{
			return default(bool);
		}

		// Token: 0x06024249 RID: 148041 RVA: 0x000C3390 File Offset: 0x000C1590
		[Token(Token = "0x6024249")]
		[Address(RVA = "0x1EDE020", Offset = "0x1EDCC20", VA = "0x181EDE020")]
		public static long GetCurrYearBirthdaySyncTs(long lastSyncTs)
		{
			return 0L;
		}

		// Token: 0x0602424A RID: 148042 RVA: 0x000C33A8 File Offset: 0x000C15A8
		[Token(Token = "0x602424A")]
		[Address(RVA = "0x1EDE6B0", Offset = "0x1EDD2B0", VA = "0x181EDE6B0")]
		public static bool IsLegalBirthday(int month, int day)
		{
			return default(bool);
		}

		// Token: 0x0602424B RID: 148043 RVA: 0x000C33C0 File Offset: 0x000C15C0
		[Token(Token = "0x602424B")]
		[Address(RVA = "0x1EDE550", Offset = "0x1EDD150", VA = "0x181EDE550")]
		public static bool IsBirthdayFuncEnable()
		{
			return default(bool);
		}

		// Token: 0x04032421 RID: 205857
		[Token(Token = "0x4032421")]
		[FieldOffset(Offset = "0x0")]
		private static int SAMPLE_LEAP_YEAR;

		// Token: 0x04032422 RID: 205858
		[Token(Token = "0x4032422")]
		[FieldOffset(Offset = "0x4")]
		private static int LEAP_MONTH;

		// Token: 0x04032423 RID: 205859
		[Token(Token = "0x4032423")]
		[FieldOffset(Offset = "0x8")]
		private static int LEAP_DAY;

		// Token: 0x04032424 RID: 205860
		[Token(Token = "0x4032424")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRewardBirthDay;

		// Token: 0x04032425 RID: 205861
		[Token(Token = "0x4032425")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsLeapDay;

		// Token: 0x04032426 RID: 205862
		[Token(Token = "0x4032426")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCurrYearBirthdaySyncTs;

		// Token: 0x04032427 RID: 205863
		[Token(Token = "0x4032427")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsLegalBirthday;

		// Token: 0x04032428 RID: 205864
		[Token(Token = "0x4032428")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsBirthdayFuncEnable;
	}
}

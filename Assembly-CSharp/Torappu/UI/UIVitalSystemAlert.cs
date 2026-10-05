using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003891 RID: 14481
	[Token(Token = "0x2003891")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIVitalSystemAlert
	{
		// Token: 0x06016ED8 RID: 93912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ED8")]
		[Address(RVA = "0xF690C0", Offset = "0xF67CC0", VA = "0x180F690C0")]
		public static void NetworkError(string alert, Action callback)
		{
		}

		// Token: 0x06016ED9 RID: 93913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ED9")]
		[Address(RVA = "0xF69130", Offset = "0xF67D30", VA = "0x180F69130")]
		public static void StoryFailAlert(string alert, Action callback)
		{
		}

		// Token: 0x06016EDA RID: 93914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EDA")]
		[Address(RVA = "0xF69050", Offset = "0xF67C50", VA = "0x180F69050")]
		public static void CrossDayAlert(string alert, Action callback)
		{
		}

		// Token: 0x06016EDB RID: 93915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EDB")]
		[Address(RVA = "0xF691A0", Offset = "0xF67DA0", VA = "0x180F691A0")]
		private static void _VitalAlert(uint weight, string alert, Action callback)
		{
		}

		// Token: 0x0401BA9C RID: 113308
		[Token(Token = "0x401BA9C")]
		public const string VITAL_SYSTEM_ALERT = "VITAL_SYSTEM_ALERT";

		// Token: 0x0401BA9D RID: 113309
		[Token(Token = "0x401BA9D")]
		public const uint NET_ERROR_WEIGHT = 100U;

		// Token: 0x0401BA9E RID: 113310
		[Token(Token = "0x401BA9E")]
		public const uint STORY_FAIL_WEIGHT = 100U;

		// Token: 0x0401BA9F RID: 113311
		[Token(Token = "0x401BA9F")]
		public const uint CROSS_DAY_WEIGHT = 50U;

		// Token: 0x0401BAA0 RID: 113312
		[Token(Token = "0x401BAA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NetworkError;

		// Token: 0x0401BAA1 RID: 113313
		[Token(Token = "0x401BAA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StoryFailAlert;

		// Token: 0x0401BAA2 RID: 113314
		[Token(Token = "0x401BAA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CrossDayAlert;

		// Token: 0x0401BAA3 RID: 113315
		[Token(Token = "0x401BAA3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__VitalAlert;
	}
}

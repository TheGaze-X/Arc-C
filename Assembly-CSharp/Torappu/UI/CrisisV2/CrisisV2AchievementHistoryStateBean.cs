using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200593E RID: 22846
	[Token(Token = "0x200593E")]
	public class CrisisV2AchievementHistoryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602147F RID: 136319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602147F")]
		[Address(RVA = "0x1B880B0", Offset = "0x1B86CB0", VA = "0x181B880B0")]
		public CrisisV2AchievementHistoryStateBean()
		{
		}

		// Token: 0x0402D5FB RID: 185851
		[Token(Token = "0x402D5FB")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2AchievementSeasonViewModel selectSeason;

		// Token: 0x0402D5FC RID: 185852
		[Token(Token = "0x402D5FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

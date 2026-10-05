using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C4 RID: 28868
	[Token(Token = "0x20070C4")]
	public class Act1BossRushMileStoneStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06029075 RID: 168053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029075")]
		[Address(RVA = "0x2468490", Offset = "0x2467090", VA = "0x182468490")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029076 RID: 168054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029076")]
		[Address(RVA = "0x2468530", Offset = "0x2467130", VA = "0x182468530")]
		public Act1BossRushMileStoneStateBean()
		{
		}

		// Token: 0x0403A903 RID: 239875
		[Token(Token = "0x403A903")]
		[FieldOffset(Offset = "0x10")]
		public Act1BossRushMileStoneProperty property;

		// Token: 0x0403A904 RID: 239876
		[Token(Token = "0x403A904")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A905 RID: 239877
		[Token(Token = "0x403A905")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

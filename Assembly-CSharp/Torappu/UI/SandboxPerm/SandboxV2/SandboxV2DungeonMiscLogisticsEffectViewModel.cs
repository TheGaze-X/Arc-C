using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A5 RID: 17061
	[Token(Token = "0x20042A5")]
	public class SandboxV2DungeonMiscLogisticsEffectViewModel : IHotfixable
	{
		// Token: 0x0601A456 RID: 107606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A456")]
		[Address(RVA = "0x1330960", Offset = "0x132F560", VA = "0x181330960")]
		public void LoadData(SandboxV2Data topicDetailData, PlayerSandboxV2 playerTopicData)
		{
		}

		// Token: 0x0601A457 RID: 107607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A457")]
		[Address(RVA = "0x1330EC0", Offset = "0x132FAC0", VA = "0x181330EC0")]
		public SandboxV2DungeonMiscLogisticsEffectViewModel()
		{
		}

		// Token: 0x0402145E RID: 136286
		[Token(Token = "0x402145E")]
		[FieldOffset(Offset = "0x10")]
		public bool isEnable;

		// Token: 0x0402145F RID: 136287
		[Token(Token = "0x402145F")]
		[FieldOffset(Offset = "0x18")]
		public List<int> charInstIds;

		// Token: 0x04021460 RID: 136288
		[Token(Token = "0x4021460")]
		[FieldOffset(Offset = "0x20")]
		public int obtainedDrink;

		// Token: 0x04021461 RID: 136289
		[Token(Token = "0x4021461")]
		[FieldOffset(Offset = "0x24")]
		public int logisticsDrinkCost;

		// Token: 0x04021462 RID: 136290
		[Token(Token = "0x4021462")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, SandboxV2DungeonMiscLogisticsEffectItemViewModel> logisticsEffects;

		// Token: 0x04021463 RID: 136291
		[Token(Token = "0x4021463")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2DungeonMiscLogisticsEffectItemComparer m_comparer;

		// Token: 0x04021464 RID: 136292
		[Token(Token = "0x4021464")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04021465 RID: 136293
		[Token(Token = "0x4021465")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

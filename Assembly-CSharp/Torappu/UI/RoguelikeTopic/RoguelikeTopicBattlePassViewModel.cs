using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200456E RID: 17774
	[Token(Token = "0x200456E")]
	public class RoguelikeTopicBattlePassViewModel : IHotfixable
	{
		// Token: 0x0601B137 RID: 110903 RVA: 0x000A43A0 File Offset: 0x000A25A0
		[Token(Token = "0x601B137")]
		[Address(RVA = "0x1435000", Offset = "0x1433C00", VA = "0x181435000")]
		public int GetIndexByLevel(int level)
		{
			return 0;
		}

		// Token: 0x0601B138 RID: 110904 RVA: 0x000A43B8 File Offset: 0x000A25B8
		[Token(Token = "0x601B138")]
		[Address(RVA = "0x14350A0", Offset = "0x1433CA0", VA = "0x1814350A0")]
		public int GetTotalCount()
		{
			return 0;
		}

		// Token: 0x0601B139 RID: 110905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B139")]
		[Address(RVA = "0x1435110", Offset = "0x1433D10", VA = "0x181435110")]
		public RoguelikeTopicBattlePassViewModel()
		{
		}

		// Token: 0x04022CE1 RID: 142561
		[Token(Token = "0x4022CE1")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicBPObjViewModel> milestoneViewModelList;

		// Token: 0x04022CE2 RID: 142562
		[Token(Token = "0x4022CE2")]
		[FieldOffset(Offset = "0x18")]
		public int curBpPoint;

		// Token: 0x04022CE3 RID: 142563
		[Token(Token = "0x4022CE3")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicBPTopViewModel topViewModel;

		// Token: 0x04022CE4 RID: 142564
		[Token(Token = "0x4022CE4")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTopicBattlePassStyle style;

		// Token: 0x04022CE5 RID: 142565
		[Token(Token = "0x4022CE5")]
		[FieldOffset(Offset = "0x30")]
		public List<string> obtainableRewardList;

		// Token: 0x04022CE6 RID: 142566
		[Token(Token = "0x4022CE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetIndexByLevel;

		// Token: 0x04022CE7 RID: 142567
		[Token(Token = "0x4022CE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTotalCount;

		// Token: 0x04022CE8 RID: 142568
		[Token(Token = "0x4022CE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

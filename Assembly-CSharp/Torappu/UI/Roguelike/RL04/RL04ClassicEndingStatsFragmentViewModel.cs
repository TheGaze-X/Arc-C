using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005697 RID: 22167
	[Token(Token = "0x2005697")]
	public class RL04ClassicEndingStatsFragmentViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x06020840 RID: 133184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020840")]
		[Address(RVA = "0x1AA4E20", Offset = "0x1AA3A20", VA = "0x181AA4E20", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x06020841 RID: 133185 RVA: 0x000B6418 File Offset: 0x000B4618
		[Token(Token = "0x6020841")]
		[Address(RVA = "0x1AA52F0", Offset = "0x1AA3EF0", VA = "0x181AA52F0")]
		private int _CompareFragmentType(RoguelikeFragmentType a, RoguelikeFragmentType b)
		{
			return 0;
		}

		// Token: 0x06020842 RID: 133186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020842")]
		[Address(RVA = "0x1AA5550", Offset = "0x1AA4150", VA = "0x181AA5550")]
		public RL04ClassicEndingStatsFragmentViewModel()
		{
		}

		// Token: 0x0402C106 RID: 180486
		[Token(Token = "0x402C106")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, int> FRAGMENT_SORT_MAP;

		// Token: 0x0402C107 RID: 180487
		[Token(Token = "0x402C107")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, RL04ClassicEndingStatsFragmentItemModel> fragmentItemModelList;

		// Token: 0x0402C108 RID: 180488
		[Token(Token = "0x402C108")]
		[FieldOffset(Offset = "0x18")]
		public int fragmentTotalCnt;

		// Token: 0x0402C109 RID: 180489
		[Token(Token = "0x402C109")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C10A RID: 180490
		[Token(Token = "0x402C10A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareFragmentType;

		// Token: 0x0402C10B RID: 180491
		[Token(Token = "0x402C10B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

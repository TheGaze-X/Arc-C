using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200557C RID: 21884
	[Token(Token = "0x200557C")]
	public class RL05ClassicEndingStatsCopperViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x06020284 RID: 131716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020284")]
		[Address(RVA = "0x1A33CC0", Offset = "0x1A328C0", VA = "0x181A33CC0", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x06020285 RID: 131717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020285")]
		[Address(RVA = "0x1A344E0", Offset = "0x1A330E0", VA = "0x181A344E0")]
		private Dictionary<string, int> _GetCopperInBagWhenEnding(string topicId)
		{
			return null;
		}

		// Token: 0x06020286 RID: 131718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020286")]
		[Address(RVA = "0x1A34710", Offset = "0x1A33310", VA = "0x181A34710")]
		public RL05ClassicEndingStatsCopperViewModel()
		{
		}

		// Token: 0x0402B709 RID: 177929
		[Token(Token = "0x402B709")]
		[FieldOffset(Offset = "0x10")]
		public List<RL05ClassicEndingStatsCopperItemModel> copperItemModelList;

		// Token: 0x0402B70A RID: 177930
		[Token(Token = "0x402B70A")]
		[FieldOffset(Offset = "0x18")]
		public int copperTotalCnt;

		// Token: 0x0402B70B RID: 177931
		[Token(Token = "0x402B70B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B70C RID: 177932
		[Token(Token = "0x402B70C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetCopperInBagWhenEnding;

		// Token: 0x0402B70D RID: 177933
		[Token(Token = "0x402B70D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005714 RID: 22292
	[Token(Token = "0x2005714")]
	public class RL04ShopDetailExtraInfoPlugin : RoguelikeShopDetailExtraInfoPlugin
	{
		// Token: 0x06020AD8 RID: 133848 RVA: 0x000B6CB8 File Offset: 0x000B4EB8
		[Token(Token = "0x6020AD8")]
		[Address(RVA = "0x1B14770", Offset = "0x1B13370", VA = "0x181B14770", Slot = "4")]
		public override RoguelikeShopDetailExtraInfo GetExtraInfo(RoguelikeGoodsViewModel viewModel)
		{
			return default(RoguelikeShopDetailExtraInfo);
		}

		// Token: 0x06020AD9 RID: 133849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AD9")]
		[Address(RVA = "0x1B149C0", Offset = "0x1B135C0", VA = "0x181B149C0")]
		private void _LoadGameDataIfNeed(string topicId)
		{
		}

		// Token: 0x06020ADA RID: 133850 RVA: 0x000B6CD0 File Offset: 0x000B4ED0
		[Token(Token = "0x6020ADA")]
		[Address(RVA = "0x1B14AE0", Offset = "0x1B136E0", VA = "0x181B14AE0")]
		private RoguelikeShopDetailExtraInfo _ProcessAsFragment(RoguelikeGoodsViewModel viewModel)
		{
			return default(RoguelikeShopDetailExtraInfo);
		}

		// Token: 0x06020ADB RID: 133851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020ADB")]
		[Address(RVA = "0x1B14E60", Offset = "0x1B13A60", VA = "0x181B14E60")]
		public RL04ShopDetailExtraInfoPlugin()
		{
		}

		// Token: 0x0402C593 RID: 181651
		[Token(Token = "0x402C593")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _colorLimitWeightWarning;

		// Token: 0x0402C594 RID: 181652
		[Token(Token = "0x402C594")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorOverWeightWarning;

		// Token: 0x0402C595 RID: 181653
		[Token(Token = "0x402C595")]
		[FieldOffset(Offset = "0x38")]
		private string m_cachedTopicId;

		// Token: 0x0402C596 RID: 181654
		[Token(Token = "0x402C596")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedLimitThreshold;

		// Token: 0x0402C597 RID: 181655
		[Token(Token = "0x402C597")]
		[FieldOffset(Offset = "0x44")]
		private int m_cachedOverThreshold;

		// Token: 0x0402C598 RID: 181656
		[Token(Token = "0x402C598")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExtraInfo;

		// Token: 0x0402C599 RID: 181657
		[Token(Token = "0x402C599")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadGameDataIfNeed;

		// Token: 0x0402C59A RID: 181658
		[Token(Token = "0x402C59A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ProcessAsFragment;

		// Token: 0x0402C59B RID: 181659
		[Token(Token = "0x402C59B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

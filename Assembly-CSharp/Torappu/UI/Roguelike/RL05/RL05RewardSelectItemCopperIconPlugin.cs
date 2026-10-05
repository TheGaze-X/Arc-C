using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200564B RID: 22091
	[Token(Token = "0x200564B")]
	public class RL05RewardSelectItemCopperIconPlugin : RoguelikeRewardSelectItemIconPlugin
	{
		// Token: 0x06020681 RID: 132737 RVA: 0x000B5C20 File Offset: 0x000B3E20
		[Token(Token = "0x6020681")]
		[Address(RVA = "0x1A7ECB0", Offset = "0x1A7D8B0", VA = "0x181A7ECB0", Slot = "4")]
		public override bool OverrideIcon(string topicId, RoguelikeRewardShowType rewardShowType, string itemId)
		{
			return default(bool);
		}

		// Token: 0x06020682 RID: 132738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020682")]
		[Address(RVA = "0x1A7EED0", Offset = "0x1A7DAD0", VA = "0x181A7EED0")]
		public RL05RewardSelectItemCopperIconPlugin()
		{
		}

		// Token: 0x0402BE07 RID: 179719
		[Token(Token = "0x402BE07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _copperItemCardScale;

		// Token: 0x0402BE08 RID: 179720
		[Token(Token = "0x402BE08")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _copperCardContainer;

		// Token: 0x0402BE09 RID: 179721
		[Token(Token = "0x402BE09")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402BE0A RID: 179722
		[Token(Token = "0x402BE0A")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402BE0B RID: 179723
		[Token(Token = "0x402BE0B")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402BE0C RID: 179724
		[Token(Token = "0x402BE0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideIcon;

		// Token: 0x0402BE0D RID: 179725
		[Token(Token = "0x402BE0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

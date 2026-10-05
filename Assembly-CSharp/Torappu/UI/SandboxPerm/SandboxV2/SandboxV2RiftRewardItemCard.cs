using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004179 RID: 16761
	[Token(Token = "0x2004179")]
	public class SandboxV2RiftRewardItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019DDE RID: 105950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DDE")]
		[Address(RVA = "0x12C6FB0", Offset = "0x12C5BB0", VA = "0x1812C6FB0")]
		public void Render(int idx, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x06019DDF RID: 105951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DDF")]
		[Address(RVA = "0x12C6E30", Offset = "0x12C5A30", VA = "0x1812C6E30")]
		public void PlayRewardAnim(float delay)
		{
		}

		// Token: 0x06019DE0 RID: 105952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE0")]
		[Address(RVA = "0x12C7080", Offset = "0x12C5C80", VA = "0x1812C7080")]
		public void ResetTween(bool isEnd)
		{
		}

		// Token: 0x06019DE1 RID: 105953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE1")]
		[Address(RVA = "0x12C7290", Offset = "0x12C5E90", VA = "0x1812C7290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019DE2 RID: 105954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE2")]
		[Address(RVA = "0x12C7190", Offset = "0x12C5D90", VA = "0x1812C7190")]
		private void _EventOnItemClick(int idx)
		{
		}

		// Token: 0x06019DE3 RID: 105955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019DE3")]
		[Address(RVA = "0x12C74D0", Offset = "0x12C60D0", VA = "0x1812C74D0")]
		public SandboxV2RiftRewardItemCard()
		{
		}

		// Token: 0x040207FC RID: 133116
		[Token(Token = "0x40207FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SandboxV2ItemCard.Option REWARD_ITEM_CARD_OPTION;

		// Token: 0x040207FD RID: 133117
		[Token(Token = "0x40207FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _rewardAnim;

		// Token: 0x040207FE RID: 133118
		[Token(Token = "0x40207FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2ItemCard _itemCardPrefab;

		// Token: 0x040207FF RID: 133119
		[Token(Token = "0x40207FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04020800 RID: 133120
		[Token(Token = "0x4020800")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2ItemCard m_itemCard;

		// Token: 0x04020801 RID: 133121
		[Token(Token = "0x4020801")]
		[FieldOffset(Offset = "0x40")]
		private UIItemViewModel m_cachedItemViewModel;

		// Token: 0x04020802 RID: 133122
		[Token(Token = "0x4020802")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x04020803 RID: 133123
		[Token(Token = "0x4020803")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04020804 RID: 133124
		[Token(Token = "0x4020804")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020805 RID: 133125
		[Token(Token = "0x4020805")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayRewardAnim;

		// Token: 0x04020806 RID: 133126
		[Token(Token = "0x4020806")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetTween;

		// Token: 0x04020807 RID: 133127
		[Token(Token = "0x4020807")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020808 RID: 133128
		[Token(Token = "0x4020808")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnItemClick;

		// Token: 0x04020809 RID: 133129
		[Token(Token = "0x4020809")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

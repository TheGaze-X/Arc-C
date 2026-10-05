using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049BE RID: 18878
	[Token(Token = "0x20049BE")]
	public class LongTermCheckInRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C707 RID: 116487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C707")]
		[Address(RVA = "0x15E5960", Offset = "0x15E4560", VA = "0x1815E5960")]
		public void Render(ItemBundle reward, bool isReceived)
		{
		}

		// Token: 0x0601C708 RID: 116488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C708")]
		[Address(RVA = "0x15E5EA0", Offset = "0x15E4AA0", VA = "0x1815E5EA0")]
		private void _RenderAvatar()
		{
		}

		// Token: 0x0601C709 RID: 116489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C709")]
		[Address(RVA = "0x15E6050", Offset = "0x15E4C50", VA = "0x1815E6050")]
		private void _RenderItem()
		{
		}

		// Token: 0x0601C70A RID: 116490 RVA: 0x000A86C0 File Offset: 0x000A68C0
		[Token(Token = "0x601C70A")]
		[Address(RVA = "0x15E5B40", Offset = "0x15E4740", VA = "0x1815E5B40")]
		private bool _EnsureItemCard()
		{
			return default(bool);
		}

		// Token: 0x0601C70B RID: 116491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C70B")]
		[Address(RVA = "0x15E5DB0", Offset = "0x15E49B0", VA = "0x1815E5DB0")]
		private void _OnItemCardClicked(int _ = 0)
		{
		}

		// Token: 0x0601C70C RID: 116492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C70C")]
		[Address(RVA = "0x15E60E0", Offset = "0x15E4CE0", VA = "0x1815E60E0")]
		public LongTermCheckInRewardView()
		{
		}

		// Token: 0x04025432 RID: 152626
		[Token(Token = "0x4025432")]
		private const float ALPHA_RECEIVED = 0.5f;

		// Token: 0x04025433 RID: 152627
		[Token(Token = "0x4025433")]
		private const float ALPHA_NORMAL = 1f;

		// Token: 0x04025434 RID: 152628
		[Token(Token = "0x4025434")]
		private const float ITEM_CARD_SCALE = 0.7f;

		// Token: 0x04025435 RID: 152629
		[Token(Token = "0x4025435")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroupReward;

		// Token: 0x04025436 RID: 152630
		[Token(Token = "0x4025436")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04025437 RID: 152631
		[Token(Token = "0x4025437")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelAvatar;

		// Token: 0x04025438 RID: 152632
		[Token(Token = "0x4025438")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x04025439 RID: 152633
		[Token(Token = "0x4025439")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelItemCard;

		// Token: 0x0402543A RID: 152634
		[Token(Token = "0x402543A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402543B RID: 152635
		[Token(Token = "0x402543B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelReceived;

		// Token: 0x0402543C RID: 152636
		[Token(Token = "0x402543C")]
		[FieldOffset(Offset = "0x50")]
		private PlayerAvatarView m_playerAvatar;

		// Token: 0x0402543D RID: 152637
		[Token(Token = "0x402543D")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCard;

		// Token: 0x0402543E RID: 152638
		[Token(Token = "0x402543E")]
		[FieldOffset(Offset = "0x60")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402543F RID: 152639
		[Token(Token = "0x402543F")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_cachedItemModel;

		// Token: 0x04025440 RID: 152640
		[Token(Token = "0x4025440")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025441 RID: 152641
		[Token(Token = "0x4025441")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x04025442 RID: 152642
		[Token(Token = "0x4025442")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderItem;

		// Token: 0x04025443 RID: 152643
		[Token(Token = "0x4025443")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnsureItemCard;

		// Token: 0x04025444 RID: 152644
		[Token(Token = "0x4025444")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04025445 RID: 152645
		[Token(Token = "0x4025445")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

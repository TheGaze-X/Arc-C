using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x0200749C RID: 29852
	[Token(Token = "0x200749C")]
	public class Act29signExpandViewItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A1B8 RID: 172472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1B8")]
		[Address(RVA = "0x25BA980", Offset = "0x25B9580", VA = "0x1825BA980")]
		public void Render(Act29signExpandViewItem.Model model, Act29signExpandViewItem.Config config)
		{
		}

		// Token: 0x0602A1B9 RID: 172473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1B9")]
		[Address(RVA = "0x25BB030", Offset = "0x25B9C30", VA = "0x1825BB030")]
		private void _ApplyConfig(Act29signExpandViewItem.Model model, Act29signExpandViewItem.Config config)
		{
		}

		// Token: 0x0602A1BA RID: 172474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1BA")]
		[Address(RVA = "0x25BB840", Offset = "0x25BA440", VA = "0x1825BB840")]
		private void _SetState(Act29signExpandViewItem.State state)
		{
		}

		// Token: 0x0602A1BB RID: 172475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1BB")]
		[Address(RVA = "0x25BB6B0", Offset = "0x25BA2B0", VA = "0x1825BB6B0")]
		private void _RenderReward(List<ItemBundle> bundleList)
		{
		}

		// Token: 0x0602A1BC RID: 172476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1BC")]
		[Address(RVA = "0x25BB900", Offset = "0x25BA500", VA = "0x1825BB900")]
		private void _SetStepDescription(string text)
		{
		}

		// Token: 0x0602A1BD RID: 172477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1BD")]
		[Address(RVA = "0x25BB3F0", Offset = "0x25B9FF0", VA = "0x1825BB3F0")]
		private void _RenderItemCard(UIItemViewModel viewModel)
		{
		}

		// Token: 0x0602A1BE RID: 172478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A1BE")]
		[Address(RVA = "0x25BBA50", Offset = "0x25BA650", VA = "0x1825BBA50")]
		public Act29signExpandViewItem()
		{
		}

		// Token: 0x0403C73C RID: 247612
		[Token(Token = "0x403C73C")]
		private const float ITEM_CARD_DISABLE = 0.5f;

		// Token: 0x0403C73D RID: 247613
		[Token(Token = "0x403C73D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _notSelectedView;

		// Token: 0x0403C73E RID: 247614
		[Token(Token = "0x403C73E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedView;

		// Token: 0x0403C73F RID: 247615
		[Token(Token = "0x403C73F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _doneView;

		// Token: 0x0403C740 RID: 247616
		[Token(Token = "0x403C740")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _expandDoneView;

		// Token: 0x0403C741 RID: 247617
		[Token(Token = "0x403C741")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _itemCardsContainer;

		// Token: 0x0403C742 RID: 247618
		[Token(Token = "0x403C742")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _rewardScale;

		// Token: 0x0403C743 RID: 247619
		[Token(Token = "0x403C743")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _stepDescTexts;

		// Token: 0x0403C744 RID: 247620
		[Token(Token = "0x403C744")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _stepIconContainer;

		// Token: 0x0403C745 RID: 247621
		[Token(Token = "0x403C745")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _topDescContainer;

		// Token: 0x0403C746 RID: 247622
		[Token(Token = "0x403C746")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _topDescTextContainer;

		// Token: 0x0403C747 RID: 247623
		[Token(Token = "0x403C747")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _topNumContainer;

		// Token: 0x0403C748 RID: 247624
		[Token(Token = "0x403C748")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _btmDescContainer;

		// Token: 0x0403C749 RID: 247625
		[Token(Token = "0x403C749")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _completeIconContainer;

		// Token: 0x0403C74A RID: 247626
		[Token(Token = "0x403C74A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAtlasImage _stepIcon;

		// Token: 0x0403C74B RID: 247627
		[Token(Token = "0x403C74B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HorizontalLayoutGroup _rewardLayoutGroup;

		// Token: 0x0403C74C RID: 247628
		[Token(Token = "0x403C74C")]
		[FieldOffset(Offset = "0x90")]
		private Act29signExpandViewItem.State m_state;

		// Token: 0x0403C74D RID: 247629
		[Token(Token = "0x403C74D")]
		[FieldOffset(Offset = "0x98")]
		private List<UIItemCard> m_itemCards;

		// Token: 0x0403C74E RID: 247630
		[Token(Token = "0x403C74E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C74F RID: 247631
		[Token(Token = "0x403C74F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ApplyConfig;

		// Token: 0x0403C750 RID: 247632
		[Token(Token = "0x403C750")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetState;

		// Token: 0x0403C751 RID: 247633
		[Token(Token = "0x403C751")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderReward;

		// Token: 0x0403C752 RID: 247634
		[Token(Token = "0x403C752")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetStepDescription;

		// Token: 0x0403C753 RID: 247635
		[Token(Token = "0x403C753")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderItemCard;

		// Token: 0x0403C754 RID: 247636
		[Token(Token = "0x403C754")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200749D RID: 29853
		[Token(Token = "0x200749D")]
		public enum State
		{
			// Token: 0x0403C756 RID: 247638
			[Token(Token = "0x403C756")]
			FOLD_NOT_DONE,
			// Token: 0x0403C757 RID: 247639
			[Token(Token = "0x403C757")]
			EXPAND_NOT_DONE,
			// Token: 0x0403C758 RID: 247640
			[Token(Token = "0x403C758")]
			FOLD_DONE,
			// Token: 0x0403C759 RID: 247641
			[Token(Token = "0x403C759")]
			EXPAND_DONE
		}

		// Token: 0x0200749E RID: 29854
		[Token(Token = "0x200749E")]
		public struct Model
		{
			// Token: 0x0403C75A RID: 247642
			[Token(Token = "0x403C75A")]
			[FieldOffset(Offset = "0x0")]
			public Act29signExpandViewItem.State state;

			// Token: 0x0403C75B RID: 247643
			[Token(Token = "0x403C75B")]
			[FieldOffset(Offset = "0x8")]
			public List<ItemBundle> bundleList;

			// Token: 0x0403C75C RID: 247644
			[Token(Token = "0x403C75C")]
			[FieldOffset(Offset = "0x10")]
			public string stepDesc;

			// Token: 0x0403C75D RID: 247645
			[Token(Token = "0x403C75D")]
			[FieldOffset(Offset = "0x18")]
			public int itemIndex;
		}

		// Token: 0x0200749F RID: 29855
		[Token(Token = "0x200749F")]
		[Serializable]
		public struct Config
		{
			// Token: 0x0403C75E RID: 247646
			[Token(Token = "0x403C75E")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 expandTopDescPosition;

			// Token: 0x0403C75F RID: 247647
			[Token(Token = "0x403C75F")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 expandStepIconPosition;

			// Token: 0x0403C760 RID: 247648
			[Token(Token = "0x403C760")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 foldStepIconPosition;

			// Token: 0x0403C761 RID: 247649
			[Token(Token = "0x403C761")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 foldTopDescPosition;

			// Token: 0x0403C762 RID: 247650
			[Token(Token = "0x403C762")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 foldBtmDescPositoin;

			// Token: 0x0403C763 RID: 247651
			[Token(Token = "0x403C763")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 rewardPosition;

			// Token: 0x0403C764 RID: 247652
			[Token(Token = "0x403C764")]
			[FieldOffset(Offset = "0x30")]
			public float rewardSpacing;

			// Token: 0x0403C765 RID: 247653
			[Token(Token = "0x403C765")]
			[FieldOffset(Offset = "0x34")]
			public Color expandStepIconColor;

			// Token: 0x0403C766 RID: 247654
			[Token(Token = "0x403C766")]
			[FieldOffset(Offset = "0x48")]
			public Color[] foldStepIconColors;
		}
	}
}

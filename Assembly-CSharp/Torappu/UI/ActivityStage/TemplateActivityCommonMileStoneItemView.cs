using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC3 RID: 27843
	[Token(Token = "0x2006CC3")]
	public abstract class TemplateActivityCommonMileStoneItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027B99 RID: 162713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B99")]
		[Address(RVA = "0x22D8810", Offset = "0x22D7410", VA = "0x1822D8810")]
		public void Render(TemplateActivityMileStoneItemModel itemModel)
		{
		}

		// Token: 0x06027B9A RID: 162714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9A")]
		[Address(RVA = "0x22D8CB0", Offset = "0x22D78B0", VA = "0x1822D8CB0")]
		private void _UpdateDisplayRewardIfNeed()
		{
		}

		// Token: 0x06027B9B RID: 162715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9B")]
		[Address(RVA = "0x22D8FB0", Offset = "0x22D7BB0", VA = "0x1822D8FB0")]
		protected void _UpdateTexts(Text[] textList, string desc)
		{
		}

		// Token: 0x06027B9C RID: 162716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9C")]
		[Address(RVA = "0x22D87B0", Offset = "0x22D73B0", VA = "0x1822D87B0", Slot = "4")]
		protected virtual void OnRender()
		{
		}

		// Token: 0x06027B9D RID: 162717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9D")]
		[Address(RVA = "0x22D8E20", Offset = "0x22D7A20", VA = "0x1822D8E20")]
		private void _UpdateRewardListIfNeed()
		{
		}

		// Token: 0x06027B9E RID: 162718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9E")]
		[Address(RVA = "0x22D86A0", Offset = "0x22D72A0", VA = "0x1822D86A0")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x06027B9F RID: 162719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B9F")]
		[Address(RVA = "0x22D90F0", Offset = "0x22D7CF0", VA = "0x1822D90F0")]
		protected TemplateActivityCommonMileStoneItemView()
		{
		}

		// Token: 0x04038536 RID: 230710
		[Token(Token = "0x4038536")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x04038537 RID: 230711
		[Token(Token = "0x4038537")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _textCostCountList;

		// Token: 0x04038538 RID: 230712
		[Token(Token = "0x4038538")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgCostItem;

		// Token: 0x04038539 RID: 230713
		[Token(Token = "0x4038539")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _textItemNameList;

		// Token: 0x0403853A RID: 230714
		[Token(Token = "0x403853A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text[] _textItemCountList;

		// Token: 0x0403853B RID: 230715
		[Token(Token = "0x403853B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _btnClick;

		// Token: 0x0403853C RID: 230716
		[Token(Token = "0x403853C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0403853D RID: 230717
		[Token(Token = "0x403853D")]
		[FieldOffset(Offset = "0x50")]
		private TemplateActivityCommonMileStoneItemView.Adapter m_adapter;

		// Token: 0x0403853E RID: 230718
		[Token(Token = "0x403853E")]
		[FieldOffset(Offset = "0x58")]
		protected TemplateActivityMileStoneItemModel m_itemModel;

		// Token: 0x0403853F RID: 230719
		[Token(Token = "0x403853F")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038540 RID: 230720
		[Token(Token = "0x4038540")]
		[FieldOffset(Offset = "0x70")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x04038541 RID: 230721
		[Token(Token = "0x4038541")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038542 RID: 230722
		[Token(Token = "0x4038542")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDisplayRewardIfNeed;

		// Token: 0x04038543 RID: 230723
		[Token(Token = "0x4038543")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateTexts;

		// Token: 0x04038544 RID: 230724
		[Token(Token = "0x4038544")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04038545 RID: 230725
		[Token(Token = "0x4038545")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateRewardListIfNeed;

		// Token: 0x04038546 RID: 230726
		[Token(Token = "0x4038546")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04038547 RID: 230727
		[Token(Token = "0x4038547")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CC4 RID: 27844
		[Token(Token = "0x2006CC4")]
		public class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06027BA0 RID: 162720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BA0")]
			[Address(RVA = "0x22D4950", Offset = "0x22D3550", VA = "0x1822D4950")]
			public Adapter(TemplateActivityCommonMileStoneItemView closure)
			{
			}

			// Token: 0x17005DCE RID: 24014
			// (get) Token: 0x06027BA1 RID: 162721 RVA: 0x000CF288 File Offset: 0x000CD488
			[Token(Token = "0x17005DCE")]
			public override int count
			{
				[Token(Token = "0x6027BA1")]
				[Address(RVA = "0x22D4AA0", Offset = "0x22D36A0", VA = "0x1822D4AA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027BA2 RID: 162722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027BA2")]
			[Address(RVA = "0x22D4790", Offset = "0x22D3390", VA = "0x1822D4790", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038548 RID: 230728
			[Token(Token = "0x4038548")]
			[FieldOffset(Offset = "0x20")]
			private TemplateActivityCommonMileStoneItemView m_closure;

			// Token: 0x04038549 RID: 230729
			[Token(Token = "0x4038549")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403854A RID: 230730
			[Token(Token = "0x403854A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403854B RID: 230731
			[Token(Token = "0x403854B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

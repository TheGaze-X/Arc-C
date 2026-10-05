using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200683D RID: 26685
	[Token(Token = "0x200683D")]
	public class SixStarRuneSelectView : DataBinder<SixStarRuneSelectProperty>, IHotfixable
	{
		// Token: 0x06026365 RID: 156517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026365")]
		[Address(RVA = "0x214CF80", Offset = "0x214BB80", VA = "0x18214CF80", Slot = "7")]
		public override void OnValueChanged(SixStarRuneSelectProperty property)
		{
		}

		// Token: 0x06026366 RID: 156518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026366")]
		[Address(RVA = "0x214CE70", Offset = "0x214BA70", VA = "0x18214CE70")]
		public void EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06026367 RID: 156519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026367")]
		[Address(RVA = "0x214CEF0", Offset = "0x214BAF0", VA = "0x18214CEF0")]
		public void EventOnMilestoneBtnClicked()
		{
		}

		// Token: 0x06026368 RID: 156520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026368")]
		[Address(RVA = "0x214D130", Offset = "0x214BD30", VA = "0x18214D130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026369 RID: 156521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026369")]
		[Address(RVA = "0x214D3F0", Offset = "0x214BFF0", VA = "0x18214D3F0")]
		public SixStarRuneSelectView()
		{
		}

		// Token: 0x04035DB2 RID: 220594
		[Token(Token = "0x4035DB2")]
		private const float ITEM_CARD_SCALE = 0.35f;

		// Token: 0x04035DB3 RID: 220595
		[Token(Token = "0x4035DB3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTotalGotPoint;

		// Token: 0x04035DB4 RID: 220596
		[Token(Token = "0x4035DB4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRewardTip;

		// Token: 0x04035DB5 RID: 220597
		[Token(Token = "0x4035DB5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNextReward;

		// Token: 0x04035DB6 RID: 220598
		[Token(Token = "0x4035DB6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _nextRewardCardContainer;

		// Token: 0x04035DB7 RID: 220599
		[Token(Token = "0x4035DB7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelMileStoneTrackPoint;

		// Token: 0x04035DB8 RID: 220600
		[Token(Token = "0x4035DB8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x04035DB9 RID: 220601
		[Token(Token = "0x4035DB9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04035DBA RID: 220602
		[Token(Token = "0x4035DBA")]
		[FieldOffset(Offset = "0x58")]
		private List<SixStarRuneSelectGroupViewModel> m_cachedRuneGroupModel;

		// Token: 0x04035DBB RID: 220603
		[Token(Token = "0x4035DBB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04035DBC RID: 220604
		[Token(Token = "0x4035DBC")]
		[FieldOffset(Offset = "0x68")]
		private SixStarRuneSelectView.Adapter m_adapter;

		// Token: 0x04035DBD RID: 220605
		[Token(Token = "0x4035DBD")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_rewardCard;

		// Token: 0x04035DBE RID: 220606
		[Token(Token = "0x4035DBE")]
		[FieldOffset(Offset = "0x78")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04035DBF RID: 220607
		[Token(Token = "0x4035DBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035DC0 RID: 220608
		[Token(Token = "0x4035DC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClicked;

		// Token: 0x04035DC1 RID: 220609
		[Token(Token = "0x4035DC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMilestoneBtnClicked;

		// Token: 0x04035DC2 RID: 220610
		[Token(Token = "0x4035DC2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035DC3 RID: 220611
		[Token(Token = "0x4035DC3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200683E RID: 26686
		[Token(Token = "0x200683E")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602636A RID: 156522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602636A")]
			[Address(RVA = "0x2147BE0", Offset = "0x21467E0", VA = "0x182147BE0")]
			public Adapter(SixStarRuneSelectView closure)
			{
			}

			// Token: 0x17005A4D RID: 23117
			// (get) Token: 0x0602636B RID: 156523 RVA: 0x000CA620 File Offset: 0x000C8820
			[Token(Token = "0x17005A4D")]
			public override int count
			{
				[Token(Token = "0x602636B")]
				[Address(RVA = "0x2147D60", Offset = "0x2146960", VA = "0x182147D60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602636C RID: 156524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602636C")]
			[Address(RVA = "0x2147840", Offset = "0x2146440", VA = "0x182147840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04035DC4 RID: 220612
			[Token(Token = "0x4035DC4")]
			[FieldOffset(Offset = "0x20")]
			private SixStarRuneSelectView m_closure;

			// Token: 0x04035DC5 RID: 220613
			[Token(Token = "0x4035DC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035DC6 RID: 220614
			[Token(Token = "0x4035DC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04035DC7 RID: 220615
			[Token(Token = "0x4035DC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

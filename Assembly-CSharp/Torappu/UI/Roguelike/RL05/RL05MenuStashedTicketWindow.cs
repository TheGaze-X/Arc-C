using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055ED RID: 21997
	[Token(Token = "0x20055ED")]
	public class RL05MenuStashedTicketWindow : RoguelikeMenuWindow<RL05MenuStashedTicketViewModel>
	{
		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x060204A7 RID: 132263 RVA: 0x000B5398 File Offset: 0x000B3598
		[Token(Token = "0x17004BA5")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x60204A7")]
			[Address(RVA = "0x1A683C0", Offset = "0x1A66FC0", VA = "0x181A683C0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x060204A8 RID: 132264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204A8")]
		[Address(RVA = "0x1A67F90", Offset = "0x1A66B90", VA = "0x181A67F90", Slot = "10")]
		public override void Render(RL05MenuStashedTicketViewModel viewModel)
		{
		}

		// Token: 0x060204A9 RID: 132265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204A9")]
		[Address(RVA = "0x1A681E0", Offset = "0x1A66DE0", VA = "0x181A681E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060204AA RID: 132266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204AA")]
		[Address(RVA = "0x1A67E80", Offset = "0x1A66A80", VA = "0x181A67E80", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x060204AB RID: 132267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204AB")]
		[Address(RVA = "0x1A68350", Offset = "0x1A66F50", VA = "0x181A68350")]
		public RL05MenuStashedTicketWindow()
		{
		}

		// Token: 0x060204AC RID: 132268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60204AC")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402BB29 RID: 178985
		[Token(Token = "0x402BB29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCandleHolder;

		// Token: 0x0402BB2A RID: 178986
		[Token(Token = "0x402BB2A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtCandleHolder;

		// Token: 0x0402BB2B RID: 178987
		[Token(Token = "0x402BB2B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelStashedTicket;

		// Token: 0x0402BB2C RID: 178988
		[Token(Token = "0x402BB2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL05MenuStashedTicketItem _itemPrefab;

		// Token: 0x0402BB2D RID: 178989
		[Token(Token = "0x402BB2D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RL05MenuStashedTicketTitleItem _titleItemPrefab;

		// Token: 0x0402BB2E RID: 178990
		[Token(Token = "0x402BB2E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _recycleLayoutList;

		// Token: 0x0402BB2F RID: 178991
		[Token(Token = "0x402BB2F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0402BB30 RID: 178992
		[Token(Token = "0x402BB30")]
		[FieldOffset(Offset = "0x60")]
		private RL05MenuStashedTicketWindow.StashedTicketAdapter m_adapter;

		// Token: 0x0402BB31 RID: 178993
		[Token(Token = "0x402BB31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402BB32 RID: 178994
		[Token(Token = "0x402BB32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BB33 RID: 178995
		[Token(Token = "0x402BB33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402BB34 RID: 178996
		[Token(Token = "0x402BB34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402BB35 RID: 178997
		[Token(Token = "0x402BB35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055EE RID: 21998
		[Token(Token = "0x20055EE")]
		private class StashedTicketAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060204AD RID: 132269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204AD")]
			[Address(RVA = "0x1A73460", Offset = "0x1A72060", VA = "0x181A73460")]
			public StashedTicketAdapter(RL05MenuStashedTicketWindow closure)
			{
			}

			// Token: 0x060204AE RID: 132270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60204AE")]
			[Address(RVA = "0x1A73000", Offset = "0x1A71C00", VA = "0x181A73000", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060204AF RID: 132271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60204AF")]
			[Address(RVA = "0x1A73130", Offset = "0x1A71D30", VA = "0x181A73130")]
			public void RebuildList(RL05MenuStashedTicketViewModel viewModel)
			{
			}

			// Token: 0x0402BB36 RID: 178998
			[Token(Token = "0x402BB36")]
			[FieldOffset(Offset = "0x18")]
			private RL05MenuStashedTicketWindow m_closure;

			// Token: 0x0402BB37 RID: 178999
			[Token(Token = "0x402BB37")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0402BB38 RID: 179000
			[Token(Token = "0x402BB38")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402BB39 RID: 179001
			[Token(Token = "0x402BB39")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402BB3A RID: 179002
			[Token(Token = "0x402BB3A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;
		}
	}
}

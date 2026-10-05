using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200553F RID: 21823
	[Token(Token = "0x200553F")]
	public class RoguelikeStashedTicketUseState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06020167 RID: 131431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020167")]
		[Address(RVA = "0x1A40870", Offset = "0x1A3F470", VA = "0x181A40870", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06020168 RID: 131432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020168")]
		[Address(RVA = "0x1A40660", Offset = "0x1A3F260", VA = "0x181A40660", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06020169 RID: 131433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020169")]
		[Address(RVA = "0x1A406C0", Offset = "0x1A3F2C0", VA = "0x181A406C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602016A RID: 131434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016A")]
		[Address(RVA = "0x1A40A90", Offset = "0x1A3F690", VA = "0x181A40A90", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0602016B RID: 131435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016B")]
		[Address(RVA = "0x1A40DD0", Offset = "0x1A3F9D0", VA = "0x181A40DD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602016C RID: 131436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016C")]
		[Address(RVA = "0x1A41080", Offset = "0x1A3FC80", VA = "0x181A41080")]
		private void _InitView()
		{
		}

		// Token: 0x0602016D RID: 131437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016D")]
		[Address(RVA = "0x1A41950", Offset = "0x1A40550", VA = "0x181A41950")]
		private void _OnItemClicked(int instId)
		{
		}

		// Token: 0x0602016E RID: 131438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016E")]
		[Address(RVA = "0x1A41590", Offset = "0x1A40190", VA = "0x181A41590")]
		private void _OnConfirmUseStashedTicket()
		{
		}

		// Token: 0x0602016F RID: 131439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602016F")]
		[Address(RVA = "0x1A41F40", Offset = "0x1A40B40", VA = "0x181A41F40")]
		private void _OnUseStashedTicketSuccess()
		{
		}

		// Token: 0x06020170 RID: 131440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020170")]
		[Address(RVA = "0x1A41480", Offset = "0x1A40080", VA = "0x181A41480")]
		private void _OnCancelLeaveClick()
		{
		}

		// Token: 0x06020171 RID: 131441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020171")]
		[Address(RVA = "0x1A41B50", Offset = "0x1A40750", VA = "0x181A41B50")]
		private void _OnLeaveBtnClick()
		{
		}

		// Token: 0x06020172 RID: 131442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020172")]
		[Address(RVA = "0x1A41260", Offset = "0x1A3FE60", VA = "0x181A41260")]
		private void _LeaveUseStashedTicketEvent()
		{
		}

		// Token: 0x06020173 RID: 131443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020173")]
		[Address(RVA = "0x1A422A0", Offset = "0x1A40EA0", VA = "0x181A422A0")]
		public RoguelikeStashedTicketUseState()
		{
		}

		// Token: 0x06020176 RID: 131446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020176")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06020177 RID: 131447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020177")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0402B57D RID: 177533
		[Token(Token = "0x402B57D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x0402B57E RID: 177534
		[Token(Token = "0x402B57E")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeStashedTicketUseState.RoguelikeStashedTicketUseStateBean m_stateBean;

		// Token: 0x0402B57F RID: 177535
		[Token(Token = "0x402B57F")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeStashedTicketUseView m_view;

		// Token: 0x0402B580 RID: 177536
		[Token(Token = "0x402B580")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeStashedTicketUseState.MenuAdapter m_menuAdapter;

		// Token: 0x0402B581 RID: 177537
		[Token(Token = "0x402B581")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0402B582 RID: 177538
		[Token(Token = "0x402B582")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeStashedTicketUsePlugin m_plugin;

		// Token: 0x0402B583 RID: 177539
		[Token(Token = "0x402B583")]
		[FieldOffset(Offset = "0xA0")]
		private string m_topicId;

		// Token: 0x0402B584 RID: 177540
		[Token(Token = "0x402B584")]
		[NonSerialized]
		public const int MSG_STASHED_TICKET_ITEM_CLICK = 0;

		// Token: 0x0402B585 RID: 177541
		[Token(Token = "0x402B585")]
		[NonSerialized]
		public const int MSG_CONFIRM_USE = 1;

		// Token: 0x0402B586 RID: 177542
		[Token(Token = "0x402B586")]
		[NonSerialized]
		public const int MSG_LEAVE_BTN_CLICK = 2;

		// Token: 0x0402B587 RID: 177543
		[Token(Token = "0x402B587")]
		[NonSerialized]
		public const int MSG_CANCEL_LEAVE_CLICK = 3;

		// Token: 0x0402B588 RID: 177544
		[Token(Token = "0x402B588")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402B589 RID: 177545
		[Token(Token = "0x402B589")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402B58A RID: 177546
		[Token(Token = "0x402B58A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402B58B RID: 177547
		[Token(Token = "0x402B58B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x0402B58C RID: 177548
		[Token(Token = "0x402B58C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B58D RID: 177549
		[Token(Token = "0x402B58D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x0402B58E RID: 177550
		[Token(Token = "0x402B58E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0402B58F RID: 177551
		[Token(Token = "0x402B58F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnConfirmUseStashedTicket;

		// Token: 0x0402B590 RID: 177552
		[Token(Token = "0x402B590")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUseStashedTicketSuccess;

		// Token: 0x0402B591 RID: 177553
		[Token(Token = "0x402B591")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCancelLeaveClick;

		// Token: 0x0402B592 RID: 177554
		[Token(Token = "0x402B592")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnLeaveBtnClick;

		// Token: 0x0402B593 RID: 177555
		[Token(Token = "0x402B593")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LeaveUseStashedTicketEvent;

		// Token: 0x0402B594 RID: 177556
		[Token(Token = "0x402B594")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005540 RID: 21824
		[Token(Token = "0x2005540")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x17004B3B RID: 19259
			// (get) Token: 0x06020178 RID: 131448 RVA: 0x000B4870 File Offset: 0x000B2A70
			[Token(Token = "0x17004B3B")]
			public override bool showStatusBar
			{
				[Token(Token = "0x6020178")]
				[Address(RVA = "0x1A31300", Offset = "0x1A2FF00", VA = "0x181A31300", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17004B3C RID: 19260
			// (get) Token: 0x06020179 RID: 131449 RVA: 0x000B4888 File Offset: 0x000B2A88
			[Token(Token = "0x17004B3C")]
			public override bool showBottomBar
			{
				[Token(Token = "0x6020179")]
				[Address(RVA = "0x1A31240", Offset = "0x1A2FE40", VA = "0x181A31240", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602017A RID: 131450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602017A")]
			[Address(RVA = "0x1A31080", Offset = "0x1A2FC80", VA = "0x181A31080")]
			public MenuAdapter()
			{
			}

			// Token: 0x0602017B RID: 131451 RVA: 0x000B48A0 File Offset: 0x000B2AA0
			[Token(Token = "0x602017B")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0602017C RID: 131452 RVA: 0x000B48B8 File Offset: 0x000B2AB8
			[Token(Token = "0x602017C")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0402B595 RID: 177557
			[Token(Token = "0x402B595")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x0402B596 RID: 177558
			[Token(Token = "0x402B596")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x0402B597 RID: 177559
			[Token(Token = "0x402B597")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005541 RID: 21825
		[Token(Token = "0x2005541")]
		private class RoguelikeStashedTicketUseStateBean : IStateBean, IHotfixable
		{
			// Token: 0x0602017D RID: 131453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602017D")]
			[Address(RVA = "0x1A40210", Offset = "0x1A3EE10", VA = "0x181A40210")]
			public void LoadData(string topicId, RoguelikeStashedTicketUseParamBuilder paramBuilder)
			{
			}

			// Token: 0x0602017E RID: 131454 RVA: 0x000B48D0 File Offset: 0x000B2AD0
			[Token(Token = "0x602017E")]
			[Address(RVA = "0x1A403C0", Offset = "0x1A3EFC0", VA = "0x181A403C0")]
			public bool OnItemClicked(int ticketInstId)
			{
				return default(bool);
			}

			// Token: 0x0602017F RID: 131455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602017F")]
			[Address(RVA = "0x1A40570", Offset = "0x1A3F170", VA = "0x181A40570")]
			public RoguelikeStashedTicketUseStateBean()
			{
			}

			// Token: 0x0402B598 RID: 177560
			[Token(Token = "0x402B598")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeStashedTicketUseProperty property;

			// Token: 0x0402B599 RID: 177561
			[Token(Token = "0x402B599")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402B59A RID: 177562
			[Token(Token = "0x402B59A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClicked;

			// Token: 0x0402B59B RID: 177563
			[Token(Token = "0x402B59B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

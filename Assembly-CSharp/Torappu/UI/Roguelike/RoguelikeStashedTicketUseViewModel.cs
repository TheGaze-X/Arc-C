using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005546 RID: 21830
	[Token(Token = "0x2005546")]
	public class RoguelikeStashedTicketUseViewModel : IHotfixable
	{
		// Token: 0x17004B4A RID: 19274
		// (get) Token: 0x0602019F RID: 131487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B4A")]
		public string selectedTicketId
		{
			[Token(Token = "0x602019F")]
			[Address(RVA = "0x1A42B70", Offset = "0x1A41770", VA = "0x181A42B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x060201A0 RID: 131488 RVA: 0x000B4930 File Offset: 0x000B2B30
		[Token(Token = "0x17004B4B")]
		public int selectedItemIndex
		{
			[Token(Token = "0x60201A0")]
			[Address(RVA = "0x1A42B10", Offset = "0x1A41710", VA = "0x181A42B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x060201A1 RID: 131489 RVA: 0x000B4948 File Offset: 0x000B2B48
		[Token(Token = "0x17004B4C")]
		public bool playerHasStashedTicket
		{
			[Token(Token = "0x60201A1")]
			[Address(RVA = "0x1A429F0", Offset = "0x1A415F0", VA = "0x181A429F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x060201A2 RID: 131490 RVA: 0x000B4960 File Offset: 0x000B2B60
		[Token(Token = "0x17004B4D")]
		public bool canConfirmUse
		{
			[Token(Token = "0x60201A2")]
			[Address(RVA = "0x1A427B0", Offset = "0x1A413B0", VA = "0x181A427B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x060201A3 RID: 131491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B4E")]
		public List<IRoguelikeStashedTicketItemViewModel> itemList
		{
			[Token(Token = "0x60201A3")]
			[Address(RVA = "0x1A42990", Offset = "0x1A41590", VA = "0x181A42990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x060201A4 RID: 131492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B4F")]
		public RoguelikeStashedTicketUseDesParam desParam
		{
			[Token(Token = "0x60201A4")]
			[Address(RVA = "0x1A42870", Offset = "0x1A41470", VA = "0x181A42870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B50 RID: 19280
		// (get) Token: 0x060201A5 RID: 131493 RVA: 0x000B4978 File Offset: 0x000B2B78
		[Token(Token = "0x17004B50")]
		public int playerUseLeftCnt
		{
			[Token(Token = "0x60201A5")]
			[Address(RVA = "0x1A42A50", Offset = "0x1A41650", VA = "0x181A42A50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x060201A6 RID: 131494 RVA: 0x000B4990 File Offset: 0x000B2B90
		[Token(Token = "0x17004B51")]
		public int recruitCostAdd
		{
			[Token(Token = "0x60201A6")]
			[Address(RVA = "0x1A42AB0", Offset = "0x1A416B0", VA = "0x181A42AB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x060201A7 RID: 131495 RVA: 0x000B49A8 File Offset: 0x000B2BA8
		[Token(Token = "0x17004B52")]
		public bool isLeaveBtnOpening
		{
			[Token(Token = "0x60201A7")]
			[Address(RVA = "0x1A42930", Offset = "0x1A41530", VA = "0x181A42930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x060201A8 RID: 131496 RVA: 0x000B49C0 File Offset: 0x000B2BC0
		[Token(Token = "0x17004B53")]
		public int initSeqNum
		{
			[Token(Token = "0x60201A8")]
			[Address(RVA = "0x1A428D0", Offset = "0x1A414D0", VA = "0x181A428D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060201A9 RID: 131497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201A9")]
		[Address(RVA = "0x1A42410", Offset = "0x1A41010", VA = "0x181A42410")]
		public void LoadData(string topicId, RoguelikeStashedTicketUseParamBuilder paramBuilder)
		{
		}

		// Token: 0x060201AA RID: 131498 RVA: 0x000B49D8 File Offset: 0x000B2BD8
		[Token(Token = "0x60201AA")]
		[Address(RVA = "0x1A425D0", Offset = "0x1A411D0", VA = "0x181A425D0")]
		public bool TrySelectItem(int ticketIdx)
		{
			return default(bool);
		}

		// Token: 0x060201AB RID: 131499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201AB")]
		[Address(RVA = "0x1A42560", Offset = "0x1A41160", VA = "0x181A42560")]
		public void RefreshLeaveBtnStatus(bool isOpening)
		{
		}

		// Token: 0x060201AC RID: 131500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201AC")]
		[Address(RVA = "0x1A426F0", Offset = "0x1A412F0", VA = "0x181A426F0")]
		public RoguelikeStashedTicketUseViewModel()
		{
		}

		// Token: 0x0402B5CB RID: 177611
		[Token(Token = "0x402B5CB")]
		[FieldOffset(Offset = "0x10")]
		private bool m_playerHasStashedTicket;

		// Token: 0x0402B5CC RID: 177612
		[Token(Token = "0x402B5CC")]
		[FieldOffset(Offset = "0x18")]
		private List<IRoguelikeStashedTicketItemViewModel> m_itemList;

		// Token: 0x0402B5CD RID: 177613
		[Token(Token = "0x402B5CD")]
		[FieldOffset(Offset = "0x20")]
		private IRoguelikeStashedTicketItemViewModel m_selectedItem;

		// Token: 0x0402B5CE RID: 177614
		[Token(Token = "0x402B5CE")]
		[FieldOffset(Offset = "0x28")]
		private int m_selectedItemIndex;

		// Token: 0x0402B5CF RID: 177615
		[Token(Token = "0x402B5CF")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeStashedTicketUseDesParam m_desParam;

		// Token: 0x0402B5D0 RID: 177616
		[Token(Token = "0x402B5D0")]
		[FieldOffset(Offset = "0x38")]
		private int m_playerUseLeftCnt;

		// Token: 0x0402B5D1 RID: 177617
		[Token(Token = "0x402B5D1")]
		[FieldOffset(Offset = "0x3C")]
		private int m_recruitCostAdd;

		// Token: 0x0402B5D2 RID: 177618
		[Token(Token = "0x402B5D2")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isLeaveBtnOpening;

		// Token: 0x0402B5D3 RID: 177619
		[Token(Token = "0x402B5D3")]
		[FieldOffset(Offset = "0x44")]
		private int m_initSeqNum;

		// Token: 0x0402B5D4 RID: 177620
		[Token(Token = "0x402B5D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTicketId;

		// Token: 0x0402B5D5 RID: 177621
		[Token(Token = "0x402B5D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItemIndex;

		// Token: 0x0402B5D6 RID: 177622
		[Token(Token = "0x402B5D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_playerHasStashedTicket;

		// Token: 0x0402B5D7 RID: 177623
		[Token(Token = "0x402B5D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canConfirmUse;

		// Token: 0x0402B5D8 RID: 177624
		[Token(Token = "0x402B5D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x0402B5D9 RID: 177625
		[Token(Token = "0x402B5D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_desParam;

		// Token: 0x0402B5DA RID: 177626
		[Token(Token = "0x402B5DA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playerUseLeftCnt;

		// Token: 0x0402B5DB RID: 177627
		[Token(Token = "0x402B5DB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_recruitCostAdd;

		// Token: 0x0402B5DC RID: 177628
		[Token(Token = "0x402B5DC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isLeaveBtnOpening;

		// Token: 0x0402B5DD RID: 177629
		[Token(Token = "0x402B5DD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_initSeqNum;

		// Token: 0x0402B5DE RID: 177630
		[Token(Token = "0x402B5DE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B5DF RID: 177631
		[Token(Token = "0x402B5DF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TrySelectItem;

		// Token: 0x0402B5E0 RID: 177632
		[Token(Token = "0x402B5E0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RefreshLeaveBtnStatus;

		// Token: 0x0402B5E1 RID: 177633
		[Token(Token = "0x402B5E1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

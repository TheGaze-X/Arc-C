using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057CB RID: 22475
	[Token(Token = "0x20057CB")]
	public class RoguelikeInitManualRecruitContext : RoguelikeInitRecruitContext
	{
		// Token: 0x17004D15 RID: 19733
		// (get) Token: 0x06020DF7 RID: 134647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020DF8 RID: 134648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D15")]
		public RoguelikeCharSelectStateBean.Input charSelInput
		{
			[Token(Token = "0x6020DF7")]
			[Address(RVA = "0x1B3B970", Offset = "0x1B3A570", VA = "0x181B3B970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020DF8")]
			[Address(RVA = "0x1B3BAB0", Offset = "0x1B3A6B0", VA = "0x181B3BAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004D16 RID: 19734
		// (get) Token: 0x06020DF9 RID: 134649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D16")]
		public override List<RoguelikeInitRecruit.Model> list
		{
			[Token(Token = "0x6020DF9")]
			[Address(RVA = "0x1B3B9D0", Offset = "0x1B3A5D0", VA = "0x181B3B9D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D17 RID: 19735
		// (get) Token: 0x06020DFA RID: 134650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D17")]
		public override string name
		{
			[Token(Token = "0x6020DFA")]
			[Address(RVA = "0x1B3BA30", Offset = "0x1B3A630", VA = "0x181B3BA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020DFB RID: 134651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DFB")]
		[Address(RVA = "0x1B3A910", Offset = "0x1B39510", VA = "0x181B3A910", Slot = "4")]
		public override void Load(PlayerRoguelikePendingEvent evt)
		{
		}

		// Token: 0x06020DFC RID: 134652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DFC")]
		[Address(RVA = "0x1B3B1E0", Offset = "0x1B39DE0", VA = "0x181B3B1E0", Slot = "7")]
		public override void OnSelect(int idx)
		{
		}

		// Token: 0x06020DFD RID: 134653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DFD")]
		[Address(RVA = "0x1B3B530", Offset = "0x1B3A130", VA = "0x181B3B530")]
		private void _JumpToRoguelikeCharSelect(string ticketIndex)
		{
		}

		// Token: 0x06020DFE RID: 134654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DFE")]
		[Address(RVA = "0x1B3B690", Offset = "0x1B3A290", VA = "0x181B3B690")]
		private void _OnSelectRecruitResponse(string ticketId, int result, Action callback)
		{
		}

		// Token: 0x06020DFF RID: 134655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DFF")]
		[Address(RVA = "0x1B3B840", Offset = "0x1B3A440", VA = "0x181B3B840")]
		public RoguelikeInitManualRecruitContext()
		{
		}

		// Token: 0x0402CAB5 RID: 182965
		[Token(Token = "0x402CAB5")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeInitRecruit.Model> m_list;

		// Token: 0x0402CAB6 RID: 182966
		[Token(Token = "0x402CAB6")]
		[FieldOffset(Offset = "0x30")]
		private int m_showCharCnt;

		// Token: 0x0402CAB7 RID: 182967
		[Token(Token = "0x402CAB7")]
		[FieldOffset(Offset = "0x38")]
		private string[] m_tickets;

		// Token: 0x0402CAB9 RID: 182969
		[Token(Token = "0x402CAB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charSelInput;

		// Token: 0x0402CABA RID: 182970
		[Token(Token = "0x402CABA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_charSelInput;

		// Token: 0x0402CABB RID: 182971
		[Token(Token = "0x402CABB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_list;

		// Token: 0x0402CABC RID: 182972
		[Token(Token = "0x402CABC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CABD RID: 182973
		[Token(Token = "0x402CABD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x0402CABE RID: 182974
		[Token(Token = "0x402CABE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSelect;

		// Token: 0x0402CABF RID: 182975
		[Token(Token = "0x402CABF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JumpToRoguelikeCharSelect;

		// Token: 0x0402CAC0 RID: 182976
		[Token(Token = "0x402CAC0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSelectRecruitResponse;

		// Token: 0x0402CAC1 RID: 182977
		[Token(Token = "0x402CAC1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

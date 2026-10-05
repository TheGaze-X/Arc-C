using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005764 RID: 22372
	[Token(Token = "0x2005764")]
	public class RL02EndingFrameMutationAndVirtueReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CCF RID: 19663
		// (get) Token: 0x06020C3E RID: 134206 RVA: 0x000B7198 File Offset: 0x000B5398
		[Token(Token = "0x17004CCF")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C3E")]
			[Address(RVA = "0x1B1F7A0", Offset = "0x1B1E3A0", VA = "0x181B1F7A0", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C3F RID: 134207 RVA: 0x000B71B0 File Offset: 0x000B53B0
		[Token(Token = "0x6020C3F")]
		[Address(RVA = "0x1B1EEA0", Offset = "0x1B1DAA0", VA = "0x181B1EEA0", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x17004CD0 RID: 19664
		// (get) Token: 0x06020C40 RID: 134208 RVA: 0x000B71C8 File Offset: 0x000B53C8
		[Token(Token = "0x17004CD0")]
		public bool hasMutation
		{
			[Token(Token = "0x6020C40")]
			[Address(RVA = "0x1B1F690", Offset = "0x1B1E290", VA = "0x181B1F690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CD1 RID: 19665
		// (get) Token: 0x06020C41 RID: 134209 RVA: 0x000B71E0 File Offset: 0x000B53E0
		[Token(Token = "0x17004CD1")]
		public bool hasVirtue
		{
			[Token(Token = "0x6020C41")]
			[Address(RVA = "0x1B1F720", Offset = "0x1B1E320", VA = "0x181B1F720")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020C42 RID: 134210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C42")]
		[Address(RVA = "0x1B1F550", Offset = "0x1B1E150", VA = "0x181B1F550")]
		public RL02EndingFrameMutationAndVirtueReportViewModel()
		{
		}

		// Token: 0x0402C7DF RID: 182239
		[Token(Token = "0x402C7DF")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0402C7E0 RID: 182240
		[Token(Token = "0x402C7E0")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeCharBuffModel mutation;

		// Token: 0x0402C7E1 RID: 182241
		[Token(Token = "0x402C7E1")]
		[FieldOffset(Offset = "0x58")]
		public List<string> mutationCharNames;

		// Token: 0x0402C7E2 RID: 182242
		[Token(Token = "0x402C7E2")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeSquadBuffModel> virtueList;

		// Token: 0x0402C7E3 RID: 182243
		[Token(Token = "0x402C7E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C7E4 RID: 182244
		[Token(Token = "0x402C7E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C7E5 RID: 182245
		[Token(Token = "0x402C7E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasMutation;

		// Token: 0x0402C7E6 RID: 182246
		[Token(Token = "0x402C7E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasVirtue;

		// Token: 0x0402C7E7 RID: 182247
		[Token(Token = "0x402C7E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

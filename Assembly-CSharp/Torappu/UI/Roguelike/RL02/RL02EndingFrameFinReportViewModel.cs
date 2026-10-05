using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005770 RID: 22384
	[Token(Token = "0x2005770")]
	public class RL02EndingFrameFinReportViewModel : RL02EndingFrameReportViewModel
	{
		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x06020C60 RID: 134240 RVA: 0x000B73A8 File Offset: 0x000B55A8
		[Token(Token = "0x17004CDB")]
		public override RL02ReportController.ReportViewType viewType
		{
			[Token(Token = "0x6020C60")]
			[Address(RVA = "0x1B1EE40", Offset = "0x1B1DA40", VA = "0x181B1EE40", Slot = "4")]
			get
			{
				return RL02ReportController.ReportViewType.NONE;
			}
		}

		// Token: 0x06020C61 RID: 134241 RVA: 0x000B73C0 File Offset: 0x000B55C0
		[Token(Token = "0x6020C61")]
		[Address(RVA = "0x1B1ED10", Offset = "0x1B1D910", VA = "0x181B1ED10", Slot = "5")]
		protected override bool LoadData(string topicId, RL02EndingFrameViewModel dataSource)
		{
			return default(bool);
		}

		// Token: 0x06020C62 RID: 134242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C62")]
		[Address(RVA = "0x1B1EDA0", Offset = "0x1B1D9A0", VA = "0x181B1EDA0")]
		public RL02EndingFrameFinReportViewModel()
		{
		}

		// Token: 0x0402C811 RID: 182289
		[Token(Token = "0x402C811")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C812 RID: 182290
		[Token(Token = "0x402C812")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C813 RID: 182291
		[Token(Token = "0x402C813")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005750 RID: 22352
	[Token(Token = "0x2005750")]
	public class RL02ReportFinView : RL02CommonReportView<RL02EndingFrameFinReportViewModel>
	{
		// Token: 0x06020C03 RID: 134147 RVA: 0x000B7090 File Offset: 0x000B5290
		[Token(Token = "0x6020C03")]
		[Address(RVA = "0x1B0ADC0", Offset = "0x1B099C0", VA = "0x181B0ADC0", Slot = "4")]
		public override RL02ReportController.ReportViewType GetViewType()
		{
			return RL02ReportController.ReportViewType.NONE;
		}

		// Token: 0x06020C04 RID: 134148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020C04")]
		[Address(RVA = "0x1B0AD50", Offset = "0x1B09950", VA = "0x181B0AD50", Slot = "7")]
		protected override string GetShowAnimName()
		{
			return null;
		}

		// Token: 0x06020C05 RID: 134149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C05")]
		[Address(RVA = "0x1B0AE20", Offset = "0x1B09A20", VA = "0x181B0AE20", Slot = "8")]
		protected override void Render(RL02EndingFrameFinReportViewModel viewModel)
		{
		}

		// Token: 0x06020C06 RID: 134150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C06")]
		[Address(RVA = "0x1B0AE80", Offset = "0x1B09A80", VA = "0x181B0AE80")]
		public RL02ReportFinView()
		{
		}

		// Token: 0x0402C768 RID: 182120
		[Token(Token = "0x402C768")]
		private const string ENTER_ANIM_NAME = "report_fin";

		// Token: 0x0402C769 RID: 182121
		[Token(Token = "0x402C769")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402C76A RID: 182122
		[Token(Token = "0x402C76A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShowAnimName;

		// Token: 0x0402C76B RID: 182123
		[Token(Token = "0x402C76B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C76C RID: 182124
		[Token(Token = "0x402C76C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

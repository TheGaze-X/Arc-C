using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005757 RID: 22359
	[Token(Token = "0x2005757")]
	public abstract class RL02ReportNewsItemView<TModel> : RL02ReportNewsItemViewBase where TModel : RL02EndingFrameNewsReportViewModel.NewsItemModel
	{
		// Token: 0x06020C18 RID: 134168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C18")]
		public sealed override void Render(RL02EndingFrameNewsReportViewModel.NewsItemModel itemModel, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C19 RID: 134169
		[Token(Token = "0x6020C19")]
		protected abstract void DoRender(TModel model, RL02EndingText textConfig);

		// Token: 0x06020C1A RID: 134170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1A")]
		protected RL02ReportNewsItemView()
		{
		}

		// Token: 0x0402C78C RID: 182156
		[Token(Token = "0x402C78C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C78D RID: 182157
		[Token(Token = "0x402C78D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005759 RID: 22361
	[Token(Token = "0x2005759")]
	public class RL02ReportNewsPracticeItemView : RL02ReportNewsItemView<RL02EndingFrameNewsReportViewModel.NewsPracticeItemModel>
	{
		// Token: 0x06020C1D RID: 134173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1D")]
		[Address(RVA = "0x1B25640", Offset = "0x1B24240", VA = "0x181B25640", Slot = "5")]
		protected override void DoRender(RL02EndingFrameNewsReportViewModel.NewsPracticeItemModel model, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C1E RID: 134174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1E")]
		[Address(RVA = "0x1B257C0", Offset = "0x1B243C0", VA = "0x181B257C0")]
		public RL02ReportNewsPracticeItemView()
		{
		}

		// Token: 0x0402C791 RID: 182161
		[Token(Token = "0x402C791")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalNum;

		// Token: 0x0402C792 RID: 182162
		[Token(Token = "0x402C792")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402C793 RID: 182163
		[Token(Token = "0x402C793")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

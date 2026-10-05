using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005758 RID: 22360
	[Token(Token = "0x2005758")]
	public class RL02ReportNewsKnightItemView : RL02ReportNewsItemView<RL02EndingFrameNewsReportViewModel.NewsKnightItemModel>
	{
		// Token: 0x06020C1B RID: 134171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1B")]
		[Address(RVA = "0x1B0BCD0", Offset = "0x1B0A8D0", VA = "0x181B0BCD0", Slot = "5")]
		protected override void DoRender(RL02EndingFrameNewsReportViewModel.NewsKnightItemModel model, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C1C RID: 134172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C1C")]
		[Address(RVA = "0x1B0BE50", Offset = "0x1B0AA50", VA = "0x181B0BE50")]
		public RL02ReportNewsKnightItemView()
		{
		}

		// Token: 0x0402C78E RID: 182158
		[Token(Token = "0x402C78E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalNum;

		// Token: 0x0402C78F RID: 182159
		[Token(Token = "0x402C78F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402C790 RID: 182160
		[Token(Token = "0x402C790")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

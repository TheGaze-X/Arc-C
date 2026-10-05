using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005754 RID: 22356
	[Token(Token = "0x2005754")]
	public class RL02ReportNewsGoldItemView : RL02ReportNewsItemView<RL02EndingFrameNewsReportViewModel.NewsGoldItemModel>
	{
		// Token: 0x06020C12 RID: 134162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C12")]
		[Address(RVA = "0x1B0B840", Offset = "0x1B0A440", VA = "0x181B0B840", Slot = "5")]
		protected override void DoRender(RL02EndingFrameNewsReportViewModel.NewsGoldItemModel model, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C13 RID: 134163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C13")]
		[Address(RVA = "0x1B0B9C0", Offset = "0x1B0A5C0", VA = "0x181B0B9C0")]
		public RL02ReportNewsGoldItemView()
		{
		}

		// Token: 0x0402C783 RID: 182147
		[Token(Token = "0x402C783")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalNum;

		// Token: 0x0402C784 RID: 182148
		[Token(Token = "0x402C784")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402C785 RID: 182149
		[Token(Token = "0x402C785")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

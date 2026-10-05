using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005755 RID: 22357
	[Token(Token = "0x2005755")]
	public class RL02ReportNewsHiddenItemView : RL02ReportNewsItemView<RL02EndingFrameNewsReportViewModel.NewsHiddenItemModel>
	{
		// Token: 0x06020C14 RID: 134164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C14")]
		[Address(RVA = "0x1B0BA30", Offset = "0x1B0A630", VA = "0x181B0BA30", Slot = "5")]
		protected override void DoRender(RL02EndingFrameNewsReportViewModel.NewsHiddenItemModel model, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C15 RID: 134165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C15")]
		[Address(RVA = "0x1B0BC00", Offset = "0x1B0A800", VA = "0x181B0BC00")]
		public RL02ReportNewsHiddenItemView()
		{
		}

		// Token: 0x0402C786 RID: 182150
		[Token(Token = "0x402C786")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _textNums;

		// Token: 0x0402C787 RID: 182151
		[Token(Token = "0x402C787")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402C788 RID: 182152
		[Token(Token = "0x402C788")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

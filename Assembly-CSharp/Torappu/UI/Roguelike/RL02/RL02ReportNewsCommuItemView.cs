using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005753 RID: 22355
	[Token(Token = "0x2005753")]
	public class RL02ReportNewsCommuItemView : RL02ReportNewsItemView<RL02EndingFrameNewsReportViewModel.NewsCommuItemModel>
	{
		// Token: 0x06020C10 RID: 134160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C10")]
		[Address(RVA = "0x1B0B660", Offset = "0x1B0A260", VA = "0x181B0B660", Slot = "5")]
		protected override void DoRender(RL02EndingFrameNewsReportViewModel.NewsCommuItemModel model, RL02EndingText textConfig)
		{
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C11")]
		[Address(RVA = "0x1B0B7D0", Offset = "0x1B0A3D0", VA = "0x181B0B7D0")]
		public RL02ReportNewsCommuItemView()
		{
		}

		// Token: 0x0402C780 RID: 182144
		[Token(Token = "0x402C780")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalNum;

		// Token: 0x0402C781 RID: 182145
		[Token(Token = "0x402C781")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402C782 RID: 182146
		[Token(Token = "0x402C782")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

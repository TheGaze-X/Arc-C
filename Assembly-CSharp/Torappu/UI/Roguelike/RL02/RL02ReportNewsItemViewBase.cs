using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005756 RID: 22358
	[Token(Token = "0x2005756")]
	public abstract class RL02ReportNewsItemViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020C16 RID: 134166
		[Token(Token = "0x6020C16")]
		public abstract void Render(RL02EndingFrameNewsReportViewModel.NewsItemModel itemModel, RL02EndingText textConfig);

		// Token: 0x06020C17 RID: 134167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C17")]
		[Address(RVA = "0x1B0BC70", Offset = "0x1B0A870", VA = "0x181B0BC70")]
		protected RL02ReportNewsItemViewBase()
		{
		}

		// Token: 0x0402C789 RID: 182153
		[Token(Token = "0x402C789")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Text _textDesc;

		// Token: 0x0402C78A RID: 182154
		[Token(Token = "0x402C78A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Text _textResult;

		// Token: 0x0402C78B RID: 182155
		[Token(Token = "0x402C78B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

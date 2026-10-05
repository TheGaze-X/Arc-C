using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C5 RID: 25541
	[Token(Token = "0x20063C5")]
	public class AutoChessCharSelectPoolView : CommonCharSelectPoolViewBase<AutoChessCharSelectPoolViewModel>
	{
		// Token: 0x06024D38 RID: 150840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D38")]
		[Address(RVA = "0x1FBACA0", Offset = "0x1FB98A0", VA = "0x181FBACA0", Slot = "8")]
		public override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x06024D39 RID: 150841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D39")]
		[Address(RVA = "0x1FBAF40", Offset = "0x1FB9B40", VA = "0x181FBAF40")]
		public AutoChessCharSelectPoolView()
		{
		}

		// Token: 0x040337C8 RID: 210888
		[Token(Token = "0x40337C8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _tipsText;

		// Token: 0x040337C9 RID: 210889
		[Token(Token = "0x40337C9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _infoText;

		// Token: 0x040337CA RID: 210890
		[Token(Token = "0x40337CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x040337CB RID: 210891
		[Token(Token = "0x40337CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

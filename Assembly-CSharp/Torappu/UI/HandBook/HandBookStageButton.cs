using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A4 RID: 26276
	[Token(Token = "0x20066A4")]
	public class HandBookStageButton : HandBookButtonTab
	{
		// Token: 0x06025BE9 RID: 154601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BE9")]
		[Address(RVA = "0x20B1C30", Offset = "0x20B0830", VA = "0x1820B1C30", Slot = "4")]
		public override void Render(HandBookInfoStateBean.HandBookInfoViewModel viewModel)
		{
		}

		// Token: 0x06025BEA RID: 154602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BEA")]
		[Address(RVA = "0x20B1DD0", Offset = "0x20B09D0", VA = "0x1820B1DD0")]
		public HandBookStageButton()
		{
		}

		// Token: 0x06025BEB RID: 154603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BEB")]
		[Address(RVA = "0x20B1DC0", Offset = "0x20B09C0", VA = "0x1820B1DC0")]
		private void <>xLuaBaseProxy_Render(HandBookInfoStateBean.HandBookInfoViewModel P0)
		{
		}

		// Token: 0x040350D1 RID: 217297
		[Token(Token = "0x40350D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040350D2 RID: 217298
		[Token(Token = "0x40350D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _activeClickButton;

		// Token: 0x040350D3 RID: 217299
		[Token(Token = "0x40350D3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lockedButton;

		// Token: 0x040350D4 RID: 217300
		[Token(Token = "0x40350D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040350D5 RID: 217301
		[Token(Token = "0x40350D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

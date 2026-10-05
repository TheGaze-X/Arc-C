using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006688 RID: 26248
	[Token(Token = "0x2006688")]
	public class HandBookAvgButton : HandBookButtonTab
	{
		// Token: 0x06025B2B RID: 154411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B2B")]
		[Address(RVA = "0x208D9B0", Offset = "0x208C5B0", VA = "0x18208D9B0", Slot = "4")]
		public override void Render(HandBookInfoStateBean.HandBookInfoViewModel viewModel)
		{
		}

		// Token: 0x06025B2C RID: 154412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B2C")]
		[Address(RVA = "0x208DB90", Offset = "0x208C790", VA = "0x18208DB90")]
		public HandBookAvgButton()
		{
		}

		// Token: 0x06025B2D RID: 154413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B2D")]
		[Address(RVA = "0x208DB30", Offset = "0x208C730", VA = "0x18208DB30")]
		private void <>xLuaBaseProxy_Render(HandBookInfoStateBean.HandBookInfoViewModel P0)
		{
		}

		// Token: 0x04034F50 RID: 216912
		[Token(Token = "0x4034F50")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04034F51 RID: 216913
		[Token(Token = "0x4034F51")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _activeClickButton;

		// Token: 0x04034F52 RID: 216914
		[Token(Token = "0x4034F52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034F53 RID: 216915
		[Token(Token = "0x4034F53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

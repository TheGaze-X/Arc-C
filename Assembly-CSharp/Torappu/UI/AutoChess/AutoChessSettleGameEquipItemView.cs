using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062EC RID: 25324
	[Token(Token = "0x20062EC")]
	public class AutoChessSettleGameEquipItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060247FF RID: 149503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FF")]
		[Address(RVA = "0x1F55A10", Offset = "0x1F54610", VA = "0x181F55A10")]
		public void Render(AutoChessSettleGamePersonalEquipItemViewModel model)
		{
		}

		// Token: 0x06024800 RID: 149504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024800")]
		[Address(RVA = "0x1F55C30", Offset = "0x1F54830", VA = "0x181F55C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024801 RID: 149505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024801")]
		[Address(RVA = "0x1F55CC0", Offset = "0x1F548C0", VA = "0x181F55CC0")]
		public AutoChessSettleGameEquipItemView()
		{
		}

		// Token: 0x04032DCC RID: 208332
		[Token(Token = "0x4032DCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _equipIconImage;

		// Token: 0x04032DCD RID: 208333
		[Token(Token = "0x4032DCD")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasInited;

		// Token: 0x04032DCE RID: 208334
		[Token(Token = "0x4032DCE")]
		[FieldOffset(Offset = "0x28")]
		private ILoadAsset m_loadAsset;

		// Token: 0x04032DCF RID: 208335
		[Token(Token = "0x4032DCF")]
		[FieldOffset(Offset = "0x30")]
		private string m_iconId;

		// Token: 0x04032DD0 RID: 208336
		[Token(Token = "0x4032DD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032DD1 RID: 208337
		[Token(Token = "0x4032DD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032DD2 RID: 208338
		[Token(Token = "0x4032DD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

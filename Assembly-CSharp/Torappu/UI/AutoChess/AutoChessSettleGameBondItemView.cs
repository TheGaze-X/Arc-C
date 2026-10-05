using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062EA RID: 25322
	[Token(Token = "0x20062EA")]
	public class AutoChessSettleGameBondItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060247FA RID: 149498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FA")]
		[Address(RVA = "0x1F55190", Offset = "0x1F53D90", VA = "0x181F55190")]
		public void Render(AutoChessSettleGamePersonalBondItemViewModel model)
		{
		}

		// Token: 0x060247FB RID: 149499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FB")]
		[Address(RVA = "0x1F55280", Offset = "0x1F53E80", VA = "0x181F55280")]
		public AutoChessSettleGameBondItemView()
		{
		}

		// Token: 0x04032DB5 RID: 208309
		[Token(Token = "0x4032DB5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04032DB6 RID: 208310
		[Token(Token = "0x4032DB6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLayerPart;

		// Token: 0x04032DB7 RID: 208311
		[Token(Token = "0x4032DB7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtLayer;

		// Token: 0x04032DB8 RID: 208312
		[Token(Token = "0x4032DB8")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032DB9 RID: 208313
		[Token(Token = "0x4032DB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032DBA RID: 208314
		[Token(Token = "0x4032DBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

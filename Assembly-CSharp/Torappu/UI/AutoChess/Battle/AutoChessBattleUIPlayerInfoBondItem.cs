using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064DB RID: 25819
	[Token(Token = "0x20064DB")]
	public class AutoChessBattleUIPlayerInfoBondItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025194 RID: 151956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025194")]
		[Address(RVA = "0x1FECCA0", Offset = "0x1FEB8A0", VA = "0x181FECCA0")]
		public void Render(AutoChessBannedBondItemModel model)
		{
		}

		// Token: 0x06025195 RID: 151957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025195")]
		[Address(RVA = "0x1FECE10", Offset = "0x1FEBA10", VA = "0x181FECE10")]
		public AutoChessBattleUIPlayerInfoBondItem()
		{
		}

		// Token: 0x04033FAD RID: 212909
		[Token(Token = "0x4033FAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBondIcon;

		// Token: 0x04033FAE RID: 212910
		[Token(Token = "0x4033FAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _absenseCharCntText;

		// Token: 0x04033FAF RID: 212911
		[Token(Token = "0x4033FAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _bondNameText;

		// Token: 0x04033FB0 RID: 212912
		[Token(Token = "0x4033FB0")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033FB1 RID: 212913
		[Token(Token = "0x4033FB1")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedBondIcon;

		// Token: 0x04033FB2 RID: 212914
		[Token(Token = "0x4033FB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033FB3 RID: 212915
		[Token(Token = "0x4033FB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

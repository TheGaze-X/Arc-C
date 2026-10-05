using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D3 RID: 25811
	[Token(Token = "0x20064D3")]
	public class AutoChessBattleUIBondIconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025172 RID: 151922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025172")]
		[Address(RVA = "0x1FE36C0", Offset = "0x1FE22C0", VA = "0x181FE36C0")]
		public void Render(AutoChessBondItemModel itemModel)
		{
		}

		// Token: 0x06025173 RID: 151923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025173")]
		[Address(RVA = "0x1FE3860", Offset = "0x1FE2460", VA = "0x181FE3860")]
		public AutoChessBattleUIBondIconView()
		{
		}

		// Token: 0x04033F46 RID: 212806
		[Token(Token = "0x4033F46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgBondIcon;

		// Token: 0x04033F47 RID: 212807
		[Token(Token = "0x4033F47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBoard;

		// Token: 0x04033F48 RID: 212808
		[Token(Token = "0x4033F48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _inactiveIconColor;

		// Token: 0x04033F49 RID: 212809
		[Token(Token = "0x4033F49")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _activeIconColor;

		// Token: 0x04033F4A RID: 212810
		[Token(Token = "0x4033F4A")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033F4B RID: 212811
		[Token(Token = "0x4033F4B")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedBondIcon;

		// Token: 0x04033F4C RID: 212812
		[Token(Token = "0x4033F4C")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedReqCnt;

		// Token: 0x04033F4D RID: 212813
		[Token(Token = "0x4033F4D")]
		[FieldOffset(Offset = "0x64")]
		private int m_cachedActiveCnt;

		// Token: 0x04033F4E RID: 212814
		[Token(Token = "0x4033F4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033F4F RID: 212815
		[Token(Token = "0x4033F4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

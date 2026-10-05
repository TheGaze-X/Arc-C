using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007111 RID: 28945
	[Token(Token = "0x2007111")]
	public class ActAutoChessHandbookBandItemView : ActAutoChessHandbookItemBaseView<ActAutoChessHandbookBandViewModel>
	{
		// Token: 0x06029203 RID: 168451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029203")]
		[Address(RVA = "0x2482690", Offset = "0x2481290", VA = "0x182482690", Slot = "4")]
		public override void OnRender(ActAutoChessHandbookBandViewModel model)
		{
		}

		// Token: 0x06029204 RID: 168452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029204")]
		[Address(RVA = "0x24827F0", Offset = "0x24813F0", VA = "0x1824827F0")]
		public ActAutoChessHandbookBandItemView()
		{
		}

		// Token: 0x0403AB90 RID: 240528
		[Token(Token = "0x403AB90")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelVictor;

		// Token: 0x0403AB91 RID: 240529
		[Token(Token = "0x403AB91")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403AB92 RID: 240530
		[Token(Token = "0x403AB92")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403AB93 RID: 240531
		[Token(Token = "0x403AB93")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403AB94 RID: 240532
		[Token(Token = "0x403AB94")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelBanned;

		// Token: 0x0403AB95 RID: 240533
		[Token(Token = "0x403AB95")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403AB96 RID: 240534
		[Token(Token = "0x403AB96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403AB97 RID: 240535
		[Token(Token = "0x403AB97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

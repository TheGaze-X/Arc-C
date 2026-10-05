using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007119 RID: 28953
	[Token(Token = "0x2007119")]
	public class ActAutoChessHandbookBondItemView : ActAutoChessHandbookItemBaseView<ActAutoChessHandbookBondViewModel>
	{
		// Token: 0x06029216 RID: 168470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029216")]
		[Address(RVA = "0x2483450", Offset = "0x2482050", VA = "0x182483450", Slot = "4")]
		public override void OnRender(ActAutoChessHandbookBondViewModel model)
		{
		}

		// Token: 0x06029217 RID: 168471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029217")]
		[Address(RVA = "0x2483500", Offset = "0x2482100", VA = "0x182483500")]
		public ActAutoChessHandbookBondItemView()
		{
		}

		// Token: 0x0403ABBD RID: 240573
		[Token(Token = "0x403ABBD")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403ABBE RID: 240574
		[Token(Token = "0x403ABBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403ABBF RID: 240575
		[Token(Token = "0x403ABBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

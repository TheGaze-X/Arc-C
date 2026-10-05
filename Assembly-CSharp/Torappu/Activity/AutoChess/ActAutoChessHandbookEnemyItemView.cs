using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007125 RID: 28965
	[Token(Token = "0x2007125")]
	public class ActAutoChessHandbookEnemyItemView : ActAutoChessHandbookItemBaseView<ActAutoChessHandbookEnemyViewModel>
	{
		// Token: 0x06029235 RID: 168501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029235")]
		[Address(RVA = "0x2484EA0", Offset = "0x2483AA0", VA = "0x182484EA0", Slot = "4")]
		public override void OnRender(ActAutoChessHandbookEnemyViewModel model)
		{
		}

		// Token: 0x06029236 RID: 168502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029236")]
		[Address(RVA = "0x2484F60", Offset = "0x2483B60", VA = "0x182484F60")]
		public ActAutoChessHandbookEnemyItemView()
		{
		}

		// Token: 0x0403ABF4 RID: 240628
		[Token(Token = "0x403ABF4")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403ABF5 RID: 240629
		[Token(Token = "0x403ABF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403ABF6 RID: 240630
		[Token(Token = "0x403ABF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

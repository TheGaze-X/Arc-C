using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200639E RID: 25502
	[Token(Token = "0x200639E")]
	public class AutoChessStageInfoEnemyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024C63 RID: 150627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C63")]
		[Address(RVA = "0x1FA79D0", Offset = "0x1FA65D0", VA = "0x181FA79D0")]
		public void Render(AutoChessStageInfoEnemyTypeViewModel model)
		{
		}

		// Token: 0x06024C64 RID: 150628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C64")]
		[Address(RVA = "0x1FA7AD0", Offset = "0x1FA66D0", VA = "0x181FA7AD0")]
		public AutoChessStageInfoEnemyItemView()
		{
		}

		// Token: 0x0403363A RID: 210490
		[Token(Token = "0x403363A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403363B RID: 210491
		[Token(Token = "0x403363B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403363C RID: 210492
		[Token(Token = "0x403363C")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403363D RID: 210493
		[Token(Token = "0x403363D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403363E RID: 210494
		[Token(Token = "0x403363E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

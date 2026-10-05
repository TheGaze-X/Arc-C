using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF8 RID: 28664
	[Token(Token = "0x2006FF8")]
	public class ActMultiV3StageListModeTitleItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B2D RID: 166701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B2D")]
		[Address(RVA = "0x2410690", Offset = "0x240F290", VA = "0x182410690")]
		public void Render(ActMultiV3StageModeGroupTitleViewModel titleViewModel, int idx, int count)
		{
		}

		// Token: 0x06028B2E RID: 166702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B2E")]
		[Address(RVA = "0x24107C0", Offset = "0x240F3C0", VA = "0x1824107C0")]
		public ActMultiV3StageListModeTitleItemView()
		{
		}

		// Token: 0x0403A017 RID: 237591
		[Token(Token = "0x403A017")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgMode;

		// Token: 0x0403A018 RID: 237592
		[Token(Token = "0x403A018")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textModeName;

		// Token: 0x0403A019 RID: 237593
		[Token(Token = "0x403A019")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlSeperator;

		// Token: 0x0403A01A RID: 237594
		[Token(Token = "0x403A01A")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A01B RID: 237595
		[Token(Token = "0x403A01B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A01C RID: 237596
		[Token(Token = "0x403A01C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

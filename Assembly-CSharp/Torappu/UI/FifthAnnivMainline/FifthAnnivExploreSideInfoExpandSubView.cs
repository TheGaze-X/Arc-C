using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F0C RID: 20236
	[Token(Token = "0x2004F0C")]
	public class FifthAnnivExploreSideInfoExpandSubView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E29B RID: 123547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E29B")]
		[Address(RVA = "0x17D75B0", Offset = "0x17D61B0", VA = "0x1817D75B0")]
		public void Render(FifthAnnivExploreViewModel viewModel)
		{
		}

		// Token: 0x0601E29C RID: 123548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E29C")]
		[Address(RVA = "0x17D73A0", Offset = "0x17D5FA0", VA = "0x1817D73A0")]
		public void OnForwardBtnClick()
		{
		}

		// Token: 0x0601E29D RID: 123549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E29D")]
		[Address(RVA = "0x17D7510", Offset = "0x17D6110", VA = "0x1817D7510")]
		public void OnTargetBtnClick()
		{
		}

		// Token: 0x0601E29E RID: 123550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E29E")]
		[Address(RVA = "0x17D7810", Offset = "0x17D6410", VA = "0x1817D7810")]
		public FifthAnnivExploreSideInfoExpandSubView()
		{
		}

		// Token: 0x0402826B RID: 164459
		[Token(Token = "0x402826B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _teamNameText;

		// Token: 0x0402826C RID: 164460
		[Token(Token = "0x402826C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _teamCodeText;

		// Token: 0x0402826D RID: 164461
		[Token(Token = "0x402826D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _teamDescText;

		// Token: 0x0402826E RID: 164462
		[Token(Token = "0x402826E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _teamIcon;

		// Token: 0x0402826F RID: 164463
		[Token(Token = "0x402826F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FifthAnnivExploreValueGroupView _valueGroupView;

		// Token: 0x04028270 RID: 164464
		[Token(Token = "0x4028270")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _forwardBtnCheckSucc;

		// Token: 0x04028271 RID: 164465
		[Token(Token = "0x4028271")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _forwardBtnCheckFail;

		// Token: 0x04028272 RID: 164466
		[Token(Token = "0x4028272")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _normalBtnText;

		// Token: 0x04028273 RID: 164467
		[Token(Token = "0x4028273")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _checkPointBtnText;

		// Token: 0x04028274 RID: 164468
		[Token(Token = "0x4028274")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _forwardBtn;

		// Token: 0x04028275 RID: 164469
		[Token(Token = "0x4028275")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasObject _groupIconAtlasObject;

		// Token: 0x04028276 RID: 164470
		[Token(Token = "0x4028276")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028277 RID: 164471
		[Token(Token = "0x4028277")]
		[FieldOffset(Offset = "0x80")]
		private FifthAnnivExploreSideInfoViewModel m_cachedViewModel;

		// Token: 0x04028278 RID: 164472
		[Token(Token = "0x4028278")]
		[FieldOffset(Offset = "0x88")]
		private FifthAnnivExploreValueGroupViewModel m_cachedPrevValueGroupViewModel;

		// Token: 0x04028279 RID: 164473
		[Token(Token = "0x4028279")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402827A RID: 164474
		[Token(Token = "0x402827A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnForwardBtnClick;

		// Token: 0x0402827B RID: 164475
		[Token(Token = "0x402827B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTargetBtnClick;

		// Token: 0x0402827C RID: 164476
		[Token(Token = "0x402827C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

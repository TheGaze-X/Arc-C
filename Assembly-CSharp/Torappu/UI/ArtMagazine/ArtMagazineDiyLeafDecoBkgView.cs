using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200654D RID: 25933
	[Token(Token = "0x200654D")]
	public class ArtMagazineDiyLeafDecoBkgView : ArtMagazineLeafDecoBkgViewBase
	{
		// Token: 0x0602548E RID: 152718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602548E")]
		[Address(RVA = "0x204B4B0", Offset = "0x204A0B0", VA = "0x18204B4B0", Slot = "4")]
		public override void Render(ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x0602548F RID: 152719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602548F")]
		[Address(RVA = "0x204B410", Offset = "0x204A010", VA = "0x18204B410")]
		public void OnClick()
		{
		}

		// Token: 0x06025490 RID: 152720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025490")]
		[Address(RVA = "0x204B650", Offset = "0x204A250", VA = "0x18204B650")]
		public ArtMagazineDiyLeafDecoBkgView()
		{
		}

		// Token: 0x040344FC RID: 214268
		[Token(Token = "0x40344FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040344FD RID: 214269
		[Token(Token = "0x40344FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dragAndPinchView;

		// Token: 0x040344FE RID: 214270
		[Token(Token = "0x40344FE")]
		[FieldOffset(Offset = "0x28")]
		private bool m_cachedLeafElementInteractable;

		// Token: 0x040344FF RID: 214271
		[Token(Token = "0x40344FF")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034500 RID: 214272
		[Token(Token = "0x4034500")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedEditingUpdateSeqNum;

		// Token: 0x04034501 RID: 214273
		[Token(Token = "0x4034501")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034502 RID: 214274
		[Token(Token = "0x4034502")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034503 RID: 214275
		[Token(Token = "0x4034503")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

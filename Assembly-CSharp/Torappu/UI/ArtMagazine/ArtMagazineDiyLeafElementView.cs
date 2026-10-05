using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006552 RID: 25938
	[Token(Token = "0x2006552")]
	public class ArtMagazineDiyLeafElementView : ArtMagazineLeafElementViewBase
	{
		// Token: 0x17005814 RID: 22548
		// (get) Token: 0x060254B9 RID: 152761 RVA: 0x000C7650 File Offset: 0x000C5850
		// (set) Token: 0x060254BA RID: 152762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005814")]
		public bool isTouching
		{
			[Token(Token = "0x60254B9")]
			[Address(RVA = "0x204E010", Offset = "0x204CC10", VA = "0x18204E010")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60254BA")]
			[Address(RVA = "0x204E070", Offset = "0x204CC70", VA = "0x18204E070")]
			set
			{
			}
		}

		// Token: 0x060254BB RID: 152763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254BB")]
		[Address(RVA = "0x204DD80", Offset = "0x204C980", VA = "0x18204DD80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060254BC RID: 152764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254BC")]
		[Address(RVA = "0x204DEE0", Offset = "0x204CAE0", VA = "0x18204DEE0")]
		private void _UpdateTouchingStatus()
		{
		}

		// Token: 0x060254BD RID: 152765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254BD")]
		[Address(RVA = "0x204D690", Offset = "0x204C290", VA = "0x18204D690", Slot = "6")]
		protected override void OnScaleChanged()
		{
		}

		// Token: 0x060254BE RID: 152766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254BE")]
		[Address(RVA = "0x204D950", Offset = "0x204C550", VA = "0x18204D950", Slot = "7")]
		protected override void Render(ArtMagazineLeafElementViewModel elementViewModel, ArtMagazineLeafViewModelBase leafViewModel)
		{
		}

		// Token: 0x060254BF RID: 152767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254BF")]
		[Address(RVA = "0x204D430", Offset = "0x204C030", VA = "0x18204D430")]
		public void OnClick()
		{
		}

		// Token: 0x060254C0 RID: 152768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C0")]
		[Address(RVA = "0x204D810", Offset = "0x204C410", VA = "0x18204D810")]
		public void OnSwitchClick()
		{
		}

		// Token: 0x060254C1 RID: 152769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C1")]
		[Address(RVA = "0x204D560", Offset = "0x204C160", VA = "0x18204D560")]
		public void OnDeleteClick()
		{
		}

		// Token: 0x060254C2 RID: 152770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C2")]
		[Address(RVA = "0x204DFB0", Offset = "0x204CBB0", VA = "0x18204DFB0")]
		public ArtMagazineDiyLeafElementView()
		{
		}

		// Token: 0x060254C3 RID: 152771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C3")]
		[Address(RVA = "0x204DD60", Offset = "0x204C960", VA = "0x18204DD60")]
		private void <>xLuaBaseProxy_OnScaleChanged()
		{
		}

		// Token: 0x060254C4 RID: 152772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60254C4")]
		[Address(RVA = "0x204DD70", Offset = "0x204C970", VA = "0x18204DD70")]
		private void <>xLuaBaseProxy_Render(ArtMagazineLeafElementViewModel P0, ArtMagazineLeafViewModelBase P1)
		{
		}

		// Token: 0x04034536 RID: 214326
		[Token(Token = "0x4034536")]
		private const string TEXT_LEAF_TYPE_FORMAT = "//.{0}";

		// Token: 0x04034537 RID: 214327
		[Token(Token = "0x4034537")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasRoot;

		// Token: 0x04034538 RID: 214328
		[Token(Token = "0x4034538")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasEditing;

		// Token: 0x04034539 RID: 214329
		[Token(Token = "0x4034539")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textLeafType;

		// Token: 0x0403453A RID: 214330
		[Token(Token = "0x403453A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textLeafTypeDuringTouch;

		// Token: 0x0403453B RID: 214331
		[Token(Token = "0x403453B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _pnlTag;

		// Token: 0x0403453C RID: 214332
		[Token(Token = "0x403453C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlDelete;

		// Token: 0x0403453D RID: 214333
		[Token(Token = "0x403453D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _pnlSwitch;

		// Token: 0x0403453E RID: 214334
		[Token(Token = "0x403453E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasBtns;

		// Token: 0x0403453F RID: 214335
		[Token(Token = "0x403453F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ArtMagazineDiyLeafDragAndPinchView _dragAndPinchView;

		// Token: 0x04034540 RID: 214336
		[Token(Token = "0x4034540")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _pnlEditing;

		// Token: 0x04034541 RID: 214337
		[Token(Token = "0x4034541")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _pnlEditingDuringTouch;

		// Token: 0x04034542 RID: 214338
		[Token(Token = "0x4034542")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedLeafElementInteractable;

		// Token: 0x04034543 RID: 214339
		[Token(Token = "0x4034543")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_cachedCanSwitch;

		// Token: 0x04034544 RID: 214340
		[Token(Token = "0x4034544")]
		[FieldOffset(Offset = "0xC2")]
		private bool m_cachedEditing;

		// Token: 0x04034545 RID: 214341
		[Token(Token = "0x4034545")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034546 RID: 214342
		[Token(Token = "0x4034546")]
		[FieldOffset(Offset = "0xD8")]
		private UISwitchTween m_editingTween;

		// Token: 0x04034547 RID: 214343
		[Token(Token = "0x4034547")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween m_btnShowTween;

		// Token: 0x04034548 RID: 214344
		[Token(Token = "0x4034548")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_inited;

		// Token: 0x04034549 RID: 214345
		[Token(Token = "0x4034549")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_isTouching;

		// Token: 0x0403454A RID: 214346
		[Token(Token = "0x403454A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTouching;

		// Token: 0x0403454B RID: 214347
		[Token(Token = "0x403454B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isTouching;

		// Token: 0x0403454C RID: 214348
		[Token(Token = "0x403454C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403454D RID: 214349
		[Token(Token = "0x403454D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateTouchingStatus;

		// Token: 0x0403454E RID: 214350
		[Token(Token = "0x403454E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnScaleChanged;

		// Token: 0x0403454F RID: 214351
		[Token(Token = "0x403454F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04034550 RID: 214352
		[Token(Token = "0x4034550")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04034551 RID: 214353
		[Token(Token = "0x4034551")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSwitchClick;

		// Token: 0x04034552 RID: 214354
		[Token(Token = "0x4034552")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDeleteClick;

		// Token: 0x04034553 RID: 214355
		[Token(Token = "0x4034553")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

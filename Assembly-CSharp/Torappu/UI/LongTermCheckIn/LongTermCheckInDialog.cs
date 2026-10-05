using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049B7 RID: 18871
	[Token(Token = "0x20049B7")]
	public class LongTermCheckInDialog : LongTermCheckInDialogBase, IHotfixable
	{
		// Token: 0x0601C6ED RID: 116461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6ED")]
		[Address(RVA = "0x15E3B70", Offset = "0x15E2770", VA = "0x1815E3B70", Slot = "19")]
		protected override void Init()
		{
		}

		// Token: 0x0601C6EE RID: 116462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6EE")]
		[Address(RVA = "0x15E3C90", Offset = "0x15E2890", VA = "0x1815E3C90", Slot = "18")]
		protected override void OnRender(object obj)
		{
		}

		// Token: 0x0601C6EF RID: 116463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6EF")]
		[Address(RVA = "0x15E3790", Offset = "0x15E2390", VA = "0x1815E3790", Slot = "20")]
		protected override void EventOnBackPressed()
		{
		}

		// Token: 0x0601C6F0 RID: 116464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F0")]
		[Address(RVA = "0x15E36D0", Offset = "0x15E22D0", VA = "0x1815E36D0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601C6F1 RID: 116465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F1")]
		[Address(RVA = "0x15E3990", Offset = "0x15E2590", VA = "0x1815E3990")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x0601C6F2 RID: 116466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F2")]
		[Address(RVA = "0x15E3A80", Offset = "0x15E2680", VA = "0x1815E3A80")]
		public void EventOnPrevBtnClicked()
		{
		}

		// Token: 0x0601C6F3 RID: 116467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F3")]
		[Address(RVA = "0x15E3880", Offset = "0x15E2480", VA = "0x1815E3880")]
		public void EventOnDetailBtnClicked()
		{
		}

		// Token: 0x0601C6F4 RID: 116468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F4")]
		[Address(RVA = "0x15E3F40", Offset = "0x15E2B40", VA = "0x1815E3F40")]
		private void _RenderGroup()
		{
		}

		// Token: 0x0601C6F5 RID: 116469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F5")]
		[Address(RVA = "0x15E3DA0", Offset = "0x15E29A0", VA = "0x1815E3DA0")]
		private void _GenerateSwitchAnim(UIAnimationLocation hideAnim, UIAnimationLocation showAnim)
		{
		}

		// Token: 0x0601C6F6 RID: 116470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6F6")]
		[Address(RVA = "0x15E4070", Offset = "0x15E2C70", VA = "0x1815E4070")]
		public LongTermCheckInDialog()
		{
		}

		// Token: 0x040253F6 RID: 152566
		[Token(Token = "0x40253F6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelLeftBtn;

		// Token: 0x040253F7 RID: 152567
		[Token(Token = "0x40253F7")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelRightBtn;

		// Token: 0x040253F8 RID: 152568
		[Token(Token = "0x40253F8")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private SimpleLayoutContent _bottomContent;

		// Token: 0x040253F9 RID: 152569
		[Token(Token = "0x40253F9")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _rightHideAnim;

		// Token: 0x040253FA RID: 152570
		[Token(Token = "0x40253FA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAnimationLocation _rightShowAnim;

		// Token: 0x040253FB RID: 152571
		[Token(Token = "0x40253FB")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIAnimationLocation _leftHideAnim;

		// Token: 0x040253FC RID: 152572
		[Token(Token = "0x40253FC")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _leftShowAnim;

		// Token: 0x040253FD RID: 152573
		[Token(Token = "0x40253FD")]
		[FieldOffset(Offset = "0x108")]
		private LongTermCheckInViewModel m_viewModel;

		// Token: 0x040253FE RID: 152574
		[Token(Token = "0x40253FE")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_tween;

		// Token: 0x040253FF RID: 152575
		[Token(Token = "0x40253FF")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04025400 RID: 152576
		[Token(Token = "0x4025400")]
		[FieldOffset(Offset = "0x128")]
		private LongTermCheckInDialog.Adapter m_adapter;

		// Token: 0x04025401 RID: 152577
		[Token(Token = "0x4025401")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04025402 RID: 152578
		[Token(Token = "0x4025402")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025403 RID: 152579
		[Token(Token = "0x4025403")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackPressed;

		// Token: 0x04025404 RID: 152580
		[Token(Token = "0x4025404")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04025405 RID: 152581
		[Token(Token = "0x4025405")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x04025406 RID: 152582
		[Token(Token = "0x4025406")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClicked;

		// Token: 0x04025407 RID: 152583
		[Token(Token = "0x4025407")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnDetailBtnClicked;

		// Token: 0x04025408 RID: 152584
		[Token(Token = "0x4025408")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderGroup;

		// Token: 0x04025409 RID: 152585
		[Token(Token = "0x4025409")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateSwitchAnim;

		// Token: 0x0402540A RID: 152586
		[Token(Token = "0x402540A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049B8 RID: 18872
		[Token(Token = "0x20049B8")]
		public class Input
		{
			// Token: 0x0601C6F7 RID: 116471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6F7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402540B RID: 152587
			[Token(Token = "0x402540B")]
			[FieldOffset(Offset = "0x10")]
			public bool showLastGroup;
		}

		// Token: 0x020049B9 RID: 18873
		[Token(Token = "0x20049B9")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601C6F8 RID: 116472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6F8")]
			[Address(RVA = "0x15DC900", Offset = "0x15DB500", VA = "0x1815DC900")]
			public Adapter(LongTermCheckInDialog closure)
			{
			}

			// Token: 0x17004359 RID: 17241
			// (get) Token: 0x0601C6F9 RID: 116473 RVA: 0x000A8678 File Offset: 0x000A6878
			[Token(Token = "0x17004359")]
			public override int count
			{
				[Token(Token = "0x601C6F9")]
				[Address(RVA = "0x15DC980", Offset = "0x15DB580", VA = "0x1815DC980", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C6FA RID: 116474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C6FA")]
			[Address(RVA = "0x15DC6D0", Offset = "0x15DB2D0", VA = "0x1815DC6D0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402540C RID: 152588
			[Token(Token = "0x402540C")]
			[FieldOffset(Offset = "0x20")]
			private LongTermCheckInDialog m_closure;

			// Token: 0x0402540D RID: 152589
			[Token(Token = "0x402540D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402540E RID: 152590
			[Token(Token = "0x402540E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402540F RID: 152591
			[Token(Token = "0x402540F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

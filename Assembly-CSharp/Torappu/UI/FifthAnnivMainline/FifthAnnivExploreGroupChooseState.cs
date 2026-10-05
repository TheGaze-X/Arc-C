using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EC1 RID: 20161
	[Token(Token = "0x2004EC1")]
	public class FifthAnnivExploreGroupChooseState : PopupFadeState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601E15B RID: 123227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E15B")]
		[Address(RVA = "0x17BCA20", Offset = "0x17BB620", VA = "0x1817BCA20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E15C RID: 123228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E15C")]
		[Address(RVA = "0x17BCCE0", Offset = "0x17BB8E0", VA = "0x1817BCCE0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E15D RID: 123229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E15D")]
		[Address(RVA = "0x17BCC70", Offset = "0x17BB870", VA = "0x1817BCC70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E15E RID: 123230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E15E")]
		[Address(RVA = "0x17BCB40", Offset = "0x17BB740", VA = "0x1817BCB40")]
		public void OnConfirmBtnClick()
		{
		}

		// Token: 0x0601E15F RID: 123231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E15F")]
		[Address(RVA = "0x17BCEB0", Offset = "0x17BBAB0", VA = "0x1817BCEB0")]
		public void SetSelectHeritage(bool select)
		{
		}

		// Token: 0x0601E160 RID: 123232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E160")]
		[Address(RVA = "0x17BCA90", Offset = "0x17BB690", VA = "0x1817BCA90", Slot = "32")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601E161 RID: 123233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E161")]
		[Address(RVA = "0x17BD0A0", Offset = "0x17BBCA0", VA = "0x1817BD0A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E162 RID: 123234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E162")]
		[Address(RVA = "0x17BD6D0", Offset = "0x17BC2D0", VA = "0x1817BD6D0")]
		private void _OnSelectGroup(int position)
		{
		}

		// Token: 0x0601E163 RID: 123235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E163")]
		[Address(RVA = "0x17BD2D0", Offset = "0x17BBED0", VA = "0x1817BD2D0")]
		private void _OnConfirmGroupChoose()
		{
		}

		// Token: 0x0601E164 RID: 123236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E164")]
		[Address(RVA = "0x17BD7E0", Offset = "0x17BC3E0", VA = "0x1817BD7E0")]
		private void _OpenConfirmDialog()
		{
		}

		// Token: 0x0601E165 RID: 123237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E165")]
		[Address(RVA = "0x17BD9D0", Offset = "0x17BC5D0", VA = "0x1817BD9D0")]
		public FifthAnnivExploreGroupChooseState()
		{
		}

		// Token: 0x0601E167 RID: 123239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E167")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04028049 RID: 163913
		[Token(Token = "0x4028049")]
		public const int SELECT_GROUP = 0;

		// Token: 0x0402804A RID: 163914
		[Token(Token = "0x402804A")]
		public const int DIALOG_CONFIRM = 1;

		// Token: 0x0402804B RID: 163915
		[Token(Token = "0x402804B")]
		public const int DIALOG_CANCEL = 2;

		// Token: 0x0402804C RID: 163916
		[Token(Token = "0x402804C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FifthAnnivExploreGroupChooseView _view;

		// Token: 0x0402804D RID: 163917
		[Token(Token = "0x402804D")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402804E RID: 163918
		[Token(Token = "0x402804E")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402804F RID: 163919
		[Token(Token = "0x402804F")]
		[FieldOffset(Offset = "0x90")]
		private int m_confirmDialogInst;

		// Token: 0x04028050 RID: 163920
		[Token(Token = "0x4028050")]
		[FieldOffset(Offset = "0x98")]
		private FifthAnnivExploreGroupChooseStateBean m_stateBean;

		// Token: 0x04028051 RID: 163921
		[Token(Token = "0x4028051")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028052 RID: 163922
		[Token(Token = "0x4028052")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028053 RID: 163923
		[Token(Token = "0x4028053")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028054 RID: 163924
		[Token(Token = "0x4028054")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmBtnClick;

		// Token: 0x04028055 RID: 163925
		[Token(Token = "0x4028055")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSelectHeritage;

		// Token: 0x04028056 RID: 163926
		[Token(Token = "0x4028056")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04028057 RID: 163927
		[Token(Token = "0x4028057")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028058 RID: 163928
		[Token(Token = "0x4028058")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSelectGroup;

		// Token: 0x04028059 RID: 163929
		[Token(Token = "0x4028059")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnConfirmGroupChoose;

		// Token: 0x0402805A RID: 163930
		[Token(Token = "0x402805A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenConfirmDialog;

		// Token: 0x0402805B RID: 163931
		[Token(Token = "0x402805B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

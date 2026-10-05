using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005647 RID: 22087
	[Token(Token = "0x2005647")]
	public class RL05SubTransDrawCopperController : RoguelikeTransitionView.SubTransitionBase<RoguelikeDrawCopperViewModel>
	{
		// Token: 0x06020665 RID: 132709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020665")]
		[Address(RVA = "0x1A88710", Offset = "0x1A87310", VA = "0x181A88710", Slot = "9")]
		protected override RoguelikeDrawCopperViewModel GetParam(RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x06020666 RID: 132710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020666")]
		[Address(RVA = "0x1A88C00", Offset = "0x1A87800", VA = "0x181A88C00", Slot = "10")]
		protected override void SetParam(RoguelikeDrawCopperViewModel param)
		{
		}

		// Token: 0x06020667 RID: 132711 RVA: 0x000B5BD8 File Offset: 0x000B3DD8
		[Token(Token = "0x6020667")]
		[Address(RVA = "0x1A88970", Offset = "0x1A87570", VA = "0x181A88970", Slot = "11")]
		public override RoguelikeTransitionView.SubTransType GetTransType()
		{
			return RoguelikeTransitionView.SubTransType.NONE;
		}

		// Token: 0x06020668 RID: 132712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020668")]
		[Address(RVA = "0x1A889D0", Offset = "0x1A875D0", VA = "0x181A889D0", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06020669 RID: 132713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020669")]
		[Address(RVA = "0x1A88C80", Offset = "0x1A87880", VA = "0x181A88C80", Slot = "12")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602066A RID: 132714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602066A")]
		[Address(RVA = "0x1A88D50", Offset = "0x1A87950", VA = "0x181A88D50")]
		private void _OnConfirmRedrawPending()
		{
		}

		// Token: 0x0602066B RID: 132715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602066B")]
		[Address(RVA = "0x1A89010", Offset = "0x1A87C10", VA = "0x181A89010")]
		private void _OnCopperExchangeDetailClicked()
		{
		}

		// Token: 0x0602066C RID: 132716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602066C")]
		[Address(RVA = "0x1A89210", Offset = "0x1A87E10", VA = "0x181A89210")]
		public RL05SubTransDrawCopperController()
		{
		}

		// Token: 0x0402BDD7 RID: 179671
		[Token(Token = "0x402BDD7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RL05RedrawCopperView _redrawCopperViewPrefab;

		// Token: 0x0402BDD8 RID: 179672
		[Token(Token = "0x402BDD8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _redrawCopperViewContainer;

		// Token: 0x0402BDD9 RID: 179673
		[Token(Token = "0x402BDD9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _redrawCanvasGroup;

		// Token: 0x0402BDDA RID: 179674
		[Token(Token = "0x402BDDA")]
		[FieldOffset(Offset = "0x30")]
		private RL05RedrawCopperView m_redrawCopperView;

		// Token: 0x0402BDDB RID: 179675
		[Token(Token = "0x402BDDB")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0402BDDC RID: 179676
		[Token(Token = "0x402BDDC")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402BDDD RID: 179677
		[Token(Token = "0x402BDDD")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BDDE RID: 179678
		[Token(Token = "0x402BDDE")]
		[FieldOffset(Offset = "0x60")]
		private bool m_unconfirmed;

		// Token: 0x0402BDDF RID: 179679
		[Token(Token = "0x402BDDF")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0402BDE0 RID: 179680
		[Token(Token = "0x402BDE0")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeDrawCopperViewModel m_cachedModel;

		// Token: 0x0402BDE1 RID: 179681
		[Token(Token = "0x402BDE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0402BDE2 RID: 179682
		[Token(Token = "0x402BDE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0402BDE3 RID: 179683
		[Token(Token = "0x402BDE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTransType;

		// Token: 0x0402BDE4 RID: 179684
		[Token(Token = "0x402BDE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402BDE5 RID: 179685
		[Token(Token = "0x402BDE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402BDE6 RID: 179686
		[Token(Token = "0x402BDE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnConfirmRedrawPending;

		// Token: 0x0402BDE7 RID: 179687
		[Token(Token = "0x402BDE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCopperExchangeDetailClicked;

		// Token: 0x0402BDE8 RID: 179688
		[Token(Token = "0x402BDE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

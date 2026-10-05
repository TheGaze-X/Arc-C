using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C6D RID: 27757
	[Token(Token = "0x2006C6D")]
	public class ActArchiveEntryState : PopupFloatState
	{
		// Token: 0x060279E1 RID: 162273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E1")]
		[Address(RVA = "0x22BF340", Offset = "0x22BDF40", VA = "0x1822BF340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060279E2 RID: 162274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E2")]
		[Address(RVA = "0x22BEE00", Offset = "0x22BDA00", VA = "0x1822BEE00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060279E3 RID: 162275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279E3")]
		[Address(RVA = "0x22BEB50", Offset = "0x22BD750", VA = "0x1822BEB50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060279E4 RID: 162276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E4")]
		[Address(RVA = "0x22BF000", Offset = "0x22BDC00", VA = "0x1822BF000")]
		public void PageOnlyNotifyBeforePageHide(bool isPageIntoStack)
		{
		}

		// Token: 0x060279E5 RID: 162277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279E5")]
		[Address(RVA = "0x22BF090", Offset = "0x22BDC90", VA = "0x1822BF090", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060279E6 RID: 162278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279E6")]
		[Address(RVA = "0x22BEBB0", Offset = "0x22BD7B0", VA = "0x1822BEBB0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x060279E7 RID: 162279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E7")]
		[Address(RVA = "0x22BF1D0", Offset = "0x22BDDD0", VA = "0x1822BF1D0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060279E8 RID: 162280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E8")]
		[Address(RVA = "0x22BECF0", Offset = "0x22BD8F0", VA = "0x1822BECF0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060279E9 RID: 162281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279E9")]
		[Address(RVA = "0x22BF490", Offset = "0x22BE090", VA = "0x1822BF490")]
		public ActArchiveEntryState()
		{
		}

		// Token: 0x060279EB RID: 162283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279EB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060279EC RID: 162284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279EC")]
		[Address(RVA = "0x15A41D0", Offset = "0x15A2DD0", VA = "0x1815A41D0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x060279ED RID: 162285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279ED")]
		[Address(RVA = "0x15A4170", Offset = "0x15A2D70", VA = "0x1815A4170")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x060279EE RID: 162286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279EE")]
		[Address(RVA = "0x15A4200", Offset = "0x15A2E00", VA = "0x1815A4200")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x060279EF RID: 162287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279EF")]
		[Address(RVA = "0x15A41A0", Offset = "0x15A2DA0", VA = "0x1815A41A0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0403830A RID: 230154
		[Token(Token = "0x403830A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvas;

		// Token: 0x0403830B RID: 230155
		[Token(Token = "0x403830B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x0403830C RID: 230156
		[Token(Token = "0x403830C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActArchiveStateBean _stateBean;

		// Token: 0x0403830D RID: 230157
		[Token(Token = "0x403830D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ActArchiveCompDataBinder _compBinder;

		// Token: 0x0403830E RID: 230158
		[Token(Token = "0x403830E")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403830F RID: 230159
		[Token(Token = "0x403830F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038310 RID: 230160
		[Token(Token = "0x4038310")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038311 RID: 230161
		[Token(Token = "0x4038311")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038312 RID: 230162
		[Token(Token = "0x4038312")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PageOnlyNotifyBeforePageHide;

		// Token: 0x04038313 RID: 230163
		[Token(Token = "0x4038313")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04038314 RID: 230164
		[Token(Token = "0x4038314")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04038315 RID: 230165
		[Token(Token = "0x4038315")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04038316 RID: 230166
		[Token(Token = "0x4038316")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04038317 RID: 230167
		[Token(Token = "0x4038317")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

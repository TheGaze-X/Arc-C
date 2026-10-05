using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C18 RID: 15384
	[Token(Token = "0x2003C18")]
	public class UniEquipShowState : PopupFadeState
	{
		// Token: 0x0601810F RID: 98575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601810F")]
		[Address(RVA = "0x1089A20", Offset = "0x1088620", VA = "0x181089A20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018110 RID: 98576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018110")]
		[Address(RVA = "0x1089A80", Offset = "0x1088680", VA = "0x181089A80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018111 RID: 98577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018111")]
		[Address(RVA = "0x1089BD0", Offset = "0x10887D0", VA = "0x181089BD0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06018112 RID: 98578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018112")]
		[Address(RVA = "0x1089D50", Offset = "0x1088950", VA = "0x181089D50")]
		public UniEquipShowState()
		{
		}

		// Token: 0x06018114 RID: 98580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018114")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018115 RID: 98581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018115")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0401D316 RID: 119574
		[Token(Token = "0x401D316")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipShowView _showViewPrefab;

		// Token: 0x0401D317 RID: 119575
		[Token(Token = "0x401D317")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401D318 RID: 119576
		[Token(Token = "0x401D318")]
		[FieldOffset(Offset = "0x80")]
		private UniEquipShowStateBean m_stateBean;

		// Token: 0x0401D319 RID: 119577
		[Token(Token = "0x401D319")]
		[FieldOffset(Offset = "0x88")]
		private UniEquipShowView m_uniEquipShowView;

		// Token: 0x0401D31A RID: 119578
		[Token(Token = "0x401D31A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401D31B RID: 119579
		[Token(Token = "0x401D31B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401D31C RID: 119580
		[Token(Token = "0x401D31C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401D31D RID: 119581
		[Token(Token = "0x401D31D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

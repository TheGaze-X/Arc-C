using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061E4 RID: 25060
	[Token(Token = "0x20061E4")]
	public class BattleFinishClimbTowerState : UIPopupState
	{
		// Token: 0x0602429A RID: 148122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602429A")]
		[Address(RVA = "0x1ECD1C0", Offset = "0x1ECBDC0", VA = "0x181ECD1C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602429B RID: 148123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602429B")]
		[Address(RVA = "0x1ECD450", Offset = "0x1ECC050", VA = "0x181ECD450", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602429C RID: 148124 RVA: 0x000C3438 File Offset: 0x000C1638
		[Token(Token = "0x602429C")]
		[Address(RVA = "0x1ECD8A0", Offset = "0x1ECC4A0", VA = "0x181ECD8A0")]
		private bool _InitClimbTowerBattleFinish()
		{
			return default(bool);
		}

		// Token: 0x0602429D RID: 148125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602429D")]
		[Address(RVA = "0x1ECD670", Offset = "0x1ECC270", VA = "0x181ECD670", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602429E RID: 148126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602429E")]
		[Address(RVA = "0x1ECD220", Offset = "0x1ECBE20", VA = "0x181ECD220", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602429F RID: 148127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602429F")]
		[Address(RVA = "0x1ECD7B0", Offset = "0x1ECC3B0", VA = "0x181ECD7B0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242A0 RID: 148128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242A0")]
		[Address(RVA = "0x1ECD360", Offset = "0x1ECBF60", VA = "0x181ECD360", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x060242A1 RID: 148129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242A1")]
		[Address(RVA = "0x1ECDF10", Offset = "0x1ECCB10", VA = "0x181ECDF10")]
		public BattleFinishClimbTowerState()
		{
		}

		// Token: 0x060242A2 RID: 148130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60242A2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04032488 RID: 205960
		[Token(Token = "0x4032488")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x04032489 RID: 205961
		[Token(Token = "0x4032489")]
		[FieldOffset(Offset = "0x68")]
		private BattleFinishClimbTowerStateBean m_stateBean;

		// Token: 0x0403248A RID: 205962
		[Token(Token = "0x403248A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403248B RID: 205963
		[Token(Token = "0x403248B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403248C RID: 205964
		[Token(Token = "0x403248C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitClimbTowerBattleFinish;

		// Token: 0x0403248D RID: 205965
		[Token(Token = "0x403248D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403248E RID: 205966
		[Token(Token = "0x403248E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403248F RID: 205967
		[Token(Token = "0x403248F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04032490 RID: 205968
		[Token(Token = "0x4032490")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04032491 RID: 205969
		[Token(Token = "0x4032491")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

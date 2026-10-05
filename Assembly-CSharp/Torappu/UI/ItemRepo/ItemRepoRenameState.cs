using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E61 RID: 24161
	[Token(Token = "0x2005E61")]
	public class ItemRepoRenameState : PopupFloatState
	{
		// Token: 0x06023024 RID: 143396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023024")]
		[Address(RVA = "0x1D871C0", Offset = "0x1D85DC0", VA = "0x181D871C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023025 RID: 143397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023025")]
		[Address(RVA = "0x1D87220", Offset = "0x1D85E20", VA = "0x181D87220", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023026 RID: 143398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023026")]
		[Address(RVA = "0x1D87130", Offset = "0x1D85D30", VA = "0x181D87130")]
		public void DismissToHome()
		{
		}

		// Token: 0x06023027 RID: 143399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023027")]
		[Address(RVA = "0x1D87390", Offset = "0x1D85F90", VA = "0x181D87390")]
		public ItemRepoRenameState()
		{
		}

		// Token: 0x06023028 RID: 143400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023028")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04030384 RID: 197508
		[Token(Token = "0x4030384")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoItemDetailStateBean _stateBean;

		// Token: 0x04030385 RID: 197509
		[Token(Token = "0x4030385")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoUseChangeNameCard _changeNameCard;

		// Token: 0x04030386 RID: 197510
		[Token(Token = "0x4030386")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030387 RID: 197511
		[Token(Token = "0x4030387")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030388 RID: 197512
		[Token(Token = "0x4030388")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DismissToHome;

		// Token: 0x04030389 RID: 197513
		[Token(Token = "0x4030389")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

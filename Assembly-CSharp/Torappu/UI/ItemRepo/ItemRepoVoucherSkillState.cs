using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E6B RID: 24171
	[Token(Token = "0x2005E6B")]
	public class ItemRepoVoucherSkillState : PopupFloatState
	{
		// Token: 0x06023070 RID: 143472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023070")]
		[Address(RVA = "0x1D8AFB0", Offset = "0x1D89BB0", VA = "0x181D8AFB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023071 RID: 143473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023071")]
		[Address(RVA = "0x1D8B230", Offset = "0x1D89E30", VA = "0x181D8B230", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023072 RID: 143474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023072")]
		[Address(RVA = "0x1D8B010", Offset = "0x1D89C10", VA = "0x181D8B010", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023073 RID: 143475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023073")]
		[Address(RVA = "0x1D8B350", Offset = "0x1D89F50", VA = "0x181D8B350")]
		private void _OnChooseSkill(int selectedIdx)
		{
		}

		// Token: 0x06023074 RID: 143476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023074")]
		[Address(RVA = "0x1D8B2B0", Offset = "0x1D89EB0", VA = "0x181D8B2B0")]
		private void _OnBackOrCancel()
		{
		}

		// Token: 0x06023075 RID: 143477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023075")]
		[Address(RVA = "0x1D8B430", Offset = "0x1D8A030", VA = "0x181D8B430")]
		public ItemRepoVoucherSkillState()
		{
		}

		// Token: 0x06023076 RID: 143478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023076")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023077 RID: 143479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023077")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040303D8 RID: 197592
		[Token(Token = "0x40303D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoVoucherSkillView _view;

		// Token: 0x040303D9 RID: 197593
		[Token(Token = "0x40303D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoVoucherSkillStateBean _stateBean;

		// Token: 0x040303DA RID: 197594
		[Token(Token = "0x40303DA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _btnExit;

		// Token: 0x040303DB RID: 197595
		[Token(Token = "0x40303DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303DC RID: 197596
		[Token(Token = "0x40303DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040303DD RID: 197597
		[Token(Token = "0x40303DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303DE RID: 197598
		[Token(Token = "0x40303DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnChooseSkill;

		// Token: 0x040303DF RID: 197599
		[Token(Token = "0x40303DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBackOrCancel;

		// Token: 0x040303E0 RID: 197600
		[Token(Token = "0x40303E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

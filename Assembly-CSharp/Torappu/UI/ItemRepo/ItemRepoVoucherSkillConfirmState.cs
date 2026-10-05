using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E69 RID: 24169
	[Token(Token = "0x2005E69")]
	public class ItemRepoVoucherSkillConfirmState : PopupFloatState
	{
		// Token: 0x06023064 RID: 143460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023064")]
		[Address(RVA = "0x1D8A6F0", Offset = "0x1D892F0", VA = "0x181D8A6F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023065 RID: 143461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023065")]
		[Address(RVA = "0x1D8A970", Offset = "0x1D89570", VA = "0x181D8A970", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023066 RID: 143462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023066")]
		[Address(RVA = "0x1D8A750", Offset = "0x1D89350", VA = "0x181D8A750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023067 RID: 143463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023067")]
		[Address(RVA = "0x1D8AC10", Offset = "0x1D89810", VA = "0x181D8AC10")]
		private void _OnBackOrCancel()
		{
		}

		// Token: 0x06023068 RID: 143464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023068")]
		[Address(RVA = "0x1D8ACB0", Offset = "0x1D898B0", VA = "0x181D8ACB0")]
		private void _OnConfirmUpgrade()
		{
		}

		// Token: 0x06023069 RID: 143465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023069")]
		[Address(RVA = "0x1D8AF50", Offset = "0x1D89B50", VA = "0x181D8AF50")]
		public ItemRepoVoucherSkillConfirmState()
		{
		}

		// Token: 0x0602306B RID: 143467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602306B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602306C RID: 143468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602306C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040303CD RID: 197581
		[Token(Token = "0x40303CD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoVoucherSkillConfirmView _view;

		// Token: 0x040303CE RID: 197582
		[Token(Token = "0x40303CE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoVoucherSkillStateBean _stateBean;

		// Token: 0x040303CF RID: 197583
		[Token(Token = "0x40303CF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _btnExit;

		// Token: 0x040303D0 RID: 197584
		[Token(Token = "0x40303D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040303D1 RID: 197585
		[Token(Token = "0x40303D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040303D2 RID: 197586
		[Token(Token = "0x40303D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040303D3 RID: 197587
		[Token(Token = "0x40303D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBackOrCancel;

		// Token: 0x040303D4 RID: 197588
		[Token(Token = "0x40303D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmUpgrade;

		// Token: 0x040303D5 RID: 197589
		[Token(Token = "0x40303D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

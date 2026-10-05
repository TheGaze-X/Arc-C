using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E4C RID: 24140
	[Token(Token = "0x2005E4C")]
	public class ItemRepoApItemState : PopupFloatState
	{
		// Token: 0x06022F93 RID: 143251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022F93")]
		[Address(RVA = "0x1D7F380", Offset = "0x1D7DF80", VA = "0x181D7F380", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022F94 RID: 143252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F94")]
		[Address(RVA = "0x1D7F3E0", Offset = "0x1D7DFE0", VA = "0x181D7F3E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022F95 RID: 143253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F95")]
		[Address(RVA = "0x1D7F2F0", Offset = "0x1D7DEF0", VA = "0x181D7F2F0")]
		public void DismissToHome()
		{
		}

		// Token: 0x06022F96 RID: 143254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F96")]
		[Address(RVA = "0x1D7F460", Offset = "0x1D7E060", VA = "0x181D7F460")]
		public ItemRepoApItemState()
		{
		}

		// Token: 0x06022F97 RID: 143255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022F97")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040302E2 RID: 197346
		[Token(Token = "0x40302E2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoItemDetailStateBean _stateBean;

		// Token: 0x040302E3 RID: 197347
		[Token(Token = "0x40302E3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ItemRepoUseApSupplyItem _useApItem;

		// Token: 0x040302E4 RID: 197348
		[Token(Token = "0x40302E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040302E5 RID: 197349
		[Token(Token = "0x40302E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040302E6 RID: 197350
		[Token(Token = "0x40302E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DismissToHome;

		// Token: 0x040302E7 RID: 197351
		[Token(Token = "0x40302E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

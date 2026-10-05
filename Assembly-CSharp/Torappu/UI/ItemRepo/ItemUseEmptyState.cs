using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E72 RID: 24178
	[Token(Token = "0x2005E72")]
	public class ItemUseEmptyState : State
	{
		// Token: 0x060230AF RID: 143535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60230AF")]
		[Address(RVA = "0x1DA52B0", Offset = "0x1DA3EB0", VA = "0x181DA52B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060230B0 RID: 143536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230B0")]
		[Address(RVA = "0x1DA5310", Offset = "0x1DA3F10", VA = "0x181DA5310")]
		public ItemUseEmptyState()
		{
		}

		// Token: 0x04030416 RID: 197654
		[Token(Token = "0x4030416")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030417 RID: 197655
		[Token(Token = "0x4030417")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

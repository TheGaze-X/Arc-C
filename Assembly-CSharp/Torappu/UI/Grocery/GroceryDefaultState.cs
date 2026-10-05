using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CAD RID: 19629
	[Token(Token = "0x2004CAD")]
	public class GroceryDefaultState : State, IHotfixable
	{
		// Token: 0x0601D6B9 RID: 120505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D6B9")]
		[Address(RVA = "0x16F4D80", Offset = "0x16F3980", VA = "0x1816F4D80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D6BA RID: 120506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BA")]
		[Address(RVA = "0x16F4DE0", Offset = "0x16F39E0", VA = "0x1816F4DE0")]
		public GroceryDefaultState()
		{
		}

		// Token: 0x04026C00 RID: 158720
		[Token(Token = "0x4026C00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026C01 RID: 158721
		[Token(Token = "0x4026C01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

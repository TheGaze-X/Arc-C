using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AE9 RID: 6889
	[Token(Token = "0x2001AE9")]
	public class BuildingCharCtrlPage : BuildingCommonPage
	{
		// Token: 0x0600AE23 RID: 44579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE23")]
		[Address(RVA = "0x328DE90", Offset = "0x328CA90", VA = "0x18328DE90", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600AE24 RID: 44580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE24")]
		[Address(RVA = "0x328DF70", Offset = "0x328CB70", VA = "0x18328DF70")]
		public BuildingCharCtrlPage()
		{
		}

		// Token: 0x0600AE25 RID: 44581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE25")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0400A682 RID: 42626
		[Token(Token = "0x400A682")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0400A683 RID: 42627
		[Token(Token = "0x400A683")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AEA RID: 6890
		[Token(Token = "0x2001AEA")]
		public struct CharCtrlParam
		{
			// Token: 0x0400A684 RID: 42628
			[Token(Token = "0x400A684")]
			[FieldOffset(Offset = "0x0")]
			public VCharacter vCharacter;
		}
	}
}

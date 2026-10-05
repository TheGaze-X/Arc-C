using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007557 RID: 30039
	[Token(Token = "0x2007557")]
	public class Act24sideSquadStartBattlePlugin : SquadHomeStartBattleServicePlugin<Act24sideBattleStartServiceConfig, Act24sideBattleStartRequest, Act24sideBattleStartResponse>
	{
		// Token: 0x0602A4DC RID: 173276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4DC")]
		[Address(RVA = "0x26020C0", Offset = "0x2600CC0", VA = "0x1826020C0", Slot = "6")]
		public override Act24sideBattleStartServiceConfig DoCreateStartBattleServiceConfig(SquadHomeStartBattleServicePluginBase.Param param)
		{
			return null;
		}

		// Token: 0x0602A4DD RID: 173277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4DD")]
		[Address(RVA = "0x26021D0", Offset = "0x2600DD0", VA = "0x1826021D0")]
		public Act24sideSquadStartBattlePlugin()
		{
		}

		// Token: 0x0403CD35 RID: 249141
		[Token(Token = "0x403CD35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCreateStartBattleServiceConfig;

		// Token: 0x0403CD36 RID: 249142
		[Token(Token = "0x403CD36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

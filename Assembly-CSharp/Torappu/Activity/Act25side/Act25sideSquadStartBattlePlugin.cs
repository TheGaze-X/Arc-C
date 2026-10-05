using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D2 RID: 29906
	[Token(Token = "0x20074D2")]
	public class Act25sideSquadStartBattlePlugin : SquadHomeStartBattleServicePlugin<Act25sideBattleStartServiceConfig, Act25sideBattleStartRequest, Act25sideBattleStartResponse>
	{
		// Token: 0x0602A2A5 RID: 172709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A2A5")]
		[Address(RVA = "0x25CE180", Offset = "0x25CCD80", VA = "0x1825CE180", Slot = "6")]
		public override Act25sideBattleStartServiceConfig DoCreateStartBattleServiceConfig(SquadHomeStartBattleServicePluginBase.Param param)
		{
			return null;
		}

		// Token: 0x0602A2A6 RID: 172710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2A6")]
		[Address(RVA = "0x25CE280", Offset = "0x25CCE80", VA = "0x1825CE280")]
		public Act25sideSquadStartBattlePlugin()
		{
		}

		// Token: 0x0403C914 RID: 248084
		[Token(Token = "0x403C914")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCreateStartBattleServiceConfig;

		// Token: 0x0403C915 RID: 248085
		[Token(Token = "0x403C915")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

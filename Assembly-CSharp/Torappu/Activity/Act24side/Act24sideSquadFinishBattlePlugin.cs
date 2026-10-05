using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007558 RID: 30040
	[Token(Token = "0x2007558")]
	public class Act24sideSquadFinishBattlePlugin : SquadHomeFinishBattleServicePlugin<Act24sideBattleFinishServiceConfig, Act24sideBattleFinishRequest, Act24sideBattleFinishResponse>
	{
		// Token: 0x0602A4DE RID: 173278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A4DE")]
		[Address(RVA = "0x2601F50", Offset = "0x2600B50", VA = "0x182601F50", Slot = "6")]
		public override Act24sideBattleFinishServiceConfig DoCreateFinishBattleServiceConfig(SquadHomeFinishBattleServicePluginBase.Param param)
		{
			return null;
		}

		// Token: 0x0602A4DF RID: 173279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4DF")]
		[Address(RVA = "0x2602050", Offset = "0x2600C50", VA = "0x182602050")]
		public Act24sideSquadFinishBattlePlugin()
		{
		}

		// Token: 0x0403CD37 RID: 249143
		[Token(Token = "0x403CD37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCreateFinishBattleServiceConfig;

		// Token: 0x0403CD38 RID: 249144
		[Token(Token = "0x403CD38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

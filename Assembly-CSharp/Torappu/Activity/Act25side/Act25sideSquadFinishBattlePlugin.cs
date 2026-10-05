using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D3 RID: 29907
	[Token(Token = "0x20074D3")]
	public class Act25sideSquadFinishBattlePlugin : SquadHomeFinishBattleServicePlugin<Act25sideBattleFinishServiceConfig, Act25sideBattleFinishRequest, Act25sideBattleFinishResponse>
	{
		// Token: 0x0602A2A7 RID: 172711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A2A7")]
		[Address(RVA = "0x25CE040", Offset = "0x25CCC40", VA = "0x1825CE040", Slot = "6")]
		public override Act25sideBattleFinishServiceConfig DoCreateFinishBattleServiceConfig(SquadHomeFinishBattleServicePluginBase.Param param)
		{
			return null;
		}

		// Token: 0x0602A2A8 RID: 172712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2A8")]
		[Address(RVA = "0x25CE110", Offset = "0x25CCD10", VA = "0x1825CE110")]
		public Act25sideSquadFinishBattlePlugin()
		{
		}

		// Token: 0x0403C916 RID: 248086
		[Token(Token = "0x403C916")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCreateFinishBattleServiceConfig;

		// Token: 0x0403C917 RID: 248087
		[Token(Token = "0x403C917")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

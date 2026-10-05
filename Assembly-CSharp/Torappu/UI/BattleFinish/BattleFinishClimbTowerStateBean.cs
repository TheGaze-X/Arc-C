using System;
using Il2CppDummyDll;
using Torappu.UI.ClimbTower;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061E3 RID: 25059
	[Token(Token = "0x20061E3")]
	public class BattleFinishClimbTowerStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06024299 RID: 148121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024299")]
		[Address(RVA = "0x1ECD120", Offset = "0x1ECBD20", VA = "0x181ECD120")]
		public BattleFinishClimbTowerStateBean()
		{
		}

		// Token: 0x04032486 RID: 205958
		[Token(Token = "0x4032486")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerBattleFinishViewModel battleFinishModel;

		// Token: 0x04032487 RID: 205959
		[Token(Token = "0x4032487")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

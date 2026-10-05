using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074CE RID: 29902
	[Token(Token = "0x20074CE")]
	public class Act25sideBattleStartServiceConfig : SquadCustomStartBattleServiceConfig<Act25sideBattleStartRequest, Act25sideBattleStartResponse>
	{
		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x0602A2A0 RID: 172704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006358")]
		protected override string serviceCode
		{
			[Token(Token = "0x602A2A0")]
			[Address(RVA = "0x25C6C20", Offset = "0x25C5820", VA = "0x1825C6C20", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A2A1 RID: 172705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2A1")]
		[Address(RVA = "0x25C6BA0", Offset = "0x25C57A0", VA = "0x1825C6BA0")]
		public Act25sideBattleStartServiceConfig(SquadHomeStartBattleServicePluginBase.Param param)
		{
		}

		// Token: 0x0403C911 RID: 248081
		[Token(Token = "0x403C911")]
		[FieldOffset(Offset = "0x18")]
		public int continuousBattleTimes;

		// Token: 0x0403C912 RID: 248082
		[Token(Token = "0x403C912")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_serviceCode;

		// Token: 0x0403C913 RID: 248083
		[Token(Token = "0x403C913")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

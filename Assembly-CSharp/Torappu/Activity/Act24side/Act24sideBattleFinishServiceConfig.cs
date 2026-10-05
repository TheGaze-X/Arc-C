using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007554 RID: 30036
	[Token(Token = "0x2007554")]
	public class Act24sideBattleFinishServiceConfig : SquadCustomFinishBattleServiceConfig<Act24sideBattleFinishRequest, Act24sideBattleFinishResponse>
	{
		// Token: 0x0602A4D8 RID: 173272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D8")]
		[Address(RVA = "0x25F47F0", Offset = "0x25F33F0", VA = "0x1825F47F0", Slot = "9")]
		public override void OnParseRequest(Act24sideBattleFinishRequest request)
		{
		}

		// Token: 0x0602A4D9 RID: 173273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D9")]
		[Address(RVA = "0x25F4860", Offset = "0x25F3460", VA = "0x1825F4860")]
		public Act24sideBattleFinishServiceConfig(string serviceCode, string activityId)
		{
		}

		// Token: 0x0403CD32 RID: 249138
		[Token(Token = "0x403CD32")]
		[FieldOffset(Offset = "0x18")]
		private string m_activityId;
	}
}

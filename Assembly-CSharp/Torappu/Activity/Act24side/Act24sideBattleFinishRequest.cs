using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007552 RID: 30034
	[Token(Token = "0x2007552")]
	public class Act24sideBattleFinishRequest : DefaultFinishBattleRequest
	{
		// Token: 0x0602A4D6 RID: 173270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D6")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act24sideBattleFinishRequest()
		{
		}

		// Token: 0x0403CD2E RID: 249134
		[Token(Token = "0x403CD2E")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}

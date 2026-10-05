using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200754F RID: 30031
	[Token(Token = "0x200754F")]
	public class Act24sideBattleStartRequest : DefaultStartBattleRequest
	{
		// Token: 0x0602A4D1 RID: 173265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D1")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act24sideBattleStartRequest()
		{
		}

		// Token: 0x0403CD29 RID: 249129
		[Token(Token = "0x403CD29")]
		[FieldOffset(Offset = "0x60")]
		public string activityId;
	}
}

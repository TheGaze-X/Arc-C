using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791B RID: 31003
	[Token(Token = "0x200791B")]
	public class ArcadeFinishBattleRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602B7EE RID: 178158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7EE")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ArcadeFinishBattleRequest()
		{
		}

		// Token: 0x0403EE2B RID: 257579
		[Token(Token = "0x403EE2B")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}

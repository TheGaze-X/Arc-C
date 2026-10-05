using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007867 RID: 30823
	[Token(Token = "0x2007867")]
	public class Act1LockInterlockBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602B336 RID: 176950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B336")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act1LockInterlockBattleFinishRequest()
		{
		}

		// Token: 0x0403E75B RID: 255835
		[Token(Token = "0x403E75B")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;
	}
}

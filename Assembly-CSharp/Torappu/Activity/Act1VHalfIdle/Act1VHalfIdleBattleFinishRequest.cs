using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C2 RID: 30402
	[Token(Token = "0x20076C2")]
	public class Act1VHalfIdleBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0602AC0D RID: 175117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC0D")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public Act1VHalfIdleBattleFinishRequest()
		{
		}

		// Token: 0x0403D9A1 RID: 252321
		[Token(Token = "0x403D9A1")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x0403D9A2 RID: 252322
		[Token(Token = "0x403D9A2")]
		[FieldOffset(Offset = "0x28")]
		public Act1VHalfIdleBattleSettleData halfidleData;
	}
}

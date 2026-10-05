using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E9C RID: 28316
	[Token(Token = "0x2006E9C")]
	public class VecBreakV2OffenseStartBattleRequest
	{
		// Token: 0x060284B6 RID: 165046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284B6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2OffenseStartBattleRequest()
		{
		}

		// Token: 0x0403944C RID: 234572
		[Token(Token = "0x403944C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403944D RID: 234573
		[Token(Token = "0x403944D")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403944E RID: 234574
		[Token(Token = "0x403944E")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x0403944F RID: 234575
		[Token(Token = "0x403944F")]
		[FieldOffset(Offset = "0x28")]
		public SquadFriendData assistFriend;
	}
}

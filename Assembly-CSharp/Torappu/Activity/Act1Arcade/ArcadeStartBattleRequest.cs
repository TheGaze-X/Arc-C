using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007918 RID: 31000
	[Token(Token = "0x2007918")]
	public class ArcadeStartBattleRequest
	{
		// Token: 0x0602B7E5 RID: 178149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArcadeStartBattleRequest()
		{
		}

		// Token: 0x0403EE20 RID: 257568
		[Token(Token = "0x403EE20")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403EE21 RID: 257569
		[Token(Token = "0x403EE21")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403EE22 RID: 257570
		[Token(Token = "0x403EE22")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x0403EE23 RID: 257571
		[Token(Token = "0x403EE23")]
		[FieldOffset(Offset = "0x28")]
		public SquadFriendData assistFriend;
	}
}

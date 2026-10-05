using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	public abstract class CommonStartBattleRequest
	{
		// Token: 0x0600655D RID: 25949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600655D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CommonStartBattleRequest()
		{
		}

		// Token: 0x0400328F RID: 12943
		[Token(Token = "0x400328F")]
		[FieldOffset(Offset = "0x10")]
		public bool usePracticeTicket;

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x28")]
		public SquadFriendData assistFriend;

		// Token: 0x04003293 RID: 12947
		[Token(Token = "0x4003293")]
		[FieldOffset(Offset = "0x30")]
		public bool isReplay;

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x38")]
		public long startTs;

		// Token: 0x020008B4 RID: 2228
		[Token(Token = "0x20008B4")]
		public class SquadModel
		{
			// Token: 0x0600655E RID: 25950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600655E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SquadModel()
			{
			}

			// Token: 0x04003295 RID: 12949
			[Token(Token = "0x4003295")]
			[FieldOffset(Offset = "0x10")]
			public string squadId;

			// Token: 0x04003296 RID: 12950
			[Token(Token = "0x4003296")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04003297 RID: 12951
			[Token(Token = "0x4003297")]
			[FieldOffset(Offset = "0x20")]
			public List<RequestSquadSlot> slots;
		}

		// Token: 0x020008B5 RID: 2229
		[Token(Token = "0x20008B5")]
		public class MultipleBattleModel
		{
			// Token: 0x0600655F RID: 25951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600655F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MultipleBattleModel()
			{
			}

			// Token: 0x04003298 RID: 12952
			[Token(Token = "0x4003298")]
			[FieldOffset(Offset = "0x10")]
			public int battleTimes;
		}
	}
}

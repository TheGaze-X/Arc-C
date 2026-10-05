using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076BE RID: 30398
	[Token(Token = "0x20076BE")]
	public class Act1VHalfIdleBattleStartRequest
	{
		// Token: 0x0602AC04 RID: 175108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC04")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleBattleStartRequest()
		{
		}

		// Token: 0x0403D998 RID: 252312
		[Token(Token = "0x403D998")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D999 RID: 252313
		[Token(Token = "0x403D999")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403D99A RID: 252314
		[Token(Token = "0x403D99A")]
		[FieldOffset(Offset = "0x20")]
		public List<RequestSquadSlot> slots;

		// Token: 0x0403D99B RID: 252315
		[Token(Token = "0x403D99B")]
		[FieldOffset(Offset = "0x28")]
		public List<string> traps;
	}
}

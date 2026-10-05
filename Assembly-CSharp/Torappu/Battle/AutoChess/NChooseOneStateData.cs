using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002721 RID: 10017
	[Token(Token = "0x2002721")]
	public class NChooseOneStateData
	{
		// Token: 0x0601047B RID: 66683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601047B")]
		[Address(RVA = "0x80A2C0", Offset = "0x808EC0", VA = "0x18080A2C0")]
		public NChooseOneStateData()
		{
		}

		// Token: 0x04012324 RID: 74532
		[Token(Token = "0x4012324")]
		[FieldOffset(Offset = "0x10")]
		public string choiceId;

		// Token: 0x04012325 RID: 74533
		[Token(Token = "0x4012325")]
		[FieldOffset(Offset = "0x18")]
		public List<ChooseStateSlot> options;

		// Token: 0x04012326 RID: 74534
		[Token(Token = "0x4012326")]
		[FieldOffset(Offset = "0x20")]
		public List<NChooseOneStateData.PlayerChoice> playerQueue;

		// Token: 0x04012327 RID: 74535
		[Token(Token = "0x4012327")]
		[FieldOffset(Offset = "0x28")]
		public long stateEndTime;

		// Token: 0x04012328 RID: 74536
		[Token(Token = "0x4012328")]
		[FieldOffset(Offset = "0x30")]
		public int currQueueIndex;

		// Token: 0x02002722 RID: 10018
		[Token(Token = "0x2002722")]
		public class PlayerChoice
		{
			// Token: 0x0601047C RID: 66684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601047C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerChoice()
			{
			}

			// Token: 0x04012329 RID: 74537
			[Token(Token = "0x4012329")]
			[FieldOffset(Offset = "0x10")]
			public int uidIndex;

			// Token: 0x0401232A RID: 74538
			[Token(Token = "0x401232A")]
			[FieldOffset(Offset = "0x14")]
			public int choice;
		}
	}
}

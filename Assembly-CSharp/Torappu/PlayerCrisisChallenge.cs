using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	public class PlayerCrisisChallenge
	{
		// Token: 0x06006759 RID: 26457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006759")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCrisisChallenge()
		{
		}

		// Token: 0x04003943 RID: 14659
		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, long> pointList;

		// Token: 0x04003944 RID: 14660
		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerCrisisChallenge.PlayerChallengeTask> taskList;

		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		[FieldOffset(Offset = "0x20")]
		public int topPoint;

		// Token: 0x02000A96 RID: 2710
		[Token(Token = "0x2000A96")]
		public class PlayerChallengeTask
		{
			// Token: 0x0600675A RID: 26458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600675A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerChallengeTask()
			{
			}

			// Token: 0x04003946 RID: 14662
			[Token(Token = "0x4003946")]
			[FieldOffset(Offset = "0x10")]
			public long fts;

			// Token: 0x04003947 RID: 14663
			[Token(Token = "0x4003947")]
			[FieldOffset(Offset = "0x18")]
			public long rts;
		}
	}
}

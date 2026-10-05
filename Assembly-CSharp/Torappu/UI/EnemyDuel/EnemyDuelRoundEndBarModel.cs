using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200500C RID: 20492
	[Token(Token = "0x200500C")]
	public struct EnemyDuelRoundEndBarModel
	{
		// Token: 0x04028AE3 RID: 166627
		[Token(Token = "0x4028AE3")]
		[FieldOffset(Offset = "0x0")]
		public bool isRoom;

		// Token: 0x04028AE4 RID: 166628
		[Token(Token = "0x4028AE4")]
		[FieldOffset(Offset = "0x1")]
		public bool isRoomOwner;

		// Token: 0x04028AE5 RID: 166629
		[Token(Token = "0x4028AE5")]
		[FieldOffset(Offset = "0x2")]
		public bool isStandMode;

		// Token: 0x04028AE6 RID: 166630
		[Token(Token = "0x4028AE6")]
		[FieldOffset(Offset = "0x8")]
		public string modeName;

		// Token: 0x04028AE7 RID: 166631
		[Token(Token = "0x4028AE7")]
		[FieldOffset(Offset = "0x10")]
		public bool isOut;

		// Token: 0x04028AE8 RID: 166632
		[Token(Token = "0x4028AE8")]
		[FieldOffset(Offset = "0x14")]
		public int currRound;

		// Token: 0x04028AE9 RID: 166633
		[Token(Token = "0x4028AE9")]
		[FieldOffset(Offset = "0x18")]
		public int totalRound;

		// Token: 0x04028AEA RID: 166634
		[Token(Token = "0x4028AEA")]
		[FieldOffset(Offset = "0x1C")]
		public int remainPlayers;

		// Token: 0x04028AEB RID: 166635
		[Token(Token = "0x4028AEB")]
		[FieldOffset(Offset = "0x20")]
		public int totalPlayers;

		// Token: 0x04028AEC RID: 166636
		[Token(Token = "0x4028AEC")]
		[FieldOffset(Offset = "0x24")]
		public int countDownSeconds;

		// Token: 0x04028AED RID: 166637
		[Token(Token = "0x4028AED")]
		[FieldOffset(Offset = "0x28")]
		public bool isGameOver;
	}
}

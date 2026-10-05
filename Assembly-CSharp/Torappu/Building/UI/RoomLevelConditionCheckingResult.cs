using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001BA0 RID: 7072
	[Token(Token = "0x2001BA0")]
	public struct RoomLevelConditionCheckingResult
	{
		// Token: 0x0600B084 RID: 45188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B084")]
		[Address(RVA = "0x32B0DA0", Offset = "0x32AF9A0", VA = "0x1832B0DA0")]
		public RoomLevelConditionCheckingResult(bool passed, RoomLevelConditionCheckingResult.Reason[] reasons, string roomName = "", int level = 0)
		{
		}

		// Token: 0x0400AAF1 RID: 43761
		[Token(Token = "0x400AAF1")]
		[FieldOffset(Offset = "0x0")]
		public bool passed;

		// Token: 0x0400AAF2 RID: 43762
		[Token(Token = "0x400AAF2")]
		[FieldOffset(Offset = "0x8")]
		public RoomLevelConditionCheckingResult.Reason[] reasons;

		// Token: 0x0400AAF3 RID: 43763
		[Token(Token = "0x400AAF3")]
		[FieldOffset(Offset = "0x10")]
		public string roomName;

		// Token: 0x0400AAF4 RID: 43764
		[Token(Token = "0x400AAF4")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0400AAF5 RID: 43765
		[Token(Token = "0x400AAF5")]
		[FieldOffset(Offset = "0x0")]
		public static RoomLevelConditionCheckingResult PASSED;

		// Token: 0x02001BA1 RID: 7073
		[Token(Token = "0x2001BA1")]
		public struct Reason
		{
			// Token: 0x0600B086 RID: 45190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B086")]
			[Address(RVA = "0x32B0C50", Offset = "0x32AF850", VA = "0x1832B0C50")]
			public Reason(BuildingData.RoomUnlockCond.CondItem condition, int currentRoomCount, int currentRoomLevel)
			{
			}

			// Token: 0x0400AAF6 RID: 43766
			[Token(Token = "0x400AAF6")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.RoomUnlockCond.CondItem condition;

			// Token: 0x0400AAF7 RID: 43767
			[Token(Token = "0x400AAF7")]
			[FieldOffset(Offset = "0x8")]
			public int currentRoomCount;

			// Token: 0x0400AAF8 RID: 43768
			[Token(Token = "0x400AAF8")]
			[FieldOffset(Offset = "0xC")]
			public int currentRoomLevel;
		}
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A67 RID: 2663
	[Token(Token = "0x2000A67")]
	public class PlayerBuildingMeeting
	{
		// Token: 0x06006726 RID: 26406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006726")]
		[Address(RVA = "0x1EF1900", Offset = "0x1EF0500", VA = "0x181EF1900")]
		public PlayerBuildingMeeting()
		{
		}

		// Token: 0x04003892 RID: 14482
		[Token(Token = "0x4003892")]
		[FieldOffset(Offset = "0x10")]
		public List<string> visitedUser;

		// Token: 0x04003893 RID: 14483
		[Token(Token = "0x4003893")]
		[FieldOffset(Offset = "0x18")]
		public PlayerBuildingMeetingBuff buff;

		// Token: 0x04003894 RID: 14484
		[Token(Token = "0x4003894")]
		[FieldOffset(Offset = "0x20")]
		public int state;

		// Token: 0x04003895 RID: 14485
		[Token(Token = "0x4003895")]
		[FieldOffset(Offset = "0x24")]
		public int processPoint;

		// Token: 0x04003896 RID: 14486
		[Token(Token = "0x4003896")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x30")]
		public List<PlayerBuildingMeetingClue> ownStock;

		// Token: 0x04003898 RID: 14488
		[Token(Token = "0x4003898")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerBuildingMeetingClue> receiveStock;

		// Token: 0x04003899 RID: 14489
		[Token(Token = "0x4003899")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, string> board;

		// Token: 0x0400389A RID: 14490
		[Token(Token = "0x400389A")]
		[FieldOffset(Offset = "0x48")]
		public PlayerBuildingMeetingSocialReward socialReward;

		// Token: 0x0400389B RID: 14491
		[Token(Token = "0x400389B")]
		[FieldOffset(Offset = "0x50")]
		public int received;

		// Token: 0x0400389C RID: 14492
		[Token(Token = "0x400389C")]
		[FieldOffset(Offset = "0x58")]
		public PlayerBuildingMeetingInfoShareState infoShare;

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x60")]
		public DateTime lastUpdateTime;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x68")]
		public PlayerBuildingMeetingClue dailyReward;

		// Token: 0x0400389F RID: 14495
		[Token(Token = "0x400389F")]
		[FieldOffset(Offset = "0x70")]
		public List<List<int>> presetQueue;

		// Token: 0x040038A0 RID: 14496
		[Token(Token = "0x40038A0")]
		[FieldOffset(Offset = "0x78")]
		public PlayerBuildingMessageLeave messageLeave;

		// Token: 0x040038A1 RID: 14497
		[Token(Token = "0x40038A1")]
		[FieldOffset(Offset = "0x80")]
		public PlayerBuildingDIYSolution diySolution;
	}
}

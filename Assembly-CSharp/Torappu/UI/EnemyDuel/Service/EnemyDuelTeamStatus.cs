using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005084 RID: 20612
	[Token(Token = "0x2005084")]
	public struct EnemyDuelTeamStatus : IStreamDeserialize
	{
		// Token: 0x0601E882 RID: 125058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E882")]
		[Address(RVA = "0x184C340", Offset = "0x184AF40", VA = "0x18184C340", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028E5A RID: 167514
		[Token(Token = "0x4028E5A")]
		[FieldOffset(Offset = "0x0")]
		public EnemyDuelTeamState state;

		// Token: 0x04028E5B RID: 167515
		[Token(Token = "0x4028E5B")]
		[FieldOffset(Offset = "0x8")]
		public STDuelOwnerStatus owner;

		// Token: 0x04028E5C RID: 167516
		[Token(Token = "0x4028E5C")]
		[FieldOffset(Offset = "0x10")]
		public long teamStateEndTs;

		// Token: 0x04028E5D RID: 167517
		[Token(Token = "0x4028E5D")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04028E5E RID: 167518
		[Token(Token = "0x4028E5E")]
		[FieldOffset(Offset = "0x20")]
		public string modeId;

		// Token: 0x04028E5F RID: 167519
		[Token(Token = "0x4028E5F")]
		[FieldOffset(Offset = "0x28")]
		public List<STDuelPlayerStatus> players;

		// Token: 0x04028E60 RID: 167520
		[Token(Token = "0x4028E60")]
		[FieldOffset(Offset = "0x30")]
		public List<string> npcs;

		// Token: 0x04028E61 RID: 167521
		[Token(Token = "0x4028E61")]
		[FieldOffset(Offset = "0x38")]
		public STDuelSceneInfo scene;

		// Token: 0x04028E62 RID: 167522
		[Token(Token = "0x4028E62")]
		[FieldOffset(Offset = "0x50")]
		public int allowNpc;
	}
}

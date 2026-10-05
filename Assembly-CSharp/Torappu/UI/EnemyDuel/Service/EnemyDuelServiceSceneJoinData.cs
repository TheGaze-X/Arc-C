using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200508E RID: 20622
	[Token(Token = "0x200508E")]
	public struct EnemyDuelServiceSceneJoinData : IStreamDeserialize
	{
		// Token: 0x0601E894 RID: 125076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E894")]
		[Address(RVA = "0x18452A0", Offset = "0x1843EA0", VA = "0x1818452A0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x04028E91 RID: 167569
		[Token(Token = "0x4028E91")]
		[FieldOffset(Offset = "0x0")]
		public long nowTs;

		// Token: 0x04028E92 RID: 167570
		[Token(Token = "0x4028E92")]
		[FieldOffset(Offset = "0x8")]
		public long sceneCreateTs;

		// Token: 0x04028E93 RID: 167571
		[Token(Token = "0x4028E93")]
		[FieldOffset(Offset = "0x10")]
		public string newToken;

		// Token: 0x04028E94 RID: 167572
		[Token(Token = "0x4028E94")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04028E95 RID: 167573
		[Token(Token = "0x4028E95")]
		[FieldOffset(Offset = "0x20")]
		public int stageSeed;

		// Token: 0x04028E96 RID: 167574
		[Token(Token = "0x4028E96")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyDuelServicePlayer> players;

		// Token: 0x04028E97 RID: 167575
		[Token(Token = "0x4028E97")]
		[FieldOffset(Offset = "0x30")]
		public List<string> npcIds;
	}
}

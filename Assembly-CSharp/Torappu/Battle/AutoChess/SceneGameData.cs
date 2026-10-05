using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200270F RID: 9999
	[Token(Token = "0x200270F")]
	public class SceneGameData
	{
		// Token: 0x06010469 RID: 66665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010469")]
		[Address(RVA = "0x80AF80", Offset = "0x809B80", VA = "0x18080AF80")]
		public SceneGameData()
		{
		}

		// Token: 0x040122DC RID: 74460
		[Token(Token = "0x40122DC")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x040122DD RID: 74461
		[Token(Token = "0x40122DD")]
		[FieldOffset(Offset = "0x18")]
		public string bossId;

		// Token: 0x040122DE RID: 74462
		[Token(Token = "0x40122DE")]
		[FieldOffset(Offset = "0x20")]
		public string hiddenBossId;

		// Token: 0x040122DF RID: 74463
		[Token(Token = "0x40122DF")]
		[FieldOffset(Offset = "0x28")]
		public int stageSeed;

		// Token: 0x040122E0 RID: 74464
		[Token(Token = "0x40122E0")]
		[FieldOffset(Offset = "0x2C")]
		public int selfIndex;

		// Token: 0x040122E1 RID: 74465
		[Token(Token = "0x40122E1")]
		[FieldOffset(Offset = "0x30")]
		public List<string> bannedBonds;
	}
}

using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	public class ActivityEnemyDuelNpcData
	{
		// Token: 0x06006AD1 RID: 27345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelNpcData()
		{
		}

		// Token: 0x04004A74 RID: 19060
		[Token(Token = "0x4004A74")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x04004A75 RID: 19061
		[Token(Token = "0x4004A75")]
		[FieldOffset(Offset = "0x18")]
		public string avatarId;

		// Token: 0x04004A76 RID: 19062
		[Token(Token = "0x4004A76")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04004A77 RID: 19063
		[Token(Token = "0x4004A77")]
		[FieldOffset(Offset = "0x28")]
		public float priority;

		// Token: 0x04004A78 RID: 19064
		[Token(Token = "0x4004A78")]
		[FieldOffset(Offset = "0x2C")]
		public EnemyDuelBetStrategy specialStrategy;

		// Token: 0x04004A79 RID: 19065
		[Token(Token = "0x4004A79")]
		[FieldOffset(Offset = "0x30")]
		public float npcProb;

		// Token: 0x04004A7A RID: 19066
		[Token(Token = "0x4004A7A")]
		[FieldOffset(Offset = "0x34")]
		public float defaultEnemyScore;

		// Token: 0x04004A7B RID: 19067
		[Token(Token = "0x4004A7B")]
		[FieldOffset(Offset = "0x38")]
		public float allinProb;
	}
}

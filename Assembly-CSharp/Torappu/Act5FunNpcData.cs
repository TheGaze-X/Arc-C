using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EB2 RID: 3762
	[Token(Token = "0x2000EB2")]
	public class Act5FunNpcData
	{
		// Token: 0x06006B84 RID: 27524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B84")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act5FunNpcData()
		{
		}

		// Token: 0x04004F8F RID: 20367
		[Token(Token = "0x4004F8F")]
		[FieldOffset(Offset = "0x10")]
		public string npcId;

		// Token: 0x04004F90 RID: 20368
		[Token(Token = "0x4004F90")]
		[FieldOffset(Offset = "0x18")]
		public string avatarId;

		// Token: 0x04004F91 RID: 20369
		[Token(Token = "0x4004F91")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04004F92 RID: 20370
		[Token(Token = "0x4004F92")]
		[FieldOffset(Offset = "0x28")]
		public float priority;

		// Token: 0x04004F93 RID: 20371
		[Token(Token = "0x4004F93")]
		[FieldOffset(Offset = "0x2C")]
		public NpcStrategy specialStrategy;

		// Token: 0x04004F94 RID: 20372
		[Token(Token = "0x4004F94")]
		[FieldOffset(Offset = "0x30")]
		public float npcProb;

		// Token: 0x04004F95 RID: 20373
		[Token(Token = "0x4004F95")]
		[FieldOffset(Offset = "0x34")]
		public float defaultEnemyScore;
	}
}

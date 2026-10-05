using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class ActivityEnemyDuelEnemyData
	{
		// Token: 0x06006AD4 RID: 27348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelEnemyData()
		{
		}

		// Token: 0x04004A80 RID: 19072
		[Token(Token = "0x4004A80")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04004A81 RID: 19073
		[Token(Token = "0x4004A81")]
		[FieldOffset(Offset = "0x18")]
		public string originalEnemyId;

		// Token: 0x04004A82 RID: 19074
		[Token(Token = "0x4004A82")]
		[FieldOffset(Offset = "0x20")]
		public string tagType;
	}
}

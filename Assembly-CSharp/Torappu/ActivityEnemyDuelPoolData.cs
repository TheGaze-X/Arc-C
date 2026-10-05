using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	public class ActivityEnemyDuelPoolData
	{
		// Token: 0x06006AD0 RID: 27344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelPoolData()
		{
		}

		// Token: 0x04004A6C RID: 19052
		[Token(Token = "0x4004A6C")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04004A6D RID: 19053
		[Token(Token = "0x4004A6D")]
		[FieldOffset(Offset = "0x18")]
		public float poolNormal;

		// Token: 0x04004A6E RID: 19054
		[Token(Token = "0x4004A6E")]
		[FieldOffset(Offset = "0x1C")]
		public float poolSmallEnemy;

		// Token: 0x04004A6F RID: 19055
		[Token(Token = "0x4004A6F")]
		[FieldOffset(Offset = "0x20")]
		public float poolBoss;

		// Token: 0x04004A70 RID: 19056
		[Token(Token = "0x4004A70")]
		[FieldOffset(Offset = "0x24")]
		public float poolMusic;

		// Token: 0x04004A71 RID: 19057
		[Token(Token = "0x4004A71")]
		[FieldOffset(Offset = "0x28")]
		public float poolNoSurpriseEnemy;

		// Token: 0x04004A72 RID: 19058
		[Token(Token = "0x4004A72")]
		[FieldOffset(Offset = "0x2C")]
		public float poolGiantBoss;

		// Token: 0x04004A73 RID: 19059
		[Token(Token = "0x4004A73")]
		[FieldOffset(Offset = "0x30")]
		public float poolAntiGiantBoss;
	}
}

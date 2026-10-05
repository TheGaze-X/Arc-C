using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012AD RID: 4781
	[Token(Token = "0x20012AD")]
	[Serializable]
	public class SandboxV2BattleRushEnemyConfig
	{
		// Token: 0x0600722E RID: 29230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BattleRushEnemyConfig()
		{
		}

		// Token: 0x040069AB RID: 27051
		[Token(Token = "0x40069AB")]
		[FieldOffset(Offset = "0x10")]
		public string enemyKey;

		// Token: 0x040069AC RID: 27052
		[Token(Token = "0x40069AC")]
		[FieldOffset(Offset = "0x18")]
		public string branchId;

		// Token: 0x040069AD RID: 27053
		[Token(Token = "0x40069AD")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x040069AE RID: 27054
		[Token(Token = "0x40069AE")]
		[FieldOffset(Offset = "0x24")]
		public float interval;

		// Token: 0x040069AF RID: 27055
		[Token(Token = "0x40069AF")]
		[FieldOffset(Offset = "0x28")]
		public float preDelay;
	}
}

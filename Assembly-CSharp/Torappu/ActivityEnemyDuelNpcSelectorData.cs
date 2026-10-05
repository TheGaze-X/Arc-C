using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E01 RID: 3585
	[Token(Token = "0x2000E01")]
	public class ActivityEnemyDuelNpcSelectorData
	{
		// Token: 0x06006AD2 RID: 27346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelNpcSelectorData()
		{
		}

		// Token: 0x04004A7C RID: 19068
		[Token(Token = "0x4004A7C")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04004A7D RID: 19069
		[Token(Token = "0x4004A7D")]
		[FieldOffset(Offset = "0x18")]
		public float score;
	}
}

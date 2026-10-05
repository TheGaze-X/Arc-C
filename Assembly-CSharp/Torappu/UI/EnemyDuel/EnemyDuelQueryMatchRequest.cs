using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F6D RID: 20333
	[Token(Token = "0x2004F6D")]
	public class EnemyDuelQueryMatchRequest
	{
		// Token: 0x0601E3FD RID: 123901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E3FD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelQueryMatchRequest()
		{
		}

		// Token: 0x040285BF RID: 165311
		[Token(Token = "0x40285BF")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285C0 RID: 165312
		[Token(Token = "0x40285C0")]
		[FieldOffset(Offset = "0x18")]
		public bool needLeave;
	}
}

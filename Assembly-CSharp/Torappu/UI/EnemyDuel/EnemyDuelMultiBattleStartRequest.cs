using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F71 RID: 20337
	[Token(Token = "0x2004F71")]
	public class EnemyDuelMultiBattleStartRequest
	{
		// Token: 0x0601E402 RID: 123906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E402")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelMultiBattleStartRequest()
		{
		}

		// Token: 0x040285D0 RID: 165328
		[Token(Token = "0x40285D0")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285D1 RID: 165329
		[Token(Token = "0x40285D1")]
		[FieldOffset(Offset = "0x18")]
		public string sceneId;
	}
}

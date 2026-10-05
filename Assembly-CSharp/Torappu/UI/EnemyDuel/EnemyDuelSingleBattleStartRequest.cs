using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F74 RID: 20340
	[Token(Token = "0x2004F74")]
	public class EnemyDuelSingleBattleStartRequest
	{
		// Token: 0x0601E40B RID: 123915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E40B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelSingleBattleStartRequest()
		{
		}

		// Token: 0x040285D7 RID: 165335
		[Token(Token = "0x40285D7")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040285D8 RID: 165336
		[Token(Token = "0x40285D8")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;
	}
}

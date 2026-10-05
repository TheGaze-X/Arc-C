using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006800 RID: 26624
	[Token(Token = "0x2006800")]
	public class StageSceneParam : ISceneParam
	{
		// Token: 0x06026275 RID: 156277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026275")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StageSceneParam()
		{
		}

		// Token: 0x04035BC9 RID: 220105
		[Token(Token = "0x4035BC9")]
		[FieldOffset(Offset = "0x10")]
		public StateEngineRuntime stageSERuntime;

		// Token: 0x04035BCA RID: 220106
		[Token(Token = "0x4035BCA")]
		[FieldOffset(Offset = "0x18")]
		public bool isJumpFromBattleFinish;

		// Token: 0x04035BCB RID: 220107
		[Token(Token = "0x4035BCB")]
		[FieldOffset(Offset = "0x20")]
		public List<KeyValuePair<string, string>> newlyUnlockedStages;

		// Token: 0x04035BCC RID: 220108
		[Token(Token = "0x4035BCC")]
		[FieldOffset(Offset = "0x28")]
		public List<string> alertsAfterBattle;
	}
}

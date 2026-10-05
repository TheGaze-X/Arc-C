using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F84 RID: 3972
	[Token(Token = "0x2000F84")]
	public class BattleVoiceData
	{
		// Token: 0x06006CC4 RID: 27844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CC4")]
		[Address(RVA = "0x20FF150", Offset = "0x20FDD50", VA = "0x1820FF150")]
		public BattleVoiceData()
		{
		}

		// Token: 0x04005471 RID: 21617
		[Token(Token = "0x4005471")]
		[FieldOffset(Offset = "0x10")]
		public float crossfade;

		// Token: 0x04005472 RID: 21618
		[Token(Token = "0x4005472")]
		[FieldOffset(Offset = "0x14")]
		public float minTimeDeltaForEnemyEncounter;

		// Token: 0x04005473 RID: 21619
		[Token(Token = "0x4005473")]
		[FieldOffset(Offset = "0x18")]
		public int minSpCostForImportantPassiveSkill;

		// Token: 0x04005474 RID: 21620
		[Token(Token = "0x4005474")]
		[FieldOffset(Offset = "0x20")]
		public List<BattleVoiceOption> voiceTypeOptions;
	}
}

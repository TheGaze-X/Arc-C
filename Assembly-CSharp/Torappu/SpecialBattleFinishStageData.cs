using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001366 RID: 4966
	[Token(Token = "0x2001366")]
	public class SpecialBattleFinishStageData
	{
		// Token: 0x0600732F RID: 29487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialBattleFinishStageData()
		{
		}

		// Token: 0x04006E2A RID: 28202
		[Token(Token = "0x4006E2A")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04006E2B RID: 28203
		[Token(Token = "0x4006E2B")]
		[FieldOffset(Offset = "0x18")]
		public bool skipAccomplishPerform;
	}
}

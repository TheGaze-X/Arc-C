using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200138F RID: 5007
	[Token(Token = "0x200138F")]
	[Serializable]
	public class TrainingCampData
	{
		// Token: 0x0600736E RID: 29550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TrainingCampData()
		{
		}

		// Token: 0x04006F34 RID: 28468
		[Token(Token = "0x4006F34")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, TrainingCampStageData> stageData;

		// Token: 0x04006F35 RID: 28469
		[Token(Token = "0x4006F35")]
		[FieldOffset(Offset = "0x18")]
		public List<NewTrainingCampStageData> newTrainingCampStages;

		// Token: 0x04006F36 RID: 28470
		[Token(Token = "0x4006F36")]
		[FieldOffset(Offset = "0x20")]
		public TrainingCampConsts consts;
	}
}

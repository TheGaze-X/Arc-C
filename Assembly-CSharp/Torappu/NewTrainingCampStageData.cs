using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001390 RID: 5008
	[Token(Token = "0x2001390")]
	[Serializable]
	public class NewTrainingCampStageData
	{
		// Token: 0x0600736F RID: 29551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NewTrainingCampStageData()
		{
		}

		// Token: 0x04006F37 RID: 28471
		[Token(Token = "0x4006F37")]
		[FieldOffset(Offset = "0x10")]
		public long updateTs;

		// Token: 0x04006F38 RID: 28472
		[Token(Token = "0x4006F38")]
		[FieldOffset(Offset = "0x18")]
		public List<string> stages;
	}
}

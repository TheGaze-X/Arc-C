using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C04 RID: 3076
	[Token(Token = "0x2000C04")]
	public class PlayerTrainingCamp
	{
		// Token: 0x06006898 RID: 26776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006898")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerTrainingCamp()
		{
		}

		// Token: 0x04003EC6 RID: 16070
		[Token(Token = "0x4003EC6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerTrainingCampStage> stages;
	}
}

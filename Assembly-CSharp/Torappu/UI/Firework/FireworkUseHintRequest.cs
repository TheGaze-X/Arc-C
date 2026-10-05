using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E55 RID: 20053
	[Token(Token = "0x2004E55")]
	public class FireworkUseHintRequest
	{
		// Token: 0x0601DED4 RID: 122580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FireworkUseHintRequest()
		{
		}

		// Token: 0x04027B99 RID: 162713
		[Token(Token = "0x4027B99")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04027B9A RID: 162714
		[Token(Token = "0x4027B9A")]
		[FieldOffset(Offset = "0x18")]
		public string puzzleId;

		// Token: 0x04027B9B RID: 162715
		[Token(Token = "0x4027B9B")]
		[FieldOffset(Offset = "0x20")]
		public List<FireworkData.PlateSlotData> solutionList;
	}
}

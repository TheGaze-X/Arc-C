using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E53 RID: 20051
	[Token(Token = "0x2004E53")]
	public class FireworkCompletePuzzleRequest
	{
		// Token: 0x0601DED2 RID: 122578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FireworkCompletePuzzleRequest()
		{
		}

		// Token: 0x04027B95 RID: 162709
		[Token(Token = "0x4027B95")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04027B96 RID: 162710
		[Token(Token = "0x4027B96")]
		[FieldOffset(Offset = "0x18")]
		public string puzzleId;

		// Token: 0x04027B97 RID: 162711
		[Token(Token = "0x4027B97")]
		[FieldOffset(Offset = "0x20")]
		public List<FireworkData.PlateSlotData> solutionList;
	}
}

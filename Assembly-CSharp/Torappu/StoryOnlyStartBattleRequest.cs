using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	public class StoryOnlyStartBattleRequest
	{
		// Token: 0x0600656D RID: 25965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StoryOnlyStartBattleRequest()
		{
		}

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x18")]
		public bool isRetro;
	}
}

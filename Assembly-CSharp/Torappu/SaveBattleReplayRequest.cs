using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000617 RID: 1559
	[Token(Token = "0x2000617")]
	public class SaveBattleReplayRequest
	{
		// Token: 0x06006245 RID: 25157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006245")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SaveBattleReplayRequest()
		{
		}

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0x10")]
		public string battleId;

		// Token: 0x04002DA1 RID: 11681
		[Token(Token = "0x4002DA1")]
		[FieldOffset(Offset = "0x18")]
		public string battleReplay;
	}
}

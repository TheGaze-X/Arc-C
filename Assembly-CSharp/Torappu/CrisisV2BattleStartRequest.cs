using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006E8 RID: 1768
	[Token(Token = "0x20006E8")]
	public class CrisisV2BattleStartRequest : CrisisStartBattleBaseRequest
	{
		// Token: 0x06006339 RID: 25401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006339")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BattleStartRequest()
		{
		}

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x28")]
		public List<string> runeSlots;
	}
}

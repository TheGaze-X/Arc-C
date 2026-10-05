using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006265 RID: 25189
	[Token(Token = "0x2006265")]
	public class AutoChessMultiBattleStartRequest
	{
		// Token: 0x06024572 RID: 148850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024572")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessMultiBattleStartRequest()
		{
		}

		// Token: 0x0403289F RID: 207007
		[Token(Token = "0x403289F")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328A0 RID: 207008
		[Token(Token = "0x40328A0")]
		[FieldOffset(Offset = "0x18")]
		public string sceneId;
	}
}

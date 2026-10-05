using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454E RID: 17742
	[Token(Token = "0x200454E")]
	public class GameSettleMissionStatus
	{
		// Token: 0x0601B0A6 RID: 110758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleMissionStatus()
		{
		}

		// Token: 0x04022BD5 RID: 142293
		[Token(Token = "0x4022BD5")]
		[FieldOffset(Offset = "0x10")]
		public bool before;

		// Token: 0x04022BD6 RID: 142294
		[Token(Token = "0x4022BD6")]
		[FieldOffset(Offset = "0x11")]
		public bool complete;

		// Token: 0x04022BD7 RID: 142295
		[Token(Token = "0x4022BD7")]
		[FieldOffset(Offset = "0x18")]
		public int[] process;
	}
}

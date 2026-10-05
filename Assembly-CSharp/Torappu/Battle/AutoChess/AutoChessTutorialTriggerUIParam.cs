using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200276F RID: 10095
	[Token(Token = "0x200276F")]
	public class AutoChessTutorialTriggerUIParam
	{
		// Token: 0x0601076C RID: 67436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601076C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessTutorialTriggerUIParam()
		{
		}

		// Token: 0x04012721 RID: 75553
		[Token(Token = "0x4012721")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessGameStateType stateType;

		// Token: 0x04012722 RID: 75554
		[Token(Token = "0x4012722")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessGameStatus.SubState subState;
	}
}

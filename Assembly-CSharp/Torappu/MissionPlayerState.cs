using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A89 RID: 2697
	[Token(Token = "0x2000A89")]
	public class MissionPlayerState
	{
		// Token: 0x06006743 RID: 26435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006743")]
		[Address(RVA = "0x1EEC240", Offset = "0x1EEAE40", VA = "0x181EEC240")]
		public MissionPlayerState()
		{
		}

		// Token: 0x0400391F RID: 14623
		[Token(Token = "0x400391F")]
		[FieldOffset(Offset = "0x10")]
		public MissionHoldingState state;

		// Token: 0x04003920 RID: 14624
		[Token(Token = "0x4003920")]
		[FieldOffset(Offset = "0x18")]
		public List<MissionCalcState> progress;
	}
}

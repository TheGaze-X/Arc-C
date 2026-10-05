using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009FD RID: 2557
	[Token(Token = "0x20009FD")]
	public class PlayerHiddenStage
	{
		// Token: 0x060066C1 RID: 26305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerHiddenStage()
		{
		}

		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		[FieldOffset(Offset = "0x10")]
		public List<MissionCalcState> missions;

		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		[FieldOffset(Offset = "0x18")]
		public int unlock;
	}
}

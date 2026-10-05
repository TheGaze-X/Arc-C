using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	public class PlayerBuildingControl
	{
		// Token: 0x06006716 RID: 26390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006716")]
		[Address(RVA = "0x1EF1670", Offset = "0x1EF0270", VA = "0x181EF1670")]
		public PlayerBuildingControl()
		{
		}

		// Token: 0x0400385C RID: 14428
		[Token(Token = "0x400385C")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingControlBuff buff;

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0x18")]
		public int apCost;

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x20")]
		public List<List<int>> presetQueue;
	}
}

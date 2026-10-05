using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009FA RID: 2554
	[Token(Token = "0x20009FA")]
	public class PlayerSixStarMilestone
	{
		// Token: 0x060066BF RID: 26303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x1EFE620", Offset = "0x1EFD220", VA = "0x181EFE620")]
		public PlayerSixStarMilestone()
		{
		}

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x10")]
		public int point;

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerSixStarMilestoneItem> rewards;
	}
}

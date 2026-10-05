using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B60 RID: 2912
	[Token(Token = "0x2000B60")]
	public class PlayerTower
	{
		// Token: 0x06006801 RID: 26625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006801")]
		[Address(RVA = "0x1EFF8B0", Offset = "0x1EFE4B0", VA = "0x181EFF8B0")]
		public PlayerTower()
		{
		}

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x10")]
		public TowerCurrent current;

		// Token: 0x04003C9C RID: 15516
		[Token(Token = "0x4003C9C")]
		[FieldOffset(Offset = "0x18")]
		public TowerOuter outer;

		// Token: 0x04003C9D RID: 15517
		[Token(Token = "0x4003C9D")]
		[FieldOffset(Offset = "0x20")]
		public TowerSeason season;
	}
}

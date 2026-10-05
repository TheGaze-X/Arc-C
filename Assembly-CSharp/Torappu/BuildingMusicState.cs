using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A84 RID: 2692
	[Token(Token = "0x2000A84")]
	public class BuildingMusicState
	{
		// Token: 0x0600673F RID: 26431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600673F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMusicState()
		{
		}

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x10")]
		public int[] progress;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x18")]
		public bool unlock;
	}
}

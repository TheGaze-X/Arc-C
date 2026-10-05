using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A7A RID: 2682
	[Token(Token = "0x2000A7A")]
	public class PlayerBuildingPrivate
	{
		// Token: 0x06006737 RID: 26423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006737")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingPrivate()
		{
		}

		// Token: 0x040038E0 RID: 14560
		[Token(Token = "0x40038E0")]
		[FieldOffset(Offset = "0x10")]
		public int[] owners;

		// Token: 0x040038E1 RID: 14561
		[Token(Token = "0x40038E1")]
		[FieldOffset(Offset = "0x18")]
		public int comfort;

		// Token: 0x040038E2 RID: 14562
		[Token(Token = "0x40038E2")]
		[FieldOffset(Offset = "0x20")]
		public PlayerBuildingDIYSolution diySolution;
	}
}

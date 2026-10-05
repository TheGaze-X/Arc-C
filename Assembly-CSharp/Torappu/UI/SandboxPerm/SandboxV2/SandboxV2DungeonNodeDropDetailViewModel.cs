using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042AE RID: 17070
	[Token(Token = "0x20042AE")]
	public class SandboxV2DungeonNodeDropDetailViewModel
	{
		// Token: 0x0601A46B RID: 107627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A46B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2DungeonNodeDropDetailViewModel()
		{
		}

		// Token: 0x040214B8 RID: 136376
		[Token(Token = "0x40214B8")]
		[FieldOffset(Offset = "0x10")]
		public bool hasEnemyRush;

		// Token: 0x040214B9 RID: 136377
		[Token(Token = "0x40214B9")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2DropDetail> enemyRushDrops;

		// Token: 0x040214BA RID: 136378
		[Token(Token = "0x40214BA")]
		[FieldOffset(Offset = "0x20")]
		public List<SandboxV2DropDetail> mainDrops;

		// Token: 0x040214BB RID: 136379
		[Token(Token = "0x40214BB")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2DropDetail> generalDrops;
	}
}

using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001293 RID: 4755
	[Token(Token = "0x2001293")]
	public class SandboxV2LivestockData
	{
		// Token: 0x0600720B RID: 29195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2LivestockData()
		{
		}

		// Token: 0x040068D0 RID: 26832
		[Token(Token = "0x40068D0")]
		[FieldOffset(Offset = "0x10")]
		public string livestockItemId;

		// Token: 0x040068D1 RID: 26833
		[Token(Token = "0x40068D1")]
		[FieldOffset(Offset = "0x18")]
		public string shinyLivestockItemId;

		// Token: 0x040068D2 RID: 26834
		[Token(Token = "0x40068D2")]
		[FieldOffset(Offset = "0x20")]
		public string livestockEnemyId;

		// Token: 0x040068D3 RID: 26835
		[Token(Token = "0x40068D3")]
		[FieldOffset(Offset = "0x28")]
		public string targetFenceId;
	}
}

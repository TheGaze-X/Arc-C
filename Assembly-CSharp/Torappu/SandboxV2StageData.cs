using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001295 RID: 4757
	[Token(Token = "0x2001295")]
	public class SandboxV2StageData
	{
		// Token: 0x0600720D RID: 29197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600720D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2StageData()
		{
		}

		// Token: 0x040068D9 RID: 26841
		[Token(Token = "0x40068D9")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040068DA RID: 26842
		[Token(Token = "0x40068DA")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x040068DB RID: 26843
		[Token(Token = "0x40068DB")]
		[FieldOffset(Offset = "0x20")]
		public string code;

		// Token: 0x040068DC RID: 26844
		[Token(Token = "0x40068DC")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x040068DD RID: 26845
		[Token(Token = "0x40068DD")]
		[FieldOffset(Offset = "0x30")]
		public string description;

		// Token: 0x040068DE RID: 26846
		[Token(Token = "0x40068DE")]
		[FieldOffset(Offset = "0x38")]
		public int actionCost;

		// Token: 0x040068DF RID: 26847
		[Token(Token = "0x40068DF")]
		[FieldOffset(Offset = "0x3C")]
		public int actionCostEnemyRush;
	}
}

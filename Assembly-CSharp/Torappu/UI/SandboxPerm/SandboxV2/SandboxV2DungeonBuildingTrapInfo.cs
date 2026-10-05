using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CE RID: 17102
	[Token(Token = "0x20042CE")]
	public struct SandboxV2DungeonBuildingTrapInfo
	{
		// Token: 0x0402159A RID: 136602
		[Token(Token = "0x402159A")]
		[FieldOffset(Offset = "0x0")]
		public bool isHomeTrap;

		// Token: 0x0402159B RID: 136603
		[Token(Token = "0x402159B")]
		[FieldOffset(Offset = "0x8")]
		public string trapMinItemId;

		// Token: 0x0402159C RID: 136604
		[Token(Token = "0x402159C")]
		[FieldOffset(Offset = "0x10")]
		public string trapName;

		// Token: 0x0402159D RID: 136605
		[Token(Token = "0x402159D")]
		[FieldOffset(Offset = "0x18")]
		public int currCount;

		// Token: 0x0402159E RID: 136606
		[Token(Token = "0x402159E")]
		[FieldOffset(Offset = "0x1C")]
		public int limitCount;

		// Token: 0x0402159F RID: 136607
		[Token(Token = "0x402159F")]
		[FieldOffset(Offset = "0x20")]
		public bool canUpgrade;

		// Token: 0x040215A0 RID: 136608
		[Token(Token = "0x40215A0")]
		[FieldOffset(Offset = "0x21")]
		public bool isDamaged;

		// Token: 0x040215A1 RID: 136609
		[Token(Token = "0x40215A1")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;
	}
}

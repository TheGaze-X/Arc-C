using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200419F RID: 16799
	[Token(Token = "0x200419F")]
	public class SandboxV2DungeonCrossDayHomeData : IHotfixable
	{
		// Token: 0x06019E92 RID: 106130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E92")]
		[Address(RVA = "0x12C2A70", Offset = "0x12C1670", VA = "0x1812C2A70")]
		public SandboxV2DungeonCrossDayHomeData()
		{
		}

		// Token: 0x04020991 RID: 133521
		[Token(Token = "0x4020991")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04020992 RID: 133522
		[Token(Token = "0x4020992")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04020993 RID: 133523
		[Token(Token = "0x4020993")]
		[FieldOffset(Offset = "0x1C")]
		public int rewardCount;

		// Token: 0x04020994 RID: 133524
		[Token(Token = "0x4020994")]
		[FieldOffset(Offset = "0x20")]
		public int rewardMax;

		// Token: 0x04020995 RID: 133525
		[Token(Token = "0x4020995")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

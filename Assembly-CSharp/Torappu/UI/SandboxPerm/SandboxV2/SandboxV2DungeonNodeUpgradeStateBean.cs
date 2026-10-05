using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F7 RID: 16887
	[Token(Token = "0x20041F7")]
	public class SandboxV2DungeonNodeUpgradeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A109 RID: 106761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A109")]
		[Address(RVA = "0x12EC8E0", Offset = "0x12EB4E0", VA = "0x1812EC8E0")]
		public SandboxV2DungeonNodeUpgradeStateBean()
		{
		}

		// Token: 0x04020D4C RID: 134476
		[Token(Token = "0x4020D4C")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04020D4D RID: 134477
		[Token(Token = "0x4020D4D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> upgrades;

		// Token: 0x04020D4E RID: 134478
		[Token(Token = "0x4020D4E")]
		[FieldOffset(Offset = "0x20")]
		public List<string> completedUpgrades;

		// Token: 0x04020D4F RID: 134479
		[Token(Token = "0x4020D4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

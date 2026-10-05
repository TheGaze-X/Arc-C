using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F3 RID: 16883
	[Token(Token = "0x20041F3")]
	public class SandboxV2DungeonNodeDropDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A0F7 RID: 106743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F7")]
		[Address(RVA = "0x12EBC30", Offset = "0x12EA830", VA = "0x1812EBC30")]
		public SandboxV2DungeonNodeDropDetailStateBean()
		{
		}

		// Token: 0x04020D2F RID: 134447
		[Token(Token = "0x4020D2F")]
		[FieldOffset(Offset = "0x10")]
		public bool hasEnemyRush;

		// Token: 0x04020D30 RID: 134448
		[Token(Token = "0x4020D30")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<SandboxV2DropDetail> enemyRushDrops;

		// Token: 0x04020D31 RID: 134449
		[Token(Token = "0x4020D31")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<SandboxV2DropDetail> mainDrops;

		// Token: 0x04020D32 RID: 134450
		[Token(Token = "0x4020D32")]
		[FieldOffset(Offset = "0x28")]
		public readonly List<SandboxV2DropDetail> generalDrops;

		// Token: 0x04020D33 RID: 134451
		[Token(Token = "0x4020D33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

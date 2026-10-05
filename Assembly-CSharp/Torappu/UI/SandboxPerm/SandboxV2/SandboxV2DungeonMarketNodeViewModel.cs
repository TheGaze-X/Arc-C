using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CA RID: 17098
	[Token(Token = "0x20042CA")]
	public class SandboxV2DungeonMarketNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4E0 RID: 107744 RVA: 0x000A0F98 File Offset: 0x0009F198
		[Token(Token = "0x601A4E0")]
		[Address(RVA = "0x132ED80", Offset = "0x132D980", VA = "0x18132ED80", Slot = "8")]
		protected override bool IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4E1 RID: 107745 RVA: 0x000A0FB0 File Offset: 0x0009F1B0
		[Token(Token = "0x601A4E1")]
		[Address(RVA = "0x132ED20", Offset = "0x132D920", VA = "0x18132ED20", Slot = "10")]
		protected override SandboxV2NodeStartBattleFuncType GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4E2 RID: 107746 RVA: 0x000A0FC8 File Offset: 0x0009F1C8
		[Token(Token = "0x601A4E2")]
		[Address(RVA = "0x132ECC0", Offset = "0x132D8C0", VA = "0x18132ECC0", Slot = "9")]
		protected override SandboxV2EnemyDetailShowType GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4E3 RID: 107747 RVA: 0x000A0FE0 File Offset: 0x0009F1E0
		[Token(Token = "0x601A4E3")]
		[Address(RVA = "0x132EC60", Offset = "0x132D860", VA = "0x18132EC60", Slot = "11")]
		protected override int GetNodeActionCost()
		{
			return 0;
		}

		// Token: 0x0601A4E4 RID: 107748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4E4")]
		[Address(RVA = "0x132EDE0", Offset = "0x132D9E0", VA = "0x18132EDE0")]
		public SandboxV2DungeonMarketNodeViewModel()
		{
		}

		// Token: 0x0601A4E5 RID: 107749 RVA: 0x000A0FF8 File Offset: 0x0009F1F8
		[Token(Token = "0x601A4E5")]
		[Address(RVA = "0x132A190", Offset = "0x1328D90", VA = "0x18132A190")]
		private bool <>xLuaBaseProxy_IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4E6 RID: 107750 RVA: 0x000A1010 File Offset: 0x0009F210
		[Token(Token = "0x601A4E6")]
		[Address(RVA = "0x132A0D0", Offset = "0x1328CD0", VA = "0x18132A0D0")]
		private SandboxV2NodeStartBattleFuncType <>xLuaBaseProxy_GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4E7 RID: 107751 RVA: 0x000A1028 File Offset: 0x0009F228
		[Token(Token = "0x601A4E7")]
		[Address(RVA = "0x132A070", Offset = "0x1328C70", VA = "0x18132A070")]
		private SandboxV2EnemyDetailShowType <>xLuaBaseProxy_GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4E8 RID: 107752 RVA: 0x000A1040 File Offset: 0x0009F240
		[Token(Token = "0x601A4E8")]
		[Address(RVA = "0x132A010", Offset = "0x1328C10", VA = "0x18132A010")]
		private int <>xLuaBaseProxy_GetNodeActionCost()
		{
			return 0;
		}

		// Token: 0x0402158E RID: 136590
		[Token(Token = "0x402158E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsUpgradable;

		// Token: 0x0402158F RID: 136591
		[Token(Token = "0x402158F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNodeStartBattleFuncType;

		// Token: 0x04021590 RID: 136592
		[Token(Token = "0x4021590")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNodeEnemyDetailShowType;

		// Token: 0x04021591 RID: 136593
		[Token(Token = "0x4021591")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNodeActionCost;

		// Token: 0x04021592 RID: 136594
		[Token(Token = "0x4021592")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

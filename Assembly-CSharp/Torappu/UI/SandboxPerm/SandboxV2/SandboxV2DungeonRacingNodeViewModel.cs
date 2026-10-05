using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CC RID: 17100
	[Token(Token = "0x20042CC")]
	public class SandboxV2DungeonRacingNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4EE RID: 107758 RVA: 0x000A10B8 File Offset: 0x0009F2B8
		[Token(Token = "0x601A4EE")]
		[Address(RVA = "0x133AB60", Offset = "0x1339760", VA = "0x18133AB60", Slot = "8")]
		protected override bool IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4EF RID: 107759 RVA: 0x000A10D0 File Offset: 0x0009F2D0
		[Token(Token = "0x601A4EF")]
		[Address(RVA = "0x133AAA0", Offset = "0x13396A0", VA = "0x18133AAA0", Slot = "9")]
		protected override SandboxV2EnemyDetailShowType GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4F0 RID: 107760 RVA: 0x000A10E8 File Offset: 0x0009F2E8
		[Token(Token = "0x601A4F0")]
		[Address(RVA = "0x133AB00", Offset = "0x1339700", VA = "0x18133AB00", Slot = "10")]
		protected override SandboxV2NodeStartBattleFuncType GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4F1 RID: 107761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4F1")]
		[Address(RVA = "0x133ABC0", Offset = "0x13397C0", VA = "0x18133ABC0")]
		public SandboxV2DungeonRacingNodeViewModel()
		{
		}

		// Token: 0x0601A4F2 RID: 107762 RVA: 0x000A1100 File Offset: 0x0009F300
		[Token(Token = "0x601A4F2")]
		[Address(RVA = "0x132A190", Offset = "0x1328D90", VA = "0x18132A190")]
		private bool <>xLuaBaseProxy_IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4F3 RID: 107763 RVA: 0x000A1118 File Offset: 0x0009F318
		[Token(Token = "0x601A4F3")]
		[Address(RVA = "0x132A070", Offset = "0x1328C70", VA = "0x18132A070")]
		private SandboxV2EnemyDetailShowType <>xLuaBaseProxy_GetNodeEnemyDetailShowType()
		{
			return SandboxV2EnemyDetailShowType.NONE;
		}

		// Token: 0x0601A4F4 RID: 107764 RVA: 0x000A1130 File Offset: 0x0009F330
		[Token(Token = "0x601A4F4")]
		[Address(RVA = "0x132A0D0", Offset = "0x1328CD0", VA = "0x18132A0D0")]
		private SandboxV2NodeStartBattleFuncType <>xLuaBaseProxy_GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x04021596 RID: 136598
		[Token(Token = "0x4021596")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsUpgradable;

		// Token: 0x04021597 RID: 136599
		[Token(Token = "0x4021597")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNodeEnemyDetailShowType;

		// Token: 0x04021598 RID: 136600
		[Token(Token = "0x4021598")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetNodeStartBattleFuncType;

		// Token: 0x04021599 RID: 136601
		[Token(Token = "0x4021599")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

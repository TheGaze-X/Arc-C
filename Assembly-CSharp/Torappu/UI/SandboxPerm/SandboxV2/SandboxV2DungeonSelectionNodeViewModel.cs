using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042CB RID: 17099
	[Token(Token = "0x20042CB")]
	public class SandboxV2DungeonSelectionNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4E9 RID: 107753 RVA: 0x000A1058 File Offset: 0x0009F258
		[Token(Token = "0x601A4E9")]
		[Address(RVA = "0x133BB40", Offset = "0x133A740", VA = "0x18133BB40", Slot = "8")]
		protected override bool IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4EA RID: 107754 RVA: 0x000A1070 File Offset: 0x0009F270
		[Token(Token = "0x601A4EA")]
		[Address(RVA = "0x133BAE0", Offset = "0x133A6E0", VA = "0x18133BAE0", Slot = "10")]
		protected override SandboxV2NodeStartBattleFuncType GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x0601A4EB RID: 107755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4EB")]
		[Address(RVA = "0x133BBA0", Offset = "0x133A7A0", VA = "0x18133BBA0")]
		public SandboxV2DungeonSelectionNodeViewModel()
		{
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x000A1088 File Offset: 0x0009F288
		[Token(Token = "0x601A4EC")]
		[Address(RVA = "0x132A190", Offset = "0x1328D90", VA = "0x18132A190")]
		private bool <>xLuaBaseProxy_IsUpgradable()
		{
			return default(bool);
		}

		// Token: 0x0601A4ED RID: 107757 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		[Token(Token = "0x601A4ED")]
		[Address(RVA = "0x132A0D0", Offset = "0x1328CD0", VA = "0x18132A0D0")]
		private SandboxV2NodeStartBattleFuncType <>xLuaBaseProxy_GetNodeStartBattleFuncType()
		{
			return SandboxV2NodeStartBattleFuncType.NONE;
		}

		// Token: 0x04021593 RID: 136595
		[Token(Token = "0x4021593")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsUpgradable;

		// Token: 0x04021594 RID: 136596
		[Token(Token = "0x4021594")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetNodeStartBattleFuncType;

		// Token: 0x04021595 RID: 136597
		[Token(Token = "0x4021595")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

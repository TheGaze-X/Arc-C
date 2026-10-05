using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042D5 RID: 17109
	[Token(Token = "0x20042D5")]
	public class SandboxV2DungeonOutpostNodeViewModel : SandboxV2DungeonConstructNodeViewModel
	{
		// Token: 0x0601A537 RID: 107831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A537")]
		[Address(RVA = "0x133A620", Offset = "0x1339220", VA = "0x18133A620", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A538 RID: 107832 RVA: 0x000A1400 File Offset: 0x0009F600
		[Token(Token = "0x601A538")]
		[Address(RVA = "0x133A5B0", Offset = "0x13391B0", VA = "0x18133A5B0", Slot = "21")]
		protected override bool SupportBuildingTrapType(SandboxV2TrapItemType buildingTrapType)
		{
			return default(bool);
		}

		// Token: 0x0601A539 RID: 107833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A539")]
		[Address(RVA = "0x133A770", Offset = "0x1339370", VA = "0x18133A770")]
		public SandboxV2DungeonOutpostNodeViewModel()
		{
		}

		// Token: 0x0601A53A RID: 107834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A53A")]
		[Address(RVA = "0x132A1F0", Offset = "0x1328DF0", VA = "0x18132A1F0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x040215D8 RID: 136664
		[Token(Token = "0x40215D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x040215D9 RID: 136665
		[Token(Token = "0x40215D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SupportBuildingTrapType;

		// Token: 0x040215DA RID: 136666
		[Token(Token = "0x40215DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

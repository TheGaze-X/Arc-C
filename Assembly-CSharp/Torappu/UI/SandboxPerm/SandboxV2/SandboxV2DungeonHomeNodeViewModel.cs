using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042D2 RID: 17106
	[Token(Token = "0x20042D2")]
	public class SandboxV2DungeonHomeNodeViewModel : SandboxV2DungeonConstructNodeViewModel
	{
		// Token: 0x0601A51E RID: 107806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A51E")]
		[Address(RVA = "0x132DE40", Offset = "0x132CA40", VA = "0x18132DE40", Slot = "6")]
		protected override string GetNodeDesc()
		{
			return null;
		}

		// Token: 0x0601A51F RID: 107807 RVA: 0x000A12F8 File Offset: 0x0009F4F8
		[Token(Token = "0x601A51F")]
		[Address(RVA = "0x132DC30", Offset = "0x132C830", VA = "0x18132DC30", Slot = "7")]
		protected override bool CanSelectWhenEmergency()
		{
			return default(bool);
		}

		// Token: 0x0601A520 RID: 107808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A520")]
		[Address(RVA = "0x132E020", Offset = "0x132CC20", VA = "0x18132E020", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A521 RID: 107809 RVA: 0x000A1310 File Offset: 0x0009F510
		[Token(Token = "0x601A521")]
		[Address(RVA = "0x132DED0", Offset = "0x132CAD0", VA = "0x18132DED0", Slot = "21")]
		protected override bool SupportBuildingTrapType(SandboxV2TrapItemType buildingTrapType)
		{
			return default(bool);
		}

		// Token: 0x0601A522 RID: 107810 RVA: 0x000A1328 File Offset: 0x0009F528
		[Token(Token = "0x601A522")]
		[Address(RVA = "0x132DC90", Offset = "0x132C890", VA = "0x18132DC90", Slot = "14")]
		public override Vector2 GetConnectorOffset(Vector2 otherNodePos)
		{
			return default(Vector2);
		}

		// Token: 0x0601A523 RID: 107811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A523")]
		[Address(RVA = "0x132E270", Offset = "0x132CE70", VA = "0x18132E270")]
		public SandboxV2DungeonHomeNodeViewModel()
		{
		}

		// Token: 0x0601A524 RID: 107812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A524")]
		[Address(RVA = "0x132DFC0", Offset = "0x132CBC0", VA = "0x18132DFC0")]
		private string <>xLuaBaseProxy_GetNodeDesc()
		{
			return null;
		}

		// Token: 0x0601A525 RID: 107813 RVA: 0x000A1340 File Offset: 0x0009F540
		[Token(Token = "0x601A525")]
		[Address(RVA = "0x132DF50", Offset = "0x132CB50", VA = "0x18132DF50")]
		private bool <>xLuaBaseProxy_CanSelectWhenEmergency()
		{
			return default(bool);
		}

		// Token: 0x0601A526 RID: 107814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A526")]
		[Address(RVA = "0x132A1F0", Offset = "0x1328DF0", VA = "0x18132A1F0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x0601A527 RID: 107815 RVA: 0x000A1358 File Offset: 0x0009F558
		[Token(Token = "0x601A527")]
		[Address(RVA = "0x132DFB0", Offset = "0x132CBB0", VA = "0x18132DFB0")]
		private Vector2 <>xLuaBaseProxy_GetConnectorOffset(Vector2 P0)
		{
			return default(Vector2);
		}

		// Token: 0x040215C1 RID: 136641
		[Token(Token = "0x40215C1")]
		private const int HOME_CONNECTOR_DISTANCE = 145;

		// Token: 0x040215C2 RID: 136642
		[Token(Token = "0x40215C2")]
		[FieldOffset(Offset = "0x120")]
		private string m_enemyRushNodeDesc;

		// Token: 0x040215C3 RID: 136643
		[Token(Token = "0x40215C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetNodeDesc;

		// Token: 0x040215C4 RID: 136644
		[Token(Token = "0x40215C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CanSelectWhenEmergency;

		// Token: 0x040215C5 RID: 136645
		[Token(Token = "0x40215C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x040215C6 RID: 136646
		[Token(Token = "0x40215C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SupportBuildingTrapType;

		// Token: 0x040215C7 RID: 136647
		[Token(Token = "0x40215C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetConnectorOffset;

		// Token: 0x040215C8 RID: 136648
		[Token(Token = "0x40215C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

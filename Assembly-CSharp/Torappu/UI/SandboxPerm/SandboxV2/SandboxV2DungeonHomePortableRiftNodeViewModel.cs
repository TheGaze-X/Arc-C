using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042D4 RID: 17108
	[Token(Token = "0x20042D4")]
	public class SandboxV2DungeonHomePortableRiftNodeViewModel : SandboxV2DungeonHomePortableNodeViewModel
	{
		// Token: 0x0601A530 RID: 107824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A530")]
		[Address(RVA = "0x132E9E0", Offset = "0x132D5E0", VA = "0x18132E9E0", Slot = "6")]
		protected override string GetNodeDesc()
		{
			return null;
		}

		// Token: 0x0601A531 RID: 107825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A531")]
		[Address(RVA = "0x132EAB0", Offset = "0x132D6B0", VA = "0x18132EAB0", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A532 RID: 107826 RVA: 0x000A13D0 File Offset: 0x0009F5D0
		[Token(Token = "0x601A532")]
		[Address(RVA = "0x132E830", Offset = "0x132D430", VA = "0x18132E830", Slot = "14")]
		public override Vector2 GetConnectorOffset(Vector2 otherNodePos)
		{
			return default(Vector2);
		}

		// Token: 0x0601A533 RID: 107827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A533")]
		[Address(RVA = "0x132EBC0", Offset = "0x132D7C0", VA = "0x18132EBC0")]
		public SandboxV2DungeonHomePortableRiftNodeViewModel()
		{
		}

		// Token: 0x0601A534 RID: 107828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A534")]
		[Address(RVA = "0x132DFC0", Offset = "0x132CBC0", VA = "0x18132DFC0")]
		private string <>xLuaBaseProxy_GetNodeDesc()
		{
			return null;
		}

		// Token: 0x0601A535 RID: 107829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A535")]
		[Address(RVA = "0x132EA70", Offset = "0x132D670", VA = "0x18132EA70")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x0601A536 RID: 107830 RVA: 0x000A13E8 File Offset: 0x0009F5E8
		[Token(Token = "0x601A536")]
		[Address(RVA = "0x132DFB0", Offset = "0x132CBB0", VA = "0x18132DFB0")]
		private Vector2 <>xLuaBaseProxy_GetConnectorOffset(Vector2 P0)
		{
			return default(Vector2);
		}

		// Token: 0x040215D1 RID: 136657
		[Token(Token = "0x40215D1")]
		private const int HOME_PORTABLE_RIFT_CONNECTOR_DISTANCE = 145;

		// Token: 0x040215D2 RID: 136658
		[Token(Token = "0x40215D2")]
		[FieldOffset(Offset = "0x140")]
		private string m_riftNodeDesc;

		// Token: 0x040215D3 RID: 136659
		[Token(Token = "0x40215D3")]
		[FieldOffset(Offset = "0x148")]
		private string m_riftEnemyRushNodeDesc;

		// Token: 0x040215D4 RID: 136660
		[Token(Token = "0x40215D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetNodeDesc;

		// Token: 0x040215D5 RID: 136661
		[Token(Token = "0x40215D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x040215D6 RID: 136662
		[Token(Token = "0x40215D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetConnectorOffset;

		// Token: 0x040215D7 RID: 136663
		[Token(Token = "0x40215D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

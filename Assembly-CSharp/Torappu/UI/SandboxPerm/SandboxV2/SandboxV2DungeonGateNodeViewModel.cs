using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C7 RID: 17095
	[Token(Token = "0x20042C7")]
	public class SandboxV2DungeonGateNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4CD RID: 107725 RVA: 0x000A0E78 File Offset: 0x0009F078
		[Token(Token = "0x601A4CD")]
		[Address(RVA = "0x132DA30", Offset = "0x132C630", VA = "0x18132DA30", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4CE RID: 107726 RVA: 0x000A0E90 File Offset: 0x0009F090
		[Token(Token = "0x601A4CE")]
		[Address(RVA = "0x132D9B0", Offset = "0x132C5B0", VA = "0x18132D9B0", Slot = "12")]
		protected override SandboxV2DungeonProgressViewModel GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4CF RID: 107727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4CF")]
		[Address(RVA = "0x132DA90", Offset = "0x132C690", VA = "0x18132DA90", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4D0 RID: 107728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4D0")]
		[Address(RVA = "0x132DBD0", Offset = "0x132C7D0", VA = "0x18132DBD0")]
		public SandboxV2DungeonGateNodeViewModel()
		{
		}

		// Token: 0x0601A4D1 RID: 107729 RVA: 0x000A0EA8 File Offset: 0x0009F0A8
		[Token(Token = "0x601A4D1")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4D2 RID: 107730 RVA: 0x000A0EC0 File Offset: 0x0009F0C0
		[Token(Token = "0x601A4D2")]
		[Address(RVA = "0x1329810", Offset = "0x1328410", VA = "0x181329810")]
		private SandboxV2DungeonProgressViewModel <>xLuaBaseProxy_GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4D3 RID: 107731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4D3")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x0402157F RID: 136575
		[Token(Token = "0x402157F")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isAllDead;

		// Token: 0x04021580 RID: 136576
		[Token(Token = "0x4021580")]
		[FieldOffset(Offset = "0xFC")]
		private SandboxV2DungeonProgressViewModel m_progressViewModel;

		// Token: 0x04021581 RID: 136577
		[Token(Token = "0x4021581")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x04021582 RID: 136578
		[Token(Token = "0x4021582")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProgressViewModel;

		// Token: 0x04021583 RID: 136579
		[Token(Token = "0x4021583")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x04021584 RID: 136580
		[Token(Token = "0x4021584")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

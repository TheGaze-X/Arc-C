using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C6 RID: 17094
	[Token(Token = "0x20042C6")]
	public class SandboxV2DungeonCaveNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4C6 RID: 107718 RVA: 0x000A0E18 File Offset: 0x0009F018
		[Token(Token = "0x601A4C6")]
		[Address(RVA = "0x13297B0", Offset = "0x13283B0", VA = "0x1813297B0", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4C7 RID: 107719 RVA: 0x000A0E30 File Offset: 0x0009F030
		[Token(Token = "0x601A4C7")]
		[Address(RVA = "0x1329730", Offset = "0x1328330", VA = "0x181329730", Slot = "12")]
		protected override SandboxV2DungeonProgressViewModel GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4C8 RID: 107720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4C8")]
		[Address(RVA = "0x1329930", Offset = "0x1328530", VA = "0x181329930", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4C9 RID: 107721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4C9")]
		[Address(RVA = "0x1329A70", Offset = "0x1328670", VA = "0x181329A70")]
		public SandboxV2DungeonCaveNodeViewModel()
		{
		}

		// Token: 0x0601A4CA RID: 107722 RVA: 0x000A0E48 File Offset: 0x0009F048
		[Token(Token = "0x601A4CA")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4CB RID: 107723 RVA: 0x000A0E60 File Offset: 0x0009F060
		[Token(Token = "0x601A4CB")]
		[Address(RVA = "0x1329810", Offset = "0x1328410", VA = "0x181329810")]
		private SandboxV2DungeonProgressViewModel <>xLuaBaseProxy_GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4CC RID: 107724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4CC")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x04021579 RID: 136569
		[Token(Token = "0x4021579")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isAllDead;

		// Token: 0x0402157A RID: 136570
		[Token(Token = "0x402157A")]
		[FieldOffset(Offset = "0xFC")]
		private SandboxV2DungeonProgressViewModel m_progressViewModel;

		// Token: 0x0402157B RID: 136571
		[Token(Token = "0x402157B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x0402157C RID: 136572
		[Token(Token = "0x402157C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProgressViewModel;

		// Token: 0x0402157D RID: 136573
		[Token(Token = "0x402157D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x0402157E RID: 136574
		[Token(Token = "0x402157E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

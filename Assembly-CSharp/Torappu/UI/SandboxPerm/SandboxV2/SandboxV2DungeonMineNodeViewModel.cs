using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C8 RID: 17096
	[Token(Token = "0x20042C8")]
	public class SandboxV2DungeonMineNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4D4 RID: 107732 RVA: 0x000A0ED8 File Offset: 0x0009F0D8
		[Token(Token = "0x601A4D4")]
		[Address(RVA = "0x132F5C0", Offset = "0x132E1C0", VA = "0x18132F5C0", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4D5 RID: 107733 RVA: 0x000A0EF0 File Offset: 0x0009F0F0
		[Token(Token = "0x601A4D5")]
		[Address(RVA = "0x132F540", Offset = "0x132E140", VA = "0x18132F540", Slot = "12")]
		protected override SandboxV2DungeonProgressViewModel GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4D6 RID: 107734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4D6")]
		[Address(RVA = "0x132F620", Offset = "0x132E220", VA = "0x18132F620", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4D7 RID: 107735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4D7")]
		[Address(RVA = "0x132F760", Offset = "0x132E360", VA = "0x18132F760")]
		public SandboxV2DungeonMineNodeViewModel()
		{
		}

		// Token: 0x0601A4D8 RID: 107736 RVA: 0x000A0F08 File Offset: 0x0009F108
		[Token(Token = "0x601A4D8")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4D9 RID: 107737 RVA: 0x000A0F20 File Offset: 0x0009F120
		[Token(Token = "0x601A4D9")]
		[Address(RVA = "0x1329810", Offset = "0x1328410", VA = "0x181329810")]
		private SandboxV2DungeonProgressViewModel <>xLuaBaseProxy_GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4DA RID: 107738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4DA")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x04021585 RID: 136581
		[Token(Token = "0x4021585")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isAllDead;

		// Token: 0x04021586 RID: 136582
		[Token(Token = "0x4021586")]
		[FieldOffset(Offset = "0xFC")]
		private SandboxV2DungeonProgressViewModel m_progressViewModel;

		// Token: 0x04021587 RID: 136583
		[Token(Token = "0x4021587")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x04021588 RID: 136584
		[Token(Token = "0x4021588")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProgressViewModel;

		// Token: 0x04021589 RID: 136585
		[Token(Token = "0x4021589")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x0402158A RID: 136586
		[Token(Token = "0x402158A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

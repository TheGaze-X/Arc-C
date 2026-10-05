using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C5 RID: 17093
	[Token(Token = "0x20042C5")]
	public class SandboxV2DungeonNestNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4BF RID: 107711 RVA: 0x000A0DB8 File Offset: 0x0009EFB8
		[Token(Token = "0x601A4BF")]
		[Address(RVA = "0x1333230", Offset = "0x1331E30", VA = "0x181333230", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4C0 RID: 107712 RVA: 0x000A0DD0 File Offset: 0x0009EFD0
		[Token(Token = "0x601A4C0")]
		[Address(RVA = "0x13331B0", Offset = "0x1331DB0", VA = "0x1813331B0", Slot = "12")]
		protected override SandboxV2DungeonProgressViewModel GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4C1 RID: 107713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4C1")]
		[Address(RVA = "0x1333290", Offset = "0x1331E90", VA = "0x181333290", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4C2 RID: 107714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4C2")]
		[Address(RVA = "0x13333D0", Offset = "0x1331FD0", VA = "0x1813333D0")]
		public SandboxV2DungeonNestNodeViewModel()
		{
		}

		// Token: 0x0601A4C3 RID: 107715 RVA: 0x000A0DE8 File Offset: 0x0009EFE8
		[Token(Token = "0x601A4C3")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4C4 RID: 107716 RVA: 0x000A0E00 File Offset: 0x0009F000
		[Token(Token = "0x601A4C4")]
		[Address(RVA = "0x1329810", Offset = "0x1328410", VA = "0x181329810")]
		private SandboxV2DungeonProgressViewModel <>xLuaBaseProxy_GetProgressViewModel()
		{
			return default(SandboxV2DungeonProgressViewModel);
		}

		// Token: 0x0601A4C5 RID: 107717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4C5")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x04021573 RID: 136563
		[Token(Token = "0x4021573")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isAllDead;

		// Token: 0x04021574 RID: 136564
		[Token(Token = "0x4021574")]
		[FieldOffset(Offset = "0xFC")]
		private SandboxV2DungeonProgressViewModel m_progressViewModel;

		// Token: 0x04021575 RID: 136565
		[Token(Token = "0x4021575")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x04021576 RID: 136566
		[Token(Token = "0x4021576")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProgressViewModel;

		// Token: 0x04021577 RID: 136567
		[Token(Token = "0x4021577")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x04021578 RID: 136568
		[Token(Token = "0x4021578")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

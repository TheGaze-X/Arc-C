using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042C3 RID: 17091
	[Token(Token = "0x20042C3")]
	public class SandboxV2DungeonResourceNodeViewModel : SandboxV2DungeonNodeViewModel
	{
		// Token: 0x0601A4B7 RID: 107703 RVA: 0x000A0D58 File Offset: 0x0009EF58
		[Token(Token = "0x601A4B7")]
		[Address(RVA = "0x133B500", Offset = "0x133A100", VA = "0x18133B500", Slot = "5")]
		protected override bool IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4B8 RID: 107704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4B8")]
		[Address(RVA = "0x133B560", Offset = "0x133A160", VA = "0x18133B560", Slot = "13")]
		protected override void UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A4B9 RID: 107705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4B9")]
		[Address(RVA = "0x133B6A0", Offset = "0x133A2A0", VA = "0x18133B6A0")]
		public SandboxV2DungeonResourceNodeViewModel()
		{
		}

		// Token: 0x0601A4BA RID: 107706 RVA: 0x000A0D70 File Offset: 0x0009EF70
		[Token(Token = "0x601A4BA")]
		[Address(RVA = "0x1329670", Offset = "0x1328270", VA = "0x181329670")]
		private bool <>xLuaBaseProxy_IsCleared()
		{
			return default(bool);
		}

		// Token: 0x0601A4BB RID: 107707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A4BB")]
		[Address(RVA = "0x13298A0", Offset = "0x13284A0", VA = "0x1813298A0")]
		private void <>xLuaBaseProxy_UpdateCustomData(SandboxV2DungeonNodeViewModel.UpdateParam P0)
		{
		}

		// Token: 0x0402156D RID: 136557
		[Token(Token = "0x402156D")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_cleared;

		// Token: 0x0402156E RID: 136558
		[Token(Token = "0x402156E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsCleared;

		// Token: 0x0402156F RID: 136559
		[Token(Token = "0x402156F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateCustomData;

		// Token: 0x04021570 RID: 136560
		[Token(Token = "0x4021570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

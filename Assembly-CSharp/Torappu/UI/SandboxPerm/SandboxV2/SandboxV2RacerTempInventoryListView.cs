using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200437A RID: 17274
	[Token(Token = "0x200437A")]
	public class SandboxV2RacerTempInventoryListView : SandboxV2RacerInventoryListBaseView<SandboxV2RacerTempInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A864 RID: 108644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A864")]
		[Address(RVA = "0x13AD200", Offset = "0x13ABE00", VA = "0x1813AD200", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerTempInventoryProperty property)
		{
		}

		// Token: 0x0601A865 RID: 108645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A865")]
		[Address(RVA = "0x13AD3A0", Offset = "0x13ABFA0", VA = "0x1813AD3A0")]
		public SandboxV2RacerTempInventoryListView()
		{
		}

		// Token: 0x04021C18 RID: 138264
		[Token(Token = "0x4021C18")]
		[FieldOffset(Offset = "0x40")]
		private int m_focusSequenceNum;

		// Token: 0x04021C19 RID: 138265
		[Token(Token = "0x4021C19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021C1A RID: 138266
		[Token(Token = "0x4021C1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

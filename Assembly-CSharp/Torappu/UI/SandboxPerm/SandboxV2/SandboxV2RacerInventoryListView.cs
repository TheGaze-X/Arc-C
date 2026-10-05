using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004358 RID: 17240
	[Token(Token = "0x2004358")]
	public class SandboxV2RacerInventoryListView : SandboxV2RacerInventoryListBaseView<SandboxV2RacerInventoryProperty>, IHotfixable
	{
		// Token: 0x0601A76A RID: 108394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76A")]
		[Address(RVA = "0x138FC30", Offset = "0x138E830", VA = "0x18138FC30", Slot = "7")]
		public override void OnValueChanged(SandboxV2RacerInventoryProperty property)
		{
		}

		// Token: 0x0601A76B RID: 108395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A76B")]
		[Address(RVA = "0x138FE70", Offset = "0x138EA70", VA = "0x18138FE70")]
		public SandboxV2RacerInventoryListView()
		{
		}

		// Token: 0x04021AA9 RID: 137897
		[Token(Token = "0x4021AA9")]
		[FieldOffset(Offset = "0x40")]
		private int m_focusSequenceNum;

		// Token: 0x04021AAA RID: 137898
		[Token(Token = "0x4021AAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021AAB RID: 137899
		[Token(Token = "0x4021AAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

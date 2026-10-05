using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200439E RID: 17310
	[Token(Token = "0x200439E")]
	public class SandboxV2RiftEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A922 RID: 108834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A922")]
		[Address(RVA = "0x13B3E70", Offset = "0x13B2A70", VA = "0x1813B3E70")]
		public SandboxV2RiftEntryStateBean()
		{
		}

		// Token: 0x04021D94 RID: 138644
		[Token(Token = "0x4021D94")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RiftEntryProperty property;

		// Token: 0x04021D95 RID: 138645
		[Token(Token = "0x4021D95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

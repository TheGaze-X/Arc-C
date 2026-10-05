using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043A3 RID: 17315
	[Token(Token = "0x20043A3")]
	public class SandboxV2RiftTeamSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601A92C RID: 108844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A92C")]
		[Address(RVA = "0x13B8280", Offset = "0x13B6E80", VA = "0x1813B8280")]
		public SandboxV2RiftTeamSelectStateBean()
		{
		}

		// Token: 0x04021DB7 RID: 138679
		[Token(Token = "0x4021DB7")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RiftTeamSelectProperty property;

		// Token: 0x04021DB8 RID: 138680
		[Token(Token = "0x4021DB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004181 RID: 16769
	[Token(Token = "0x2004181")]
	public class SandboxV2RiftSettleStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06019E0C RID: 105996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E0C")]
		[Address(RVA = "0x12C75B0", Offset = "0x12C61B0", VA = "0x1812C75B0")]
		public SandboxV2RiftSettleStateBean()
		{
		}

		// Token: 0x0402086A RID: 133226
		[Token(Token = "0x402086A")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2RiftSettleProperty property;

		// Token: 0x0402086B RID: 133227
		[Token(Token = "0x402086B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040EB RID: 16619
	[Token(Token = "0x20040EB")]
	public class SandboxV2AdminMainWorkbenchInitParam : ISandboxV2AdminMainTabPanelInitParam, IHotfixable
	{
		// Token: 0x06019B3E RID: 105278 RVA: 0x0009F1E0 File Offset: 0x0009D3E0
		[Token(Token = "0x6019B3E")]
		[Address(RVA = "0x128DCD0", Offset = "0x128C8D0", VA = "0x18128DCD0")]
		public bool CheckTypeActive(SandboxV2AdminMainWorkbenchType type)
		{
			return default(bool);
		}

		// Token: 0x06019B3F RID: 105279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B3F")]
		[Address(RVA = "0x128DD70", Offset = "0x128C970", VA = "0x18128DD70")]
		public SandboxV2AdminMainWorkbenchInitParam()
		{
		}

		// Token: 0x04020284 RID: 131716
		[Token(Token = "0x4020284")]
		[FieldOffset(Offset = "0x10")]
		public IList<SandboxV2AdminMainWorkbenchType> activeTypeList;

		// Token: 0x04020285 RID: 131717
		[Token(Token = "0x4020285")]
		[FieldOffset(Offset = "0x18")]
		public bool autoSquad;

		// Token: 0x04020286 RID: 131718
		[Token(Token = "0x4020286")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x04020287 RID: 131719
		[Token(Token = "0x4020287")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

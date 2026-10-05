using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004135 RID: 16693
	[Token(Token = "0x2004135")]
	public abstract class SandboxV2ConfirmDialogDecoViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C6B RID: 105579
		[Token(Token = "0x6019C6B")]
		public abstract void RenderDecoView(object param);

		// Token: 0x06019C6C RID: 105580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C6C")]
		[Address(RVA = "0x12A8BB0", Offset = "0x12A77B0", VA = "0x1812A8BB0")]
		protected SandboxV2ConfirmDialogDecoViewBase()
		{
		}

		// Token: 0x04020542 RID: 132418
		[Token(Token = "0x4020542")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

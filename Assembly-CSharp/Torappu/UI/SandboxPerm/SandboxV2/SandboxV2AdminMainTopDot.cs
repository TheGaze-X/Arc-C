using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B5 RID: 16565
	[Token(Token = "0x20040B5")]
	public class SandboxV2AdminMainTopDot : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019A0A RID: 104970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0A")]
		[Address(RVA = "0x12896E0", Offset = "0x12882E0", VA = "0x1812896E0")]
		public void Render(SandboxV2AdminMainPanelType showPanel)
		{
		}

		// Token: 0x06019A0B RID: 104971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A0B")]
		[Address(RVA = "0x1289790", Offset = "0x1288390", VA = "0x181289790")]
		public SandboxV2AdminMainTopDot()
		{
		}

		// Token: 0x04020047 RID: 131143
		[Token(Token = "0x4020047")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminMainPanelType _panelType;

		// Token: 0x04020048 RID: 131144
		[Token(Token = "0x4020048")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _dot;

		// Token: 0x04020049 RID: 131145
		[Token(Token = "0x4020049")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402004A RID: 131146
		[Token(Token = "0x402004A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

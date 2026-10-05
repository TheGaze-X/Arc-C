using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200420E RID: 16910
	[Token(Token = "0x200420E")]
	public class SandboxV2TopBarSphereDecisionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A16C RID: 106860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16C")]
		[Address(RVA = "0x12F8BD0", Offset = "0x12F77D0", VA = "0x1812F8BD0")]
		public void Render(bool isLight)
		{
		}

		// Token: 0x0601A16D RID: 106861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A16D")]
		[Address(RVA = "0x12F8C60", Offset = "0x12F7860", VA = "0x1812F8C60")]
		public SandboxV2TopBarSphereDecisionView()
		{
		}

		// Token: 0x04020E35 RID: 134709
		[Token(Token = "0x4020E35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLight;

		// Token: 0x04020E36 RID: 134710
		[Token(Token = "0x4020E36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelDark;

		// Token: 0x04020E37 RID: 134711
		[Token(Token = "0x4020E37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E38 RID: 134712
		[Token(Token = "0x4020E38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

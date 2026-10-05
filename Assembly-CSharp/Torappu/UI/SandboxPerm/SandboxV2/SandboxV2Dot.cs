using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200411D RID: 16669
	[Token(Token = "0x200411D")]
	public class SandboxV2Dot : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C1D RID: 105501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C1D")]
		[Address(RVA = "0x1297940", Offset = "0x1296540", VA = "0x181297940")]
		public void Render(bool selected, bool complete)
		{
		}

		// Token: 0x06019C1E RID: 105502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C1E")]
		[Address(RVA = "0x1297A90", Offset = "0x1296690", VA = "0x181297A90")]
		public SandboxV2Dot()
		{
		}

		// Token: 0x04020489 RID: 132233
		[Token(Token = "0x4020489")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Graphic _normalGraphic;

		// Token: 0x0402048A RID: 132234
		[Token(Token = "0x402048A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Graphic _selectedGraphic;

		// Token: 0x0402048B RID: 132235
		[Token(Token = "0x402048B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _completedGraphic;

		// Token: 0x0402048C RID: 132236
		[Token(Token = "0x402048C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDur;

		// Token: 0x0402048D RID: 132237
		[Token(Token = "0x402048D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402048E RID: 132238
		[Token(Token = "0x402048E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

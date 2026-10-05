using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004213 RID: 16915
	[Token(Token = "0x2004213")]
	public class SandboxV2TopBarStateBindingPanel : SandboxV2StateBindingPanel
	{
		// Token: 0x0601A188 RID: 106888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A188")]
		[Address(RVA = "0x1311270", Offset = "0x130FE70", VA = "0x181311270", Slot = "4")]
		public override void SetShow(bool isShow)
		{
		}

		// Token: 0x0601A189 RID: 106889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A189")]
		[Address(RVA = "0x1311300", Offset = "0x130FF00", VA = "0x181311300")]
		public SandboxV2TopBarStateBindingPanel()
		{
		}

		// Token: 0x04020E79 RID: 134777
		[Token(Token = "0x4020E79")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04020E7A RID: 134778
		[Token(Token = "0x4020E7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04020E7B RID: 134779
		[Token(Token = "0x4020E7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

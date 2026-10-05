using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200414F RID: 16719
	[Token(Token = "0x200414F")]
	public class SandboxV2BasementUpgradePreviewItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D1D RID: 105757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D1D")]
		[Address(RVA = "0x12A4710", Offset = "0x12A3310", VA = "0x1812A4710")]
		public void Render(SandboxV2BaseFunctionPreviewData previewData)
		{
		}

		// Token: 0x06019D1E RID: 105758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D1E")]
		[Address(RVA = "0x12A4960", Offset = "0x12A3560", VA = "0x1812A4960")]
		public SandboxV2BasementUpgradePreviewItemView()
		{
		}

		// Token: 0x0402069D RID: 132765
		[Token(Token = "0x402069D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _darkModeBgColor;

		// Token: 0x0402069E RID: 132766
		[Token(Token = "0x402069E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _lightModeBgColor;

		// Token: 0x0402069F RID: 132767
		[Token(Token = "0x402069F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _darkModeTextColor;

		// Token: 0x040206A0 RID: 132768
		[Token(Token = "0x40206A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _lightModeTextColor;

		// Token: 0x040206A1 RID: 132769
		[Token(Token = "0x40206A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x040206A2 RID: 132770
		[Token(Token = "0x40206A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _content;

		// Token: 0x040206A3 RID: 132771
		[Token(Token = "0x40206A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objArrow;

		// Token: 0x040206A4 RID: 132772
		[Token(Token = "0x40206A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _txtCnt;

		// Token: 0x040206A5 RID: 132773
		[Token(Token = "0x40206A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040206A6 RID: 132774
		[Token(Token = "0x40206A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

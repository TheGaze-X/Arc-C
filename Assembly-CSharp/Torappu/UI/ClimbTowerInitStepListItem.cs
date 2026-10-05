using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200349E RID: 13470
	[Token(Token = "0x200349E")]
	public class ClimbTowerInitStepListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015790 RID: 87952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015790")]
		[Address(RVA = "0xDE9870", Offset = "0xDE8470", VA = "0x180DE9870")]
		public void Render(int stepVal, bool isLast, bool isSelected)
		{
		}

		// Token: 0x06015791 RID: 87953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015791")]
		[Address(RVA = "0xDE99E0", Offset = "0xDE85E0", VA = "0x180DE99E0")]
		public ClimbTowerInitStepListItem()
		{
		}

		// Token: 0x04019B54 RID: 105300
		[Token(Token = "0x4019B54")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x04019B55 RID: 105301
		[Token(Token = "0x4019B55")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStep;

		// Token: 0x04019B56 RID: 105302
		[Token(Token = "0x4019B56")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _unselectedAlpha;

		// Token: 0x04019B57 RID: 105303
		[Token(Token = "0x4019B57")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _dotGo;

		// Token: 0x04019B58 RID: 105304
		[Token(Token = "0x4019B58")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04019B59 RID: 105305
		[Token(Token = "0x4019B59")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _normalWidth;

		// Token: 0x04019B5A RID: 105306
		[Token(Token = "0x4019B5A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _lastWidth;

		// Token: 0x04019B5B RID: 105307
		[Token(Token = "0x4019B5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04019B5C RID: 105308
		[Token(Token = "0x4019B5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

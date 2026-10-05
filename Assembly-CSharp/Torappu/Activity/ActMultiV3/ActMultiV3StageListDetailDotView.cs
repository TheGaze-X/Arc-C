using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FE4 RID: 28644
	[Token(Token = "0x2006FE4")]
	public class ActMultiV3StageListDetailDotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028AEF RID: 166639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AEF")]
		[Address(RVA = "0x23FF4F0", Offset = "0x23FE0F0", VA = "0x1823FF4F0")]
		public void Render(int idx, ActMultiV3StageListDetailStateViewModel viewModel)
		{
		}

		// Token: 0x06028AF0 RID: 166640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF0")]
		[Address(RVA = "0x23FF660", Offset = "0x23FE260", VA = "0x1823FF660")]
		public ActMultiV3StageListDetailDotView()
		{
		}

		// Token: 0x04039F91 RID: 237457
		[Token(Token = "0x4039F91")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgDot;

		// Token: 0x04039F92 RID: 237458
		[Token(Token = "0x4039F92")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x04039F93 RID: 237459
		[Token(Token = "0x4039F93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x04039F94 RID: 237460
		[Token(Token = "0x4039F94")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04039F95 RID: 237461
		[Token(Token = "0x4039F95")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _widthNormal;

		// Token: 0x04039F96 RID: 237462
		[Token(Token = "0x4039F96")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _widthSeperator;

		// Token: 0x04039F97 RID: 237463
		[Token(Token = "0x4039F97")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlSeparator;

		// Token: 0x04039F98 RID: 237464
		[Token(Token = "0x4039F98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039F99 RID: 237465
		[Token(Token = "0x4039F99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

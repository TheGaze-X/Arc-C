using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007511 RID: 29969
	[Token(Token = "0x2007511")]
	public class Act25sideItemCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A3CB RID: 173003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CB")]
		[Address(RVA = "0x25DEC30", Offset = "0x25DD830", VA = "0x1825DEC30")]
		public void Render(int index, UIItemViewModel itemViewModel, bool isGain)
		{
		}

		// Token: 0x0602A3CC RID: 173004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CC")]
		[Address(RVA = "0x25DF140", Offset = "0x25DDD40", VA = "0x1825DF140")]
		private void _OnItemClick(int index)
		{
		}

		// Token: 0x0602A3CD RID: 173005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CD")]
		[Address(RVA = "0x25DEFC0", Offset = "0x25DDBC0", VA = "0x1825DEFC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A3CE RID: 173006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A3CE")]
		[Address(RVA = "0x25DF1E0", Offset = "0x25DDDE0", VA = "0x1825DF1E0")]
		public Act25sideItemCardView()
		{
		}

		// Token: 0x0403CB3B RID: 248635
		[Token(Token = "0x403CB3B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelGain;

		// Token: 0x0403CB3C RID: 248636
		[Token(Token = "0x403CB3C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0403CB3D RID: 248637
		[Token(Token = "0x403CB3D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x0403CB3E RID: 248638
		[Token(Token = "0x403CB3E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _inactiveAlpha;

		// Token: 0x0403CB3F RID: 248639
		[Token(Token = "0x403CB3F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _scale;

		// Token: 0x0403CB40 RID: 248640
		[Token(Token = "0x403CB40")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403CB41 RID: 248641
		[Token(Token = "0x403CB41")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_itemCard;

		// Token: 0x0403CB42 RID: 248642
		[Token(Token = "0x403CB42")]
		[FieldOffset(Offset = "0x48")]
		private UIScaler m_scaler;

		// Token: 0x0403CB43 RID: 248643
		[Token(Token = "0x403CB43")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403CB44 RID: 248644
		[Token(Token = "0x403CB44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CB45 RID: 248645
		[Token(Token = "0x403CB45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0403CB46 RID: 248646
		[Token(Token = "0x403CB46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CB47 RID: 248647
		[Token(Token = "0x403CB47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

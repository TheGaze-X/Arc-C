using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD6 RID: 15574
	[Token(Token = "0x2003CD6")]
	public class TuningProductFragItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018488 RID: 99464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018488")]
		[Address(RVA = "0x10C9FE0", Offset = "0x10C8BE0", VA = "0x1810C9FE0")]
		public void Render(TuningFragModel model)
		{
		}

		// Token: 0x06018489 RID: 99465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018489")]
		[Address(RVA = "0x10CA500", Offset = "0x10C9100", VA = "0x1810CA500")]
		private void _SelectNumShow(bool isShow)
		{
		}

		// Token: 0x0601848A RID: 99466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848A")]
		[Address(RVA = "0x10CA400", Offset = "0x10C9000", VA = "0x1810CA400")]
		public void SelectFrag()
		{
		}

		// Token: 0x0601848B RID: 99467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601848B")]
		[Address(RVA = "0x10CA5F0", Offset = "0x10C91F0", VA = "0x1810CA5F0")]
		public TuningProductFragItemView()
		{
		}

		// Token: 0x0401DA3A RID: 121402
		[Token(Token = "0x401DA3A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _fragNameText;

		// Token: 0x0401DA3B RID: 121403
		[Token(Token = "0x401DA3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _fragNumText;

		// Token: 0x0401DA3C RID: 121404
		[Token(Token = "0x401DA3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _fragSelectText;

		// Token: 0x0401DA3D RID: 121405
		[Token(Token = "0x401DA3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _fragImage;

		// Token: 0x0401DA3E RID: 121406
		[Token(Token = "0x401DA3E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _emptyTextColor;

		// Token: 0x0401DA3F RID: 121407
		[Token(Token = "0x401DA3F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _nonEmptyTextColor;

		// Token: 0x0401DA40 RID: 121408
		[Token(Token = "0x401DA40")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _emptyFragImageAlpha;

		// Token: 0x0401DA41 RID: 121409
		[Token(Token = "0x401DA41")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _nonEmptyFragImageAlpha;

		// Token: 0x0401DA42 RID: 121410
		[Token(Token = "0x401DA42")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0401DA43 RID: 121411
		[Token(Token = "0x401DA43")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _nonEmptyPanel;

		// Token: 0x0401DA44 RID: 121412
		[Token(Token = "0x401DA44")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _selectNumGroup;

		// Token: 0x0401DA45 RID: 121413
		[Token(Token = "0x401DA45")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _showAlpha;

		// Token: 0x0401DA46 RID: 121414
		[Token(Token = "0x401DA46")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _hideAlpha;

		// Token: 0x0401DA47 RID: 121415
		[Token(Token = "0x401DA47")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x0401DA48 RID: 121416
		[Token(Token = "0x401DA48")]
		[FieldOffset(Offset = "0x88")]
		private TuningFragModel m_cachedModel;

		// Token: 0x0401DA49 RID: 121417
		[Token(Token = "0x401DA49")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DA4A RID: 121418
		[Token(Token = "0x401DA4A")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401DA4B RID: 121419
		[Token(Token = "0x401DA4B")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_showTween;

		// Token: 0x0401DA4C RID: 121420
		[Token(Token = "0x401DA4C")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedIsShow;

		// Token: 0x0401DA4D RID: 121421
		[Token(Token = "0x401DA4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA4E RID: 121422
		[Token(Token = "0x401DA4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SelectNumShow;

		// Token: 0x0401DA4F RID: 121423
		[Token(Token = "0x401DA4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectFrag;

		// Token: 0x0401DA50 RID: 121424
		[Token(Token = "0x401DA50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

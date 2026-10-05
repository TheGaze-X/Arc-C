using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CE5 RID: 19685
	[Token(Token = "0x2004CE5")]
	public class GroceryOrderResultShopItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D810 RID: 120848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D810")]
		[Address(RVA = "0x17117B0", Offset = "0x17103B0", VA = "0x1817117B0")]
		public void Render(GroceryOrderResultShopItemViewModel itemViewModel, bool isLastOne)
		{
		}

		// Token: 0x0601D811 RID: 120849 RVA: 0x000ABBE8 File Offset: 0x000A9DE8
		[Token(Token = "0x601D811")]
		[Address(RVA = "0x17115B0", Offset = "0x17101B0", VA = "0x1817115B0")]
		public bool NeedPlayTween()
		{
			return default(bool);
		}

		// Token: 0x0601D812 RID: 120850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D812")]
		[Address(RVA = "0x1711640", Offset = "0x1710240", VA = "0x181711640")]
		public void PlaySliderCountChangeTween()
		{
		}

		// Token: 0x0601D813 RID: 120851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D813")]
		[Address(RVA = "0x1711C00", Offset = "0x1710800", VA = "0x181711C00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D814 RID: 120852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D814")]
		[Address(RVA = "0x1711E10", Offset = "0x1710A10", VA = "0x181711E10")]
		private void _PlaySelfIconLoopTween(bool show)
		{
		}

		// Token: 0x0601D815 RID: 120853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D815")]
		[Address(RVA = "0x1711FD0", Offset = "0x1710BD0", VA = "0x181711FD0")]
		public GroceryOrderResultShopItemView()
		{
		}

		// Token: 0x04026EA8 RID: 159400
		[Token(Token = "0x4026EA8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objEmpty;

		// Token: 0x04026EA9 RID: 159401
		[Token(Token = "0x4026EA9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNotEmpty;

		// Token: 0x04026EAA RID: 159402
		[Token(Token = "0x4026EAA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgShopIcon;

		// Token: 0x04026EAB RID: 159403
		[Token(Token = "0x4026EAB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtStrategy;

		// Token: 0x04026EAC RID: 159404
		[Token(Token = "0x4026EAC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCount;

		// Token: 0x04026EAD RID: 159405
		[Token(Token = "0x4026EAD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtPrice;

		// Token: 0x04026EAE RID: 159406
		[Token(Token = "0x4026EAE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04026EAF RID: 159407
		[Token(Token = "0x4026EAF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _sliderImg;

		// Token: 0x04026EB0 RID: 159408
		[Token(Token = "0x4026EB0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _animSelfShopIconLoop;

		// Token: 0x04026EB1 RID: 159409
		[Token(Token = "0x4026EB1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objSplit;

		// Token: 0x04026EB2 RID: 159410
		[Token(Token = "0x4026EB2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasTxtCount;

		// Token: 0x04026EB3 RID: 159411
		[Token(Token = "0x4026EB3")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x04026EB4 RID: 159412
		[Token(Token = "0x4026EB4")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026EB5 RID: 159413
		[Token(Token = "0x4026EB5")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_loopSelfShopIconTween;

		// Token: 0x04026EB6 RID: 159414
		[Token(Token = "0x4026EB6")]
		private const float COUNT_CHANGE_DUR = 1f;

		// Token: 0x04026EB7 RID: 159415
		[Token(Token = "0x4026EB7")]
		[FieldOffset(Offset = "0x98")]
		private GroceryOrderCountTextTweener m_countTextTweener;

		// Token: 0x04026EB8 RID: 159416
		[Token(Token = "0x4026EB8")]
		[FieldOffset(Offset = "0xA0")]
		private GroceryOrderResultSliderCountTweener m_sliderCountTweener;

		// Token: 0x04026EB9 RID: 159417
		[Token(Token = "0x4026EB9")]
		[FieldOffset(Offset = "0xA8")]
		private GroceryOrderResultShopItemViewModel m_cachedModel;

		// Token: 0x04026EBA RID: 159418
		[Token(Token = "0x4026EBA")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_tweenTxtCount;

		// Token: 0x04026EBB RID: 159419
		[Token(Token = "0x4026EBB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_OTHER_SLIDER;

		// Token: 0x04026EBC RID: 159420
		[Token(Token = "0x4026EBC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_MY_SLIDER;

		// Token: 0x04026EBD RID: 159421
		[Token(Token = "0x4026EBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026EBE RID: 159422
		[Token(Token = "0x4026EBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NeedPlayTween;

		// Token: 0x04026EBF RID: 159423
		[Token(Token = "0x4026EBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlaySliderCountChangeTween;

		// Token: 0x04026EC0 RID: 159424
		[Token(Token = "0x4026EC0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026EC1 RID: 159425
		[Token(Token = "0x4026EC1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlaySelfIconLoopTween;

		// Token: 0x04026EC2 RID: 159426
		[Token(Token = "0x4026EC2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

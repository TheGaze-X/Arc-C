using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077B4 RID: 30644
	[Token(Token = "0x20077B4")]
	public class Act1VHalfIdleIncomeGraphItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B04D RID: 176205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B04D")]
		[Address(RVA = "0x26D15D0", Offset = "0x26D01D0", VA = "0x1826D15D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B04E RID: 176206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B04E")]
		[Address(RVA = "0x26D1B50", Offset = "0x26D0750", VA = "0x1826D1B50")]
		private void _SetBarRectHeight(float fillAmount, RectTransform rect)
		{
		}

		// Token: 0x0602B04F RID: 176207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B04F")]
		[Address(RVA = "0x26D1670", Offset = "0x26D0270", VA = "0x1826D1670")]
		private Tween _PlayBarTween(float from, float to, RectTransform rect)
		{
			return null;
		}

		// Token: 0x0602B050 RID: 176208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B050")]
		[Address(RVA = "0x26D1C10", Offset = "0x26D0810", VA = "0x1826D1C10")]
		private Tween _WrapDealyTween(Tween tween, float delay)
		{
			return null;
		}

		// Token: 0x0602B051 RID: 176209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B051")]
		[Address(RVA = "0x26D1A50", Offset = "0x26D0650", VA = "0x1826D1A50")]
		public void _PlayNoChangeAnim()
		{
		}

		// Token: 0x0602B052 RID: 176210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B052")]
		[Address(RVA = "0x26D1780", Offset = "0x26D0380", VA = "0x1826D1780")]
		public void _PlayChangeAnim()
		{
		}

		// Token: 0x0602B053 RID: 176211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B053")]
		[Address(RVA = "0x26D0EA0", Offset = "0x26CFAA0", VA = "0x1826D0EA0")]
		public void Render(Act1VHalfIdleIncomeGraphItemViewModel viewModel)
		{
		}

		// Token: 0x0602B054 RID: 176212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B054")]
		[Address(RVA = "0x26D0D30", Offset = "0x26CF930", VA = "0x1826D0D30")]
		public void PlayCompareTween()
		{
		}

		// Token: 0x0602B055 RID: 176213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B055")]
		[Address(RVA = "0x26D0CA0", Offset = "0x26CF8A0", VA = "0x1826D0CA0")]
		public void EventOnClickItem()
		{
		}

		// Token: 0x0602B056 RID: 176214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B056")]
		[Address(RVA = "0x26D1D90", Offset = "0x26D0990", VA = "0x1826D1D90")]
		public Act1VHalfIdleIncomeGraphItemView()
		{
		}

		// Token: 0x0403E1AB RID: 254379
		[Token(Token = "0x403E1AB")]
		private const float CHANGE_TWEEN_TIME = 1f;

		// Token: 0x0403E1AC RID: 254380
		[Token(Token = "0x403E1AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _valueText;

		// Token: 0x0403E1AD RID: 254381
		[Token(Token = "0x403E1AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _maxValueText;

		// Token: 0x0403E1AE RID: 254382
		[Token(Token = "0x403E1AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _deltaValueTexts;

		// Token: 0x0403E1AF RID: 254383
		[Token(Token = "0x403E1AF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _maxIconTipObj;

		// Token: 0x0403E1B0 RID: 254384
		[Token(Token = "0x403E1B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _maxLightObj;

		// Token: 0x0403E1B1 RID: 254385
		[Token(Token = "0x403E1B1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _itemHighLightBgObj;

		// Token: 0x0403E1B2 RID: 254386
		[Token(Token = "0x403E1B2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _dataDiffPartObj;

		// Token: 0x0403E1B3 RID: 254387
		[Token(Token = "0x403E1B3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _dataIncreaseObj;

		// Token: 0x0403E1B4 RID: 254388
		[Token(Token = "0x403E1B4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _dataDecreaseObj;

		// Token: 0x0403E1B5 RID: 254389
		[Token(Token = "0x403E1B5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _dataNoChangeObj;

		// Token: 0x0403E1B6 RID: 254390
		[Token(Token = "0x403E1B6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _fixedProdIconObj;

		// Token: 0x0403E1B7 RID: 254391
		[Token(Token = "0x403E1B7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0403E1B8 RID: 254392
		[Token(Token = "0x403E1B8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _itemBgObj;

		// Token: 0x0403E1B9 RID: 254393
		[Token(Token = "0x403E1B9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _barMaxRect;

		// Token: 0x0403E1BA RID: 254394
		[Token(Token = "0x403E1BA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _barTopMaxRect;

		// Token: 0x0403E1BB RID: 254395
		[Token(Token = "0x403E1BB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _barNormalRect;

		// Token: 0x0403E1BC RID: 254396
		[Token(Token = "0x403E1BC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _barNoChangeRect;

		// Token: 0x0403E1BD RID: 254397
		[Token(Token = "0x403E1BD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _barIncreaseRect;

		// Token: 0x0403E1BE RID: 254398
		[Token(Token = "0x403E1BE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _barDecreaseRect;

		// Token: 0x0403E1BF RID: 254399
		[Token(Token = "0x403E1BF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TwoStateToggle _topEmptyToggle;

		// Token: 0x0403E1C0 RID: 254400
		[Token(Token = "0x403E1C0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _itemImg;

		// Token: 0x0403E1C1 RID: 254401
		[Token(Token = "0x403E1C1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _changeAnim;

		// Token: 0x0403E1C2 RID: 254402
		[Token(Token = "0x403E1C2")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _noChangeAnim;

		// Token: 0x0403E1C3 RID: 254403
		[Token(Token = "0x403E1C3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _tweenDelay;

		// Token: 0x0403E1C4 RID: 254404
		[Token(Token = "0x403E1C4")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float _changeAnimDelay;

		// Token: 0x0403E1C5 RID: 254405
		[Token(Token = "0x403E1C5")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0403E1C6 RID: 254406
		[Token(Token = "0x403E1C6")]
		[FieldOffset(Offset = "0xEC")]
		private float m_barBaseHeight;

		// Token: 0x0403E1C7 RID: 254407
		[Token(Token = "0x403E1C7")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_tween;

		// Token: 0x0403E1C8 RID: 254408
		[Token(Token = "0x403E1C8")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleIncomeGraphItemViewModel m_viewModel;

		// Token: 0x0403E1C9 RID: 254409
		[Token(Token = "0x403E1C9")]
		[FieldOffset(Offset = "0x100")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E1CA RID: 254410
		[Token(Token = "0x403E1CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E1CB RID: 254411
		[Token(Token = "0x403E1CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetBarRectHeight;

		// Token: 0x0403E1CC RID: 254412
		[Token(Token = "0x403E1CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayBarTween;

		// Token: 0x0403E1CD RID: 254413
		[Token(Token = "0x403E1CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__WrapDealyTween;

		// Token: 0x0403E1CE RID: 254414
		[Token(Token = "0x403E1CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayNoChangeAnim;

		// Token: 0x0403E1CF RID: 254415
		[Token(Token = "0x403E1CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayChangeAnim;

		// Token: 0x0403E1D0 RID: 254416
		[Token(Token = "0x403E1D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E1D1 RID: 254417
		[Token(Token = "0x403E1D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayCompareTween;

		// Token: 0x0403E1D2 RID: 254418
		[Token(Token = "0x403E1D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnClickItem;

		// Token: 0x0403E1D3 RID: 254419
		[Token(Token = "0x403E1D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

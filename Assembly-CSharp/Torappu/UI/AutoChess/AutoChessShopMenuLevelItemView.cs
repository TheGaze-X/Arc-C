using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006350 RID: 25424
	[Token(Token = "0x2006350")]
	public class AutoChessShopMenuLevelItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06024AF3 RID: 150259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF3")]
		[Address(RVA = "0x1F8BDB0", Offset = "0x1F8A9B0", VA = "0x181F8BDB0")]
		public void Render(AutoChessShopMenuLevelItemViewModel itemViewModel)
		{
		}

		// Token: 0x06024AF4 RID: 150260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF4")]
		[Address(RVA = "0x1F8C040", Offset = "0x1F8AC40", VA = "0x181F8C040")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024AF5 RID: 150261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF5")]
		[Address(RVA = "0x1F8C1A0", Offset = "0x1F8ADA0", VA = "0x181F8C1A0")]
		private void _RenderItemView(AutoChessShopMenuLevelItemViewModel itemViewModel)
		{
		}

		// Token: 0x06024AF6 RID: 150262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF6")]
		[Address(RVA = "0x1F8C720", Offset = "0x1F8B320", VA = "0x181F8C720")]
		private void _ShowClickTips()
		{
		}

		// Token: 0x06024AF7 RID: 150263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF7")]
		[Address(RVA = "0x1F8C510", Offset = "0x1F8B110", VA = "0x181F8C510")]
		private void _ResetClickTips()
		{
		}

		// Token: 0x06024AF8 RID: 150264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF8")]
		[Address(RVA = "0x1F8C5A0", Offset = "0x1F8B1A0", VA = "0x181F8C5A0")]
		private void _SetCharTabShowTrackPoint(bool isShow)
		{
		}

		// Token: 0x06024AF9 RID: 150265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AF9")]
		[Address(RVA = "0x1F8BB70", Offset = "0x1F8A770", VA = "0x181F8BB70")]
		public void OnItemClick()
		{
		}

		// Token: 0x06024AFA RID: 150266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024AFA")]
		[Address(RVA = "0x1F8C830", Offset = "0x1F8B430", VA = "0x181F8C830")]
		public AutoChessShopMenuLevelItemView()
		{
		}

		// Token: 0x04033352 RID: 209746
		[Token(Token = "0x4033352")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgShopLevelIcon;

		// Token: 0x04033353 RID: 209747
		[Token(Token = "0x4033353")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtShopLevel;

		// Token: 0x04033354 RID: 209748
		[Token(Token = "0x4033354")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objDiyCharInfo;

		// Token: 0x04033355 RID: 209749
		[Token(Token = "0x4033355")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtCurDiyCharCount;

		// Token: 0x04033356 RID: 209750
		[Token(Token = "0x4033356")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objSplitLine;

		// Token: 0x04033357 RID: 209751
		[Token(Token = "0x4033357")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animationLocationClickTips;

		// Token: 0x04033358 RID: 209752
		[Token(Token = "0x4033358")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasHasInfo;

		// Token: 0x04033359 RID: 209753
		[Token(Token = "0x4033359")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasNoInfo;

		// Token: 0x0403335A RID: 209754
		[Token(Token = "0x403335A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _trackPointContainer;

		// Token: 0x0403335B RID: 209755
		[Token(Token = "0x403335B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objNewPrefab;

		// Token: 0x0403335C RID: 209756
		[Token(Token = "0x403335C")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedShopLevel;

		// Token: 0x0403335D RID: 209757
		[Token(Token = "0x403335D")]
		[FieldOffset(Offset = "0x74")]
		private int m_cachedIndex;

		// Token: 0x0403335E RID: 209758
		[Token(Token = "0x403335E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403335F RID: 209759
		[Token(Token = "0x403335F")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033360 RID: 209760
		[Token(Token = "0x4033360")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04033361 RID: 209761
		[Token(Token = "0x4033361")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_tween;

		// Token: 0x04033362 RID: 209762
		[Token(Token = "0x4033362")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_hasInfoTween;

		// Token: 0x04033363 RID: 209763
		[Token(Token = "0x4033363")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_noInfoTween;

		// Token: 0x04033364 RID: 209764
		[Token(Token = "0x4033364")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_trackPointObj;

		// Token: 0x04033365 RID: 209765
		[Token(Token = "0x4033365")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033366 RID: 209766
		[Token(Token = "0x4033366")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033367 RID: 209767
		[Token(Token = "0x4033367")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderItemView;

		// Token: 0x04033368 RID: 209768
		[Token(Token = "0x4033368")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowClickTips;

		// Token: 0x04033369 RID: 209769
		[Token(Token = "0x4033369")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetClickTips;

		// Token: 0x0403336A RID: 209770
		[Token(Token = "0x403336A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetCharTabShowTrackPoint;

		// Token: 0x0403336B RID: 209771
		[Token(Token = "0x403336B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403336C RID: 209772
		[Token(Token = "0x403336C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006351 RID: 25425
		[Token(Token = "0x2006351")]
		public class AutoChessShopMenuLevelItemMsgParam
		{
			// Token: 0x06024AFB RID: 150267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024AFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessShopMenuLevelItemMsgParam()
			{
			}

			// Token: 0x0403336D RID: 209773
			[Token(Token = "0x403336D")]
			[FieldOffset(Offset = "0x10")]
			public int chessLv;

			// Token: 0x0403336E RID: 209774
			[Token(Token = "0x403336E")]
			[FieldOffset(Offset = "0x14")]
			public int index;
		}
	}
}

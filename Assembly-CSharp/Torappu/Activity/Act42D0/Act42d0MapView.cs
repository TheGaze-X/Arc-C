using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200739F RID: 29599
	[Token(Token = "0x200739F")]
	public class Act42d0MapView : DataBinder<Act42d0AreaMapProperty>, IHotfixable
	{
		// Token: 0x06029D70 RID: 171376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D70")]
		[Address(RVA = "0x257B340", Offset = "0x2579F40", VA = "0x18257B340", Slot = "7")]
		public override void OnValueChanged(Act42d0AreaMapProperty property)
		{
		}

		// Token: 0x06029D71 RID: 171377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D71")]
		[Address(RVA = "0x257B960", Offset = "0x257A560", VA = "0x18257B960")]
		private void _PlayAnimMapInfoIfNecessary(Act42D0Data.Act42D0AreaDifficulty currentDiff)
		{
		}

		// Token: 0x06029D72 RID: 171378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D72")]
		[Address(RVA = "0x257C0C0", Offset = "0x257ACC0", VA = "0x18257C0C0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x06029D73 RID: 171379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D73")]
		[Address(RVA = "0x257B8C0", Offset = "0x257A4C0", VA = "0x18257B8C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D74 RID: 171380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D74")]
		[Address(RVA = "0x257BB40", Offset = "0x257A740", VA = "0x18257BB40")]
		private void _RefreshInfo(Act42d0AreaMapViewModel mapViewModel)
		{
		}

		// Token: 0x06029D75 RID: 171381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D75")]
		[Address(RVA = "0x257C3A0", Offset = "0x257AFA0", VA = "0x18257C3A0")]
		private void _RenderProgressOnMap(Act42d0AreaMapViewModel viewModel)
		{
		}

		// Token: 0x06029D76 RID: 171382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D76")]
		[Address(RVA = "0x257BCC0", Offset = "0x257A8C0", VA = "0x18257BCC0")]
		private void _RefreshMap(Act42d0AreaMapViewModel mapViewModel)
		{
		}

		// Token: 0x06029D77 RID: 171383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D77")]
		[Address(RVA = "0x257BA70", Offset = "0x257A670", VA = "0x18257BA70")]
		private void _RefreshBtn(Act42d0AreaMapViewModel mapViewModel)
		{
		}

		// Token: 0x06029D78 RID: 171384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D78")]
		[Address(RVA = "0x257C570", Offset = "0x257B170", VA = "0x18257C570")]
		public Act42d0MapView()
		{
		}

		// Token: 0x0403BF1B RID: 245531
		[Token(Token = "0x403BF1B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _areaGroupContainer;

		// Token: 0x0403BF1C RID: 245532
		[Token(Token = "0x403BF1C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mapInfoGo;

		// Token: 0x0403BF1D RID: 245533
		[Token(Token = "0x403BF1D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _nextBtn;

		// Token: 0x0403BF1E RID: 245534
		[Token(Token = "0x403BF1E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _prevBtn;

		// Token: 0x0403BF1F RID: 245535
		[Token(Token = "0x403BF1F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textAreaTitle;

		// Token: 0x0403BF20 RID: 245536
		[Token(Token = "0x403BF20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textAreaContent;

		// Token: 0x0403BF21 RID: 245537
		[Token(Token = "0x403BF21")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _mapInfoBgGo;

		// Token: 0x0403BF22 RID: 245538
		[Token(Token = "0x403BF22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _progressInfo;

		// Token: 0x0403BF23 RID: 245539
		[Token(Token = "0x403BF23")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _areaCode;

		// Token: 0x0403BF24 RID: 245540
		[Token(Token = "0x403BF24")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x0403BF25 RID: 245541
		[Token(Token = "0x403BF25")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _rateName;

		// Token: 0x0403BF26 RID: 245542
		[Token(Token = "0x403BF26")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _areaRateIcon;

		// Token: 0x0403BF27 RID: 245543
		[Token(Token = "0x403BF27")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _btnBoss;

		// Token: 0x0403BF28 RID: 245544
		[Token(Token = "0x403BF28")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _imgBoss;

		// Token: 0x0403BF29 RID: 245545
		[Token(Token = "0x403BF29")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasObject _atlasAsset;

		// Token: 0x0403BF2A RID: 245546
		[Token(Token = "0x403BF2A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _blankSpace;

		// Token: 0x0403BF2B RID: 245547
		[Token(Token = "0x403BF2B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act42d0AreaGroupView[] _areaGroupPrefabs;

		// Token: 0x0403BF2C RID: 245548
		[Token(Token = "0x403BF2C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _focusThreshold;

		// Token: 0x0403BF2D RID: 245549
		[Token(Token = "0x403BF2D")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x0403BF2E RID: 245550
		[Token(Token = "0x403BF2E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animMapInfo;

		// Token: 0x0403BF2F RID: 245551
		[Token(Token = "0x403BF2F")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0403BF30 RID: 245552
		[Token(Token = "0x403BF30")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BF31 RID: 245553
		[Token(Token = "0x403BF31")]
		[FieldOffset(Offset = "0xD8")]
		private Act42D0Data.Act42D0AreaDifficulty m_cachedDiff;

		// Token: 0x0403BF32 RID: 245554
		[Token(Token = "0x403BF32")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_mapInfoTween;

		// Token: 0x0403BF33 RID: 245555
		[Token(Token = "0x403BF33")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<Act42D0Data.Act42D0AreaDifficulty, Act42d0AreaGroupView> m_areaGroupViewsDict;

		// Token: 0x0403BF34 RID: 245556
		[Token(Token = "0x403BF34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BF35 RID: 245557
		[Token(Token = "0x403BF35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnimMapInfoIfNecessary;

		// Token: 0x0403BF36 RID: 245558
		[Token(Token = "0x403BF36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0403BF37 RID: 245559
		[Token(Token = "0x403BF37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BF38 RID: 245560
		[Token(Token = "0x403BF38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshInfo;

		// Token: 0x0403BF39 RID: 245561
		[Token(Token = "0x403BF39")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderProgressOnMap;

		// Token: 0x0403BF3A RID: 245562
		[Token(Token = "0x403BF3A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshMap;

		// Token: 0x0403BF3B RID: 245563
		[Token(Token = "0x403BF3B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshBtn;

		// Token: 0x0403BF3C RID: 245564
		[Token(Token = "0x403BF3C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

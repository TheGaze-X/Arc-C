using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200732B RID: 29483
	[Token(Token = "0x200732B")]
	public class Act42SideGunTaskProgressView : DataBinder<Act42SideGunTaskProgressProp>
	{
		// Token: 0x06029B13 RID: 170771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B13")]
		[Address(RVA = "0x2512B30", Offset = "0x2511730", VA = "0x182512B30", Slot = "7")]
		public override void OnValueChanged(Act42SideGunTaskProgressProp property)
		{
		}

		// Token: 0x06029B14 RID: 170772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B14")]
		[Address(RVA = "0x2512A90", Offset = "0x2511690", VA = "0x182512A90")]
		public void OnCoffeeClicked()
		{
		}

		// Token: 0x06029B15 RID: 170773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B15")]
		[Address(RVA = "0x2513EA0", Offset = "0x2512AA0", VA = "0x182513EA0")]
		private void _RenderTabs(Act42SideGunTaskProgressViewModel model)
		{
		}

		// Token: 0x06029B16 RID: 170774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B16")]
		[Address(RVA = "0x2513B80", Offset = "0x2512780", VA = "0x182513B80")]
		private void _RenderBtns(Act42SideCenterViewModel centerModel)
		{
		}

		// Token: 0x06029B17 RID: 170775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B17")]
		[Address(RVA = "0x2513CF0", Offset = "0x25128F0", VA = "0x182513CF0")]
		private void _RenderCharBg(string trustorId)
		{
		}

		// Token: 0x06029B18 RID: 170776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B18")]
		[Address(RVA = "0x2513AE0", Offset = "0x25126E0", VA = "0x182513AE0")]
		private void _PlayRefreshAnim()
		{
		}

		// Token: 0x06029B19 RID: 170777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B19")]
		[Address(RVA = "0x25137F0", Offset = "0x25123F0", VA = "0x1825137F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B1A RID: 170778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1A")]
		[Address(RVA = "0x25139D0", Offset = "0x25125D0", VA = "0x1825139D0")]
		private void _PlayAnim(Tween tween, UIAnimationLocation anim)
		{
		}

		// Token: 0x06029B1B RID: 170779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1B")]
		[Address(RVA = "0x2514000", Offset = "0x2512C00", VA = "0x182514000")]
		public Act42SideGunTaskProgressView()
		{
		}

		// Token: 0x0403BAB0 RID: 244400
		[Token(Token = "0x403BAB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Left Part")]
		private Act42SideGunTaskTabView _tabItem;

		// Token: 0x0403BAB1 RID: 244401
		[Token(Token = "0x403BAB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Left Part")]
		private Transform[] _tabHolderList;

		// Token: 0x0403BAB2 RID: 244402
		[Token(Token = "0x403BAB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Mid Part")]
		private Image[] _charBgList;

		// Token: 0x0403BAB3 RID: 244403
		[Token(Token = "0x403BAB3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Mid Part")]
		private Act42SideGunTaskBtnView _btnItem;

		// Token: 0x0403BAB4 RID: 244404
		[Token(Token = "0x403BAB4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Mid Part")]
		private Transform[] _btnHolderList;

		// Token: 0x0403BAB5 RID: 244405
		[Token(Token = "0x403BAB5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Mid Part")]
		private Act42SideGunTaskCenterView _gunView;

		// Token: 0x0403BAB6 RID: 244406
		[Token(Token = "0x403BAB6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Right Part")]
		private Act42SideGunTaskDetailView _detailView;

		// Token: 0x0403BAB7 RID: 244407
		[Token(Token = "0x403BAB7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Right Part")]
		private Text _coffeeCnt;

		// Token: 0x0403BAB8 RID: 244408
		[Token(Token = "0x403BAB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _animRefresh;

		// Token: 0x0403BAB9 RID: 244409
		[Token(Token = "0x403BAB9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _charBg;

		// Token: 0x0403BABA RID: 244410
		[Token(Token = "0x403BABA")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403BABB RID: 244411
		[Token(Token = "0x403BABB")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedIndex;

		// Token: 0x0403BABC RID: 244412
		[Token(Token = "0x403BABC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cachedIsEnter;

		// Token: 0x0403BABD RID: 244413
		[Token(Token = "0x403BABD")]
		[FieldOffset(Offset = "0x89")]
		private bool m_cachedTabChanged;

		// Token: 0x0403BABE RID: 244414
		[Token(Token = "0x403BABE")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_charBgTween;

		// Token: 0x0403BABF RID: 244415
		[Token(Token = "0x403BABF")]
		[FieldOffset(Offset = "0x98")]
		private Tween m_refreshTween;

		// Token: 0x0403BAC0 RID: 244416
		[Token(Token = "0x403BAC0")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BAC1 RID: 244417
		[Token(Token = "0x403BAC1")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BAC2 RID: 244418
		[Token(Token = "0x403BAC2")]
		[FieldOffset(Offset = "0xC0")]
		private List<Act42SideGunTaskTabView> m_tabViewList;

		// Token: 0x0403BAC3 RID: 244419
		[Token(Token = "0x403BAC3")]
		[FieldOffset(Offset = "0xC8")]
		private List<Act42SideGunTaskBtnView> m_btnViewList;

		// Token: 0x0403BAC4 RID: 244420
		[Token(Token = "0x403BAC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BAC5 RID: 244421
		[Token(Token = "0x403BAC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCoffeeClicked;

		// Token: 0x0403BAC6 RID: 244422
		[Token(Token = "0x403BAC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTabs;

		// Token: 0x0403BAC7 RID: 244423
		[Token(Token = "0x403BAC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderBtns;

		// Token: 0x0403BAC8 RID: 244424
		[Token(Token = "0x403BAC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCharBg;

		// Token: 0x0403BAC9 RID: 244425
		[Token(Token = "0x403BAC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayRefreshAnim;

		// Token: 0x0403BACA RID: 244426
		[Token(Token = "0x403BACA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BACB RID: 244427
		[Token(Token = "0x403BACB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403BACC RID: 244428
		[Token(Token = "0x403BACC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

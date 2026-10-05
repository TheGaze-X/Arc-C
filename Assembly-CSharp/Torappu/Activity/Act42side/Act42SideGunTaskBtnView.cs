using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007328 RID: 29480
	[Token(Token = "0x2007328")]
	public class Act42SideGunTaskBtnView : Act42SideSelectAnimView
	{
		// Token: 0x06029AFE RID: 170750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFE")]
		[Address(RVA = "0x250B3D0", Offset = "0x2509FD0", VA = "0x18250B3D0")]
		public void Render(Act42SideTaskBtnViewModel model, bool isTabChanged)
		{
		}

		// Token: 0x06029AFF RID: 170751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFF")]
		[Address(RVA = "0x250B270", Offset = "0x2509E70", VA = "0x18250B270")]
		public void OnBtnClicked()
		{
		}

		// Token: 0x06029B00 RID: 170752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B00")]
		[Address(RVA = "0x250B990", Offset = "0x250A590", VA = "0x18250B990")]
		private void _OnTabChanged(Act42SideTaskBtnViewModel model)
		{
		}

		// Token: 0x06029B01 RID: 170753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B01")]
		[Address(RVA = "0x250B7E0", Offset = "0x250A3E0", VA = "0x18250B7E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B02 RID: 170754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B02")]
		[Address(RVA = "0x250BB00", Offset = "0x250A700", VA = "0x18250BB00")]
		public Act42SideGunTaskBtnView()
		{
		}

		// Token: 0x0403BA68 RID: 244328
		[Token(Token = "0x403BA68")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _toggleLock;

		// Token: 0x0403BA69 RID: 244329
		[Token(Token = "0x403BA69")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggleColor;

		// Token: 0x0403BA6A RID: 244330
		[Token(Token = "0x403BA6A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgWhite;

		// Token: 0x0403BA6B RID: 244331
		[Token(Token = "0x403BA6B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgColor;

		// Token: 0x0403BA6C RID: 244332
		[Token(Token = "0x403BA6C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ThreeStateToggle _toggleIndex;

		// Token: 0x0403BA6D RID: 244333
		[Token(Token = "0x403BA6D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _tagNew;

		// Token: 0x0403BA6E RID: 244334
		[Token(Token = "0x403BA6E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animUnlock;

		// Token: 0x0403BA6F RID: 244335
		[Token(Token = "0x403BA6F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animColor;

		// Token: 0x0403BA70 RID: 244336
		[Token(Token = "0x403BA70")]
		[FieldOffset(Offset = "0xA0")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0403BA71 RID: 244337
		[Token(Token = "0x403BA71")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_colorTween;

		// Token: 0x0403BA72 RID: 244338
		[Token(Token = "0x403BA72")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_cachedUnlocked;

		// Token: 0x0403BA73 RID: 244339
		[Token(Token = "0x403BA73")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_cachedColor;

		// Token: 0x0403BA74 RID: 244340
		[Token(Token = "0x403BA74")]
		[FieldOffset(Offset = "0xB8")]
		private string m_taskId;

		// Token: 0x0403BA75 RID: 244341
		[Token(Token = "0x403BA75")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0403BA76 RID: 244342
		[Token(Token = "0x403BA76")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BA77 RID: 244343
		[Token(Token = "0x403BA77")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BA78 RID: 244344
		[Token(Token = "0x403BA78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BA79 RID: 244345
		[Token(Token = "0x403BA79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBtnClicked;

		// Token: 0x0403BA7A RID: 244346
		[Token(Token = "0x403BA7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTabChanged;

		// Token: 0x0403BA7B RID: 244347
		[Token(Token = "0x403BA7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BA7C RID: 244348
		[Token(Token = "0x403BA7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

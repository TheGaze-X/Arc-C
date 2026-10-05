using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007329 RID: 29481
	[Token(Token = "0x2007329")]
	public class Act42SideGunTaskCenterView : Act42SideSelectAnimView
	{
		// Token: 0x06029B03 RID: 170755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B03")]
		[Address(RVA = "0x250BD00", Offset = "0x250A900", VA = "0x18250BD00")]
		public void Render(Act42SideCenterViewModel model, bool isTabChanged)
		{
		}

		// Token: 0x06029B04 RID: 170756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B04")]
		[Address(RVA = "0x250C1D0", Offset = "0x250ADD0", VA = "0x18250C1D0", Slot = "4")]
		protected override void _OnPlaySelectAnim()
		{
		}

		// Token: 0x06029B05 RID: 170757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B05")]
		[Address(RVA = "0x250C2A0", Offset = "0x250AEA0", VA = "0x18250C2A0")]
		private void _OnTabChanged(Act42SideCenterViewModel model)
		{
		}

		// Token: 0x06029B06 RID: 170758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B06")]
		[Address(RVA = "0x250C0C0", Offset = "0x250ACC0", VA = "0x18250C0C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029B07 RID: 170759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B07")]
		[Address(RVA = "0x250BBA0", Offset = "0x250A7A0", VA = "0x18250BBA0")]
		public void OnGunClicked()
		{
		}

		// Token: 0x06029B08 RID: 170760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B08")]
		[Address(RVA = "0x250C3C0", Offset = "0x250AFC0", VA = "0x18250C3C0")]
		public Act42SideGunTaskCenterView()
		{
		}

		// Token: 0x06029B09 RID: 170761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B09")]
		[Address(RVA = "0x250C060", Offset = "0x250AC60", VA = "0x18250C060")]
		private void <>xLuaBaseProxy__OnPlaySelectAnim()
		{
		}

		// Token: 0x0403BA7D RID: 244349
		[Token(Token = "0x403BA7D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _toggleLock;

		// Token: 0x0403BA7E RID: 244350
		[Token(Token = "0x403BA7E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _tagNew;

		// Token: 0x0403BA7F RID: 244351
		[Token(Token = "0x403BA7F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _fxUnlock;

		// Token: 0x0403BA80 RID: 244352
		[Token(Token = "0x403BA80")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgWhite;

		// Token: 0x0403BA81 RID: 244353
		[Token(Token = "0x403BA81")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgColor;

		// Token: 0x0403BA82 RID: 244354
		[Token(Token = "0x403BA82")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animUnlock;

		// Token: 0x0403BA83 RID: 244355
		[Token(Token = "0x403BA83")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UISpineLocation _animSpine;

		// Token: 0x0403BA84 RID: 244356
		[Token(Token = "0x403BA84")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cachedUnlocked;

		// Token: 0x0403BA85 RID: 244357
		[Token(Token = "0x403BA85")]
		[FieldOffset(Offset = "0xA0")]
		private string m_gunId;

		// Token: 0x0403BA86 RID: 244358
		[Token(Token = "0x403BA86")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0403BA87 RID: 244359
		[Token(Token = "0x403BA87")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0403BA88 RID: 244360
		[Token(Token = "0x403BA88")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BA89 RID: 244361
		[Token(Token = "0x403BA89")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BA8A RID: 244362
		[Token(Token = "0x403BA8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BA8B RID: 244363
		[Token(Token = "0x403BA8B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnPlaySelectAnim;

		// Token: 0x0403BA8C RID: 244364
		[Token(Token = "0x403BA8C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTabChanged;

		// Token: 0x0403BA8D RID: 244365
		[Token(Token = "0x403BA8D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BA8E RID: 244366
		[Token(Token = "0x403BA8E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGunClicked;

		// Token: 0x0403BA8F RID: 244367
		[Token(Token = "0x403BA8F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

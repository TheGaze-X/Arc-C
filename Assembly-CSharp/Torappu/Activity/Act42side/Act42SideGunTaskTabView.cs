using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x0200732C RID: 29484
	[Token(Token = "0x200732C")]
	public class Act42SideGunTaskTabView : Act42SideSelectAnimView
	{
		// Token: 0x06029B1C RID: 170780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1C")]
		[Address(RVA = "0x2514210", Offset = "0x2512E10", VA = "0x182514210")]
		public void Render(Act42SideTrustorTabViewModel model, bool isEnter, bool isActEnd)
		{
		}

		// Token: 0x06029B1D RID: 170781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1D")]
		[Address(RVA = "0x2514120", Offset = "0x2512D20", VA = "0x182514120")]
		public void EventOnTabClicked()
		{
		}

		// Token: 0x06029B1E RID: 170782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1E")]
		[Address(RVA = "0x2514600", Offset = "0x2513200", VA = "0x182514600")]
		private void _InitIfNot(Act42SideTrustorTabViewModel model)
		{
		}

		// Token: 0x06029B1F RID: 170783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B1F")]
		[Address(RVA = "0x25147A0", Offset = "0x25133A0", VA = "0x1825147A0")]
		protected void _PlayAnim(Tween tween, UIAnimationLocation anim)
		{
		}

		// Token: 0x06029B20 RID: 170784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029B20")]
		[Address(RVA = "0x25148B0", Offset = "0x25134B0", VA = "0x1825148B0")]
		public Act42SideGunTaskTabView()
		{
		}

		// Token: 0x0403BACD RID: 244429
		[Token(Token = "0x403BACD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403BACE RID: 244430
		[Token(Token = "0x403BACE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x0403BACF RID: 244431
		[Token(Token = "0x403BACF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ThreeStateToggle _toggleProgress;

		// Token: 0x0403BAD0 RID: 244432
		[Token(Token = "0x403BAD0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _tagNew;

		// Token: 0x0403BAD1 RID: 244433
		[Token(Token = "0x403BAD1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _tagWorking;

		// Token: 0x0403BAD2 RID: 244434
		[Token(Token = "0x403BAD2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x0403BAD3 RID: 244435
		[Token(Token = "0x403BAD3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animTask;

		// Token: 0x0403BAD4 RID: 244436
		[Token(Token = "0x403BAD4")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_taskTween;

		// Token: 0x0403BAD5 RID: 244437
		[Token(Token = "0x403BAD5")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BAD6 RID: 244438
		[Token(Token = "0x403BAD6")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BAD7 RID: 244439
		[Token(Token = "0x403BAD7")]
		[FieldOffset(Offset = "0xB8")]
		private string m_trustorId;

		// Token: 0x0403BAD8 RID: 244440
		[Token(Token = "0x403BAD8")]
		[FieldOffset(Offset = "0xC0")]
		private int m_cachedTaskCnt;

		// Token: 0x0403BAD9 RID: 244441
		[Token(Token = "0x403BAD9")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_isInited;

		// Token: 0x0403BADA RID: 244442
		[Token(Token = "0x403BADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BADB RID: 244443
		[Token(Token = "0x403BADB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnTabClicked;

		// Token: 0x0403BADC RID: 244444
		[Token(Token = "0x403BADC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BADD RID: 244445
		[Token(Token = "0x403BADD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403BADE RID: 244446
		[Token(Token = "0x403BADE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

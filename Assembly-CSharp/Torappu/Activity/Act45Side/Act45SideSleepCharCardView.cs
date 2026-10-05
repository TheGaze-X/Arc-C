using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072CB RID: 29387
	[Token(Token = "0x20072CB")]
	public class Act45SideSleepCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029983 RID: 170371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029983")]
		[Address(RVA = "0x24FC970", Offset = "0x24FB570", VA = "0x1824FC970")]
		public void SetUp(Act45SideCharItemModel charModel)
		{
		}

		// Token: 0x06029984 RID: 170372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029984")]
		[Address(RVA = "0x24FCA80", Offset = "0x24FB680", VA = "0x1824FCA80")]
		public void TryPlayClickAnim(string clickId)
		{
		}

		// Token: 0x06029985 RID: 170373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029985")]
		[Address(RVA = "0x24FC870", Offset = "0x24FB470", VA = "0x1824FC870")]
		public void EventOnCharCardClicked()
		{
		}

		// Token: 0x06029986 RID: 170374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029986")]
		[Address(RVA = "0x24FCBE0", Offset = "0x24FB7E0", VA = "0x1824FCBE0")]
		public Act45SideSleepCharCardView()
		{
		}

		// Token: 0x0403B7CD RID: 243661
		[Token(Token = "0x403B7CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _frontImg;

		// Token: 0x0403B7CE RID: 243662
		[Token(Token = "0x403B7CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0403B7CF RID: 243663
		[Token(Token = "0x403B7CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403B7D0 RID: 243664
		[Token(Token = "0x403B7D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403B7D1 RID: 243665
		[Token(Token = "0x403B7D1")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403B7D2 RID: 243666
		[Token(Token = "0x403B7D2")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403B7D3 RID: 243667
		[Token(Token = "0x403B7D3")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedCharId;

		// Token: 0x0403B7D4 RID: 243668
		[Token(Token = "0x403B7D4")]
		[FieldOffset(Offset = "0x68")]
		private Tween m_tween;

		// Token: 0x0403B7D5 RID: 243669
		[Token(Token = "0x403B7D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetUp;

		// Token: 0x0403B7D6 RID: 243670
		[Token(Token = "0x403B7D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryPlayClickAnim;

		// Token: 0x0403B7D7 RID: 243671
		[Token(Token = "0x403B7D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCharCardClicked;

		// Token: 0x0403B7D8 RID: 243672
		[Token(Token = "0x403B7D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

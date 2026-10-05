using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004861 RID: 18529
	[Token(Token = "0x2004861")]
	public class GuideCharRewardItemView : GuideRewardItemView
	{
		// Token: 0x0601BFD1 RID: 114641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD1")]
		[Address(RVA = "0x154B080", Offset = "0x1549C80", VA = "0x18154B080", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0601BFD2 RID: 114642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD2")]
		[Address(RVA = "0x154AF10", Offset = "0x1549B10", VA = "0x18154AF10")]
		public void EventOnCharShow()
		{
		}

		// Token: 0x0601BFD3 RID: 114643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BFD3")]
		[Address(RVA = "0x154B210", Offset = "0x1549E10", VA = "0x18154B210")]
		public GuideCharRewardItemView()
		{
		}

		// Token: 0x0402481B RID: 149531
		[Token(Token = "0x402481B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rewardAvailGo;

		// Token: 0x0402481C RID: 149532
		[Token(Token = "0x402481C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textHint;

		// Token: 0x0402481D RID: 149533
		[Token(Token = "0x402481D")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402481E RID: 149534
		[Token(Token = "0x402481E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402481F RID: 149535
		[Token(Token = "0x402481F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCharShow;

		// Token: 0x04024820 RID: 149536
		[Token(Token = "0x4024820")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

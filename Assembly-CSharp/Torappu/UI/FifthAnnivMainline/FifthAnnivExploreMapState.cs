using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED5 RID: 20181
	[Token(Token = "0x2004ED5")]
	public class FifthAnnivExploreMapState : PopupFadeState
	{
		// Token: 0x0601E1C4 RID: 123332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E1C4")]
		[Address(RVA = "0x17CF840", Offset = "0x17CE440", VA = "0x1817CF840", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E1C5 RID: 123333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C5")]
		[Address(RVA = "0x17CF8A0", Offset = "0x17CE4A0", VA = "0x1817CF8A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E1C6 RID: 123334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C6")]
		[Address(RVA = "0x17CF930", Offset = "0x17CE530", VA = "0x1817CF930", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601E1C7 RID: 123335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C7")]
		[Address(RVA = "0x17CFC70", Offset = "0x17CE870", VA = "0x1817CFC70")]
		private void _RefreshMap()
		{
		}

		// Token: 0x0601E1C8 RID: 123336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C8")]
		[Address(RVA = "0x17CFAA0", Offset = "0x17CE6A0", VA = "0x1817CFAA0")]
		private void _DealWithBroadcast()
		{
		}

		// Token: 0x0601E1C9 RID: 123337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C9")]
		[Address(RVA = "0x17CFD50", Offset = "0x17CE950", VA = "0x1817CFD50")]
		public FifthAnnivExploreMapState()
		{
		}

		// Token: 0x0601E1CA RID: 123338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1CA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E1CB RID: 123339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1CB")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402810F RID: 164111
		[Token(Token = "0x402810F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _mapEntryGo;

		// Token: 0x04028110 RID: 164112
		[Token(Token = "0x4028110")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEntrySideBar;

		// Token: 0x04028111 RID: 164113
		[Token(Token = "0x4028111")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private FifthAnnivExploreMapEffect _animMapEffect;

		// Token: 0x04028112 RID: 164114
		[Token(Token = "0x4028112")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private FifthAnnivExploreCarouselGroup _carouselGroup;

		// Token: 0x04028113 RID: 164115
		[Token(Token = "0x4028113")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _toastAnimationLocation;

		// Token: 0x04028114 RID: 164116
		[Token(Token = "0x4028114")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028115 RID: 164117
		[Token(Token = "0x4028115")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028116 RID: 164118
		[Token(Token = "0x4028116")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028117 RID: 164119
		[Token(Token = "0x4028117")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04028118 RID: 164120
		[Token(Token = "0x4028118")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshMap;

		// Token: 0x04028119 RID: 164121
		[Token(Token = "0x4028119")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DealWithBroadcast;

		// Token: 0x0402811A RID: 164122
		[Token(Token = "0x402811A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C4A RID: 23626
	[Token(Token = "0x2005C4A")]
	public class ClimbTowerEntryGodCardDetailButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700505A RID: 20570
		// (get) Token: 0x060223D6 RID: 140246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223D7 RID: 140247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700505A")]
		public Action<string> onClicked
		{
			[Token(Token = "0x60223D6")]
			[Address(RVA = "0x1CA6B40", Offset = "0x1CA5740", VA = "0x181CA6B40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223D7")]
			[Address(RVA = "0x1CA6BA0", Offset = "0x1CA57A0", VA = "0x181CA6BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223D8 RID: 140248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223D8")]
		[Address(RVA = "0x1CA66F0", Offset = "0x1CA52F0", VA = "0x181CA66F0")]
		public void Render(ClimbTowerEntryGodCardModel viewModel, string selectedCardId, bool showDivideLine)
		{
		}

		// Token: 0x060223D9 RID: 140249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223D9")]
		[Address(RVA = "0x1CA6610", Offset = "0x1CA5210", VA = "0x181CA6610")]
		public void OnClick()
		{
		}

		// Token: 0x060223DA RID: 140250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223DA")]
		[Address(RVA = "0x1CA6990", Offset = "0x1CA5590", VA = "0x181CA6990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060223DB RID: 140251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223DB")]
		[Address(RVA = "0x1CA6AE0", Offset = "0x1CA56E0", VA = "0x181CA6AE0")]
		public ClimbTowerEntryGodCardDetailButtonView()
		{
		}

		// Token: 0x0402EFC8 RID: 192456
		[Token(Token = "0x402EFC8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _cardIcon;

		// Token: 0x0402EFC9 RID: 192457
		[Token(Token = "0x402EFC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _divideLine;

		// Token: 0x0402EFCA RID: 192458
		[Token(Token = "0x402EFCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x0402EFCB RID: 192459
		[Token(Token = "0x402EFCB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0402EFCC RID: 192460
		[Token(Token = "0x402EFCC")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedCardId;

		// Token: 0x0402EFCD RID: 192461
		[Token(Token = "0x402EFCD")]
		[FieldOffset(Offset = "0x48")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402EFCE RID: 192462
		[Token(Token = "0x402EFCE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402EFCF RID: 192463
		[Token(Token = "0x402EFCF")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402EFD1 RID: 192465
		[Token(Token = "0x402EFD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x0402EFD2 RID: 192466
		[Token(Token = "0x402EFD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x0402EFD3 RID: 192467
		[Token(Token = "0x402EFD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EFD4 RID: 192468
		[Token(Token = "0x402EFD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402EFD5 RID: 192469
		[Token(Token = "0x402EFD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EFD6 RID: 192470
		[Token(Token = "0x402EFD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

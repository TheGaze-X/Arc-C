using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047F3 RID: 18419
	[Token(Token = "0x20047F3")]
	public class MonopolyCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDB9 RID: 114105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDB9")]
		[Address(RVA = "0x1537530", Offset = "0x1536130", VA = "0x181537530")]
		public void Render(MonopolyCardItemView.Input input)
		{
		}

		// Token: 0x0601BDBA RID: 114106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDBA")]
		[Address(RVA = "0x1537460", Offset = "0x1536060", VA = "0x181537460")]
		public void PlayFadeInOutTween(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601BDBB RID: 114107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDBB")]
		[Address(RVA = "0x15376C0", Offset = "0x15362C0", VA = "0x1815376C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDBC RID: 114108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDBC")]
		[Address(RVA = "0x1537340", Offset = "0x1535F40", VA = "0x181537340")]
		public void EventOnClick()
		{
		}

		// Token: 0x0601BDBD RID: 114109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDBD")]
		[Address(RVA = "0x1537900", Offset = "0x1536500", VA = "0x181537900")]
		public MonopolyCardItemView()
		{
		}

		// Token: 0x04024444 RID: 148548
		[Token(Token = "0x4024444")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04024445 RID: 148549
		[Token(Token = "0x4024445")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _selectAnimDuration;

		// Token: 0x04024446 RID: 148550
		[Token(Token = "0x4024446")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _pointIcon;

		// Token: 0x04024447 RID: 148551
		[Token(Token = "0x4024447")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _pointNum;

		// Token: 0x04024448 RID: 148552
		[Token(Token = "0x4024448")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _fadeInAnim;

		// Token: 0x04024449 RID: 148553
		[Token(Token = "0x4024449")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _fadeOutAnim;

		// Token: 0x0402444A RID: 148554
		[Token(Token = "0x402444A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _comboHintGo;

		// Token: 0x0402444B RID: 148555
		[Token(Token = "0x402444B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Font _kjeragDigitFont;

		// Token: 0x0402444C RID: 148556
		[Token(Token = "0x402444C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text[] _textUseKjeragFont;

		// Token: 0x0402444D RID: 148557
		[Token(Token = "0x402444D")]
		[FieldOffset(Offset = "0x78")]
		private int m_cacheCardPoint;

		// Token: 0x0402444E RID: 148558
		[Token(Token = "0x402444E")]
		[FieldOffset(Offset = "0x7C")]
		private int m_cacheCardIndex;

		// Token: 0x0402444F RID: 148559
		[Token(Token = "0x402444F")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_fadeInOutTween;

		// Token: 0x04024450 RID: 148560
		[Token(Token = "0x4024450")]
		[FieldOffset(Offset = "0x88")]
		private UISwitchTween m_selectSwitchTween;

		// Token: 0x04024451 RID: 148561
		[Token(Token = "0x4024451")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04024452 RID: 148562
		[Token(Token = "0x4024452")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024453 RID: 148563
		[Token(Token = "0x4024453")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024454 RID: 148564
		[Token(Token = "0x4024454")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cacheIsSelect;

		// Token: 0x04024455 RID: 148565
		[Token(Token = "0x4024455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024456 RID: 148566
		[Token(Token = "0x4024456")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayFadeInOutTween;

		// Token: 0x04024457 RID: 148567
		[Token(Token = "0x4024457")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024458 RID: 148568
		[Token(Token = "0x4024458")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x04024459 RID: 148569
		[Token(Token = "0x4024459")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047F4 RID: 18420
		[Token(Token = "0x20047F4")]
		public class Input : IHotfixable
		{
			// Token: 0x0601BDBE RID: 114110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BDBE")]
			[Address(RVA = "0x15372C0", Offset = "0x1535EC0", VA = "0x1815372C0")]
			public Input()
			{
			}

			// Token: 0x0402445A RID: 148570
			[Token(Token = "0x402445A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly MonopolyCardItemView.Input EMPTY;

			// Token: 0x0402445B RID: 148571
			[Token(Token = "0x402445B")]
			[FieldOffset(Offset = "0x10")]
			public int cardPoint;

			// Token: 0x0402445C RID: 148572
			[Token(Token = "0x402445C")]
			[FieldOffset(Offset = "0x14")]
			public int cardIndex;

			// Token: 0x0402445D RID: 148573
			[Token(Token = "0x402445D")]
			[FieldOffset(Offset = "0x18")]
			public bool isCardSelect;

			// Token: 0x0402445E RID: 148574
			[Token(Token = "0x402445E")]
			[FieldOffset(Offset = "0x1C")]
			public int lastSelectPoint;

			// Token: 0x0402445F RID: 148575
			[Token(Token = "0x402445F")]
			[FieldOffset(Offset = "0x20")]
			public bool isSelectFastMode;

			// Token: 0x04024460 RID: 148576
			[Token(Token = "0x4024460")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

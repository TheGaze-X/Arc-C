using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F9 RID: 21497
	[Token(Token = "0x20053F9")]
	public class RoguelikeRewardRelicView : RoguelikeRewardItem
	{
		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x0601FA13 RID: 129555 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA14 RID: 129556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A17")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601FA13")]
			[Address(RVA = "0x195DF90", Offset = "0x195CB90", VA = "0x18195DF90", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601FA14")]
			[Address(RVA = "0x195E050", Offset = "0x195CC50", VA = "0x18195E050", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0601FA15 RID: 129557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A18")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA15")]
			[Address(RVA = "0x195DFF0", Offset = "0x195CBF0", VA = "0x18195DFF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA16 RID: 129558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA16")]
		[Address(RVA = "0x195D940", Offset = "0x195C540", VA = "0x18195D940", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA17 RID: 129559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA17")]
		[Address(RVA = "0x195DA10", Offset = "0x195C610", VA = "0x18195DA10", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA18 RID: 129560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA18")]
		[Address(RVA = "0x195DF30", Offset = "0x195CB30", VA = "0x18195DF30")]
		public RoguelikeRewardRelicView()
		{
		}

		// Token: 0x0402A9D0 RID: 174544
		[Token(Token = "0x402A9D0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _relicBg;

		// Token: 0x0402A9D1 RID: 174545
		[Token(Token = "0x402A9D1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _relicIcon;

		// Token: 0x0402A9D2 RID: 174546
		[Token(Token = "0x402A9D2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _relicName;

		// Token: 0x0402A9D3 RID: 174547
		[Token(Token = "0x402A9D3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402A9D4 RID: 174548
		[Token(Token = "0x402A9D4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelCurse;

		// Token: 0x0402A9D5 RID: 174549
		[Token(Token = "0x402A9D5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0402A9D6 RID: 174550
		[Token(Token = "0x402A9D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x0402A9D7 RID: 174551
		[Token(Token = "0x402A9D7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textUpgrade;

		// Token: 0x0402A9D8 RID: 174552
		[Token(Token = "0x402A9D8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textUpgradeDesc;

		// Token: 0x0402A9D9 RID: 174553
		[Token(Token = "0x402A9D9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A9DA RID: 174554
		[Token(Token = "0x402A9DA")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A9DB RID: 174555
		[Token(Token = "0x402A9DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A9DC RID: 174556
		[Token(Token = "0x402A9DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A9DD RID: 174557
		[Token(Token = "0x402A9DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A9DE RID: 174558
		[Token(Token = "0x402A9DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A9DF RID: 174559
		[Token(Token = "0x402A9DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A9E0 RID: 174560
		[Token(Token = "0x402A9E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

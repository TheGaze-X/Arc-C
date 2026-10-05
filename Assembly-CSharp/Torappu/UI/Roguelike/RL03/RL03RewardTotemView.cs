using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005892 RID: 22674
	[Token(Token = "0x2005892")]
	public class RL03RewardTotemView : RoguelikeRewardItem
	{
		// Token: 0x17004DA7 RID: 19879
		// (get) Token: 0x060211A0 RID: 135584 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211A1 RID: 135585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DA7")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x60211A0")]
			[Address(RVA = "0x1B7A930", Offset = "0x1B79530", VA = "0x181B7A930", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60211A1")]
			[Address(RVA = "0x1B7A9F0", Offset = "0x1B795F0", VA = "0x181B7A9F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004DA8 RID: 19880
		// (get) Token: 0x060211A2 RID: 135586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004DA8")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x60211A2")]
			[Address(RVA = "0x1B7A990", Offset = "0x1B79590", VA = "0x181B7A990", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060211A3 RID: 135587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A3")]
		[Address(RVA = "0x1B7A400", Offset = "0x1B79000", VA = "0x181B7A400", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x060211A4 RID: 135588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A4")]
		[Address(RVA = "0x1B7A4D0", Offset = "0x1B790D0", VA = "0x181B7A4D0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x060211A5 RID: 135589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A5")]
		[Address(RVA = "0x1B7A880", Offset = "0x1B79480", VA = "0x181B7A880")]
		public RL03RewardTotemView()
		{
		}

		// Token: 0x0402D119 RID: 184601
		[Token(Token = "0x402D119")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _totemBg;

		// Token: 0x0402D11A RID: 184602
		[Token(Token = "0x402D11A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _totemIcon;

		// Token: 0x0402D11B RID: 184603
		[Token(Token = "0x402D11B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _totemName;

		// Token: 0x0402D11C RID: 184604
		[Token(Token = "0x402D11C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402D11D RID: 184605
		[Token(Token = "0x402D11D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelCombine;

		// Token: 0x0402D11E RID: 184606
		[Token(Token = "0x402D11E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textCombine;

		// Token: 0x0402D11F RID: 184607
		[Token(Token = "0x402D11F")]
		[FieldOffset(Offset = "0x78")]
		private List<RL03TotemViewModel> m_cachedTotemModels;

		// Token: 0x0402D120 RID: 184608
		[Token(Token = "0x402D120")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402D122 RID: 184610
		[Token(Token = "0x402D122")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402D123 RID: 184611
		[Token(Token = "0x402D123")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402D124 RID: 184612
		[Token(Token = "0x402D124")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402D125 RID: 184613
		[Token(Token = "0x402D125")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402D126 RID: 184614
		[Token(Token = "0x402D126")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D127 RID: 184615
		[Token(Token = "0x402D127")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

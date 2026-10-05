using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F4 RID: 21492
	[Token(Token = "0x20053F4")]
	public class RoguelikeRewardPillView : RoguelikeRewardItem
	{
		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x0601F9F2 RID: 129522 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9F3 RID: 129523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A0F")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9F2")]
			[Address(RVA = "0x195BE20", Offset = "0x195AA20", VA = "0x18195BE20", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F9F3")]
			[Address(RVA = "0x195BEE0", Offset = "0x195AAE0", VA = "0x18195BEE0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x0601F9F4 RID: 129524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A10")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F9F4")]
			[Address(RVA = "0x195BE80", Offset = "0x195AA80", VA = "0x18195BE80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9F5 RID: 129525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9F5")]
		[Address(RVA = "0x195B9D0", Offset = "0x195A5D0", VA = "0x18195B9D0", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F9F6 RID: 129526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9F6")]
		[Address(RVA = "0x195BAA0", Offset = "0x195A6A0", VA = "0x18195BAA0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F9F7 RID: 129527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9F7")]
		[Address(RVA = "0x195BDC0", Offset = "0x195A9C0", VA = "0x18195BDC0")]
		public RoguelikeRewardPillView()
		{
		}

		// Token: 0x0402A993 RID: 174483
		[Token(Token = "0x402A993")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _pillIcon;

		// Token: 0x0402A994 RID: 174484
		[Token(Token = "0x402A994")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _pillBg;

		// Token: 0x0402A995 RID: 174485
		[Token(Token = "0x402A995")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402A996 RID: 174486
		[Token(Token = "0x402A996")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402A997 RID: 174487
		[Token(Token = "0x402A997")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A998 RID: 174488
		[Token(Token = "0x402A998")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A99A RID: 174490
		[Token(Token = "0x402A99A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A99B RID: 174491
		[Token(Token = "0x402A99B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A99C RID: 174492
		[Token(Token = "0x402A99C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A99D RID: 174493
		[Token(Token = "0x402A99D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A99E RID: 174494
		[Token(Token = "0x402A99E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A99F RID: 174495
		[Token(Token = "0x402A99F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

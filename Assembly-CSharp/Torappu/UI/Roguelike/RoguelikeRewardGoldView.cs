using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E2 RID: 21474
	[Token(Token = "0x20053E2")]
	public class RoguelikeRewardGoldView : RoguelikeRewardItem
	{
		// Token: 0x170049FE RID: 18942
		// (get) Token: 0x0601F990 RID: 129424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F991 RID: 129425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049FE")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F990")]
			[Address(RVA = "0x193D680", Offset = "0x193C280", VA = "0x18193D680", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F991")]
			[Address(RVA = "0x193D740", Offset = "0x193C340", VA = "0x18193D740", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x0601F992 RID: 129426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049FF")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F992")]
			[Address(RVA = "0x193D6E0", Offset = "0x193C2E0", VA = "0x18193D6E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F993 RID: 129427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F993")]
		[Address(RVA = "0x193D210", Offset = "0x193BE10", VA = "0x18193D210", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F994 RID: 129428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F994")]
		[Address(RVA = "0x193D2E0", Offset = "0x193BEE0", VA = "0x18193D2E0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F995 RID: 129429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F995")]
		[Address(RVA = "0x193D5E0", Offset = "0x193C1E0", VA = "0x18193D5E0")]
		public RoguelikeRewardGoldView()
		{
		}

		// Token: 0x0402A8E5 RID: 174309
		[Token(Token = "0x402A8E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _goldBg;

		// Token: 0x0402A8E6 RID: 174310
		[Token(Token = "0x402A8E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _goldIcon;

		// Token: 0x0402A8E7 RID: 174311
		[Token(Token = "0x402A8E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _goldName;

		// Token: 0x0402A8E8 RID: 174312
		[Token(Token = "0x402A8E8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _goldCount;

		// Token: 0x0402A8E9 RID: 174313
		[Token(Token = "0x402A8E9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A8EA RID: 174314
		[Token(Token = "0x402A8EA")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A8EB RID: 174315
		[Token(Token = "0x402A8EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A8EC RID: 174316
		[Token(Token = "0x402A8EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A8ED RID: 174317
		[Token(Token = "0x402A8ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A8EE RID: 174318
		[Token(Token = "0x402A8EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A8EF RID: 174319
		[Token(Token = "0x402A8EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A8F0 RID: 174320
		[Token(Token = "0x402A8F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

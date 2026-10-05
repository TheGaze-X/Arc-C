using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005401 RID: 21505
	[Token(Token = "0x2005401")]
	public class RoguelikeRewardSimpleView : RoguelikeRewardItem
	{
		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x0601FA31 RID: 129585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA32 RID: 129586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A1D")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601FA31")]
			[Address(RVA = "0x19612C0", Offset = "0x195FEC0", VA = "0x1819612C0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601FA32")]
			[Address(RVA = "0x1961380", Offset = "0x195FF80", VA = "0x181961380", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x0601FA33 RID: 129587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A1E")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA33")]
			[Address(RVA = "0x1961320", Offset = "0x195FF20", VA = "0x181961320", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA34 RID: 129588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA34")]
		[Address(RVA = "0x1960E90", Offset = "0x195FA90", VA = "0x181960E90", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA35 RID: 129589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA35")]
		[Address(RVA = "0x1960F60", Offset = "0x195FB60", VA = "0x181960F60", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA36 RID: 129590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA36")]
		[Address(RVA = "0x1961260", Offset = "0x195FE60", VA = "0x181961260")]
		public RoguelikeRewardSimpleView()
		{
		}

		// Token: 0x0402AA1E RID: 174622
		[Token(Token = "0x402AA1E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _itemBg;

		// Token: 0x0402AA1F RID: 174623
		[Token(Token = "0x402AA1F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x0402AA20 RID: 174624
		[Token(Token = "0x402AA20")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402AA21 RID: 174625
		[Token(Token = "0x402AA21")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0402AA22 RID: 174626
		[Token(Token = "0x402AA22")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RoguelikeRewardShowTypeSet _showType;

		// Token: 0x0402AA23 RID: 174627
		[Token(Token = "0x402AA23")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402AA24 RID: 174628
		[Token(Token = "0x402AA24")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402AA26 RID: 174630
		[Token(Token = "0x402AA26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402AA27 RID: 174631
		[Token(Token = "0x402AA27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402AA28 RID: 174632
		[Token(Token = "0x402AA28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402AA29 RID: 174633
		[Token(Token = "0x402AA29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402AA2A RID: 174634
		[Token(Token = "0x402AA2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AA2B RID: 174635
		[Token(Token = "0x402AA2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

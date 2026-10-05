using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F5 RID: 21493
	[Token(Token = "0x20053F5")]
	public class RoguelikeRewardRecruitView : RoguelikeRewardItem
	{
		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x0601F9F8 RID: 129528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9F9 RID: 129529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A11")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9F8")]
			[Address(RVA = "0x195C4F0", Offset = "0x195B0F0", VA = "0x18195C4F0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F9F9")]
			[Address(RVA = "0x195C5B0", Offset = "0x195B1B0", VA = "0x18195C5B0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x0601F9FA RID: 129530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A12")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F9FA")]
			[Address(RVA = "0x195C550", Offset = "0x195B150", VA = "0x18195C550", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9FB RID: 129531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9FB")]
		[Address(RVA = "0x195BF60", Offset = "0x195AB60", VA = "0x18195BF60", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F9FC RID: 129532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9FC")]
		[Address(RVA = "0x195C030", Offset = "0x195AC30", VA = "0x18195C030", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F9FD RID: 129533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9FD")]
		[Address(RVA = "0x195C490", Offset = "0x195B090", VA = "0x18195C490")]
		public RoguelikeRewardRecruitView()
		{
		}

		// Token: 0x0402A9A1 RID: 174497
		[Token(Token = "0x402A9A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _recruitBg;

		// Token: 0x0402A9A2 RID: 174498
		[Token(Token = "0x402A9A2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _recruitIcon;

		// Token: 0x0402A9A3 RID: 174499
		[Token(Token = "0x402A9A3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _recruitName;

		// Token: 0x0402A9A4 RID: 174500
		[Token(Token = "0x402A9A4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402A9A5 RID: 174501
		[Token(Token = "0x402A9A5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelUpgrade;

		// Token: 0x0402A9A6 RID: 174502
		[Token(Token = "0x402A9A6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textUpgrade;

		// Token: 0x0402A9A7 RID: 174503
		[Token(Token = "0x402A9A7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A9A8 RID: 174504
		[Token(Token = "0x402A9A8")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A9A9 RID: 174505
		[Token(Token = "0x402A9A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A9AA RID: 174506
		[Token(Token = "0x402A9AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A9AB RID: 174507
		[Token(Token = "0x402A9AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A9AC RID: 174508
		[Token(Token = "0x402A9AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A9AD RID: 174509
		[Token(Token = "0x402A9AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A9AE RID: 174510
		[Token(Token = "0x402A9AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

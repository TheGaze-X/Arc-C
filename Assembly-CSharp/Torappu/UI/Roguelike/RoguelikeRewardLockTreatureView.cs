using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F2 RID: 21490
	[Token(Token = "0x20053F2")]
	public class RoguelikeRewardLockTreatureView : RoguelikeRewardItem
	{
		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x0601F9EA RID: 129514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9EB RID: 129515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A0D")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9EA")]
			[Address(RVA = "0x195B760", Offset = "0x195A360", VA = "0x18195B760", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F9EB")]
			[Address(RVA = "0x195B820", Offset = "0x195A420", VA = "0x18195B820", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x0601F9EC RID: 129516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A0E")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F9EC")]
			[Address(RVA = "0x195B7C0", Offset = "0x195A3C0", VA = "0x18195B7C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9ED RID: 129517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9ED")]
		[Address(RVA = "0x195B310", Offset = "0x1959F10", VA = "0x18195B310", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F9EE RID: 129518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9EE")]
		[Address(RVA = "0x195B3E0", Offset = "0x1959FE0", VA = "0x18195B3E0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F9EF RID: 129519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9EF")]
		[Address(RVA = "0x195B700", Offset = "0x195A300", VA = "0x18195B700")]
		public RoguelikeRewardLockTreatureView()
		{
		}

		// Token: 0x0402A983 RID: 174467
		[Token(Token = "0x402A983")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _treasureIcon;

		// Token: 0x0402A984 RID: 174468
		[Token(Token = "0x402A984")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _treasureBg;

		// Token: 0x0402A985 RID: 174469
		[Token(Token = "0x402A985")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _name;

		// Token: 0x0402A986 RID: 174470
		[Token(Token = "0x402A986")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402A987 RID: 174471
		[Token(Token = "0x402A987")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A988 RID: 174472
		[Token(Token = "0x402A988")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402A98A RID: 174474
		[Token(Token = "0x402A98A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A98B RID: 174475
		[Token(Token = "0x402A98B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A98C RID: 174476
		[Token(Token = "0x402A98C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A98D RID: 174477
		[Token(Token = "0x402A98D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A98E RID: 174478
		[Token(Token = "0x402A98E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A98F RID: 174479
		[Token(Token = "0x402A98F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

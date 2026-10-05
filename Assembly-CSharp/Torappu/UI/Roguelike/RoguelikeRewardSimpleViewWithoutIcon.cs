using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005402 RID: 21506
	[Token(Token = "0x2005402")]
	public class RoguelikeRewardSimpleViewWithoutIcon : RoguelikeRewardItem
	{
		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x0601FA37 RID: 129591 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA38 RID: 129592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A1F")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601FA37")]
			[Address(RVA = "0x1960D50", Offset = "0x195F950", VA = "0x181960D50", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601FA38")]
			[Address(RVA = "0x1960E10", Offset = "0x195FA10", VA = "0x181960E10", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x0601FA39 RID: 129593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A20")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA39")]
			[Address(RVA = "0x1960DB0", Offset = "0x195F9B0", VA = "0x181960DB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA3A RID: 129594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA3A")]
		[Address(RVA = "0x19609D0", Offset = "0x195F5D0", VA = "0x1819609D0", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA3B RID: 129595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA3B")]
		[Address(RVA = "0x1960AA0", Offset = "0x195F6A0", VA = "0x181960AA0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA3C RID: 129596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA3C")]
		[Address(RVA = "0x1960CF0", Offset = "0x195F8F0", VA = "0x181960CF0")]
		public RoguelikeRewardSimpleViewWithoutIcon()
		{
		}

		// Token: 0x0402AA2C RID: 174636
		[Token(Token = "0x402AA2C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _itemBg;

		// Token: 0x0402AA2D RID: 174637
		[Token(Token = "0x402AA2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402AA2E RID: 174638
		[Token(Token = "0x402AA2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0402AA2F RID: 174639
		[Token(Token = "0x402AA2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RoguelikeRewardShowTypeSet _showType;

		// Token: 0x0402AA30 RID: 174640
		[Token(Token = "0x402AA30")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402AA32 RID: 174642
		[Token(Token = "0x402AA32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402AA33 RID: 174643
		[Token(Token = "0x402AA33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402AA34 RID: 174644
		[Token(Token = "0x402AA34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402AA35 RID: 174645
		[Token(Token = "0x402AA35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402AA36 RID: 174646
		[Token(Token = "0x402AA36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402AA37 RID: 174647
		[Token(Token = "0x402AA37")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

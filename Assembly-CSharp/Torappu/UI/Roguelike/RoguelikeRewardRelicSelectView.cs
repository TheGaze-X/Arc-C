using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053F8 RID: 21496
	[Token(Token = "0x20053F8")]
	public class RoguelikeRewardRelicSelectView : RoguelikeRewardItem
	{
		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x0601FA0D RID: 129549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601FA0E RID: 129550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A15")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601FA0D")]
			[Address(RVA = "0x195D800", Offset = "0x195C400", VA = "0x18195D800", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601FA0E")]
			[Address(RVA = "0x195D8C0", Offset = "0x195C4C0", VA = "0x18195D8C0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x0601FA0F RID: 129551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A16")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601FA0F")]
			[Address(RVA = "0x195D860", Offset = "0x195C460", VA = "0x18195D860", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FA10 RID: 129552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA10")]
		[Address(RVA = "0x195D3F0", Offset = "0x195BFF0", VA = "0x18195D3F0", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601FA11 RID: 129553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA11")]
		[Address(RVA = "0x195D4C0", Offset = "0x195C0C0", VA = "0x18195D4C0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601FA12 RID: 129554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA12")]
		[Address(RVA = "0x195D7A0", Offset = "0x195C3A0", VA = "0x18195D7A0")]
		public RoguelikeRewardRelicSelectView()
		{
		}

		// Token: 0x0402A9C6 RID: 174534
		[Token(Token = "0x402A9C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _selectBg;

		// Token: 0x0402A9C7 RID: 174535
		[Token(Token = "0x402A9C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402A9C8 RID: 174536
		[Token(Token = "0x402A9C8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A9C9 RID: 174537
		[Token(Token = "0x402A9C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A9CA RID: 174538
		[Token(Token = "0x402A9CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A9CB RID: 174539
		[Token(Token = "0x402A9CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A9CC RID: 174540
		[Token(Token = "0x402A9CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A9CD RID: 174541
		[Token(Token = "0x402A9CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A9CE RID: 174542
		[Token(Token = "0x402A9CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

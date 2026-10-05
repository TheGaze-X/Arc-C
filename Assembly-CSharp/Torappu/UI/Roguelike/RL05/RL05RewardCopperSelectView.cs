using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005649 RID: 22089
	[Token(Token = "0x2005649")]
	public class RL05RewardCopperSelectView : RoguelikeRewardItem
	{
		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x06020675 RID: 132725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020676 RID: 132726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BD3")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x6020675")]
			[Address(RVA = "0x1A7E510", Offset = "0x1A7D110", VA = "0x181A7E510", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020676")]
			[Address(RVA = "0x1A7E5D0", Offset = "0x1A7D1D0", VA = "0x181A7E5D0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x06020677 RID: 132727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BD4")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x6020677")]
			[Address(RVA = "0x1A7E570", Offset = "0x1A7D170", VA = "0x181A7E570", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020678 RID: 132728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020678")]
		[Address(RVA = "0x1A7E1E0", Offset = "0x1A7CDE0", VA = "0x181A7E1E0", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x06020679 RID: 132729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020679")]
		[Address(RVA = "0x1A7E2B0", Offset = "0x1A7CEB0", VA = "0x181A7E2B0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0602067A RID: 132730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602067A")]
		[Address(RVA = "0x1A7E4B0", Offset = "0x1A7D0B0", VA = "0x181A7E4B0")]
		public RL05RewardCopperSelectView()
		{
		}

		// Token: 0x0402BDED RID: 179693
		[Token(Token = "0x402BDED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _selectBg;

		// Token: 0x0402BDEE RID: 179694
		[Token(Token = "0x402BDEE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402BDEF RID: 179695
		[Token(Token = "0x402BDEF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402BDF0 RID: 179696
		[Token(Token = "0x402BDF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402BDF1 RID: 179697
		[Token(Token = "0x402BDF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402BDF2 RID: 179698
		[Token(Token = "0x402BDF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402BDF3 RID: 179699
		[Token(Token = "0x402BDF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402BDF4 RID: 179700
		[Token(Token = "0x402BDF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BDF5 RID: 179701
		[Token(Token = "0x402BDF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

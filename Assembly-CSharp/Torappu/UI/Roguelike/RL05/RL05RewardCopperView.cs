using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200564A RID: 22090
	[Token(Token = "0x200564A")]
	public class RL05RewardCopperView : RoguelikeRewardItem
	{
		// Token: 0x17004BD5 RID: 19413
		// (get) Token: 0x0602067B RID: 132731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BD5")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x602067B")]
			[Address(RVA = "0x1A7EBD0", Offset = "0x1A7D7D0", VA = "0x181A7EBD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004BD6 RID: 19414
		// (get) Token: 0x0602067C RID: 132732 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602067D RID: 132733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BD6")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x602067C")]
			[Address(RVA = "0x1A7EB70", Offset = "0x1A7D770", VA = "0x181A7EB70", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x602067D")]
			[Address(RVA = "0x1A7EC30", Offset = "0x1A7D830", VA = "0x181A7EC30", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602067E RID: 132734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602067E")]
		[Address(RVA = "0x1A7E650", Offset = "0x1A7D250", VA = "0x181A7E650", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0602067F RID: 132735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602067F")]
		[Address(RVA = "0x1A7E720", Offset = "0x1A7D320", VA = "0x181A7E720", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x06020680 RID: 132736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020680")]
		[Address(RVA = "0x1A7EB10", Offset = "0x1A7D710", VA = "0x181A7EB10")]
		public RL05RewardCopperView()
		{
		}

		// Token: 0x0402BDF6 RID: 179702
		[Token(Token = "0x402BDF6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _copperItemCardScale;

		// Token: 0x0402BDF7 RID: 179703
		[Token(Token = "0x402BDF7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _copperCardContainer;

		// Token: 0x0402BDF8 RID: 179704
		[Token(Token = "0x402BDF8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIColorGraphic _graphicColor;

		// Token: 0x0402BDF9 RID: 179705
		[Token(Token = "0x402BDF9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _copperBg;

		// Token: 0x0402BDFA RID: 179706
		[Token(Token = "0x402BDFA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _copperName;

		// Token: 0x0402BDFB RID: 179707
		[Token(Token = "0x402BDFB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402BDFC RID: 179708
		[Token(Token = "0x402BDFC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402BDFD RID: 179709
		[Token(Token = "0x402BDFD")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402BDFE RID: 179710
		[Token(Token = "0x402BDFE")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeCopperResHolder m_copperResHolder;

		// Token: 0x0402BDFF RID: 179711
		[Token(Token = "0x402BDFF")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeAbstractCopperItemCard m_copperCard;

		// Token: 0x0402BE01 RID: 179713
		[Token(Token = "0x402BE01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402BE02 RID: 179714
		[Token(Token = "0x402BE02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402BE03 RID: 179715
		[Token(Token = "0x402BE03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402BE04 RID: 179716
		[Token(Token = "0x402BE04")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402BE05 RID: 179717
		[Token(Token = "0x402BE05")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BE06 RID: 179718
		[Token(Token = "0x402BE06")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

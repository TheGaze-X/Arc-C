using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005725 RID: 22309
	[Token(Token = "0x2005725")]
	public class RL04RewardFragmentView : RoguelikeRewardItem
	{
		// Token: 0x17004CAC RID: 19628
		// (get) Token: 0x06020B2A RID: 133930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CAC")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x6020B2A")]
			[Address(RVA = "0x1B14690", Offset = "0x1B13290", VA = "0x181B14690", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004CAD RID: 19629
		// (get) Token: 0x06020B2B RID: 133931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020B2C RID: 133932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CAD")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x6020B2B")]
			[Address(RVA = "0x1B14630", Offset = "0x1B13230", VA = "0x181B14630", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020B2C")]
			[Address(RVA = "0x1B146F0", Offset = "0x1B132F0", VA = "0x181B146F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020B2D RID: 133933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B2D")]
		[Address(RVA = "0x1B13C10", Offset = "0x1B12810", VA = "0x181B13C10", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x06020B2E RID: 133934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B2E")]
		[Address(RVA = "0x1B14200", Offset = "0x1B12E00", VA = "0x181B14200")]
		private void _EnsureFragmentCard()
		{
		}

		// Token: 0x06020B2F RID: 133935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B2F")]
		[Address(RVA = "0x1B13CE0", Offset = "0x1B128E0", VA = "0x181B13CE0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x06020B30 RID: 133936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B30")]
		[Address(RVA = "0x1B143C0", Offset = "0x1B12FC0", VA = "0x181B143C0")]
		private void _RenderCombineInfo(bool needShow, RoguelikeFragmentModuleData fragmentData)
		{
		}

		// Token: 0x06020B31 RID: 133937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B31")]
		[Address(RVA = "0x1B145C0", Offset = "0x1B131C0", VA = "0x181B145C0")]
		public RL04RewardFragmentView()
		{
		}

		// Token: 0x0402C607 RID: 181767
		[Token(Token = "0x402C607")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RL04FragmentItemCard _fragmentCardPrefab;

		// Token: 0x0402C608 RID: 181768
		[Token(Token = "0x402C608")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _fragmentCardContainer;

		// Token: 0x0402C609 RID: 181769
		[Token(Token = "0x402C609")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIColorGraphic _graphicColor;

		// Token: 0x0402C60A RID: 181770
		[Token(Token = "0x402C60A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _fragmentBg;

		// Token: 0x0402C60B RID: 181771
		[Token(Token = "0x402C60B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0402C60C RID: 181772
		[Token(Token = "0x402C60C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _fragmentName;

		// Token: 0x0402C60D RID: 181773
		[Token(Token = "0x402C60D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _description;

		// Token: 0x0402C60E RID: 181774
		[Token(Token = "0x402C60E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelCombine;

		// Token: 0x0402C60F RID: 181775
		[Token(Token = "0x402C60F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCombine;

		// Token: 0x0402C610 RID: 181776
		[Token(Token = "0x402C610")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402C611 RID: 181777
		[Token(Token = "0x402C611")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _fragmentCardScale;

		// Token: 0x0402C612 RID: 181778
		[Token(Token = "0x402C612")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pagefd;

		// Token: 0x0402C613 RID: 181779
		[Token(Token = "0x402C613")]
		[FieldOffset(Offset = "0xB0")]
		private RL04FragmentItemCard m_fragmentCard;

		// Token: 0x0402C615 RID: 181781
		[Token(Token = "0x402C615")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402C616 RID: 181782
		[Token(Token = "0x402C616")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402C617 RID: 181783
		[Token(Token = "0x402C617")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402C618 RID: 181784
		[Token(Token = "0x402C618")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402C619 RID: 181785
		[Token(Token = "0x402C619")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnsureFragmentCard;

		// Token: 0x0402C61A RID: 181786
		[Token(Token = "0x402C61A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C61B RID: 181787
		[Token(Token = "0x402C61B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderCombineInfo;

		// Token: 0x0402C61C RID: 181788
		[Token(Token = "0x402C61C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}

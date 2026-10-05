using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Resource;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x020078BC RID: 30908
	[Token(Token = "0x20078BC")]
	public class Act1LockNormalDetailView : Act1LockDetailViewBase
	{
		// Token: 0x17006564 RID: 25956
		// (get) Token: 0x0602B574 RID: 177524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006564")]
		public Act1LockAutoBattleView autoBattleView
		{
			[Token(Token = "0x602B574")]
			[Address(RVA = "0x272DE90", Offset = "0x272CA90", VA = "0x18272DE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006565 RID: 25957
		// (get) Token: 0x0602B575 RID: 177525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B576 RID: 177526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006565")]
		public Action onBtnEnemy
		{
			[Token(Token = "0x602B575")]
			[Address(RVA = "0x272DFB0", Offset = "0x272CBB0", VA = "0x18272DFB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B576")]
			[Address(RVA = "0x272E1D0", Offset = "0x272CDD0", VA = "0x18272E1D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006566 RID: 25958
		// (get) Token: 0x0602B577 RID: 177527 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B578 RID: 177528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006566")]
		public Action onBtnPractice
		{
			[Token(Token = "0x602B577")]
			[Address(RVA = "0x272E010", Offset = "0x272CC10", VA = "0x18272E010")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B578")]
			[Address(RVA = "0x272E250", Offset = "0x272CE50", VA = "0x18272E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006567 RID: 25959
		// (get) Token: 0x0602B579 RID: 177529 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B57A RID: 177530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006567")]
		public Action onBtnBattle
		{
			[Token(Token = "0x602B579")]
			[Address(RVA = "0x272DF50", Offset = "0x272CB50", VA = "0x18272DF50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B57A")]
			[Address(RVA = "0x272E150", Offset = "0x272CD50", VA = "0x18272E150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006568 RID: 25960
		// (get) Token: 0x0602B57B RID: 177531 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B57C RID: 177532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006568")]
		public Action onAutoBattleToggle
		{
			[Token(Token = "0x602B57B")]
			[Address(RVA = "0x272DEF0", Offset = "0x272CAF0", VA = "0x18272DEF0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B57C")]
			[Address(RVA = "0x272E0D0", Offset = "0x272CCD0", VA = "0x18272E0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006569 RID: 25961
		// (get) Token: 0x0602B57D RID: 177533 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B57E RID: 177534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006569")]
		public Action onBtnReward
		{
			[Token(Token = "0x602B57D")]
			[Address(RVA = "0x272E070", Offset = "0x272CC70", VA = "0x18272E070")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B57E")]
			[Address(RVA = "0x272E2D0", Offset = "0x272CED0", VA = "0x18272E2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B57F RID: 177535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B57F")]
		[Address(RVA = "0x272C790", Offset = "0x272B390", VA = "0x18272C790", Slot = "9")]
		protected override void OnDataUpdated(Act1LockDetailProperty prop)
		{
		}

		// Token: 0x0602B580 RID: 177536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B580")]
		[Address(RVA = "0x272D950", Offset = "0x272C550", VA = "0x18272D950")]
		private void _UpdateView(Act1LockNormalDetailModel detailModel)
		{
		}

		// Token: 0x0602B581 RID: 177537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B581")]
		[Address(RVA = "0x272CFC0", Offset = "0x272BBC0", VA = "0x18272CFC0")]
		private void _CleanAnimTween()
		{
		}

		// Token: 0x0602B582 RID: 177538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B582")]
		[Address(RVA = "0x272D250", Offset = "0x272BE50", VA = "0x18272D250")]
		private void _LoadMapPreview(string stageId)
		{
		}

		// Token: 0x0602B583 RID: 177539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B583")]
		[Address(RVA = "0x272D650", Offset = "0x272C250", VA = "0x18272D650")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x0602B584 RID: 177540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B584")]
		[Address(RVA = "0x272D740", Offset = "0x272C340", VA = "0x18272D740")]
		private void _UpdateRewardList(StageViewModel selectedStageModel)
		{
		}

		// Token: 0x0602B585 RID: 177541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B585")]
		[Address(RVA = "0x272D070", Offset = "0x272BC70", VA = "0x18272D070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B586 RID: 177542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B586")]
		[Address(RVA = "0x272D3E0", Offset = "0x272BFE0", VA = "0x18272D3E0")]
		private void _SwitchExpandStatus()
		{
		}

		// Token: 0x0602B587 RID: 177543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B587")]
		[Address(RVA = "0x272C2F0", Offset = "0x272AEF0", VA = "0x18272C2F0")]
		public void OnBtnEnemyClick()
		{
		}

		// Token: 0x0602B588 RID: 177544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B588")]
		[Address(RVA = "0x272C570", Offset = "0x272B170", VA = "0x18272C570")]
		public void OnBtnStartBattleClick()
		{
		}

		// Token: 0x0602B589 RID: 177545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B589")]
		[Address(RVA = "0x272C680", Offset = "0x272B280", VA = "0x18272C680")]
		public void OnBtnStartPractiseClick()
		{
		}

		// Token: 0x0602B58A RID: 177546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B58A")]
		[Address(RVA = "0x272C400", Offset = "0x272B000", VA = "0x18272C400")]
		public void OnBtnExpandClick()
		{
		}

		// Token: 0x0602B58B RID: 177547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B58B")]
		[Address(RVA = "0x272C1E0", Offset = "0x272ADE0", VA = "0x18272C1E0")]
		public void OnBtnAutoBattleClick()
		{
		}

		// Token: 0x0602B58C RID: 177548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B58C")]
		[Address(RVA = "0x272C460", Offset = "0x272B060", VA = "0x18272C460")]
		public void OnBtnRewardClick()
		{
		}

		// Token: 0x0602B58D RID: 177549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B58D")]
		[Address(RVA = "0x272DD90", Offset = "0x272C990", VA = "0x18272DD90")]
		public Act1LockNormalDetailView()
		{
		}

		// Token: 0x0602B58E RID: 177550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B58E")]
		[Address(RVA = "0x271E7F0", Offset = "0x271D3F0", VA = "0x18271E7F0")]
		private void <>xLuaBaseProxy_OnDataUpdated(Act1LockDetailProperty P0)
		{
		}

		// Token: 0x0403EAA1 RID: 256673
		[Token(Token = "0x403EAA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textType;

		// Token: 0x0403EAA2 RID: 256674
		[Token(Token = "0x403EAA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x0403EAA3 RID: 256675
		[Token(Token = "0x403EAA3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403EAA4 RID: 256676
		[Token(Token = "0x403EAA4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDifficulty;

		// Token: 0x0403EAA5 RID: 256677
		[Token(Token = "0x403EAA5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403EAA6 RID: 256678
		[Token(Token = "0x403EAA6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textApCost;

		// Token: 0x0403EAA7 RID: 256679
		[Token(Token = "0x403EAA7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgMapPreview;

		// Token: 0x0403EAA8 RID: 256680
		[Token(Token = "0x403EAA8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _rewardList;

		// Token: 0x0403EAA9 RID: 256681
		[Token(Token = "0x403EAA9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private StagePreviewRankView _rankView;

		// Token: 0x0403EAAA RID: 256682
		[Token(Token = "0x403EAAA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animation;

		// Token: 0x0403EAAB RID: 256683
		[Token(Token = "0x403EAAB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act1LockAutoBattleView _autoBattleView;

		// Token: 0x0403EAAC RID: 256684
		[Token(Token = "0x403EAAC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private StagePreviewApStatusBinder _apStatusView;

		// Token: 0x0403EAB2 RID: 256690
		[Token(Token = "0x403EAB2")]
		[FieldOffset(Offset = "0xD8")]
		private Act1LockDetailProperty m_property;

		// Token: 0x0403EAB3 RID: 256691
		[Token(Token = "0x403EAB3")]
		[FieldOffset(Offset = "0xE0")]
		private Act1LockNormalDetailModel m_detailModel;

		// Token: 0x0403EAB4 RID: 256692
		[Token(Token = "0x403EAB4")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x0403EAB5 RID: 256693
		[Token(Token = "0x403EAB5")]
		[FieldOffset(Offset = "0xF0")]
		private Act1LockNormalDetailView.RewardPreviewAdapter m_rewardAdapter;

		// Token: 0x0403EAB6 RID: 256694
		[Token(Token = "0x403EAB6")]
		[FieldOffset(Offset = "0xF8")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x0403EAB7 RID: 256695
		[Token(Token = "0x403EAB7")]
		[FieldOffset(Offset = "0x100")]
		private Sprite m_stagePreviewMap;

		// Token: 0x0403EAB8 RID: 256696
		[Token(Token = "0x403EAB8")]
		[FieldOffset(Offset = "0x108")]
		private string m_stageId;

		// Token: 0x0403EAB9 RID: 256697
		[Token(Token = "0x403EAB9")]
		[FieldOffset(Offset = "0x110")]
		private Tween m_expandTween;

		// Token: 0x0403EABA RID: 256698
		[Token(Token = "0x403EABA")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isAniming;

		// Token: 0x0403EABB RID: 256699
		[Token(Token = "0x403EABB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_autoBattleView;

		// Token: 0x0403EABC RID: 256700
		[Token(Token = "0x403EABC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onBtnEnemy;

		// Token: 0x0403EABD RID: 256701
		[Token(Token = "0x403EABD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onBtnEnemy;

		// Token: 0x0403EABE RID: 256702
		[Token(Token = "0x403EABE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onBtnPractice;

		// Token: 0x0403EABF RID: 256703
		[Token(Token = "0x403EABF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_onBtnPractice;

		// Token: 0x0403EAC0 RID: 256704
		[Token(Token = "0x403EAC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onBtnBattle;

		// Token: 0x0403EAC1 RID: 256705
		[Token(Token = "0x403EAC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_onBtnBattle;

		// Token: 0x0403EAC2 RID: 256706
		[Token(Token = "0x403EAC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onAutoBattleToggle;

		// Token: 0x0403EAC3 RID: 256707
		[Token(Token = "0x403EAC3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_onAutoBattleToggle;

		// Token: 0x0403EAC4 RID: 256708
		[Token(Token = "0x403EAC4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_onBtnReward;

		// Token: 0x0403EAC5 RID: 256709
		[Token(Token = "0x403EAC5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_onBtnReward;

		// Token: 0x0403EAC6 RID: 256710
		[Token(Token = "0x403EAC6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0403EAC7 RID: 256711
		[Token(Token = "0x403EAC7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x0403EAC8 RID: 256712
		[Token(Token = "0x403EAC8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CleanAnimTween;

		// Token: 0x0403EAC9 RID: 256713
		[Token(Token = "0x403EAC9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadMapPreview;

		// Token: 0x0403EACA RID: 256714
		[Token(Token = "0x403EACA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x0403EACB RID: 256715
		[Token(Token = "0x403EACB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateRewardList;

		// Token: 0x0403EACC RID: 256716
		[Token(Token = "0x403EACC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403EACD RID: 256717
		[Token(Token = "0x403EACD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwitchExpandStatus;

		// Token: 0x0403EACE RID: 256718
		[Token(Token = "0x403EACE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBtnEnemyClick;

		// Token: 0x0403EACF RID: 256719
		[Token(Token = "0x403EACF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnBtnStartBattleClick;

		// Token: 0x0403EAD0 RID: 256720
		[Token(Token = "0x403EAD0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnBtnStartPractiseClick;

		// Token: 0x0403EAD1 RID: 256721
		[Token(Token = "0x403EAD1")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnBtnExpandClick;

		// Token: 0x0403EAD2 RID: 256722
		[Token(Token = "0x403EAD2")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnBtnAutoBattleClick;

		// Token: 0x0403EAD3 RID: 256723
		[Token(Token = "0x403EAD3")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnBtnRewardClick;

		// Token: 0x0403EAD4 RID: 256724
		[Token(Token = "0x403EAD4")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078BD RID: 30909
		[Token(Token = "0x20078BD")]
		private class RewardPreviewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700656A RID: 25962
			// (get) Token: 0x0602B58F RID: 177551 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602B590 RID: 177552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700656A")]
			public List<StageRewardViewModel> cardModels
			{
				[Token(Token = "0x602B58F")]
				[Address(RVA = "0x2734540", Offset = "0x2733140", VA = "0x182734540")]
				get
				{
					return null;
				}
				[Token(Token = "0x602B590")]
				[Address(RVA = "0x27349D0", Offset = "0x27335D0", VA = "0x1827349D0")]
				set
				{
				}
			}

			// Token: 0x1700656B RID: 25963
			// (get) Token: 0x0602B591 RID: 177553 RVA: 0x000DB750 File Offset: 0x000D9950
			[Token(Token = "0x1700656B")]
			public override int count
			{
				[Token(Token = "0x602B591")]
				[Address(RVA = "0x2734710", Offset = "0x2733310", VA = "0x182734710", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B592 RID: 177554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B592")]
			[Address(RVA = "0x2734200", Offset = "0x2732E00", VA = "0x182734200", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B593 RID: 177555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B593")]
			[Address(RVA = "0x2734420", Offset = "0x2733020", VA = "0x182734420")]
			public RewardPreviewAdapter()
			{
			}

			// Token: 0x0403EAD5 RID: 256725
			[Token(Token = "0x403EAD5")]
			private const int MAX_ITEM_COUNT = 3;

			// Token: 0x0403EAD6 RID: 256726
			[Token(Token = "0x403EAD6")]
			[FieldOffset(Offset = "0x20")]
			private List<StageRewardViewModel> m_cardModels;

			// Token: 0x0403EAD7 RID: 256727
			[Token(Token = "0x403EAD7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_cardModels;

			// Token: 0x0403EAD8 RID: 256728
			[Token(Token = "0x403EAD8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_cardModels;

			// Token: 0x0403EAD9 RID: 256729
			[Token(Token = "0x403EAD9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403EADA RID: 256730
			[Token(Token = "0x403EADA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403EADB RID: 256731
			[Token(Token = "0x403EADB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

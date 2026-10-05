using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007826 RID: 30758
	[Token(Token = "0x2007826")]
	public class Act1VHalfIdleBattleFinishNormalView : Act1VHalfIdleBattleFinishSubViewBase
	{
		// Token: 0x0602B24E RID: 176718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B24E")]
		[Address(RVA = "0x26F3EE0", Offset = "0x26F2AE0", VA = "0x1826F3EE0")]
		public void UpdateView(Act1VHalfIdleBattleFinishViewModel model)
		{
		}

		// Token: 0x0602B24F RID: 176719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B24F")]
		[Address(RVA = "0x26F4B50", Offset = "0x26F3750", VA = "0x1826F4B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B250 RID: 176720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B250")]
		[Address(RVA = "0x26F3E30", Offset = "0x26F2A30", VA = "0x1826F3E30", Slot = "4")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602B251 RID: 176721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B251")]
		[Address(RVA = "0x26F3D80", Offset = "0x26F2980", VA = "0x1826F3D80")]
		public IEnumerator PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x0602B252 RID: 176722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B252")]
		[Address(RVA = "0x26F4E10", Offset = "0x26F3A10", VA = "0x1826F4E10")]
		private void _PlayVoice(CharUISkinStruct skin, CharWordShowType charWordShowType)
		{
		}

		// Token: 0x0602B253 RID: 176723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B253")]
		[Address(RVA = "0x26F3D00", Offset = "0x26F2900", VA = "0x1826F3D00")]
		public void EventOnComplete()
		{
		}

		// Token: 0x0602B254 RID: 176724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B254")]
		[Address(RVA = "0x26F5020", Offset = "0x26F3C20", VA = "0x1826F5020")]
		public Act1VHalfIdleBattleFinishNormalView()
		{
		}

		// Token: 0x0602B255 RID: 176725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B255")]
		[Address(RVA = "0x26F3590", Offset = "0x26F2190", VA = "0x1826F3590")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0403E5D6 RID: 255446
		[Token(Token = "0x403E5D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _minLife;

		// Token: 0x0403E5D7 RID: 255447
		[Token(Token = "0x403E5D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E5D8 RID: 255448
		[Token(Token = "0x403E5D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _lvlUpEntryAnim;

		// Token: 0x0403E5D9 RID: 255449
		[Token(Token = "0x403E5D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Anim")]
		private float _rewardItemEntryDelay;

		// Token: 0x0403E5DA RID: 255450
		[Token(Token = "0x403E5DA")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Anim")]
		private float _entryDelay;

		// Token: 0x0403E5DB RID: 255451
		[Token(Token = "0x403E5DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Illust")]
		private Text _playerName;

		// Token: 0x0403E5DC RID: 255452
		[Token(Token = "0x403E5DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Illust")]
		private Text _finishTime;

		// Token: 0x0403E5DD RID: 255453
		[Token(Token = "0x403E5DD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Illust")]
		private RectTransform _illustContainer;

		// Token: 0x0403E5DE RID: 255454
		[Token(Token = "0x403E5DE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Suqad")]
		private SimpleLayoutContent _charSqudLine1;

		// Token: 0x0403E5DF RID: 255455
		[Token(Token = "0x403E5DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Suqad")]
		private SimpleLayoutContent _charSqudLine2;

		// Token: 0x0403E5E0 RID: 255456
		[Token(Token = "0x403E5E0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Suqad")]
		private SimpleLayoutContent _plotSquadList;

		// Token: 0x0403E5E1 RID: 255457
		[Token(Token = "0x403E5E1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("MileStone")]
		private Image _milestoneIcon;

		// Token: 0x0403E5E2 RID: 255458
		[Token(Token = "0x403E5E2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("MileStone")]
		private Text _milestoneAdd;

		// Token: 0x0403E5E3 RID: 255459
		[Token(Token = "0x403E5E3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("MileStone")]
		private Slider _milestonePrg;

		// Token: 0x0403E5E4 RID: 255460
		[Token(Token = "0x403E5E4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("MileStone")]
		private Text _milestoneLvl;

		// Token: 0x0403E5E5 RID: 255461
		[Token(Token = "0x403E5E5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("MileStone")]
		private GameObject _milestoneMaxNode;

		// Token: 0x0403E5E6 RID: 255462
		[Token(Token = "0x403E5E6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("MileStone")]
		private GameObject _milestoneLvlUpNode;

		// Token: 0x0403E5E7 RID: 255463
		[Token(Token = "0x403E5E7")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("RewardItem")]
		private SimpleLayoutContent _rewardItemList;

		// Token: 0x0403E5E8 RID: 255464
		[Token(Token = "0x403E5E8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("RewardItem")]
		private ScrollRect _rewardItemScroll;

		// Token: 0x0403E5E9 RID: 255465
		[Token(Token = "0x403E5E9")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("RewardItem")]
		private TwoStateToggle _rewardToggle;

		// Token: 0x0403E5EA RID: 255466
		[Token(Token = "0x403E5EA")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Stage")]
		private Text _stageName;

		// Token: 0x0403E5EB RID: 255467
		[Token(Token = "0x403E5EB")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Stage")]
		private Text _stageCode;

		// Token: 0x0403E5EC RID: 255468
		[Token(Token = "0x403E5EC")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Stage")]
		private TwoStateToggle _bossState;

		// Token: 0x0403E5ED RID: 255469
		[Token(Token = "0x403E5ED")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Stage")]
		private Text _stagePrgText;

		// Token: 0x0403E5EE RID: 255470
		[Token(Token = "0x403E5EE")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private InputField _testInput;

		// Token: 0x0403E5EF RID: 255471
		[Token(Token = "0x403E5EF")]
		[FieldOffset(Offset = "0xE8")]
		private float m_updateTime;

		// Token: 0x0403E5F0 RID: 255472
		[Token(Token = "0x403E5F0")]
		[FieldOffset(Offset = "0xF0")]
		private Act1VHalfIdleBattleFinishViewModel m_cachedModel;

		// Token: 0x0403E5F1 RID: 255473
		[Token(Token = "0x403E5F1")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleBattleFinishNormalView.CharSquadLineAdapter m_squadLine1Adapter;

		// Token: 0x0403E5F2 RID: 255474
		[Token(Token = "0x403E5F2")]
		[FieldOffset(Offset = "0x100")]
		private Act1VHalfIdleBattleFinishNormalView.CharSquadLineAdapter m_squadLine2Adapter;

		// Token: 0x0403E5F3 RID: 255475
		[Token(Token = "0x403E5F3")]
		[FieldOffset(Offset = "0x108")]
		private Act1VHalfIdleBattleFinishNormalView.RewardItemListAdapter m_reardItemAdapter;

		// Token: 0x0403E5F4 RID: 255476
		[Token(Token = "0x403E5F4")]
		[FieldOffset(Offset = "0x110")]
		private Act1VHalfIdleBattleFinishNormalView.PlotItemListAdapter m_plotListAdatper;

		// Token: 0x0403E5F5 RID: 255477
		[Token(Token = "0x403E5F5")]
		[FieldOffset(Offset = "0x118")]
		private UICharacterIllust m_cacheIllust;

		// Token: 0x0403E5F6 RID: 255478
		[Token(Token = "0x403E5F6")]
		[FieldOffset(Offset = "0x120")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E5F7 RID: 255479
		[Token(Token = "0x403E5F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403E5F8 RID: 255480
		[Token(Token = "0x403E5F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E5F9 RID: 255481
		[Token(Token = "0x403E5F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403E5FA RID: 255482
		[Token(Token = "0x403E5FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayEntryAnim;

		// Token: 0x0403E5FB RID: 255483
		[Token(Token = "0x403E5FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayVoice;

		// Token: 0x0403E5FC RID: 255484
		[Token(Token = "0x403E5FC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnComplete;

		// Token: 0x0403E5FD RID: 255485
		[Token(Token = "0x403E5FD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007827 RID: 30759
		[Token(Token = "0x2007827")]
		private class CharSquadLineAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170064EE RID: 25838
			// (get) Token: 0x0602B256 RID: 176726 RVA: 0x000DAF58 File Offset: 0x000D9158
			[Token(Token = "0x170064EE")]
			public override int count
			{
				[Token(Token = "0x602B256")]
				[Address(RVA = "0x2704160", Offset = "0x2702D60", VA = "0x182704160", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B257 RID: 176727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B257")]
			[Address(RVA = "0x2703E10", Offset = "0x2702A10", VA = "0x182703E10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B258 RID: 176728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B258")]
			[Address(RVA = "0x2703CE0", Offset = "0x27028E0", VA = "0x182703CE0")]
			public void PlayLvlUpAnim()
			{
			}

			// Token: 0x0602B259 RID: 176729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B259")]
			[Address(RVA = "0x2704100", Offset = "0x2702D00", VA = "0x182704100")]
			public CharSquadLineAdapter()
			{
			}

			// Token: 0x0403E5FE RID: 255486
			[Token(Token = "0x403E5FE")]
			private const int COUNT_PER_LINE = 6;

			// Token: 0x0403E5FF RID: 255487
			[Token(Token = "0x403E5FF")]
			[FieldOffset(Offset = "0x20")]
			public bool firstLine;

			// Token: 0x0403E600 RID: 255488
			[Token(Token = "0x403E600")]
			[FieldOffset(Offset = "0x28")]
			public List<Act1VHalfIdleBattleFinishCharCardViewModel> charSquad;

			// Token: 0x0403E601 RID: 255489
			[Token(Token = "0x403E601")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E602 RID: 255490
			[Token(Token = "0x403E602")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403E603 RID: 255491
			[Token(Token = "0x403E603")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PlayLvlUpAnim;

			// Token: 0x0403E604 RID: 255492
			[Token(Token = "0x403E604")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007828 RID: 30760
		[Token(Token = "0x2007828")]
		private abstract class NormalSimpleLayoutAdatper<ViewType, ModelType> : SimpleLayoutAdapter where ViewType : MonoBehaviour, IAct1VHalfIdleSimpleItemView<ModelType>
		{
			// Token: 0x170064EF RID: 25839
			// (get) Token: 0x0602B25A RID: 176730 RVA: 0x000DAF70 File Offset: 0x000D9170
			[Token(Token = "0x170064EF")]
			public override int count
			{
				[Token(Token = "0x602B25A")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B25B RID: 176731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B25B")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602B25C RID: 176732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B25C")]
			protected NormalSimpleLayoutAdatper()
			{
			}

			// Token: 0x0403E605 RID: 255493
			[Token(Token = "0x403E605")]
			[FieldOffset(Offset = "0x0")]
			public List<ModelType> itemList;

			// Token: 0x0403E606 RID: 255494
			[Token(Token = "0x403E606")]
			[FieldOffset(Offset = "0x0")]
			public int testCnt;

			// Token: 0x0403E607 RID: 255495
			[Token(Token = "0x403E607")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E608 RID: 255496
			[Token(Token = "0x403E608")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403E609 RID: 255497
			[Token(Token = "0x403E609")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007829 RID: 30761
		[Token(Token = "0x2007829")]
		private class RewardItemListAdapter : Act1VHalfIdleBattleFinishNormalView.NormalSimpleLayoutAdatper<Act1VHalfIdleBattleFinishRewardItemView, Act1VHalfIdleStuffDepotItemViewModel>
		{
			// Token: 0x0602B25D RID: 176733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B25D")]
			[Address(RVA = "0x2704DF0", Offset = "0x27039F0", VA = "0x182704DF0")]
			public void PlayEntryAnim(float delay)
			{
			}

			// Token: 0x0602B25E RID: 176734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B25E")]
			[Address(RVA = "0x2704F30", Offset = "0x2703B30", VA = "0x182704F30")]
			public RewardItemListAdapter()
			{
			}

			// Token: 0x0403E60A RID: 255498
			[Token(Token = "0x403E60A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_PlayEntryAnim;

			// Token: 0x0403E60B RID: 255499
			[Token(Token = "0x403E60B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200782A RID: 30762
		[Token(Token = "0x200782A")]
		private class PlotItemListAdapter : Act1VHalfIdleBattleFinishNormalView.NormalSimpleLayoutAdatper<Act1VHalfIdleBattleFinishPlotCardView, Act1VHalfIdleBattleFinishPlotCardViewModel>
		{
			// Token: 0x0602B25F RID: 176735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B25F")]
			[Address(RVA = "0x2704CB0", Offset = "0x27038B0", VA = "0x182704CB0")]
			public PlotItemListAdapter()
			{
			}

			// Token: 0x0403E60C RID: 255500
			[Token(Token = "0x403E60C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

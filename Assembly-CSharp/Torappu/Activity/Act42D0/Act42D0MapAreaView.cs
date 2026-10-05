using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200739A RID: 29594
	[Token(Token = "0x200739A")]
	public class Act42D0MapAreaView : DataBinder<Act42d0AreaMapProperty>
	{
		// Token: 0x06029D52 RID: 171346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D52")]
		[Address(RVA = "0x2570E80", Offset = "0x256FA80", VA = "0x182570E80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D53 RID: 171347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D53")]
		[Address(RVA = "0x2571590", Offset = "0x2570190", VA = "0x182571590")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x06029D54 RID: 171348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D54")]
		[Address(RVA = "0x25701C0", Offset = "0x256EDC0", VA = "0x1825701C0", Slot = "7")]
		public override void OnValueChanged(Act42d0AreaMapProperty property)
		{
		}

		// Token: 0x06029D55 RID: 171349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D55")]
		[Address(RVA = "0x2571770", Offset = "0x2570370", VA = "0x182571770")]
		private void _RenderDetail(Act42d0AreaViewModel areaModel)
		{
		}

		// Token: 0x06029D56 RID: 171350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D56")]
		[Address(RVA = "0x2571BA0", Offset = "0x25707A0", VA = "0x182571BA0")]
		private void _RenderStageSelectedItems(Act42d0AreaViewModel areaModel, bool areaChanged)
		{
		}

		// Token: 0x06029D57 RID: 171351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D57")]
		[Address(RVA = "0x25708F0", Offset = "0x256F4F0", VA = "0x1825708F0")]
		private void _CheckAnimation(string previousAreaSelectedId, int previousStageSelectedIndex)
		{
		}

		// Token: 0x06029D58 RID: 171352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D58")]
		[Address(RVA = "0x2570BD0", Offset = "0x256F7D0", VA = "0x182570BD0")]
		private void _CheckSelectStageAnimation(string previousAreaSelectedId)
		{
		}

		// Token: 0x06029D59 RID: 171353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D59")]
		[Address(RVA = "0x2570CB0", Offset = "0x256F8B0", VA = "0x182570CB0")]
		private void _CheckStageDetailAnimation(int previousStageSelectedIndex)
		{
		}

		// Token: 0x06029D5A RID: 171354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5A")]
		[Address(RVA = "0x2570B00", Offset = "0x256F700", VA = "0x182570B00")]
		private void _CheckBottomMenuAnimation()
		{
		}

		// Token: 0x06029D5B RID: 171355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5B")]
		[Address(RVA = "0x25714F0", Offset = "0x25700F0", VA = "0x1825714F0")]
		private void _NotifyFirstStageSelected()
		{
		}

		// Token: 0x06029D5C RID: 171356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5C")]
		[Address(RVA = "0x2571450", Offset = "0x2570050", VA = "0x182571450")]
		private void _NotifyAreaSelected()
		{
		}

		// Token: 0x06029D5D RID: 171357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5D")]
		[Address(RVA = "0x256FF00", Offset = "0x256EB00", VA = "0x18256FF00")]
		public void OnClickEnemy()
		{
		}

		// Token: 0x06029D5E RID: 171358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5E")]
		[Address(RVA = "0x2570020", Offset = "0x256EC20", VA = "0x182570020")]
		public void OnClickMap()
		{
		}

		// Token: 0x06029D5F RID: 171359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D5F")]
		[Address(RVA = "0x256FD70", Offset = "0x256E970", VA = "0x18256FD70")]
		public void OnClickBoss()
		{
		}

		// Token: 0x06029D60 RID: 171360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D60")]
		[Address(RVA = "0x256FE60", Offset = "0x256EA60", VA = "0x18256FE60")]
		public void OnClickEffect()
		{
		}

		// Token: 0x06029D61 RID: 171361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D61")]
		[Address(RVA = "0x2570120", Offset = "0x256ED20", VA = "0x182570120")]
		public void OnClickReward()
		{
		}

		// Token: 0x06029D62 RID: 171362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D62")]
		[Address(RVA = "0x256FCD0", Offset = "0x256E8D0", VA = "0x18256FCD0")]
		public void OnClickBattleStart()
		{
		}

		// Token: 0x06029D63 RID: 171363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D63")]
		[Address(RVA = "0x2571D50", Offset = "0x2570950", VA = "0x182571D50")]
		public Act42D0MapAreaView()
		{
		}

		// Token: 0x0403BEBA RID: 245434
		[Token(Token = "0x403BEBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("MenuBottom")]
		private GameObject _btnEffect;

		// Token: 0x0403BEBB RID: 245435
		[Token(Token = "0x403BEBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("StageDetail")]
		private Text _textStageName;

		// Token: 0x0403BEBC RID: 245436
		[Token(Token = "0x403BEBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("StageDetail")]
		private Text _textStageCode;

		// Token: 0x0403BEBD RID: 245437
		[Token(Token = "0x403BEBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _bkgAreaTitleNormal;

		// Token: 0x0403BEBE RID: 245438
		[Token(Token = "0x403BEBE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _bkgAreaTitleHard;

		// Token: 0x0403BEBF RID: 245439
		[Token(Token = "0x403BEBF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _bkgAreaInfoPanelHard;

		// Token: 0x0403BEC0 RID: 245440
		[Token(Token = "0x403BEC0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _bkgAreaInfoPanelNormal;

		// Token: 0x0403BEC1 RID: 245441
		[Token(Token = "0x403BEC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("StageDetail")]
		private Text _textUnlockTips;

		// Token: 0x0403BEC2 RID: 245442
		[Token(Token = "0x403BEC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _objUnlockTips;

		// Token: 0x0403BEC3 RID: 245443
		[Token(Token = "0x403BEC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("StageDetail")]
		private SimpleLayoutContent _difficultyContent;

		// Token: 0x0403BEC4 RID: 245444
		[Token(Token = "0x403BEC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("StageDetail")]
		private GameObject _objRating;

		// Token: 0x0403BEC5 RID: 245445
		[Token(Token = "0x403BEC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("StageDetail")]
		private Image _imgRating;

		// Token: 0x0403BEC6 RID: 245446
		[Token(Token = "0x403BEC6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("SelectStage")]
		private Act42D0MapStageSelectItemView _stageSelectItemPrefab;

		// Token: 0x0403BEC7 RID: 245447
		[Token(Token = "0x403BEC7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("SelectStage")]
		private RectTransform[] _rectStageSelectItemContainers;

		// Token: 0x0403BEC8 RID: 245448
		[Token(Token = "0x403BEC8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("MenuBottom")]
		private GameObject _bkgStartNormal;

		// Token: 0x0403BEC9 RID: 245449
		[Token(Token = "0x403BEC9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("MenuBottom")]
		private GameObject _bkgStartHard;

		// Token: 0x0403BECA RID: 245450
		[Token(Token = "0x403BECA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("StageDetail")]
		private UIAtlasImage _bkgBossBtn;

		// Token: 0x0403BECB RID: 245451
		[Token(Token = "0x403BECB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("StageDetail")]
		private Button _btnBoss;

		// Token: 0x0403BECC RID: 245452
		[Token(Token = "0x403BECC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403BECD RID: 245453
		[Token(Token = "0x403BECD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animSelectStage;

		// Token: 0x0403BECE RID: 245454
		[Token(Token = "0x403BECE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animStageDetailEnter;

		// Token: 0x0403BECF RID: 245455
		[Token(Token = "0x403BECF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animBottomMenu;

		// Token: 0x0403BED0 RID: 245456
		[Token(Token = "0x403BED0")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _animStageDetailChange;

		// Token: 0x0403BED1 RID: 245457
		[Token(Token = "0x403BED1")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _btnStartBattleGo;

		// Token: 0x0403BED2 RID: 245458
		[Token(Token = "0x403BED2")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _newTrackPointGo;

		// Token: 0x0403BED3 RID: 245459
		[Token(Token = "0x403BED3")]
		private const string ICON_RATING_NAME = "icon_rating_{0}";

		// Token: 0x0403BED4 RID: 245460
		[Token(Token = "0x403BED4")]
		private const int STAGE_COUNT_IN_A_AREA = 3;

		// Token: 0x0403BED5 RID: 245461
		[Token(Token = "0x403BED5")]
		[FieldOffset(Offset = "0x108")]
		private bool m_IsInited;

		// Token: 0x0403BED6 RID: 245462
		[Token(Token = "0x403BED6")]
		[FieldOffset(Offset = "0x110")]
		private List<Act42D0MapStageSelectItemView> m_stageSelectItemList;

		// Token: 0x0403BED7 RID: 245463
		[Token(Token = "0x403BED7")]
		[FieldOffset(Offset = "0x118")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BED8 RID: 245464
		[Token(Token = "0x403BED8")]
		[FieldOffset(Offset = "0x128")]
		private Act42D0MapStageItemViewModel m_stageSelectedData;

		// Token: 0x0403BED9 RID: 245465
		[Token(Token = "0x403BED9")]
		[FieldOffset(Offset = "0x130")]
		private Act42D0MapAreaView.Adapter m_adapter;

		// Token: 0x0403BEDA RID: 245466
		[Token(Token = "0x403BEDA")]
		[FieldOffset(Offset = "0x138")]
		private string m_bossId;

		// Token: 0x0403BEDB RID: 245467
		[Token(Token = "0x403BEDB")]
		[FieldOffset(Offset = "0x140")]
		private string m_areaSelectedId;

		// Token: 0x0403BEDC RID: 245468
		[Token(Token = "0x403BEDC")]
		[FieldOffset(Offset = "0x148")]
		private int m_stageSelectedIndex;

		// Token: 0x0403BEDD RID: 245469
		[Token(Token = "0x403BEDD")]
		[FieldOffset(Offset = "0x150")]
		private AnimationSwitchTween m_selectStageSwitchTween;

		// Token: 0x0403BEDE RID: 245470
		[Token(Token = "0x403BEDE")]
		[FieldOffset(Offset = "0x158")]
		private AnimationSwitchTween m_stageDetailEnterSwitchTween;

		// Token: 0x0403BEDF RID: 245471
		[Token(Token = "0x403BEDF")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_bottomMenuSwitchTween;

		// Token: 0x0403BEE0 RID: 245472
		[Token(Token = "0x403BEE0")]
		[FieldOffset(Offset = "0x168")]
		private AnimationSwitchTween m_stageDetailChangeSwitchTween;

		// Token: 0x0403BEE1 RID: 245473
		[Token(Token = "0x403BEE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BEE2 RID: 245474
		[Token(Token = "0x403BEE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0403BEE3 RID: 245475
		[Token(Token = "0x403BEE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BEE4 RID: 245476
		[Token(Token = "0x403BEE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDetail;

		// Token: 0x0403BEE5 RID: 245477
		[Token(Token = "0x403BEE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderStageSelectedItems;

		// Token: 0x0403BEE6 RID: 245478
		[Token(Token = "0x403BEE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckAnimation;

		// Token: 0x0403BEE7 RID: 245479
		[Token(Token = "0x403BEE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckSelectStageAnimation;

		// Token: 0x0403BEE8 RID: 245480
		[Token(Token = "0x403BEE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckStageDetailAnimation;

		// Token: 0x0403BEE9 RID: 245481
		[Token(Token = "0x403BEE9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckBottomMenuAnimation;

		// Token: 0x0403BEEA RID: 245482
		[Token(Token = "0x403BEEA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__NotifyFirstStageSelected;

		// Token: 0x0403BEEB RID: 245483
		[Token(Token = "0x403BEEB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NotifyAreaSelected;

		// Token: 0x0403BEEC RID: 245484
		[Token(Token = "0x403BEEC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClickEnemy;

		// Token: 0x0403BEED RID: 245485
		[Token(Token = "0x403BEED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnClickMap;

		// Token: 0x0403BEEE RID: 245486
		[Token(Token = "0x403BEEE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClickBoss;

		// Token: 0x0403BEEF RID: 245487
		[Token(Token = "0x403BEEF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClickEffect;

		// Token: 0x0403BEF0 RID: 245488
		[Token(Token = "0x403BEF0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnClickReward;

		// Token: 0x0403BEF1 RID: 245489
		[Token(Token = "0x403BEF1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnClickBattleStart;

		// Token: 0x0403BEF2 RID: 245490
		[Token(Token = "0x403BEF2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200739B RID: 29595
		[Token(Token = "0x200739B")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029D64 RID: 171364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029D64")]
			[Address(RVA = "0x257FF90", Offset = "0x257EB90", VA = "0x18257FF90")]
			public Adapter(Act42D0MapAreaView closure)
			{
			}

			// Token: 0x170062CD RID: 25293
			// (get) Token: 0x06029D65 RID: 171365 RVA: 0x000D6C20 File Offset: 0x000D4E20
			[Token(Token = "0x170062CD")]
			public override int count
			{
				[Token(Token = "0x6029D65")]
				[Address(RVA = "0x2580230", Offset = "0x257EE30", VA = "0x182580230", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029D66 RID: 171366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029D66")]
			[Address(RVA = "0x257FC50", Offset = "0x257E850", VA = "0x18257FC50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BEF3 RID: 245491
			[Token(Token = "0x403BEF3")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0MapAreaView m_closure;

			// Token: 0x0403BEF4 RID: 245492
			[Token(Token = "0x403BEF4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BEF5 RID: 245493
			[Token(Token = "0x403BEF5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BEF6 RID: 245494
			[Token(Token = "0x403BEF6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

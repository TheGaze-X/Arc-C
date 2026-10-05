using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F95 RID: 28565
	[Token(Token = "0x2006F95")]
	public class ActMultiV3QuickMatchModeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060288B0 RID: 166064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B0")]
		[Address(RVA = "0x23DECC0", Offset = "0x23DD8C0", VA = "0x1823DECC0")]
		public void Render(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel modeGroupModel)
		{
		}

		// Token: 0x060288B1 RID: 166065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B1")]
		[Address(RVA = "0x23DFA20", Offset = "0x23DE620", VA = "0x1823DFA20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060288B2 RID: 166066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B2")]
		[Address(RVA = "0x23DFB60", Offset = "0x23DE760", VA = "0x1823DFB60")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x060288B3 RID: 166067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B3")]
		[Address(RVA = "0x23E0270", Offset = "0x23DEE70", VA = "0x1823E0270")]
		private void _RenderNormalPart(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel modeGroupModel, long currTs)
		{
		}

		// Token: 0x060288B4 RID: 166068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B4")]
		[Address(RVA = "0x23E0020", Offset = "0x23DEC20", VA = "0x1823E0020")]
		private void _RenderLockPart(ActMultiV3MatchModeGroupModel modeGroupModel, string modeUnlockHint)
		{
		}

		// Token: 0x060288B5 RID: 166069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B5")]
		[Address(RVA = "0x23DFC50", Offset = "0x23DE850", VA = "0x1823DFC50")]
		private void _RenderDiffItemViews(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel modeGroupModel)
		{
		}

		// Token: 0x060288B6 RID: 166070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B6")]
		[Address(RVA = "0x23DF690", Offset = "0x23DE290", VA = "0x1823DF690")]
		private void _InitDiffItemViewIfNeed(ActMultiV3MatchModeGroupModel modeGroupModel)
		{
		}

		// Token: 0x060288B7 RID: 166071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288B7")]
		[Address(RVA = "0x23E08D0", Offset = "0x23DF4D0", VA = "0x1823E08D0")]
		private void _UpdateDiffItemTrackGO(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel modeGroupModel)
		{
		}

		// Token: 0x060288B8 RID: 166072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288B8")]
		[Address(RVA = "0x23DF520", Offset = "0x23DE120", VA = "0x1823DF520")]
		private ActMultiV3QuickMatchDiffItemView _FindModeDiffPrefab(ActMultiV3MapModeType modeType)
		{
			return null;
		}

		// Token: 0x060288B9 RID: 166073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288B9")]
		[Address(RVA = "0x23DF3D0", Offset = "0x23DDFD0", VA = "0x1823DF3D0")]
		private ActMultiV3QuickMatchModeItemView.ColorConfig _FindMatchConfig(ActMultiV3MapModeType modeType)
		{
			return null;
		}

		// Token: 0x060288BA RID: 166074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288BA")]
		[Address(RVA = "0x23DF010", Offset = "0x23DDC10", VA = "0x1823DF010")]
		private void _ApplyColorConfig(ActMultiV3MatchModeGroupModel modeGroupModel)
		{
		}

		// Token: 0x060288BB RID: 166075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288BB")]
		[Address(RVA = "0x23DEB60", Offset = "0x23DD760", VA = "0x1823DEB60")]
		public void EventOnBtnTraining()
		{
		}

		// Token: 0x060288BC RID: 166076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288BC")]
		[Address(RVA = "0x23E0A60", Offset = "0x23DF660", VA = "0x1823E0A60")]
		public ActMultiV3QuickMatchModeItemView()
		{
		}

		// Token: 0x04039BC8 RID: 236488
		[Token(Token = "0x4039BC8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x04039BC9 RID: 236489
		[Token(Token = "0x4039BC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockPartGO;

		// Token: 0x04039BCA RID: 236490
		[Token(Token = "0x4039BCA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _textNameInLock;

		// Token: 0x04039BCB RID: 236491
		[Token(Token = "0x4039BCB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Lock Part")]
		private Image _imgTopIconInLock;

		// Token: 0x04039BCC RID: 236492
		[Token(Token = "0x4039BCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Lock Part")]
		private Image _imgBottomIconInLock;

		// Token: 0x04039BCD RID: 236493
		[Token(Token = "0x4039BCD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Lock Part")]
		private Text _textModeUnlockTime;

		// Token: 0x04039BCE RID: 236494
		[Token(Token = "0x4039BCE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04039BCF RID: 236495
		[Token(Token = "0x4039BCF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgTopIcon;

		// Token: 0x04039BD0 RID: 236496
		[Token(Token = "0x4039BD0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imgTopIconBg;

		// Token: 0x04039BD1 RID: 236497
		[Token(Token = "0x4039BD1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasImage _imgHeaderBg;

		// Token: 0x04039BD2 RID: 236498
		[Token(Token = "0x4039BD2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _captionHeader;

		// Token: 0x04039BD3 RID: 236499
		[Token(Token = "0x4039BD3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgHeaderIcon;

		// Token: 0x04039BD4 RID: 236500
		[Token(Token = "0x4039BD4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgBottomIcon;

		// Token: 0x04039BD5 RID: 236501
		[Token(Token = "0x4039BD5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _stageUnlockHintGO;

		// Token: 0x04039BD6 RID: 236502
		[Token(Token = "0x4039BD6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textStageUnlockHint;

		// Token: 0x04039BD7 RID: 236503
		[Token(Token = "0x4039BD7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActMultiV3QuickMatchModeItemView.DiffItemContainer[] _diffItemContainers;

		// Token: 0x04039BD8 RID: 236504
		[Token(Token = "0x4039BD8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private ActMultiV3QuickMatchModeItemView.ColorConfig[] _colorConfigs;

		// Token: 0x04039BD9 RID: 236505
		[Token(Token = "0x4039BD9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ActMultiV3QuickMatchModeItemView.DiffItemPrefabConfig[] _diffItemConfigs;

		// Token: 0x04039BDA RID: 236506
		[Token(Token = "0x4039BDA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x04039BDB RID: 236507
		[Token(Token = "0x4039BDB")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Lock Training")]
		private GameObject _trainingLockGO;

		// Token: 0x04039BDC RID: 236508
		[Token(Token = "0x4039BDC")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Lock Training")]
		private Text _trainingTextName;

		// Token: 0x04039BDD RID: 236509
		[Token(Token = "0x4039BDD")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Lock Training")]
		private Text _textTrainingUnlockHint;

		// Token: 0x04039BDE RID: 236510
		[Token(Token = "0x4039BDE")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Lock Training")]
		private Image _trainingLockTopIcon;

		// Token: 0x04039BDF RID: 236511
		[Token(Token = "0x4039BDF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Lock Training")]
		private Image _trainingLockSideIcon;

		// Token: 0x04039BE0 RID: 236512
		[Token(Token = "0x4039BE0")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _trainingPartGO;

		// Token: 0x04039BE1 RID: 236513
		[Token(Token = "0x4039BE1")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _btnTrainingPartGo;

		// Token: 0x04039BE2 RID: 236514
		[Token(Token = "0x4039BE2")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_inited;

		// Token: 0x04039BE3 RID: 236515
		[Token(Token = "0x4039BE3")]
		[FieldOffset(Offset = "0xF8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039BE4 RID: 236516
		[Token(Token = "0x4039BE4")]
		[FieldOffset(Offset = "0x108")]
		private ActMultiV3MatchModeGroupModel m_modeGroupModel;

		// Token: 0x04039BE5 RID: 236517
		[Token(Token = "0x4039BE5")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<string, ActMultiV3QuickMatchDiffItemView> m_diffItemViewDict;

		// Token: 0x04039BE6 RID: 236518
		[Token(Token = "0x4039BE6")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04039BE7 RID: 236519
		[Token(Token = "0x4039BE7")]
		[FieldOffset(Offset = "0x120")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039BE8 RID: 236520
		[Token(Token = "0x4039BE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039BE9 RID: 236521
		[Token(Token = "0x4039BE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039BEA RID: 236522
		[Token(Token = "0x4039BEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04039BEB RID: 236523
		[Token(Token = "0x4039BEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNormalPart;

		// Token: 0x04039BEC RID: 236524
		[Token(Token = "0x4039BEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderLockPart;

		// Token: 0x04039BED RID: 236525
		[Token(Token = "0x4039BED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDiffItemViews;

		// Token: 0x04039BEE RID: 236526
		[Token(Token = "0x4039BEE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitDiffItemViewIfNeed;

		// Token: 0x04039BEF RID: 236527
		[Token(Token = "0x4039BEF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateDiffItemTrackGO;

		// Token: 0x04039BF0 RID: 236528
		[Token(Token = "0x4039BF0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__FindModeDiffPrefab;

		// Token: 0x04039BF1 RID: 236529
		[Token(Token = "0x4039BF1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindMatchConfig;

		// Token: 0x04039BF2 RID: 236530
		[Token(Token = "0x4039BF2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyColorConfig;

		// Token: 0x04039BF3 RID: 236531
		[Token(Token = "0x4039BF3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnBtnTraining;

		// Token: 0x04039BF4 RID: 236532
		[Token(Token = "0x4039BF4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F96 RID: 28566
		[Token(Token = "0x2006F96")]
		[Serializable]
		private class ColorConfig
		{
			// Token: 0x060288BD RID: 166077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ColorConfig()
			{
			}

			// Token: 0x04039BF5 RID: 236533
			[Token(Token = "0x4039BF5")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapModeType modeType;

			// Token: 0x04039BF6 RID: 236534
			[Token(Token = "0x4039BF6")]
			[FieldOffset(Offset = "0x14")]
			public Color colorTopIcon;

			// Token: 0x04039BF7 RID: 236535
			[Token(Token = "0x4039BF7")]
			[FieldOffset(Offset = "0x24")]
			public Color colorHeaderInfo;
		}

		// Token: 0x02006F97 RID: 28567
		[Token(Token = "0x2006F97")]
		[Serializable]
		private class DiffItemContainer
		{
			// Token: 0x060288BE RID: 166078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288BE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DiffItemContainer()
			{
			}

			// Token: 0x04039BF8 RID: 236536
			[Token(Token = "0x4039BF8")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapDiffType diffType;

			// Token: 0x04039BF9 RID: 236537
			[Token(Token = "0x4039BF9")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform container;

			// Token: 0x04039BFA RID: 236538
			[Token(Token = "0x4039BFA")]
			[FieldOffset(Offset = "0x20")]
			public GameObject trackGO;
		}

		// Token: 0x02006F98 RID: 28568
		[Token(Token = "0x2006F98")]
		[Serializable]
		private class DiffItemPrefabConfig
		{
			// Token: 0x060288BF RID: 166079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288BF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DiffItemPrefabConfig()
			{
			}

			// Token: 0x04039BFB RID: 236539
			[Token(Token = "0x4039BFB")]
			[FieldOffset(Offset = "0x10")]
			public List<ActMultiV3MapModeType> types;

			// Token: 0x04039BFC RID: 236540
			[Token(Token = "0x4039BFC")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3QuickMatchDiffItemView diffItemPrefab;
		}
	}
}

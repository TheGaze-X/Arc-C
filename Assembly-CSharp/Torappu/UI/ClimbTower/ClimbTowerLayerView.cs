using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C69 RID: 23657
	[Token(Token = "0x2005C69")]
	public class ClimbTowerLayerView : DataBinder<ClimbTowerLayerProperty>
	{
		// Token: 0x1700507D RID: 20605
		// (set) Token: 0x06022471 RID: 140401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700507D")]
		public ClimbTowerLayerState bindState
		{
			[Token(Token = "0x6022471")]
			[Address(RVA = "0x1CBDB60", Offset = "0x1CBC760", VA = "0x181CBDB60")]
			set
			{
			}
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x06022472 RID: 140402 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022473 RID: 140403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700507E")]
		public UIPage page
		{
			[Token(Token = "0x6022472")]
			[Address(RVA = "0x1CBDAE0", Offset = "0x1CBC6E0", VA = "0x181CBDAE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022473")]
			[Address(RVA = "0x1CBDBF0", Offset = "0x1CBC7F0", VA = "0x181CBDBF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06022474 RID: 140404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022474")]
		[Address(RVA = "0x1CBCF60", Offset = "0x1CBBB60", VA = "0x181CBCF60")]
		private void _InitIfNot(ClimbTowerLayerViewModel model)
		{
		}

		// Token: 0x06022475 RID: 140405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022475")]
		[Address(RVA = "0x1CBD240", Offset = "0x1CBBE40", VA = "0x181CBD240")]
		private void _LoadPreviewMap(string mapPreviewId)
		{
		}

		// Token: 0x06022476 RID: 140406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022476")]
		[Address(RVA = "0x1CBD870", Offset = "0x1CBC470", VA = "0x181CBD870")]
		private void _UnloadPreviewMap()
		{
		}

		// Token: 0x06022477 RID: 140407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022477")]
		[Address(RVA = "0x1CBD6E0", Offset = "0x1CBC2E0", VA = "0x181CBD6E0")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x06022478 RID: 140408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022478")]
		[Address(RVA = "0x1CBCE40", Offset = "0x1CBBA40", VA = "0x181CBCE40")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06022479 RID: 140409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022479")]
		[Address(RVA = "0x1CBD500", Offset = "0x1CBC100", VA = "0x181CBD500")]
		private void _SetGraphicsColorWithMode(bool isHardMode)
		{
		}

		// Token: 0x0602247A RID: 140410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247A")]
		[Address(RVA = "0x1CBC530", Offset = "0x1CBB130", VA = "0x181CBC530", Slot = "7")]
		public override void OnValueChanged(ClimbTowerLayerProperty property)
		{
		}

		// Token: 0x0602247B RID: 140411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247B")]
		[Address(RVA = "0x1CBC2B0", Offset = "0x1CBAEB0", VA = "0x181CBC2B0")]
		public void OnBtnMapTipsClicked()
		{
		}

		// Token: 0x0602247C RID: 140412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247C")]
		[Address(RVA = "0x1CBC1B0", Offset = "0x1CBADB0", VA = "0x181CBC1B0")]
		public void OnBtnExitMapTipsClicked()
		{
		}

		// Token: 0x0602247D RID: 140413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247D")]
		[Address(RVA = "0x1CBBFA0", Offset = "0x1CBABA0", VA = "0x181CBBFA0")]
		public void AnimRefreshEntranceDot(int count)
		{
		}

		// Token: 0x0602247E RID: 140414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247E")]
		[Address(RVA = "0x1CBC070", Offset = "0x1CBAC70", VA = "0x181CBC070")]
		public void AnimResetToBegin(ClimbTowerLayerState.EntranceConfig entranceConfig)
		{
		}

		// Token: 0x0602247F RID: 140415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602247F")]
		[Address(RVA = "0x1CBC120", Offset = "0x1CBAD20", VA = "0x181CBC120")]
		public void AnimResetToEnd(ClimbTowerLayerState.EntranceConfig entranceConfig)
		{
		}

		// Token: 0x06022480 RID: 140416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022480")]
		[Address(RVA = "0x1CBDA40", Offset = "0x1CBC640", VA = "0x181CBDA40")]
		public ClimbTowerLayerView()
		{
		}

		// Token: 0x0402F108 RID: 192776
		[Token(Token = "0x402F108")]
		private const string MAX_LAYER_FORMAT = "/{0}";

		// Token: 0x0402F109 RID: 192777
		[Token(Token = "0x402F109")]
		private const char ENTRANCE_DOT = '.';

		// Token: 0x0402F10A RID: 192778
		[Token(Token = "0x402F10A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402F10B RID: 192779
		[Token(Token = "0x402F10B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_MAX;

		// Token: 0x0402F10C RID: 192780
		[Token(Token = "0x402F10C")]
		private const int DANGER_LAYER_COUNT = 4;

		// Token: 0x0402F10D RID: 192781
		[Token(Token = "0x402F10D")]
		private const int MAX_ENTRANCE_DOT = 3;

		// Token: 0x0402F10E RID: 192782
		[Token(Token = "0x402F10E")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color COLOR_NORMAL_FLASH;

		// Token: 0x0402F10F RID: 192783
		[Token(Token = "0x402F10F")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color COLOR_HARD_FLASH;

		// Token: 0x0402F110 RID: 192784
		[Token(Token = "0x402F110")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLayerNum;

		// Token: 0x0402F111 RID: 192785
		[Token(Token = "0x402F111")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLastLayerNum;

		// Token: 0x0402F112 RID: 192786
		[Token(Token = "0x402F112")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLayerTotalNum;

		// Token: 0x0402F113 RID: 192787
		[Token(Token = "0x402F113")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLayerName;

		// Token: 0x0402F114 RID: 192788
		[Token(Token = "0x402F114")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textLayerCode;

		// Token: 0x0402F115 RID: 192789
		[Token(Token = "0x402F115")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textLayerDesc;

		// Token: 0x0402F116 RID: 192790
		[Token(Token = "0x402F116")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtHardDesc;

		// Token: 0x0402F117 RID: 192791
		[Token(Token = "0x402F117")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _txtDangerDesc;

		// Token: 0x0402F118 RID: 192792
		[Token(Token = "0x402F118")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _towerIcon;

		// Token: 0x0402F119 RID: 192793
		[Token(Token = "0x402F119")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgFlash;

		// Token: 0x0402F11A RID: 192794
		[Token(Token = "0x402F11A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelHardTag;

		// Token: 0x0402F11B RID: 192795
		[Token(Token = "0x402F11B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _towerBkg;

		// Token: 0x0402F11C RID: 192796
		[Token(Token = "0x402F11C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imageLevelPreview;

		// Token: 0x0402F11D RID: 192797
		[Token(Token = "0x402F11D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Map Tips")]
		private Image _imageLevelMapTips;

		// Token: 0x0402F11E RID: 192798
		[Token(Token = "0x402F11E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Map Tips")]
		private Image _imageMapTipsBkg;

		// Token: 0x0402F11F RID: 192799
		[Token(Token = "0x402F11F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Map Tips")]
		private GameObject _pnlMapTips;

		// Token: 0x0402F120 RID: 192800
		[Token(Token = "0x402F120")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelCurrLayerDesc;

		// Token: 0x0402F121 RID: 192801
		[Token(Token = "0x402F121")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _cardScaleFactor;

		// Token: 0x0402F122 RID: 192802
		[Token(Token = "0x402F122")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelIconNormal;

		// Token: 0x0402F123 RID: 192803
		[Token(Token = "0x402F123")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelIconTraining;

		// Token: 0x0402F124 RID: 192804
		[Token(Token = "0x402F124")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelBtnUp;

		// Token: 0x0402F125 RID: 192805
		[Token(Token = "0x402F125")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelBtnDown;

		// Token: 0x0402F126 RID: 192806
		[Token(Token = "0x402F126")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _panelList;

		// Token: 0x0402F127 RID: 192807
		[Token(Token = "0x402F127")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ClimbTowerLayerView.RewardItemView _rewardItem1;

		// Token: 0x0402F128 RID: 192808
		[Token(Token = "0x402F128")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private ClimbTowerLayerView.RewardItemView _rewardItem2;

		// Token: 0x0402F129 RID: 192809
		[Token(Token = "0x402F129")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402F12A RID: 192810
		[Token(Token = "0x402F12A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _textSettle;

		// Token: 0x0402F12B RID: 192811
		[Token(Token = "0x402F12B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _canvasDanger;

		// Token: 0x0402F12C RID: 192812
		[Token(Token = "0x402F12C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _textEntranceDot;

		// Token: 0x0402F12D RID: 192813
		[Token(Token = "0x402F12D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _imgLight;

		// Token: 0x0402F12E RID: 192814
		[Token(Token = "0x402F12E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private ClimbTowerBackgroundController _bkgController;

		// Token: 0x0402F12F RID: 192815
		[Token(Token = "0x402F12F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Layer Stack")]
		private ClimbTowerTowerLayerStack _layerStackPrefab;

		// Token: 0x0402F130 RID: 192816
		[Token(Token = "0x402F130")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Layer Stack")]
		private RectTransform _panelLayerStackViewHolder;

		// Token: 0x0402F131 RID: 192817
		[Token(Token = "0x402F131")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Layer Stack")]
		private ClimbTowerTowerLayerSelectArrowSimple _selectArrowPrefab;

		// Token: 0x0402F132 RID: 192818
		[Token(Token = "0x402F132")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Layer Stack")]
		private ClimbTowerTowerLayerGodCardTipsWithAttach _godCardTipsPrefab;

		// Token: 0x0402F133 RID: 192819
		[Token(Token = "0x402F133")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Graphic[] _modeRelatedGraphics;

		// Token: 0x0402F134 RID: 192820
		[Token(Token = "0x402F134")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedTowerId;

		// Token: 0x0402F135 RID: 192821
		[Token(Token = "0x402F135")]
		[FieldOffset(Offset = "0x148")]
		private string m_cachedLevelId;

		// Token: 0x0402F136 RID: 192822
		[Token(Token = "0x402F136")]
		[FieldOffset(Offset = "0x150")]
		private ClimbTowerLayerViewModel m_cachedModel;

		// Token: 0x0402F137 RID: 192823
		[Token(Token = "0x402F137")]
		[FieldOffset(Offset = "0x158")]
		private List<StageRewardViewModel> m_cachedReward;

		// Token: 0x0402F138 RID: 192824
		[Token(Token = "0x402F138")]
		[FieldOffset(Offset = "0x160")]
		private bool m_cachedIsHardMode;

		// Token: 0x0402F139 RID: 192825
		[Token(Token = "0x402F139")]
		[FieldOffset(Offset = "0x168")]
		private Sprite m_spriteMapTip;

		// Token: 0x0402F13A RID: 192826
		[Token(Token = "0x402F13A")]
		[FieldOffset(Offset = "0x170")]
		private ClimbTowerLayerView.Adapter m_adapter;

		// Token: 0x0402F13B RID: 192827
		[Token(Token = "0x402F13B")]
		[FieldOffset(Offset = "0x178")]
		private bool m_inited;

		// Token: 0x0402F13C RID: 192828
		[Token(Token = "0x402F13C")]
		[FieldOffset(Offset = "0x180")]
		private ClimbTowerLayerState m_bindState;

		// Token: 0x0402F13D RID: 192829
		[Token(Token = "0x402F13D")]
		[FieldOffset(Offset = "0x188")]
		private FadeSwitchTween m_dangerSwitchTween;

		// Token: 0x0402F13E RID: 192830
		[Token(Token = "0x402F13E")]
		[FieldOffset(Offset = "0x190")]
		private ClimbTowerTowerLayerStack m_towerLayerView;

		// Token: 0x0402F140 RID: 192832
		[Token(Token = "0x402F140")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x0402F141 RID: 192833
		[Token(Token = "0x402F141")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F142 RID: 192834
		[Token(Token = "0x402F142")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F143 RID: 192835
		[Token(Token = "0x402F143")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F144 RID: 192836
		[Token(Token = "0x402F144")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadPreviewMap;

		// Token: 0x0402F145 RID: 192837
		[Token(Token = "0x402F145")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UnloadPreviewMap;

		// Token: 0x0402F146 RID: 192838
		[Token(Token = "0x402F146")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x0402F147 RID: 192839
		[Token(Token = "0x402F147")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0402F148 RID: 192840
		[Token(Token = "0x402F148")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetGraphicsColorWithMode;

		// Token: 0x0402F149 RID: 192841
		[Token(Token = "0x402F149")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F14A RID: 192842
		[Token(Token = "0x402F14A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnBtnMapTipsClicked;

		// Token: 0x0402F14B RID: 192843
		[Token(Token = "0x402F14B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnBtnExitMapTipsClicked;

		// Token: 0x0402F14C RID: 192844
		[Token(Token = "0x402F14C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_AnimRefreshEntranceDot;

		// Token: 0x0402F14D RID: 192845
		[Token(Token = "0x402F14D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_AnimResetToBegin;

		// Token: 0x0402F14E RID: 192846
		[Token(Token = "0x402F14E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_AnimResetToEnd;

		// Token: 0x0402F14F RID: 192847
		[Token(Token = "0x402F14F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C6A RID: 23658
		[Token(Token = "0x2005C6A")]
		private class Adapter : ClimbTowerTowerLayerStackAdapter
		{
			// Token: 0x06022482 RID: 140418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022482")]
			[Address(RVA = "0x1CB81B0", Offset = "0x1CB6DB0", VA = "0x181CB81B0")]
			public Adapter(ClimbTowerLayerView closure)
			{
			}

			// Token: 0x1700507F RID: 20607
			// (get) Token: 0x06022483 RID: 140419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700507F")]
			public override List<ClimbTowerLevelModel> data
			{
				[Token(Token = "0x6022483")]
				[Address(RVA = "0x1CB8800", Offset = "0x1CB7400", VA = "0x181CB8800", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005080 RID: 20608
			// (get) Token: 0x06022484 RID: 140420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005080")]
			public override string selectedItem
			{
				[Token(Token = "0x6022484")]
				[Address(RVA = "0x1CB8BB0", Offset = "0x1CB77B0", VA = "0x181CB8BB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005081 RID: 20609
			// (get) Token: 0x06022485 RID: 140421 RVA: 0x000BCDD8 File Offset: 0x000BAFD8
			[Token(Token = "0x17005081")]
			public override int arrowIndex
			{
				[Token(Token = "0x6022485")]
				[Address(RVA = "0x1CB8440", Offset = "0x1CB7040", VA = "0x181CB8440", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022486 RID: 140422 RVA: 0x000BCDF0 File Offset: 0x000BAFF0
			[Token(Token = "0x6022486")]
			[Address(RVA = "0x1CB7450", Offset = "0x1CB6050", VA = "0x181CB7450", Slot = "7")]
			public override bool IsLevelPassed(ClimbTowerLevelModel levelModel)
			{
				return default(bool);
			}

			// Token: 0x06022487 RID: 140423 RVA: 0x000BCE08 File Offset: 0x000BB008
			[Token(Token = "0x6022487")]
			[Address(RVA = "0x1CB7350", Offset = "0x1CB5F50", VA = "0x181CB7350", Slot = "8")]
			public override bool IsHardMode()
			{
				return default(bool);
			}

			// Token: 0x17005082 RID: 20610
			// (get) Token: 0x06022488 RID: 140424 RVA: 0x000BCE20 File Offset: 0x000BB020
			[Token(Token = "0x17005082")]
			public override int subCardStageSortBefore
			{
				[Token(Token = "0x6022488")]
				[Address(RVA = "0x1CB8CA0", Offset = "0x1CB78A0", VA = "0x181CB8CA0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17005083 RID: 20611
			// (get) Token: 0x06022489 RID: 140425 RVA: 0x000BCE38 File Offset: 0x000BB038
			[Token(Token = "0x17005083")]
			public override bool hasSelectedSubCard
			{
				[Token(Token = "0x6022489")]
				[Address(RVA = "0x1CB8960", Offset = "0x1CB7560", VA = "0x181CB8960", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17005084 RID: 20612
			// (get) Token: 0x0602248A RID: 140426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005084")]
			public override ClimbTowerTowerLayerBaseSelectArrow selectArrowPrefab
			{
				[Token(Token = "0x602248A")]
				[Address(RVA = "0x1CB8A40", Offset = "0x1CB7640", VA = "0x181CB8A40", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005085 RID: 20613
			// (get) Token: 0x0602248B RID: 140427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005085")]
			public override ClimbTowerTowerLayerBaseGodCardTips godCardTipsPrefab
			{
				[Token(Token = "0x602248B")]
				[Address(RVA = "0x1CB8880", Offset = "0x1CB7480", VA = "0x181CB8880", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x0402F150 RID: 192848
			[Token(Token = "0x402F150")]
			[FieldOffset(Offset = "0x28")]
			private ClimbTowerLayerView m_closure;

			// Token: 0x0402F151 RID: 192849
			[Token(Token = "0x402F151")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F152 RID: 192850
			[Token(Token = "0x402F152")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0402F153 RID: 192851
			[Token(Token = "0x402F153")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_selectedItem;

			// Token: 0x0402F154 RID: 192852
			[Token(Token = "0x402F154")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_arrowIndex;

			// Token: 0x0402F155 RID: 192853
			[Token(Token = "0x402F155")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsLevelPassed;

			// Token: 0x0402F156 RID: 192854
			[Token(Token = "0x402F156")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsHardMode;

			// Token: 0x0402F157 RID: 192855
			[Token(Token = "0x402F157")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_subCardStageSortBefore;

			// Token: 0x0402F158 RID: 192856
			[Token(Token = "0x402F158")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hasSelectedSubCard;

			// Token: 0x0402F159 RID: 192857
			[Token(Token = "0x402F159")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_selectArrowPrefab;

			// Token: 0x0402F15A RID: 192858
			[Token(Token = "0x402F15A")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_godCardTipsPrefab;
		}

		// Token: 0x02005C6B RID: 23659
		[Token(Token = "0x2005C6B")]
		[Serializable]
		private class RewardItemView : IHotfixable
		{
			// Token: 0x0602248C RID: 140428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602248C")]
			[Address(RVA = "0x1CC83C0", Offset = "0x1CC6FC0", VA = "0x181CC83C0")]
			public void RenderItem(ItemData data, float itemCardScaleFactor)
			{
			}

			// Token: 0x0602248D RID: 140429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602248D")]
			[Address(RVA = "0x1CC8180", Offset = "0x1CC6D80", VA = "0x181CC8180")]
			public void RenderCount(int currCount, int addCount, int maxCount)
			{
			}

			// Token: 0x0602248E RID: 140430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602248E")]
			[Address(RVA = "0x1CC8770", Offset = "0x1CC7370", VA = "0x181CC8770")]
			public RewardItemView()
			{
			}

			// Token: 0x0402F15B RID: 192859
			[Token(Token = "0x402F15B")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Color COLOR_ZERO;

			// Token: 0x0402F15C RID: 192860
			[Token(Token = "0x402F15C")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Color COLOR_OVER_ZERO;

			// Token: 0x0402F15D RID: 192861
			[Token(Token = "0x402F15D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x0402F15E RID: 192862
			[Token(Token = "0x402F15E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textName;

			// Token: 0x0402F15F RID: 192863
			[Token(Token = "0x402F15F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textCount;

			// Token: 0x0402F160 RID: 192864
			[Token(Token = "0x402F160")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private GameObject _panelMax;

			// Token: 0x0402F161 RID: 192865
			[Token(Token = "0x402F161")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private RectTransform _itemCardContainer;

			// Token: 0x0402F162 RID: 192866
			[Token(Token = "0x402F162")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Image _progressCur;

			// Token: 0x0402F163 RID: 192867
			[Token(Token = "0x402F163")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private Image _progressAdd;

			// Token: 0x0402F164 RID: 192868
			[Token(Token = "0x402F164")]
			[FieldOffset(Offset = "0x48")]
			private UIItemCard m_itemCard;

			// Token: 0x0402F165 RID: 192869
			[Token(Token = "0x402F165")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderItem;

			// Token: 0x0402F166 RID: 192870
			[Token(Token = "0x402F166")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RenderCount;

			// Token: 0x0402F167 RID: 192871
			[Token(Token = "0x402F167")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}

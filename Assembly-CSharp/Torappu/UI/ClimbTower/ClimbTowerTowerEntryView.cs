using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CB1 RID: 23729
	[Token(Token = "0x2005CB1")]
	public class ClimbTowerTowerEntryView : DataBinder<ClimbTowerProperty>
	{
		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x06022576 RID: 140662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022577 RID: 140663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050AC")]
		public Action eventOnSwitchModeClick
		{
			[Token(Token = "0x6022576")]
			[Address(RVA = "0x1CC5DA0", Offset = "0x1CC49A0", VA = "0x181CC5DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022577")]
			[Address(RVA = "0x1CC5F30", Offset = "0x1CC4B30", VA = "0x181CC5F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x06022578 RID: 140664 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022579 RID: 140665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050AD")]
		public Action eventOnClickSweep
		{
			[Token(Token = "0x6022578")]
			[Address(RVA = "0x1CC5D20", Offset = "0x1CC4920", VA = "0x181CC5D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022579")]
			[Address(RVA = "0x1CC5EA0", Offset = "0x1CC4AA0", VA = "0x181CC5EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170050AE RID: 20654
		// (get) Token: 0x0602257A RID: 140666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602257B RID: 140667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050AE")]
		public UIPage page
		{
			[Token(Token = "0x602257A")]
			[Address(RVA = "0x1CC5E20", Offset = "0x1CC4A20", VA = "0x181CC5E20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602257B")]
			[Address(RVA = "0x1CC5FC0", Offset = "0x1CC4BC0", VA = "0x181CC5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602257C RID: 140668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602257C")]
		[Address(RVA = "0x1CC3FA0", Offset = "0x1CC2BA0", VA = "0x181CC3FA0", Slot = "7")]
		public override void OnValueChanged(ClimbTowerProperty property)
		{
		}

		// Token: 0x0602257D RID: 140669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602257D")]
		[Address(RVA = "0x1CC3C90", Offset = "0x1CC2890", VA = "0x181CC3C90")]
		public void OnExit()
		{
		}

		// Token: 0x0602257E RID: 140670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602257E")]
		[Address(RVA = "0x1CC4570", Offset = "0x1CC3170", VA = "0x181CC4570")]
		private void _InitIfNot(ClimbTowerViewModel model)
		{
		}

		// Token: 0x0602257F RID: 140671 RVA: 0x000BD150 File Offset: 0x000BB350
		[Token(Token = "0x602257F")]
		[Address(RVA = "0x1CC47F0", Offset = "0x1CC33F0", VA = "0x181CC47F0")]
		private bool _IsModeEqual(bool isHardMode)
		{
			return default(bool);
		}

		// Token: 0x06022580 RID: 140672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022580")]
		[Address(RVA = "0x1CC50E0", Offset = "0x1CC3CE0", VA = "0x181CC50E0")]
		private void _RenderLeftInfoPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022581 RID: 140673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022581")]
		[Address(RVA = "0x1CC4C40", Offset = "0x1CC3840", VA = "0x181CC4C40")]
		private void _RenderFirstRecordPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022582 RID: 140674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022582")]
		[Address(RVA = "0x1CC48B0", Offset = "0x1CC34B0", VA = "0x181CC48B0")]
		private void _RenderBgPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022583 RID: 140675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022583")]
		[Address(RVA = "0x1CC4EA0", Offset = "0x1CC3AA0", VA = "0x181CC4EA0")]
		private void _RenderLayerPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022584 RID: 140676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022584")]
		[Address(RVA = "0x1CC4990", Offset = "0x1CC3590", VA = "0x181CC4990")]
		private void _RenderBtnEnterPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022585 RID: 140677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022585")]
		[Address(RVA = "0x1CC5840", Offset = "0x1CC4440", VA = "0x181CC5840")]
		private void _RenderSwitchBtnPart(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022586 RID: 140678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022586")]
		[Address(RVA = "0x1CC56B0", Offset = "0x1CC42B0", VA = "0x181CC56B0")]
		private void _RenderSweep(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022587 RID: 140679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022587")]
		[Address(RVA = "0x1CC5460", Offset = "0x1CC4060", VA = "0x181CC5460")]
		private void _RenderMedal(ClimbTowerViewModel model)
		{
		}

		// Token: 0x06022588 RID: 140680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022588")]
		[Address(RVA = "0x1CC5990", Offset = "0x1CC4590", VA = "0x181CC5990")]
		private string _TryGetMedalId(ClimbTowerViewModel model)
		{
			return null;
		}

		// Token: 0x06022589 RID: 140681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022589")]
		[Address(RVA = "0x1CC5AC0", Offset = "0x1CC46C0", VA = "0x181CC5AC0")]
		private void _TryPlaySwitchModeTween(bool isHardMode)
		{
		}

		// Token: 0x0602258A RID: 140682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602258A")]
		[Address(RVA = "0x1CC3DD0", Offset = "0x1CC29D0", VA = "0x181CC3DD0")]
		public void OnSwitchToHardBtnClick()
		{
		}

		// Token: 0x0602258B RID: 140683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602258B")]
		[Address(RVA = "0x1CC3EE0", Offset = "0x1CC2AE0", VA = "0x181CC3EE0")]
		public void OnSwitchToNormBtnClick()
		{
		}

		// Token: 0x0602258C RID: 140684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602258C")]
		[Address(RVA = "0x1CC3D20", Offset = "0x1CC2920", VA = "0x181CC3D20")]
		public void OnSelectSweep()
		{
		}

		// Token: 0x0602258D RID: 140685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602258D")]
		[Address(RVA = "0x1CC5C80", Offset = "0x1CC4880", VA = "0x181CC5C80")]
		public ClimbTowerTowerEntryView()
		{
		}

		// Token: 0x0402F2E3 RID: 193251
		[Token(Token = "0x402F2E3")]
		private const string MAX_LAYER_FORMAT = "/{0}";

		// Token: 0x0402F2E4 RID: 193252
		[Token(Token = "0x402F2E4")]
		private const string SWEEP_COST_FORMAT = "-{0}";

		// Token: 0x0402F2E5 RID: 193253
		[Token(Token = "0x402F2E5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_ALL_COMPLETED;

		// Token: 0x0402F2E6 RID: 193254
		[Token(Token = "0x402F2E6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402F2E7 RID: 193255
		[Token(Token = "0x402F2E7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Info")]
		private Text _textTowerName;

		// Token: 0x0402F2E8 RID: 193256
		[Token(Token = "0x402F2E8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Info")]
		private Text _textTowerSubName;

		// Token: 0x0402F2E9 RID: 193257
		[Token(Token = "0x402F2E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Info")]
		private GameObject _objHardModeTag;

		// Token: 0x0402F2EA RID: 193258
		[Token(Token = "0x402F2EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Info")]
		private VerticalLayoutGroup _layoutTowerTips;

		// Token: 0x0402F2EB RID: 193259
		[Token(Token = "0x402F2EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Info")]
		private Text _textHardModeTips;

		// Token: 0x0402F2EC RID: 193260
		[Token(Token = "0x402F2EC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Info")]
		private Text _textTowerDesc;

		// Token: 0x0402F2ED RID: 193261
		[Token(Token = "0x402F2ED")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Info")]
		private Text _textDangerEffect;

		// Token: 0x0402F2EE RID: 193262
		[Token(Token = "0x402F2EE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Info")]
		private Image _towerIcon;

		// Token: 0x0402F2EF RID: 193263
		[Token(Token = "0x402F2EF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Bkg")]
		private Image _towerBkg;

		// Token: 0x0402F2F0 RID: 193264
		[Token(Token = "0x402F2F0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Bkg")]
		private ClimbTowerBackgroundController _bkgController;

		// Token: 0x0402F2F1 RID: 193265
		[Token(Token = "0x402F2F1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Record")]
		private GameObject _objRecord;

		// Token: 0x0402F2F2 RID: 193266
		[Token(Token = "0x402F2F2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Record")]
		private Text _textRecordLayer;

		// Token: 0x0402F2F3 RID: 193267
		[Token(Token = "0x402F2F3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Record")]
		private Text _textMaxLayer;

		// Token: 0x0402F2F4 RID: 193268
		[Token(Token = "0x402F2F4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Record")]
		private GameObject _pnlTrackpoint;

		// Token: 0x0402F2F5 RID: 193269
		[Token(Token = "0x402F2F5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasObject _atlasEntry;

		// Token: 0x0402F2F6 RID: 193270
		[Token(Token = "0x402F2F6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Layer")]
		private RectTransform _rectTransLayerViewHolder;

		// Token: 0x0402F2F7 RID: 193271
		[Token(Token = "0x402F2F7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Layer")]
		private ClimbTowerTowerLayerStack _layerViewPrefab;

		// Token: 0x0402F2F8 RID: 193272
		[Token(Token = "0x402F2F8")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Layer")]
		private UIColorGraphic _btnColorGraphic1;

		// Token: 0x0402F2F9 RID: 193273
		[Token(Token = "0x402F2F9")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Layer")]
		private UIColorGraphic _btnColorGraphic2;

		// Token: 0x0402F2FA RID: 193274
		[Token(Token = "0x402F2FA")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Layer")]
		private ClimbTowerTowerLayerSelectArrowWithMode _selectArrowPrefab;

		// Token: 0x0402F2FB RID: 193275
		[Token(Token = "0x402F2FB")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Layer")]
		private ClimbTowerTowerLayerGodCardTipsSimple _godCardTipsPrefab;

		// Token: 0x0402F2FC RID: 193276
		[Token(Token = "0x402F2FC")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Medal")]
		private Image _medalImg;

		// Token: 0x0402F2FD RID: 193277
		[Token(Token = "0x402F2FD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Medal")]
		private GameObject _medalEmpty;

		// Token: 0x0402F2FE RID: 193278
		[Token(Token = "0x402F2FE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Btn Enter")]
		private UIAtlasImage _imgNotInBattle;

		// Token: 0x0402F2FF RID: 193279
		[Token(Token = "0x402F2FF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Btn Enter")]
		private UIAtlasImage _imgInBattle;

		// Token: 0x0402F300 RID: 193280
		[Token(Token = "0x402F300")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Btn Enter")]
		private TwoStateToggle _btnEnter;

		// Token: 0x0402F301 RID: 193281
		[Token(Token = "0x402F301")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Btn Enter")]
		private GameObject _enterBtnSweepPanel;

		// Token: 0x0402F302 RID: 193282
		[Token(Token = "0x402F302")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Btn Enter")]
		private Text _enterSweepCostCnt;

		// Token: 0x0402F303 RID: 193283
		[Token(Token = "0x402F303")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Btn Switch")]
		private GameObject _objSwitchToNormMode;

		// Token: 0x0402F304 RID: 193284
		[Token(Token = "0x402F304")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Btn Switch")]
		private GameObject _objTrackPointSwitchToNorm;

		// Token: 0x0402F305 RID: 193285
		[Token(Token = "0x402F305")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Btn Switch")]
		private GameObject _objSwitchToHardMode;

		// Token: 0x0402F306 RID: 193286
		[Token(Token = "0x402F306")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Btn Switch")]
		private GameObject _objSwitchToHardModeBan;

		// Token: 0x0402F307 RID: 193287
		[Token(Token = "0x402F307")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Btn Switch")]
		private GameObject _objSwitchToHardNew;

		// Token: 0x0402F308 RID: 193288
		[Token(Token = "0x402F308")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0402F309 RID: 193289
		[Token(Token = "0x402F309")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("sweep")]
		private GameObject _sweepAble;

		// Token: 0x0402F30A RID: 193290
		[Token(Token = "0x402F30A")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("sweep")]
		private GameObject _sweepDisable;

		// Token: 0x0402F30B RID: 193291
		[Token(Token = "0x402F30B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("sweep")]
		private GameObject _sweepLock;

		// Token: 0x0402F30C RID: 193292
		[Token(Token = "0x402F30C")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("sweep")]
		private UIAnimationLocation _sweepSwitchAnimLocation;

		// Token: 0x0402F30D RID: 193293
		[Token(Token = "0x402F30D")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("sweep")]
		private ClimbTowerSweepConfirmView _sweepConfirmView;

		// Token: 0x0402F310 RID: 193296
		[Token(Token = "0x402F310")]
		[FieldOffset(Offset = "0x170")]
		private string m_cachedTowerId;

		// Token: 0x0402F311 RID: 193297
		[Token(Token = "0x402F311")]
		[FieldOffset(Offset = "0x178")]
		private string m_cachedMedalId;

		// Token: 0x0402F312 RID: 193298
		[Token(Token = "0x402F312")]
		[FieldOffset(Offset = "0x180")]
		private ClimbTowerViewModel m_cachedModel;

		// Token: 0x0402F313 RID: 193299
		[Token(Token = "0x402F313")]
		[FieldOffset(Offset = "0x188")]
		private ClimbTowerTowerEntryView.Adapter m_adapter;

		// Token: 0x0402F314 RID: 193300
		[Token(Token = "0x402F314")]
		[FieldOffset(Offset = "0x190")]
		private bool m_inited;

		// Token: 0x0402F315 RID: 193301
		[Token(Token = "0x402F315")]
		private const string SWITCH_MODE_ANIM = "climb_tower_entry_mode_switch";

		// Token: 0x0402F316 RID: 193302
		[Token(Token = "0x402F316")]
		[FieldOffset(Offset = "0x198")]
		private Tween m_switchModeTween;

		// Token: 0x0402F317 RID: 193303
		[Token(Token = "0x402F317")]
		[FieldOffset(Offset = "0x1A0")]
		private ClimbTowerTowerEntryView.MODE_TYPE m_cachedMode;

		// Token: 0x0402F318 RID: 193304
		[Token(Token = "0x402F318")]
		[FieldOffset(Offset = "0x1A8")]
		private ClimbTowerTowerLayerStack m_towerLayerView;

		// Token: 0x0402F319 RID: 193305
		[Token(Token = "0x402F319")]
		[FieldOffset(Offset = "0x1B0")]
		private bool m_cachedIsHardMode;

		// Token: 0x0402F31A RID: 193306
		[Token(Token = "0x402F31A")]
		[FieldOffset(Offset = "0x1B8")]
		private AnimationSwitchTween m_sweepSwitchTween;

		// Token: 0x0402F31B RID: 193307
		[Token(Token = "0x402F31B")]
		[FieldOffset(Offset = "0x1C0")]
		private int m_switchHardModeSeqNum;

		// Token: 0x0402F31C RID: 193308
		[Token(Token = "0x402F31C")]
		[FieldOffset(Offset = "0x1C4")]
		private readonly int LAYOUT_TOWER_TIPS_TOP_HARD;

		// Token: 0x0402F31D RID: 193309
		[Token(Token = "0x402F31D")]
		[FieldOffset(Offset = "0x1C8")]
		private readonly float ALPHA_TOWER_ICON;

		// Token: 0x0402F31E RID: 193310
		[Token(Token = "0x402F31E")]
		private const string BTN_ENTER_PREFIX = "btn_start{0}";

		// Token: 0x0402F320 RID: 193312
		[Token(Token = "0x402F320")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_eventOnSwitchModeClick;

		// Token: 0x0402F321 RID: 193313
		[Token(Token = "0x402F321")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_eventOnSwitchModeClick;

		// Token: 0x0402F322 RID: 193314
		[Token(Token = "0x402F322")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventOnClickSweep;

		// Token: 0x0402F323 RID: 193315
		[Token(Token = "0x402F323")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_eventOnClickSweep;

		// Token: 0x0402F324 RID: 193316
		[Token(Token = "0x402F324")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F325 RID: 193317
		[Token(Token = "0x402F325")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F326 RID: 193318
		[Token(Token = "0x402F326")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402F327 RID: 193319
		[Token(Token = "0x402F327")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402F328 RID: 193320
		[Token(Token = "0x402F328")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F329 RID: 193321
		[Token(Token = "0x402F329")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__IsModeEqual;

		// Token: 0x0402F32A RID: 193322
		[Token(Token = "0x402F32A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderLeftInfoPart;

		// Token: 0x0402F32B RID: 193323
		[Token(Token = "0x402F32B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderFirstRecordPart;

		// Token: 0x0402F32C RID: 193324
		[Token(Token = "0x402F32C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderBgPart;

		// Token: 0x0402F32D RID: 193325
		[Token(Token = "0x402F32D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RenderLayerPart;

		// Token: 0x0402F32E RID: 193326
		[Token(Token = "0x402F32E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RenderBtnEnterPart;

		// Token: 0x0402F32F RID: 193327
		[Token(Token = "0x402F32F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RenderSwitchBtnPart;

		// Token: 0x0402F330 RID: 193328
		[Token(Token = "0x402F330")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RenderSweep;

		// Token: 0x0402F331 RID: 193329
		[Token(Token = "0x402F331")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RenderMedal;

		// Token: 0x0402F332 RID: 193330
		[Token(Token = "0x402F332")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryGetMedalId;

		// Token: 0x0402F333 RID: 193331
		[Token(Token = "0x402F333")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TryPlaySwitchModeTween;

		// Token: 0x0402F334 RID: 193332
		[Token(Token = "0x402F334")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnSwitchToHardBtnClick;

		// Token: 0x0402F335 RID: 193333
		[Token(Token = "0x402F335")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnSwitchToNormBtnClick;

		// Token: 0x0402F336 RID: 193334
		[Token(Token = "0x402F336")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnSelectSweep;

		// Token: 0x0402F337 RID: 193335
		[Token(Token = "0x402F337")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CB2 RID: 23730
		[Token(Token = "0x2005CB2")]
		private class Adapter : ClimbTowerTowerLayerStackAdapter
		{
			// Token: 0x0602258F RID: 140687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602258F")]
			[Address(RVA = "0x1CCC410", Offset = "0x1CCB010", VA = "0x181CCC410")]
			public Adapter(ClimbTowerTowerEntryView closure)
			{
			}

			// Token: 0x170050AF RID: 20655
			// (get) Token: 0x06022590 RID: 140688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050AF")]
			public override List<ClimbTowerLevelModel> data
			{
				[Token(Token = "0x6022590")]
				[Address(RVA = "0x1CCC850", Offset = "0x1CCB450", VA = "0x181CCC850", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170050B0 RID: 20656
			// (get) Token: 0x06022591 RID: 140689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050B0")]
			public override string selectedItem
			{
				[Token(Token = "0x6022591")]
				[Address(RVA = "0x1CCCA10", Offset = "0x1CCB610", VA = "0x181CCCA10", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170050B1 RID: 20657
			// (get) Token: 0x06022592 RID: 140690 RVA: 0x000BD168 File Offset: 0x000BB368
			[Token(Token = "0x170050B1")]
			public override int arrowIndex
			{
				[Token(Token = "0x6022592")]
				[Address(RVA = "0x1CCC5A0", Offset = "0x1CCB1A0", VA = "0x181CCC5A0", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022593 RID: 140691 RVA: 0x000BD180 File Offset: 0x000BB380
			[Token(Token = "0x6022593")]
			[Address(RVA = "0x1CCBBB0", Offset = "0x1CCA7B0", VA = "0x181CCBBB0", Slot = "7")]
			public override bool IsLevelPassed(ClimbTowerLevelModel levelModel)
			{
				return default(bool);
			}

			// Token: 0x06022594 RID: 140692 RVA: 0x000BD198 File Offset: 0x000BB398
			[Token(Token = "0x6022594")]
			[Address(RVA = "0x1CCBB30", Offset = "0x1CCA730", VA = "0x181CCBB30", Slot = "8")]
			public override bool IsHardMode()
			{
				return default(bool);
			}

			// Token: 0x170050B2 RID: 20658
			// (get) Token: 0x06022595 RID: 140693 RVA: 0x000BD1B0 File Offset: 0x000BB3B0
			[Token(Token = "0x170050B2")]
			public override int subCardStageSortBefore
			{
				[Token(Token = "0x6022595")]
				[Address(RVA = "0x1CCCA70", Offset = "0x1CCB670", VA = "0x181CCCA70", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170050B3 RID: 20659
			// (get) Token: 0x06022596 RID: 140694 RVA: 0x000BD1C8 File Offset: 0x000BB3C8
			[Token(Token = "0x170050B3")]
			public override bool hasSelectedSubCard
			{
				[Token(Token = "0x6022596")]
				[Address(RVA = "0x1CCC940", Offset = "0x1CCB540", VA = "0x181CCC940", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170050B4 RID: 20660
			// (get) Token: 0x06022597 RID: 140695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050B4")]
			public override ClimbTowerTowerLayerBaseSelectArrow selectArrowPrefab
			{
				[Token(Token = "0x6022597")]
				[Address(RVA = "0x1CCC9A0", Offset = "0x1CCB5A0", VA = "0x181CCC9A0", Slot = "11")]
				get
				{
					return null;
				}
			}

			// Token: 0x170050B5 RID: 20661
			// (get) Token: 0x06022598 RID: 140696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170050B5")]
			public override ClimbTowerTowerLayerBaseGodCardTips godCardTipsPrefab
			{
				[Token(Token = "0x6022598")]
				[Address(RVA = "0x1CCC8D0", Offset = "0x1CCB4D0", VA = "0x181CCC8D0", Slot = "12")]
				get
				{
					return null;
				}
			}

			// Token: 0x0402F338 RID: 193336
			[Token(Token = "0x402F338")]
			[FieldOffset(Offset = "0x28")]
			private ClimbTowerTowerEntryView m_closure;

			// Token: 0x0402F339 RID: 193337
			[Token(Token = "0x402F339")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F33A RID: 193338
			[Token(Token = "0x402F33A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_data;

			// Token: 0x0402F33B RID: 193339
			[Token(Token = "0x402F33B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_selectedItem;

			// Token: 0x0402F33C RID: 193340
			[Token(Token = "0x402F33C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_arrowIndex;

			// Token: 0x0402F33D RID: 193341
			[Token(Token = "0x402F33D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsLevelPassed;

			// Token: 0x0402F33E RID: 193342
			[Token(Token = "0x402F33E")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_IsHardMode;

			// Token: 0x0402F33F RID: 193343
			[Token(Token = "0x402F33F")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_subCardStageSortBefore;

			// Token: 0x0402F340 RID: 193344
			[Token(Token = "0x402F340")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_hasSelectedSubCard;

			// Token: 0x0402F341 RID: 193345
			[Token(Token = "0x402F341")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_selectArrowPrefab;

			// Token: 0x0402F342 RID: 193346
			[Token(Token = "0x402F342")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_godCardTipsPrefab;
		}

		// Token: 0x02005CB3 RID: 23731
		[Token(Token = "0x2005CB3")]
		private enum MODE_TYPE
		{
			// Token: 0x0402F344 RID: 193348
			[Token(Token = "0x402F344")]
			NONE,
			// Token: 0x0402F345 RID: 193349
			[Token(Token = "0x402F345")]
			NORMAL,
			// Token: 0x0402F346 RID: 193350
			[Token(Token = "0x402F346")]
			HARD
		}
	}
}

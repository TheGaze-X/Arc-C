using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006908 RID: 26888
	[Token(Token = "0x2006908")]
	public class MainStageButtonOnMap : StageButtonOnMap, IHotfixable
	{
		// Token: 0x0602682D RID: 157741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602682D")]
		[Address(RVA = "0x2192690", Offset = "0x2191290", VA = "0x182192690")]
		private void _InitIfNot(StageButtonOnMapHolder holder)
		{
		}

		// Token: 0x17005AEC RID: 23276
		// (get) Token: 0x0602682E RID: 157742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AEC")]
		public override RectTransform positionRect
		{
			[Token(Token = "0x602682E")]
			[Address(RVA = "0x2193600", Offset = "0x2192200", VA = "0x182193600", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602682F RID: 157743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602682F")]
		[Address(RVA = "0x2191D00", Offset = "0x2190900", VA = "0x182191D00", Slot = "8")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x06026830 RID: 157744 RVA: 0x000CB640 File Offset: 0x000C9840
		[Token(Token = "0x6026830")]
		[Address(RVA = "0x2191750", Offset = "0x2190350", VA = "0x182191750", Slot = "6")]
		protected override bool CheckIsStageButtonBlockClick(StageViewModel stageViewModel, ZoneViewModel zoneViewModel)
		{
			return default(bool);
		}

		// Token: 0x06026831 RID: 157745 RVA: 0x000CB658 File Offset: 0x000C9858
		[Token(Token = "0x6026831")]
		[Address(RVA = "0x21917F0", Offset = "0x21903F0", VA = "0x1821917F0", Slot = "7")]
		protected override bool CheckStageLocked(StageViewModel stageViewModel, ZoneViewModel zoneViewModel)
		{
			return default(bool);
		}

		// Token: 0x06026832 RID: 157746 RVA: 0x000CB670 File Offset: 0x000C9870
		[Token(Token = "0x6026832")]
		[Address(RVA = "0x21925B0", Offset = "0x21911B0", VA = "0x1821925B0")]
		private bool _CheckCanStageShowWithFog(StageViewModel stageViewModel)
		{
			return default(bool);
		}

		// Token: 0x06026833 RID: 157747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026833")]
		[Address(RVA = "0x2192A00", Offset = "0x2191600", VA = "0x182192A00")]
		private void _RenderBkg()
		{
		}

		// Token: 0x06026834 RID: 157748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026834")]
		[Address(RVA = "0x2192D90", Offset = "0x2191990", VA = "0x182192D90")]
		private void _RenderBossIcon()
		{
		}

		// Token: 0x06026835 RID: 157749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026835")]
		[Address(RVA = "0x2193120", Offset = "0x2191D20", VA = "0x182193120")]
		private void _RenderRewards()
		{
		}

		// Token: 0x06026836 RID: 157750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026836")]
		[Address(RVA = "0x2191B00", Offset = "0x2190700", VA = "0x182191B00")]
		public void HideReward()
		{
		}

		// Token: 0x06026837 RID: 157751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026837")]
		[Address(RVA = "0x2192EC0", Offset = "0x2191AC0", VA = "0x182192EC0")]
		private void _RenderEntry()
		{
		}

		// Token: 0x06026838 RID: 157752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026838")]
		[Address(RVA = "0x2191990", Offset = "0x2190590", VA = "0x182191990")]
		public void HideEntry()
		{
		}

		// Token: 0x06026839 RID: 157753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026839")]
		[Address(RVA = "0x2191BD0", Offset = "0x21907D0", VA = "0x182191BD0")]
		public void HideStageNameCode()
		{
		}

		// Token: 0x0602683A RID: 157754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602683A")]
		[Address(RVA = "0x21923D0", Offset = "0x2190FD0", VA = "0x1821923D0")]
		public void SetBtnColor(Color targetColor)
		{
		}

		// Token: 0x0602683B RID: 157755 RVA: 0x000CB688 File Offset: 0x000C9888
		[Token(Token = "0x602683B")]
		[Address(RVA = "0x2192800", Offset = "0x2191400", VA = "0x182192800")]
		private bool _InstBkgStyle(Graphic prefab, bool isShow, ref Graphic inst)
		{
			return default(bool);
		}

		// Token: 0x0602683C RID: 157756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602683C")]
		[Address(RVA = "0x2193570", Offset = "0x2192170", VA = "0x182193570")]
		public MainStageButtonOnMap()
		{
		}

		// Token: 0x0602683D RID: 157757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602683D")]
		[Address(RVA = "0x21925A0", Offset = "0x21911A0", VA = "0x1821925A0")]
		private RectTransform <>xLuaBaseProxy_get_positionRect()
		{
			return null;
		}

		// Token: 0x0602683E RID: 157758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602683E")]
		[Address(RVA = "0x20FCE20", Offset = "0x20FBA20", VA = "0x1820FCE20")]
		private void <>xLuaBaseProxy_RenderStage(StageButtonOnMapHolder P0, StageViewModel P1, ZoneViewModel P2, bool P3)
		{
		}

		// Token: 0x0602683F RID: 157759 RVA: 0x000CB6A0 File Offset: 0x000C98A0
		[Token(Token = "0x602683F")]
		[Address(RVA = "0x2192580", Offset = "0x2191180", VA = "0x182192580")]
		private bool <>xLuaBaseProxy_CheckIsStageButtonBlockClick(StageViewModel P0, ZoneViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x06026840 RID: 157760 RVA: 0x000CB6B8 File Offset: 0x000C98B8
		[Token(Token = "0x6026840")]
		[Address(RVA = "0x2192590", Offset = "0x2191190", VA = "0x182192590")]
		private bool <>xLuaBaseProxy_CheckStageLocked(StageViewModel P0, ZoneViewModel P1)
		{
			return default(bool);
		}

		// Token: 0x0403647B RID: 222331
		[Token(Token = "0x403647B")]
		public const string FUNC_SELECT_GRAPHIC = "mainStage_selectGraphic";

		// Token: 0x0403647C RID: 222332
		[Token(Token = "0x403647C")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgTraining;

		// Token: 0x0403647D RID: 222333
		[Token(Token = "0x403647D")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgStory;

		// Token: 0x0403647E RID: 222334
		[Token(Token = "0x403647E")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgNormal;

		// Token: 0x0403647F RID: 222335
		[Token(Token = "0x403647F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgPredefinedNormal;

		// Token: 0x04036480 RID: 222336
		[Token(Token = "0x4036480")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgBranch;

		// Token: 0x04036481 RID: 222337
		[Token(Token = "0x4036481")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Background")]
		private Sprite _spriteBkgHilight;

		// Token: 0x04036482 RID: 222338
		[Token(Token = "0x4036482")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Background")]
		private Image _imgBkg;

		// Token: 0x04036483 RID: 222339
		[Token(Token = "0x4036483")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Background")]
		private Color _normalTextColor;

		// Token: 0x04036484 RID: 222340
		[Token(Token = "0x4036484")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Background")]
		private Color _trainTextColor;

		// Token: 0x04036485 RID: 222341
		[Token(Token = "0x4036485")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Background")]
		private Color _storyTextColor;

		// Token: 0x04036486 RID: 222342
		[Token(Token = "0x4036486")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Background")]
		private Color _hilightTextColor;

		// Token: 0x04036487 RID: 222343
		[Token(Token = "0x4036487")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Background")]
		private Color _predefinedTextColor;

		// Token: 0x04036488 RID: 222344
		[Token(Token = "0x4036488")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("BkgInst")]
		[Tooltip("Nullable")]
		private Graphic _hightDifficultBkgPrefab;

		// Token: 0x04036489 RID: 222345
		[Token(Token = "0x4036489")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("BkgInst")]
		[Tooltip("Nullable")]
		private Graphic _mistOptBkgPrefab;

		// Token: 0x0403648A RID: 222346
		[Token(Token = "0x403648A")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("BkgInst")]
		[Tooltip("Nullable")]
		private RectTransform _bkgInstLayer;

		// Token: 0x0403648B RID: 222347
		[Token(Token = "0x403648B")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Boss")]
		private Image _iconBoss;

		// Token: 0x0403648C RID: 222348
		[Token(Token = "0x403648C")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		[Group("Boss")]
		private Sprite _spriteBossNormal;

		// Token: 0x0403648D RID: 222349
		[Token(Token = "0x403648D")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		[Group("Boss")]
		private Sprite _spriteBossHilight;

		// Token: 0x0403648E RID: 222350
		[Token(Token = "0x403648E")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Group("Training")]
		private Image _iconTrainFinished;

		// Token: 0x0403648F RID: 222351
		[Token(Token = "0x403648F")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[Group("Training")]
		private Image _iconTrainUnfinished;

		// Token: 0x04036490 RID: 222352
		[Token(Token = "0x4036490")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Group("Training")]
		private Image _iconPredefinedTraining;

		// Token: 0x04036491 RID: 222353
		[Token(Token = "0x4036491")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		[Group("Story Only")]
		private Image _storyOnlyMark;

		// Token: 0x04036492 RID: 222354
		[Token(Token = "0x4036492")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		[Group("Rewards")]
		private RectTransform _itemCardContainer;

		// Token: 0x04036493 RID: 222355
		[Token(Token = "0x4036493")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		[Group("Rewards")]
		private float _itemScaler;

		// Token: 0x04036494 RID: 222356
		[Token(Token = "0x4036494")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		[Group("Rewards")]
		private GameObject _charContainer;

		// Token: 0x04036495 RID: 222357
		[Token(Token = "0x4036495")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		[Group("Rewards")]
		private Image _imgChar;

		// Token: 0x04036496 RID: 222358
		[Token(Token = "0x4036496")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Group("Rewards")]
		private Vector2 _charPosNoItem;

		// Token: 0x04036497 RID: 222359
		[Token(Token = "0x4036497")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		[Group("Rewards")]
		private Vector2 _charPosWithItem;

		// Token: 0x04036498 RID: 222360
		[Token(Token = "0x4036498")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Group("Selection")]
		private UIColorGraphic _selectionGraphic;

		// Token: 0x04036499 RID: 222361
		[Token(Token = "0x4036499")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		[Group("Selection")]
		private Color _selectedColor;

		// Token: 0x0403649A RID: 222362
		[Token(Token = "0x403649A")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[Tooltip("Used to bound a button in stage map")]
		private Button _stageButton;

		// Token: 0x0403649B RID: 222363
		[Token(Token = "0x403649B")]
		[FieldOffset(Offset = "0x200")]
		private UIItemCard m_itemCard;

		// Token: 0x0403649C RID: 222364
		[Token(Token = "0x403649C")]
		[FieldOffset(Offset = "0x208")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0403649D RID: 222365
		[Token(Token = "0x403649D")]
		[FieldOffset(Offset = "0x210")]
		private UIItemViewModel m_charModel;

		// Token: 0x0403649E RID: 222366
		[Token(Token = "0x403649E")]
		[FieldOffset(Offset = "0x218")]
		private Graphic m_highDifficultBkgInst;

		// Token: 0x0403649F RID: 222367
		[Token(Token = "0x403649F")]
		[FieldOffset(Offset = "0x220")]
		private Graphic m_mistOptBkgInst;

		// Token: 0x040364A0 RID: 222368
		[Token(Token = "0x40364A0")]
		[FieldOffset(Offset = "0x228")]
		private MainStageButtonOnMap.ViewModelCache m_viewModelCache;

		// Token: 0x040364A1 RID: 222369
		[Token(Token = "0x40364A1")]
		[FieldOffset(Offset = "0x258")]
		private bool m_isBtnInited;

		// Token: 0x040364A2 RID: 222370
		[Token(Token = "0x40364A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040364A3 RID: 222371
		[Token(Token = "0x40364A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_positionRect;

		// Token: 0x040364A4 RID: 222372
		[Token(Token = "0x40364A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x040364A5 RID: 222373
		[Token(Token = "0x40364A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIsStageButtonBlockClick;

		// Token: 0x040364A6 RID: 222374
		[Token(Token = "0x40364A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckStageLocked;

		// Token: 0x040364A7 RID: 222375
		[Token(Token = "0x40364A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckCanStageShowWithFog;

		// Token: 0x040364A8 RID: 222376
		[Token(Token = "0x40364A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBkg;

		// Token: 0x040364A9 RID: 222377
		[Token(Token = "0x40364A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderBossIcon;

		// Token: 0x040364AA RID: 222378
		[Token(Token = "0x40364AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderRewards;

		// Token: 0x040364AB RID: 222379
		[Token(Token = "0x40364AB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideReward;

		// Token: 0x040364AC RID: 222380
		[Token(Token = "0x40364AC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderEntry;

		// Token: 0x040364AD RID: 222381
		[Token(Token = "0x40364AD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideEntry;

		// Token: 0x040364AE RID: 222382
		[Token(Token = "0x40364AE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideStageNameCode;

		// Token: 0x040364AF RID: 222383
		[Token(Token = "0x40364AF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SetBtnColor;

		// Token: 0x040364B0 RID: 222384
		[Token(Token = "0x40364B0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InstBkgStyle;

		// Token: 0x040364B1 RID: 222385
		[Token(Token = "0x40364B1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006909 RID: 26889
		[Token(Token = "0x2006909")]
		private struct ViewModelCache
		{
			// Token: 0x06026841 RID: 157761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026841")]
			[Address(RVA = "0x21A4D60", Offset = "0x21A3960", VA = "0x1821A4D60")]
			public ViewModelCache(MainStageButtonOnMapHolder holder, StageViewModel viewModel, bool isSelected)
			{
			}

			// Token: 0x040364B2 RID: 222386
			[Token(Token = "0x40364B2")]
			[FieldOffset(Offset = "0x0")]
			public bool isTraining;

			// Token: 0x040364B3 RID: 222387
			[Token(Token = "0x40364B3")]
			[FieldOffset(Offset = "0x1")]
			public bool isEntry;

			// Token: 0x040364B4 RID: 222388
			[Token(Token = "0x40364B4")]
			[FieldOffset(Offset = "0x2")]
			public bool isHilighted;

			// Token: 0x040364B5 RID: 222389
			[Token(Token = "0x40364B5")]
			[FieldOffset(Offset = "0x3")]
			public bool isCharacterPredefined;

			// Token: 0x040364B6 RID: 222390
			[Token(Token = "0x40364B6")]
			[FieldOffset(Offset = "0x4")]
			public bool isHardStageCharacterPredefined;

			// Token: 0x040364B7 RID: 222391
			[Token(Token = "0x40364B7")]
			[FieldOffset(Offset = "0x5")]
			public bool isStoryOnly;

			// Token: 0x040364B8 RID: 222392
			[Token(Token = "0x40364B8")]
			[FieldOffset(Offset = "0x8")]
			public AppearanceStyle appearanceStyle;

			// Token: 0x040364B9 RID: 222393
			[Token(Token = "0x40364B9")]
			[FieldOffset(Offset = "0xC")]
			public bool isBranch;

			// Token: 0x040364BA RID: 222394
			[Token(Token = "0x40364BA")]
			[FieldOffset(Offset = "0xD")]
			public bool hasBoss;

			// Token: 0x040364BB RID: 222395
			[Token(Token = "0x40364BB")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x040364BC RID: 222396
			[Token(Token = "0x40364BC")]
			[FieldOffset(Offset = "0x18")]
			public string mainRewardItem;

			// Token: 0x040364BD RID: 222397
			[Token(Token = "0x40364BD")]
			[FieldOffset(Offset = "0x20")]
			public string rewardCharId;

			// Token: 0x040364BE RID: 222398
			[Token(Token = "0x40364BE")]
			[FieldOffset(Offset = "0x28")]
			public PlayerStageState stageState;

			// Token: 0x040364BF RID: 222399
			[Token(Token = "0x40364BF")]
			[FieldOffset(Offset = "0x2C")]
			public bool isSelected;

			// Token: 0x040364C0 RID: 222400
			[Token(Token = "0x40364C0")]
			[FieldOffset(Offset = "0x2D")]
			public bool isPassed;
		}
	}
}

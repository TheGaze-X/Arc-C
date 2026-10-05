using System;
using System.Collections;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Workshop
{
	// Token: 0x02001BE8 RID: 7144
	[Token(Token = "0x2001BE8")]
	public class BuildingWorkshopWholeView : DataBinder<BuildingWorkshopProperty>, IHotfixable
	{
		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700154D")]
		public WorkshopMotionEffect motionEffect
		{
			[Token(Token = "0x600B230")]
			[Address(RVA = "0x32CB940", Offset = "0x32CA540", VA = "0x1832CB940")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B231")]
		[Address(RVA = "0x32C98D0", Offset = "0x32C84D0", VA = "0x1832C98D0")]
		private void _SaveSetupIngredientStorage(IFormulaItem item, Text label, int workCount)
		{
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B232")]
		[Address(RVA = "0x32C9A90", Offset = "0x32C8690", VA = "0x1832C9A90")]
		private void _SaveSetupIngredient(IFormulaItem item, BuildingWorkshopWholeView.FormulaItemGroup group, int workCount)
		{
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B233")]
		[Address(RVA = "0x32C96F0", Offset = "0x32C82F0", VA = "0x1832C96F0")]
		private void _SaveSetupIngredientJumpBtn(IFormulaItem item, BuildingWorkshopWholeView.FormulaItemGroup group, int workCount)
		{
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B234")]
		[Address(RVA = "0x32C9540", Offset = "0x32C8140", VA = "0x1832C9540")]
		private void _RenderAllIngredient(IWorkshopFormula currentFormula, int workCount)
		{
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B235")]
		[Address(RVA = "0x32CADC0", Offset = "0x32C99C0", VA = "0x1832CADC0")]
		private void _SetupFormulaItemGroup(BuildingWorkshopWholeView.FormulaItemGroup group, bool isIngredient, bool showItemNum = false)
		{
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B236")]
		[Address(RVA = "0x32CACB0", Offset = "0x32C98B0", VA = "0x1832CACB0")]
		private void _SetWorkOverload(bool on)
		{
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B237")]
		[Address(RVA = "0x32C9DC0", Offset = "0x32C89C0", VA = "0x1832C9DC0")]
		private void _SetMoodValue(int curMood, IWorkshopStationaryCharacter stationaryChar)
		{
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B238")]
		[Address(RVA = "0x32C87B0", Offset = "0x32C73B0", VA = "0x1832C87B0")]
		private void _RefreshView(BuildingWorkshopWholeViewModel viewModel)
		{
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B239")]
		[Address(RVA = "0x32CA550", Offset = "0x32C9150", VA = "0x1832CA550")]
		private void _SetProtect(bool isItemProtection)
		{
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23A")]
		[Address(RVA = "0x32CA860", Offset = "0x32C9460", VA = "0x1832CA860")]
		private void _SetWorkCount(BuildingWorkshopModel model, int count)
		{
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23B")]
		[Address(RVA = "0x32CA160", Offset = "0x32C8D60", VA = "0x1832CA160")]
		private void _SetPrevItemPanel(BuildingWorkshopModel model)
		{
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23C")]
		[Address(RVA = "0x32CA610", Offset = "0x32C9210", VA = "0x1832CA610")]
		private void _SetTargetAmountPanel(BuildingWorkshopModel model)
		{
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23D")]
		[Address(RVA = "0x32C84C0", Offset = "0x32C70C0", VA = "0x1832C84C0")]
		private void _HintCallback(float val)
		{
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B23E")]
		[Address(RVA = "0x32C8700", Offset = "0x32C7300", VA = "0x1832C8700")]
		private IEnumerator _MotionAndMoodEffectWithCallback()
		{
			return null;
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B23F")]
		[Address(RVA = "0x32C7FD0", Offset = "0x32C6BD0", VA = "0x1832C7FD0")]
		public IEnumerator OutcomeEffectCoroutine(WorkResult workResult, Action refresh)
		{
			return null;
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B240")]
		[Address(RVA = "0x32CB770", Offset = "0x32CA370", VA = "0x1832CB770")]
		private void _ToastBySideProduct(BuildingWorkshopBySideNotify prefab, string itemId, long count, int index)
		{
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B241")]
		[Address(RVA = "0x32CB1A0", Offset = "0x32C9DA0", VA = "0x1832CB1A0")]
		private void _ShowRecoverMood(long recoverCost)
		{
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B242")]
		[Address(RVA = "0x32C80F0", Offset = "0x32C6CF0", VA = "0x1832C80F0")]
		public void StopRecoverTweens()
		{
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B243")]
		[Address(RVA = "0x32C7E10", Offset = "0x32C6A10", VA = "0x1832C7E10")]
		public void BlockScreen()
		{
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B244")]
		[Address(RVA = "0x32C7E80", Offset = "0x32C6A80", VA = "0x1832C7E80", Slot = "7")]
		public override void OnValueChanged(BuildingWorkshopProperty property)
		{
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B245")]
		[Address(RVA = "0x32C8680", Offset = "0x32C7280", VA = "0x1832C8680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B246")]
		[Address(RVA = "0x32C81E0", Offset = "0x32C6DE0", VA = "0x1832C81E0")]
		private void Update()
		{
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B247")]
		[Address(RVA = "0x32CB8B0", Offset = "0x32CA4B0", VA = "0x1832CB8B0")]
		public BuildingWorkshopWholeView()
		{
		}

		// Token: 0x0400ACF6 RID: 44278
		[Token(Token = "0x400ACF6")]
		private const float BY_SIDE_NOTIFY_DELAY = 0.5f;

		// Token: 0x0400ACF7 RID: 44279
		[Token(Token = "0x400ACF7")]
		private const float RECOVER_MOOD_DELAY = 1f;

		// Token: 0x0400ACF8 RID: 44280
		[Token(Token = "0x400ACF8")]
		private const float RECOVER_MOOD_HOLD_TIME = 1f;

		// Token: 0x0400ACF9 RID: 44281
		[Token(Token = "0x400ACF9")]
		private const float DURATION_SWITCH = 0.1f;

		// Token: 0x0400ACFA RID: 44282
		[Token(Token = "0x400ACFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0400ACFB RID: 44283
		[Token(Token = "0x400ACFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _characterName;

		// Token: 0x0400ACFC RID: 44284
		[Token(Token = "0x400ACFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _distractedLabel;

		// Token: 0x0400ACFD RID: 44285
		[Token(Token = "0x400ACFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _mpBarContainer;

		// Token: 0x0400ACFE RID: 44286
		[Token(Token = "0x400ACFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _moodTextLabel;

		// Token: 0x0400ACFF RID: 44287
		[Token(Token = "0x400ACFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _characterEmptyHint;

		// Token: 0x0400AD00 RID: 44288
		[Token(Token = "0x400AD00")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingBuffDescView _buffView;

		// Token: 0x0400AD01 RID: 44289
		[Token(Token = "0x400AD01")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _buffHintLabel;

		// Token: 0x0400AD02 RID: 44290
		[Token(Token = "0x400AD02")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _goldCostLabel;

		// Token: 0x0400AD03 RID: 44291
		[Token(Token = "0x400AD03")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _moodCostLabel;

		// Token: 0x0400AD04 RID: 44292
		[Token(Token = "0x400AD04")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _workCountLabel;

		// Token: 0x0400AD05 RID: 44293
		[Token(Token = "0x400AD05")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _moodOverloadHint;

		// Token: 0x0400AD06 RID: 44294
		[Token(Token = "0x400AD06")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _moodOverloadBG;

		// Token: 0x0400AD07 RID: 44295
		[Token(Token = "0x400AD07")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _workCountBG;

		// Token: 0x0400AD08 RID: 44296
		[Token(Token = "0x400AD08")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x0400AD09 RID: 44297
		[Token(Token = "0x400AD09")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _characterMoodOverloadColor;

		// Token: 0x0400AD0A RID: 44298
		[Token(Token = "0x400AD0A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _characterMoodBG;

		// Token: 0x0400AD0B RID: 44299
		[Token(Token = "0x400AD0B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _extraProbLabel;

		// Token: 0x0400AD0C RID: 44300
		[Token(Token = "0x400AD0C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _extraProbPlusLabel;

		// Token: 0x0400AD0D RID: 44301
		[Token(Token = "0x400AD0D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private BuildingWorkshopWholeView.FormulaItemGroup _outcomeItemCard;

		// Token: 0x0400AD0E RID: 44302
		[Token(Token = "0x400AD0E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private BuildingWorkshopWholeView.FormulaItemGroup _ingredient1ItemCard;

		// Token: 0x0400AD0F RID: 44303
		[Token(Token = "0x400AD0F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private BuildingWorkshopWholeView.FormulaItemGroup _ingredient2ItemCard;

		// Token: 0x0400AD10 RID: 44304
		[Token(Token = "0x400AD10")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private BuildingWorkshopWholeView.FormulaItemGroup _ingredient3ItemCard;

		// Token: 0x0400AD11 RID: 44305
		[Token(Token = "0x400AD11")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Transform _switchHandler;

		// Token: 0x0400AD12 RID: 44306
		[Token(Token = "0x400AD12")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _switchOnPos;

		// Token: 0x0400AD13 RID: 44307
		[Token(Token = "0x400AD13")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Transform _switchOffPos;

		// Token: 0x0400AD14 RID: 44308
		[Token(Token = "0x400AD14")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _switchOnGroup;

		// Token: 0x0400AD15 RID: 44309
		[Token(Token = "0x400AD15")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _switchOffGroup;

		// Token: 0x0400AD16 RID: 44310
		[Token(Token = "0x400AD16")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _switchPanel;

		// Token: 0x0400AD17 RID: 44311
		[Token(Token = "0x400AD17")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Button _switchButton;

		// Token: 0x0400AD18 RID: 44312
		[Token(Token = "0x400AD18")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _itemStorageLackFormat;

		// Token: 0x0400AD19 RID: 44313
		[Token(Token = "0x400AD19")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _itemStorageNormFormat;

		// Token: 0x0400AD1A RID: 44314
		[Token(Token = "0x400AD1A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private WorkshopMotionEffect _motionEffect;

		// Token: 0x0400AD1B RID: 44315
		[Token(Token = "0x400AD1B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _screenBlocker;

		// Token: 0x0400AD1C RID: 44316
		[Token(Token = "0x400AD1C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float _outcomePanelDisplayDelay;

		// Token: 0x0400AD1D RID: 44317
		[Token(Token = "0x400AD1D")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Transform _hintPanelTransform;

		// Token: 0x0400AD1E RID: 44318
		[Token(Token = "0x400AD1E")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private CanvasGroup _hintPanelCanvasGroup;

		// Token: 0x0400AD1F RID: 44319
		[Token(Token = "0x400AD1F")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Transform _hintControlPoint0;

		// Token: 0x0400AD20 RID: 44320
		[Token(Token = "0x400AD20")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Transform _hintControlPoint1;

		// Token: 0x0400AD21 RID: 44321
		[Token(Token = "0x400AD21")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private AnimationCurve _hintAnimationCurve;

		// Token: 0x0400AD22 RID: 44322
		[Token(Token = "0x400AD22")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _hintTransferTime;

		// Token: 0x0400AD23 RID: 44323
		[Token(Token = "0x400AD23")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("Room Title")]
		private BuildingRoomLevelView _roomLevel;

		// Token: 0x0400AD24 RID: 44324
		[Token(Token = "0x400AD24")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("Room Title")]
		private Text _roomTitle;

		// Token: 0x0400AD25 RID: 44325
		[Token(Token = "0x400AD25")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _switchProcessingSpeed;

		// Token: 0x0400AD26 RID: 44326
		[Token(Token = "0x400AD26")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Transform _recoverPanelTransform;

		// Token: 0x0400AD27 RID: 44327
		[Token(Token = "0x400AD27")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Text _recoverMoodLabel;

		// Token: 0x0400AD28 RID: 44328
		[Token(Token = "0x400AD28")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private BuildingWorkshopBonusView _bonusView;

		// Token: 0x0400AD29 RID: 44329
		[Token(Token = "0x400AD29")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0400AD2A RID: 44330
		[Token(Token = "0x400AD2A")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private BuildingWorkshopWholeView.PrevItemPart _prevItemPart;

		// Token: 0x0400AD2B RID: 44331
		[Token(Token = "0x400AD2B")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private BuildingWorkshopWholeView.TargetAmountPart _targetAmountPart;

		// Token: 0x0400AD2C RID: 44332
		[Token(Token = "0x400AD2C")]
		[FieldOffset(Offset = "0x1C0")]
		[NonSerialized]
		public BuildingUIResMenu resMenu;

		// Token: 0x0400AD2D RID: 44333
		[Token(Token = "0x400AD2D")]
		[FieldOffset(Offset = "0x1C8")]
		[NonSerialized]
		public Action onClickFormulaButton;

		// Token: 0x0400AD2E RID: 44334
		[Token(Token = "0x400AD2E")]
		[FieldOffset(Offset = "0x1D0")]
		private BuildingCharMPStateBar m_mpBar;

		// Token: 0x0400AD2F RID: 44335
		[Token(Token = "0x400AD2F")]
		[FieldOffset(Offset = "0x1D8")]
		private float m_switchPositionValue;

		// Token: 0x0400AD30 RID: 44336
		[Token(Token = "0x400AD30")]
		[FieldOffset(Offset = "0x1DC")]
		private float m_switchPositionValueTarget;

		// Token: 0x0400AD31 RID: 44337
		[Token(Token = "0x400AD31")]
		[FieldOffset(Offset = "0x1E0")]
		private Sequence m_recoverTweenSequence;

		// Token: 0x0400AD32 RID: 44338
		[Token(Token = "0x400AD32")]
		[FieldOffset(Offset = "0x1E8")]
		private bool m_isInited;

		// Token: 0x0400AD33 RID: 44339
		[Token(Token = "0x400AD33")]
		[FieldOffset(Offset = "0x1F0")]
		private BuildingWorkshopWholeViewModel m_cachedViewModel;

		// Token: 0x0400AD34 RID: 44340
		[Token(Token = "0x400AD34")]
		[FieldOffset(Offset = "0x1F8")]
		private int m_cachedMood;

		// Token: 0x0400AD35 RID: 44341
		[Token(Token = "0x400AD35")]
		[FieldOffset(Offset = "0x200")]
		private UIItemCard m_prevItemCard;

		// Token: 0x0400AD36 RID: 44342
		[Token(Token = "0x400AD36")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_motionEffect;

		// Token: 0x0400AD37 RID: 44343
		[Token(Token = "0x400AD37")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SaveSetupIngredientStorage;

		// Token: 0x0400AD38 RID: 44344
		[Token(Token = "0x400AD38")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SaveSetupIngredient;

		// Token: 0x0400AD39 RID: 44345
		[Token(Token = "0x400AD39")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SaveSetupIngredientJumpBtn;

		// Token: 0x0400AD3A RID: 44346
		[Token(Token = "0x400AD3A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderAllIngredient;

		// Token: 0x0400AD3B RID: 44347
		[Token(Token = "0x400AD3B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetupFormulaItemGroup;

		// Token: 0x0400AD3C RID: 44348
		[Token(Token = "0x400AD3C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetWorkOverload;

		// Token: 0x0400AD3D RID: 44349
		[Token(Token = "0x400AD3D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetMoodValue;

		// Token: 0x0400AD3E RID: 44350
		[Token(Token = "0x400AD3E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0400AD3F RID: 44351
		[Token(Token = "0x400AD3F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetProtect;

		// Token: 0x0400AD40 RID: 44352
		[Token(Token = "0x400AD40")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetWorkCount;

		// Token: 0x0400AD41 RID: 44353
		[Token(Token = "0x400AD41")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetPrevItemPanel;

		// Token: 0x0400AD42 RID: 44354
		[Token(Token = "0x400AD42")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetTargetAmountPanel;

		// Token: 0x0400AD43 RID: 44355
		[Token(Token = "0x400AD43")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HintCallback;

		// Token: 0x0400AD44 RID: 44356
		[Token(Token = "0x400AD44")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__MotionAndMoodEffectWithCallback;

		// Token: 0x0400AD45 RID: 44357
		[Token(Token = "0x400AD45")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OutcomeEffectCoroutine;

		// Token: 0x0400AD46 RID: 44358
		[Token(Token = "0x400AD46")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ToastBySideProduct;

		// Token: 0x0400AD47 RID: 44359
		[Token(Token = "0x400AD47")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowRecoverMood;

		// Token: 0x0400AD48 RID: 44360
		[Token(Token = "0x400AD48")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_StopRecoverTweens;

		// Token: 0x0400AD49 RID: 44361
		[Token(Token = "0x400AD49")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_BlockScreen;

		// Token: 0x0400AD4A RID: 44362
		[Token(Token = "0x400AD4A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400AD4B RID: 44363
		[Token(Token = "0x400AD4B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400AD4C RID: 44364
		[Token(Token = "0x400AD4C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400AD4D RID: 44365
		[Token(Token = "0x400AD4D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001BE9 RID: 7145
		[Token(Token = "0x2001BE9")]
		[Serializable]
		public class FormulaItemGroup
		{
			// Token: 0x0600B24A RID: 45642 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24A")]
			[Address(RVA = "0x32E4110", Offset = "0x32E2D10", VA = "0x1832E4110")]
			public FormulaItemGroup()
			{
			}

			// Token: 0x0400AD4E RID: 44366
			[Token(Token = "0x400AD4E")]
			[FieldOffset(Offset = "0x10")]
			public Transform container;

			// Token: 0x0400AD4F RID: 44367
			[Token(Token = "0x400AD4F")]
			[FieldOffset(Offset = "0x18")]
			public float scale;

			// Token: 0x0400AD50 RID: 44368
			[Token(Token = "0x400AD50")]
			[FieldOffset(Offset = "0x20")]
			public UIItemCard card;

			// Token: 0x0400AD51 RID: 44369
			[Token(Token = "0x400AD51")]
			[FieldOffset(Offset = "0x28")]
			public Text name;

			// Token: 0x0400AD52 RID: 44370
			[Token(Token = "0x400AD52")]
			[FieldOffset(Offset = "0x30")]
			public Text storage;

			// Token: 0x0400AD53 RID: 44371
			[Token(Token = "0x400AD53")]
			[FieldOffset(Offset = "0x38")]
			public GameObject emptyHint;

			// Token: 0x0400AD54 RID: 44372
			[Token(Token = "0x400AD54")]
			[FieldOffset(Offset = "0x40")]
			public GameObject panelStorage;

			// Token: 0x0400AD55 RID: 44373
			[Token(Token = "0x400AD55")]
			[FieldOffset(Offset = "0x48")]
			public BuildingWorkshopWholeView.FormulaJumpToIngredientBtn jumpBtn;

			// Token: 0x0400AD56 RID: 44374
			[Token(Token = "0x400AD56")]
			[FieldOffset(Offset = "0x50")]
			public UIItemViewModel cacheItemModel;
		}

		// Token: 0x02001BEA RID: 7146
		[Token(Token = "0x2001BEA")]
		[Serializable]
		public class FormulaJumpToIngredientBtn
		{
			// Token: 0x0600B24B RID: 45643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FormulaJumpToIngredientBtn()
			{
			}

			// Token: 0x0400AD57 RID: 44375
			[Token(Token = "0x400AD57")]
			[FieldOffset(Offset = "0x10")]
			public GameObject panelJumpToIngredientBtn;

			// Token: 0x0400AD58 RID: 44376
			[Token(Token = "0x400AD58")]
			[FieldOffset(Offset = "0x18")]
			public GameObject panelBtnCheck;

			// Token: 0x0400AD59 RID: 44377
			[Token(Token = "0x400AD59")]
			[FieldOffset(Offset = "0x20")]
			public GameObject panelBtnCanProcess;
		}

		// Token: 0x02001BEB RID: 7147
		[Token(Token = "0x2001BEB")]
		[Serializable]
		public class PrevItemPart
		{
			// Token: 0x0600B24C RID: 45644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24C")]
			[Address(RVA = "0x32E52D0", Offset = "0x32E3ED0", VA = "0x1832E52D0")]
			public PrevItemPart()
			{
			}

			// Token: 0x0400AD5A RID: 44378
			[Token(Token = "0x400AD5A")]
			[FieldOffset(Offset = "0x10")]
			public GameObject panelPrev;

			// Token: 0x0400AD5B RID: 44379
			[Token(Token = "0x400AD5B")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform prevItemContainer;

			// Token: 0x0400AD5C RID: 44380
			[Token(Token = "0x400AD5C")]
			[FieldOffset(Offset = "0x20")]
			public float itemScale;
		}

		// Token: 0x02001BEC RID: 7148
		[Token(Token = "0x2001BEC")]
		[Serializable]
		public class TargetAmountPart
		{
			// Token: 0x0600B24D RID: 45645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TargetAmountPart()
			{
			}

			// Token: 0x0400AD5D RID: 44381
			[Token(Token = "0x400AD5D")]
			[FieldOffset(Offset = "0x10")]
			public GameObject panelTargetAmount;

			// Token: 0x0400AD5E RID: 44382
			[Token(Token = "0x400AD5E")]
			[FieldOffset(Offset = "0x18")]
			public GameObject panelNormal;

			// Token: 0x0400AD5F RID: 44383
			[Token(Token = "0x400AD5F")]
			[FieldOffset(Offset = "0x20")]
			public GameObject panelEnough;

			// Token: 0x0400AD60 RID: 44384
			[Token(Token = "0x400AD60")]
			[FieldOffset(Offset = "0x28")]
			public Text txtTargetAmount;
		}
	}
}

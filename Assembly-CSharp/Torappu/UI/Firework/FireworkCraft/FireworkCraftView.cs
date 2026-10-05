using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E90 RID: 20112
	[Token(Token = "0x2004E90")]
	public class FireworkCraftView : DataBinder<FireworkCraftProperty>
	{
		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x0601E01A RID: 122906 RVA: 0x000AD298 File Offset: 0x000AB498
		[Token(Token = "0x17004665")]
		public bool isStable
		{
			[Token(Token = "0x601E01A")]
			[Address(RVA = "0x17C7350", Offset = "0x17C5F50", VA = "0x1817C7350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601E01B RID: 122907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E01B")]
		[Address(RVA = "0x17C5080", Offset = "0x17C3C80", VA = "0x1817C5080", Slot = "7")]
		public override void OnValueChanged(FireworkCraftProperty property)
		{
		}

		// Token: 0x0601E01C RID: 122908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E01C")]
		[Address(RVA = "0x17C5730", Offset = "0x17C4330", VA = "0x1817C5730")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E01D RID: 122909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E01D")]
		[Address(RVA = "0x17C6080", Offset = "0x17C4C80", VA = "0x1817C6080")]
		private void _PlayTweens(FireworkCraftModel model)
		{
		}

		// Token: 0x0601E01E RID: 122910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E01E")]
		[Address(RVA = "0x17C6EC0", Offset = "0x17C5AC0", VA = "0x1817C6EC0")]
		private void _ResetPlateStyle(string currAnimalId)
		{
		}

		// Token: 0x0601E01F RID: 122911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E01F")]
		[Address(RVA = "0x17C6980", Offset = "0x17C5580", VA = "0x1817C6980")]
		private void _RenderImgMap(string stageId, bool isMap)
		{
		}

		// Token: 0x0601E020 RID: 122912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E020")]
		[Address(RVA = "0x17C67D0", Offset = "0x17C53D0", VA = "0x1817C67D0")]
		private void _RenderFireworkView(FireworkPlateGroupModel plateGroupModel, string currAnimalId, bool isMap)
		{
		}

		// Token: 0x0601E021 RID: 122913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E021")]
		[Address(RVA = "0x17C6240", Offset = "0x17C4E40", VA = "0x1817C6240")]
		private void _RenderAnimalBkg(string currAnimalId)
		{
		}

		// Token: 0x0601E022 RID: 122914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E022")]
		[Address(RVA = "0x17C6A80", Offset = "0x17C5680", VA = "0x1817C6A80")]
		private void _RenderStageList(FireworkCraftModel model, bool isMap)
		{
		}

		// Token: 0x0601E023 RID: 122915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E023")]
		[Address(RVA = "0x17C63B0", Offset = "0x17C4FB0", VA = "0x1817C63B0")]
		private void _RenderAnimalEffectPart(FireworkCraftModel model)
		{
		}

		// Token: 0x0601E024 RID: 122916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E024")]
		[Address(RVA = "0x17C7130", Offset = "0x17C5D30", VA = "0x1817C7130")]
		private void _SetPlatePos(FireworkCraftModel.EditStatus status, FireworkCraftModel.CraftStageInfoModel selectedStage, bool isMap)
		{
		}

		// Token: 0x0601E025 RID: 122917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E025")]
		[Address(RVA = "0x17C5540", Offset = "0x17C4140", VA = "0x1817C5540")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0601E026 RID: 122918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E026")]
		[Address(RVA = "0x17C4D20", Offset = "0x17C3920", VA = "0x1817C4D20")]
		public void EventOnMapEditBtnClicked()
		{
		}

		// Token: 0x0601E027 RID: 122919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E027")]
		[Address(RVA = "0x17C4EF0", Offset = "0x17C3AF0", VA = "0x1817C4EF0")]
		public void EventOnStageChooseBtnClicked()
		{
		}

		// Token: 0x0601E028 RID: 122920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E028")]
		[Address(RVA = "0x17C4E10", Offset = "0x17C3A10", VA = "0x1817C4E10")]
		public void EventOnStageChooseBgClicked()
		{
		}

		// Token: 0x0601E029 RID: 122921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E029")]
		[Address(RVA = "0x17C4C90", Offset = "0x17C3890", VA = "0x1817C4C90")]
		public void EventOnAnimalSelectClicked()
		{
		}

		// Token: 0x0601E02A RID: 122922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E02A")]
		[Address(RVA = "0x17C4FF0", Offset = "0x17C3BF0", VA = "0x1817C4FF0")]
		public void OnBtnSaveClicked()
		{
		}

		// Token: 0x0601E02B RID: 122923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E02B")]
		[Address(RVA = "0x17C72A0", Offset = "0x17C5EA0", VA = "0x1817C72A0")]
		public FireworkCraftView()
		{
		}

		// Token: 0x04027DE4 RID: 163300
		[Token(Token = "0x4027DE4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgMap;

		// Token: 0x04027DE5 RID: 163301
		[Token(Token = "0x4027DE5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _gridSize;

		// Token: 0x04027DE6 RID: 163302
		[Token(Token = "0x4027DE6")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 _mapOffsetSize;

		// Token: 0x04027DE7 RID: 163303
		[Token(Token = "0x4027DE7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _bkgParticleFxContainer;

		// Token: 0x04027DE8 RID: 163304
		[Token(Token = "0x4027DE8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _animalBgContainer;

		// Token: 0x04027DE9 RID: 163305
		[Token(Token = "0x4027DE9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Enter Anim")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04027DEA RID: 163306
		[Token(Token = "0x4027DEA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Switch Anim")]
		private UIAnimationLocation _mapBtnOnAnim;

		// Token: 0x04027DEB RID: 163307
		[Token(Token = "0x4027DEB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Switch Anim")]
		private UIAnimationLocation _mapBtnOffAnim;

		// Token: 0x04027DEC RID: 163308
		[Token(Token = "0x4027DEC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Switch Anim")]
		private UIAnimationLocation _rightListSwitchAnim;

		// Token: 0x04027DED RID: 163309
		[Token(Token = "0x4027DED")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Switch Anim")]
		private UIAnimationLocation _bkgSwitchAnim;

		// Token: 0x04027DEE RID: 163310
		[Token(Token = "0x4027DEE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateViewContainer;

		// Token: 0x04027DEF RID: 163311
		[Token(Token = "0x4027DEF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateViewContainerMap;

		// Token: 0x04027DF0 RID: 163312
		[Token(Token = "0x4027DF0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateRootMap;

		// Token: 0x04027DF1 RID: 163313
		[Token(Token = "0x4027DF1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateSelectionViewContainer;

		// Token: 0x04027DF2 RID: 163314
		[Token(Token = "0x4027DF2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateSelectionViewContainerMap;

		// Token: 0x04027DF3 RID: 163315
		[Token(Token = "0x4027DF3")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _plateListViewContainer;

		// Token: 0x04027DF4 RID: 163316
		[Token(Token = "0x4027DF4")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Firework view")]
		private RectTransform _filledPlateListViewContainer;

		// Token: 0x04027DF5 RID: 163317
		[Token(Token = "0x4027DF5")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Firework view")]
		private FireworkCraftBtnSaveView _saveBtnView;

		// Token: 0x04027DF6 RID: 163318
		[Token(Token = "0x4027DF6")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Firework view")]
		private FireworkGroupListRaycastLayer _pnlRaycastLayer;

		// Token: 0x04027DF7 RID: 163319
		[Token(Token = "0x4027DF7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Stage List")]
		private SimpleLayoutContent _stageContent;

		// Token: 0x04027DF8 RID: 163320
		[Token(Token = "0x4027DF8")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Stage List")]
		private FireworkCraftZoneBtnItem[] _zoneItems;

		// Token: 0x04027DF9 RID: 163321
		[Token(Token = "0x4027DF9")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Stage List")]
		private Text _zoneName;

		// Token: 0x04027DFA RID: 163322
		[Token(Token = "0x4027DFA")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Stage List")]
		private Text _stageCode;

		// Token: 0x04027DFB RID: 163323
		[Token(Token = "0x4027DFB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Stage List")]
		private Image _scrollHandler;

		// Token: 0x04027DFC RID: 163324
		[Token(Token = "0x4027DFC")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Animal Effect")]
		private UIAnimationLocation _animalIconSwitchAnim;

		// Token: 0x04027DFD RID: 163325
		[Token(Token = "0x4027DFD")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("Animal Effect")]
		private Image _animalIcon;

		// Token: 0x04027DFE RID: 163326
		[Token(Token = "0x4027DFE")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Group("Animal Effect")]
		private Image _animalName;

		// Token: 0x04027DFF RID: 163327
		[Token(Token = "0x4027DFF")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Group("Animal Effect")]
		private Text _effectBuffDesc;

		// Token: 0x04027E00 RID: 163328
		[Token(Token = "0x4027E00")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		[Group("Animal Effect")]
		private GameObject _animalNewPanel;

		// Token: 0x04027E01 RID: 163329
		[Token(Token = "0x4027E01")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		[Group("Animal Effect")]
		private Image _animalDescBgColor;

		// Token: 0x04027E02 RID: 163330
		[Token(Token = "0x4027E02")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Group("Animal Effect")]
		private UIAtlasImage _animalSelectBtnBg;

		// Token: 0x04027E03 RID: 163331
		[Token(Token = "0x4027E03")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Animal Effect")]
		private Image _animalSelectedPlateBg;

		// Token: 0x04027E04 RID: 163332
		[Token(Token = "0x4027E04")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _fireworkPlateGo;

		// Token: 0x04027E05 RID: 163333
		[Token(Token = "0x4027E05")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		[Group("Tutorial")]
		private Button _fireworkAnimalSwitchButton;

		// Token: 0x04027E06 RID: 163334
		[Token(Token = "0x4027E06")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		[Group("Tutorial")]
		private Button _btnSave;

		// Token: 0x04027E07 RID: 163335
		[Token(Token = "0x4027E07")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("Tutorial")]
		private Button _btnSwitchMap;

		// Token: 0x04027E08 RID: 163336
		[Token(Token = "0x4027E08")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04027E09 RID: 163337
		[Token(Token = "0x4027E09")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private float _alphaMin;

		// Token: 0x04027E0A RID: 163338
		[Token(Token = "0x4027E0A")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private float _alphaMax;

		// Token: 0x04027E0B RID: 163339
		[Token(Token = "0x4027E0B")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private float _loopDur;

		// Token: 0x04027E0C RID: 163340
		[Token(Token = "0x4027E0C")]
		[FieldOffset(Offset = "0x184")]
		private bool m_hasInited;

		// Token: 0x04027E0D RID: 163341
		[Token(Token = "0x4027E0D")]
		[FieldOffset(Offset = "0x188")]
		private Tween m_enterAnimTween;

		// Token: 0x04027E0E RID: 163342
		[Token(Token = "0x4027E0E")]
		[FieldOffset(Offset = "0x190")]
		private UISwitchTween m_mapBtnSwitchTween;

		// Token: 0x04027E0F RID: 163343
		[Token(Token = "0x4027E0F")]
		[FieldOffset(Offset = "0x198")]
		private UISwitchTween m_rightListSwitchTween;

		// Token: 0x04027E10 RID: 163344
		[Token(Token = "0x4027E10")]
		[FieldOffset(Offset = "0x1A0")]
		private UISwitchTween m_bkgSwitchTween;

		// Token: 0x04027E11 RID: 163345
		[Token(Token = "0x4027E11")]
		[FieldOffset(Offset = "0x1A8")]
		private Tween m_animalIconSwitchTween;

		// Token: 0x04027E12 RID: 163346
		[Token(Token = "0x4027E12")]
		[FieldOffset(Offset = "0x1B0")]
		private int m_cachedEnterSeqNum;

		// Token: 0x04027E13 RID: 163347
		[Token(Token = "0x4027E13")]
		[FieldOffset(Offset = "0x1B8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027E14 RID: 163348
		[Token(Token = "0x4027E14")]
		[FieldOffset(Offset = "0x1C8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027E15 RID: 163349
		[Token(Token = "0x4027E15")]
		[FieldOffset(Offset = "0x1D8")]
		private FireworkCraftModel.EditStatus m_cachedStatus;

		// Token: 0x04027E16 RID: 163350
		[Token(Token = "0x4027E16")]
		[FieldOffset(Offset = "0x1E0")]
		private FireworkPlateListView m_plateListView;

		// Token: 0x04027E17 RID: 163351
		[Token(Token = "0x4027E17")]
		[FieldOffset(Offset = "0x1E8")]
		private FireworkPlateGroupViewStyle m_plateListStyle;

		// Token: 0x04027E18 RID: 163352
		[Token(Token = "0x4027E18")]
		[FieldOffset(Offset = "0x1F0")]
		private FireworkPlateView m_plateView;

		// Token: 0x04027E19 RID: 163353
		[Token(Token = "0x4027E19")]
		[FieldOffset(Offset = "0x1F8")]
		private FireworkPlateSelectionView m_plateSelectionView;

		// Token: 0x04027E1A RID: 163354
		[Token(Token = "0x4027E1A")]
		[FieldOffset(Offset = "0x200")]
		private FireworkPlateViewStyle m_plateStyle;

		// Token: 0x04027E1B RID: 163355
		[Token(Token = "0x4027E1B")]
		[FieldOffset(Offset = "0x208")]
		private FireworkPlateView m_plateViewMap;

		// Token: 0x04027E1C RID: 163356
		[Token(Token = "0x4027E1C")]
		[FieldOffset(Offset = "0x210")]
		private FireworkPlateSelectionView m_plateSelectionViewMap;

		// Token: 0x04027E1D RID: 163357
		[Token(Token = "0x4027E1D")]
		[FieldOffset(Offset = "0x218")]
		private FireworkPlateViewStyle m_plateStyleMap;

		// Token: 0x04027E1E RID: 163358
		[Token(Token = "0x4027E1E")]
		[FieldOffset(Offset = "0x220")]
		private FireworkPlateFilledListView m_filledPlateListView;

		// Token: 0x04027E1F RID: 163359
		[Token(Token = "0x4027E1F")]
		[FieldOffset(Offset = "0x228")]
		private GameObject m_animalBkg;

		// Token: 0x04027E20 RID: 163360
		[Token(Token = "0x4027E20")]
		[FieldOffset(Offset = "0x230")]
		private string m_cachedAnimalId;

		// Token: 0x04027E21 RID: 163361
		[Token(Token = "0x4027E21")]
		[FieldOffset(Offset = "0x238")]
		private string m_cachedAnimalIconId;

		// Token: 0x04027E22 RID: 163362
		[Token(Token = "0x4027E22")]
		[FieldOffset(Offset = "0x240")]
		private string m_cachedAnimalNameId;

		// Token: 0x04027E23 RID: 163363
		[Token(Token = "0x4027E23")]
		[FieldOffset(Offset = "0x248")]
		private List<FireworkCraftModel.CraftStageInfoModel> m_cachedStageList;

		// Token: 0x04027E24 RID: 163364
		[Token(Token = "0x4027E24")]
		[FieldOffset(Offset = "0x250")]
		private string m_cachedSelectedStageId;

		// Token: 0x04027E25 RID: 163365
		[Token(Token = "0x4027E25")]
		[FieldOffset(Offset = "0x258")]
		private FireworkCraftView.StageAdapter m_stageAdapter;

		// Token: 0x04027E26 RID: 163366
		[Token(Token = "0x4027E26")]
		[FieldOffset(Offset = "0x260")]
		private Tween m_loopTween;

		// Token: 0x04027E27 RID: 163367
		[Token(Token = "0x4027E27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x04027E28 RID: 163368
		[Token(Token = "0x4027E28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027E29 RID: 163369
		[Token(Token = "0x4027E29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027E2A RID: 163370
		[Token(Token = "0x4027E2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayTweens;

		// Token: 0x04027E2B RID: 163371
		[Token(Token = "0x4027E2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetPlateStyle;

		// Token: 0x04027E2C RID: 163372
		[Token(Token = "0x4027E2C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderImgMap;

		// Token: 0x04027E2D RID: 163373
		[Token(Token = "0x4027E2D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderFireworkView;

		// Token: 0x04027E2E RID: 163374
		[Token(Token = "0x4027E2E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderAnimalBkg;

		// Token: 0x04027E2F RID: 163375
		[Token(Token = "0x4027E2F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderStageList;

		// Token: 0x04027E30 RID: 163376
		[Token(Token = "0x4027E30")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderAnimalEffectPart;

		// Token: 0x04027E31 RID: 163377
		[Token(Token = "0x4027E31")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetPlatePos;

		// Token: 0x04027E32 RID: 163378
		[Token(Token = "0x4027E32")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04027E33 RID: 163379
		[Token(Token = "0x4027E33")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnMapEditBtnClicked;

		// Token: 0x04027E34 RID: 163380
		[Token(Token = "0x4027E34")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnStageChooseBtnClicked;

		// Token: 0x04027E35 RID: 163381
		[Token(Token = "0x4027E35")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnStageChooseBgClicked;

		// Token: 0x04027E36 RID: 163382
		[Token(Token = "0x4027E36")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnAnimalSelectClicked;

		// Token: 0x04027E37 RID: 163383
		[Token(Token = "0x4027E37")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnBtnSaveClicked;

		// Token: 0x04027E38 RID: 163384
		[Token(Token = "0x4027E38")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E91 RID: 20113
		[Token(Token = "0x2004E91")]
		private class StageAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E02C RID: 122924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E02C")]
			[Address(RVA = "0x17C8200", Offset = "0x17C6E00", VA = "0x1817C8200")]
			public StageAdapter(FireworkCraftView closure)
			{
			}

			// Token: 0x17004666 RID: 18022
			// (get) Token: 0x0601E02D RID: 122925 RVA: 0x000AD2B0 File Offset: 0x000AB4B0
			[Token(Token = "0x17004666")]
			public override int count
			{
				[Token(Token = "0x601E02D")]
				[Address(RVA = "0x17C8280", Offset = "0x17C6E80", VA = "0x1817C8280", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E02E RID: 122926 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E02E")]
			[Address(RVA = "0x17C8040", Offset = "0x17C6C40", VA = "0x1817C8040", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04027E39 RID: 163385
			[Token(Token = "0x4027E39")]
			[FieldOffset(Offset = "0x20")]
			private FireworkCraftView m_closure;

			// Token: 0x04027E3A RID: 163386
			[Token(Token = "0x4027E3A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027E3B RID: 163387
			[Token(Token = "0x4027E3B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027E3C RID: 163388
			[Token(Token = "0x4027E3C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200781B RID: 30747
	[Token(Token = "0x200781B")]
	public class Act1VHalfIdleZoneMapViewPlugin : ActivityCustomZoneMapBasePlugin
	{
		// Token: 0x170064E7 RID: 25831
		// (get) Token: 0x0602B206 RID: 176646 RVA: 0x000DAEF8 File Offset: 0x000D90F8
		[Token(Token = "0x170064E7")]
		public bool isPlayingEntryAnim
		{
			[Token(Token = "0x602B206")]
			[Address(RVA = "0x2702760", Offset = "0x2701360", VA = "0x182702760")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B207 RID: 176647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B207")]
		[Address(RVA = "0x2701510", Offset = "0x2700110", VA = "0x182701510")]
		private void _InitIfNot(string actId)
		{
		}

		// Token: 0x0602B208 RID: 176648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B208")]
		[Address(RVA = "0x27022D0", Offset = "0x2700ED0", VA = "0x1827022D0")]
		private void _TryOpenBattleRecoverDialog(string actId)
		{
		}

		// Token: 0x0602B209 RID: 176649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B209")]
		[Address(RVA = "0x27019B0", Offset = "0x27005B0", VA = "0x1827019B0")]
		private void _LoadSquadAndCharSelectResHolder(string actId)
		{
		}

		// Token: 0x0602B20A RID: 176650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20A")]
		[Address(RVA = "0x2701C30", Offset = "0x2700830", VA = "0x182701C30")]
		public void _ResizeDragArea()
		{
		}

		// Token: 0x0602B20B RID: 176651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20B")]
		[Address(RVA = "0x27013D0", Offset = "0x26FFFD0", VA = "0x1827013D0")]
		private void _FocusOnStageBlockRect(RectTransform rect)
		{
		}

		// Token: 0x0602B20C RID: 176652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20C")]
		[Address(RVA = "0x2701DA0", Offset = "0x27009A0", VA = "0x182701DA0")]
		private void _SetBlocksActiveAndUpdateContentSize(ActivityCustomZoneMapViewModel model, Act1VHalfIdleZoneMapPluginsViewModel actMeta)
		{
		}

		// Token: 0x0602B20D RID: 176653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20D")]
		[Address(RVA = "0x2700DF0", Offset = "0x26FF9F0", VA = "0x182700DF0", Slot = "5")]
		public override void Render(ActivityCustomZoneMapViewModel model, bool isFastMode)
		{
		}

		// Token: 0x0602B20E RID: 176654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20E")]
		[Address(RVA = "0x2700D10", Offset = "0x26FF910", VA = "0x182700D10")]
		public void PlayEntryAnim()
		{
		}

		// Token: 0x0602B20F RID: 176655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B20F")]
		[Address(RVA = "0x2700260", Offset = "0x26FEE60", VA = "0x182700260")]
		public void FocusStageOnEnterMap(Act1VHalfIdleZoneMapPluginsViewModel viewModel)
		{
		}

		// Token: 0x0602B210 RID: 176656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B210")]
		[Address(RVA = "0x2700C60", Offset = "0x26FF860", VA = "0x182700C60")]
		public void OnMapDrag(Vector2 pos)
		{
		}

		// Token: 0x0602B211 RID: 176657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B211")]
		[Address(RVA = "0x2700500", Offset = "0x26FF100", VA = "0x182700500")]
		public void OnClickMapBg()
		{
		}

		// Token: 0x0602B212 RID: 176658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B212")]
		[Address(RVA = "0x2700760", Offset = "0x26FF360", VA = "0x182700760")]
		public void OnClickShowStageProduction()
		{
		}

		// Token: 0x0602B213 RID: 176659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B213")]
		[Address(RVA = "0x27005A0", Offset = "0x26FF1A0", VA = "0x1827005A0")]
		public void OnClickShowStageInfo()
		{
		}

		// Token: 0x0602B214 RID: 176660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B214")]
		[Address(RVA = "0x27003E0", Offset = "0x26FEFE0", VA = "0x1827003E0")]
		public void OnClickEnemyDetail()
		{
		}

		// Token: 0x0602B215 RID: 176661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B215")]
		[Address(RVA = "0x27009E0", Offset = "0x26FF5E0", VA = "0x1827009E0")]
		public void OnClickStartBattle()
		{
		}

		// Token: 0x0602B216 RID: 176662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B216")]
		[Address(RVA = "0x2700C00", Offset = "0x26FF800", VA = "0x182700C00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B217 RID: 176663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B217")]
		[Address(RVA = "0x2701290", Offset = "0x26FFE90", VA = "0x182701290")]
		public void TryTriggerTutorial()
		{
		}

		// Token: 0x0602B218 RID: 176664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B218")]
		[Address(RVA = "0x2702210", Offset = "0x2700E10", VA = "0x182702210")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0602B219 RID: 176665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B219")]
		[Address(RVA = "0x27025A0", Offset = "0x27011A0", VA = "0x1827025A0")]
		private IEnumerator _WaitAndRaiseSignal()
		{
			return null;
		}

		// Token: 0x0602B21A RID: 176666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B21A")]
		[Address(RVA = "0x2702490", Offset = "0x2701090", VA = "0x182702490")]
		private void _TryRaiseStageBarShowSignal()
		{
		}

		// Token: 0x0602B21B RID: 176667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B21B")]
		[Address(RVA = "0x2702650", Offset = "0x2701250", VA = "0x182702650")]
		public Act1VHalfIdleZoneMapViewPlugin()
		{
		}

		// Token: 0x0602B21C RID: 176668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B21C")]
		[Address(RVA = "0x24B0180", Offset = "0x24AED80", VA = "0x1824B0180")]
		private void <>xLuaBaseProxy_Render(ActivityCustomZoneMapViewModel P0, bool P1)
		{
		}

		// Token: 0x0403E543 RID: 255299
		[Token(Token = "0x403E543")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E544 RID: 255300
		[Token(Token = "0x403E544")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _barShowAnim;

		// Token: 0x0403E545 RID: 255301
		[Token(Token = "0x403E545")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILayoutDimensionListener _layoutDimensionListener;

		// Token: 0x0403E546 RID: 255302
		[Token(Token = "0x403E546")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _mapContainerRect;

		// Token: 0x0403E547 RID: 255303
		[Token(Token = "0x403E547")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _mapContentRect;

		// Token: 0x0403E548 RID: 255304
		[Token(Token = "0x403E548")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _stageContentRect;

		// Token: 0x0403E549 RID: 255305
		[Token(Token = "0x403E549")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _stageBlockInterval;

		// Token: 0x0403E54A RID: 255306
		[Token(Token = "0x403E54A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<Act1VHalfIdleZoneMapViewPlugin.StageBlockPair> _stageBlockPairs;

		// Token: 0x0403E54B RID: 255307
		[Token(Token = "0x403E54B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _mapSlider;

		// Token: 0x0403E54C RID: 255308
		[Token(Token = "0x403E54C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _mapScrollRect;

		// Token: 0x0403E54D RID: 255309
		[Token(Token = "0x403E54D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _previewStageNameText;

		// Token: 0x0403E54E RID: 255310
		[Token(Token = "0x403E54E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _previewStageCodeText;

		// Token: 0x0403E54F RID: 255311
		[Token(Token = "0x403E54F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _previewStageDangerText;

		// Token: 0x0403E550 RID: 255312
		[Token(Token = "0x403E550")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _previewMaxToggle;

		// Token: 0x0403E551 RID: 255313
		[Token(Token = "0x403E551")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _previewProductionAvailToggle;

		// Token: 0x0403E552 RID: 255314
		[Token(Token = "0x403E552")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act1VHalfIdleZoneStageButtonPlugin _trStageBtnPlugin;

		// Token: 0x0403E553 RID: 255315
		[Token(Token = "0x403E553")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _btnProduction;

		// Token: 0x0403E554 RID: 255316
		[Token(Token = "0x403E554")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _btnStartBattle;

		// Token: 0x0403E555 RID: 255317
		[Token(Token = "0x403E555")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x0403E556 RID: 255318
		[Token(Token = "0x403E556")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_barSwitchTween;

		// Token: 0x0403E557 RID: 255319
		[Token(Token = "0x403E557")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E558 RID: 255320
		[Token(Token = "0x403E558")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E559 RID: 255321
		[Token(Token = "0x403E559")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<string, string> m_focusLookupDict;

		// Token: 0x0403E55A RID: 255322
		[Token(Token = "0x403E55A")]
		[FieldOffset(Offset = "0xF0")]
		private List<string> m_orderedStageIds;

		// Token: 0x0403E55B RID: 255323
		[Token(Token = "0x403E55B")]
		[FieldOffset(Offset = "0xF8")]
		private string m_cacheActId;

		// Token: 0x0403E55C RID: 255324
		[Token(Token = "0x403E55C")]
		[FieldOffset(Offset = "0x100")]
		private string m_cacheSelectedStageId;

		// Token: 0x0403E55D RID: 255325
		[Token(Token = "0x403E55D")]
		[FieldOffset(Offset = "0x108")]
		private bool m_cachePreviewIsHard;

		// Token: 0x0403E55E RID: 255326
		[Token(Token = "0x403E55E")]
		[FieldOffset(Offset = "0x110")]
		private CommonSquadResHolder m_cachedSquadResHolder;

		// Token: 0x0403E55F RID: 255327
		[Token(Token = "0x403E55F")]
		[FieldOffset(Offset = "0x118")]
		private CommonCharSelectResHolder m_cachedCharSelectResHolder;

		// Token: 0x0403E560 RID: 255328
		[Token(Token = "0x403E560")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_entryAnimTween;

		// Token: 0x0403E561 RID: 255329
		[Token(Token = "0x403E561")]
		[FieldOffset(Offset = "0x128")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0403E562 RID: 255330
		[Token(Token = "0x403E562")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPlayingEntryAnim;

		// Token: 0x0403E563 RID: 255331
		[Token(Token = "0x403E563")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E564 RID: 255332
		[Token(Token = "0x403E564")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryOpenBattleRecoverDialog;

		// Token: 0x0403E565 RID: 255333
		[Token(Token = "0x403E565")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSquadAndCharSelectResHolder;

		// Token: 0x0403E566 RID: 255334
		[Token(Token = "0x403E566")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResizeDragArea;

		// Token: 0x0403E567 RID: 255335
		[Token(Token = "0x403E567")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FocusOnStageBlockRect;

		// Token: 0x0403E568 RID: 255336
		[Token(Token = "0x403E568")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetBlocksActiveAndUpdateContentSize;

		// Token: 0x0403E569 RID: 255337
		[Token(Token = "0x403E569")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E56A RID: 255338
		[Token(Token = "0x403E56A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlayEntryAnim;

		// Token: 0x0403E56B RID: 255339
		[Token(Token = "0x403E56B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FocusStageOnEnterMap;

		// Token: 0x0403E56C RID: 255340
		[Token(Token = "0x403E56C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMapDrag;

		// Token: 0x0403E56D RID: 255341
		[Token(Token = "0x403E56D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnClickMapBg;

		// Token: 0x0403E56E RID: 255342
		[Token(Token = "0x403E56E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnClickShowStageProduction;

		// Token: 0x0403E56F RID: 255343
		[Token(Token = "0x403E56F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnClickShowStageInfo;

		// Token: 0x0403E570 RID: 255344
		[Token(Token = "0x403E570")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClickEnemyDetail;

		// Token: 0x0403E571 RID: 255345
		[Token(Token = "0x403E571")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnClickStartBattle;

		// Token: 0x0403E572 RID: 255346
		[Token(Token = "0x403E572")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403E573 RID: 255347
		[Token(Token = "0x403E573")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TryTriggerTutorial;

		// Token: 0x0403E574 RID: 255348
		[Token(Token = "0x403E574")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0403E575 RID: 255349
		[Token(Token = "0x403E575")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__WaitAndRaiseSignal;

		// Token: 0x0403E576 RID: 255350
		[Token(Token = "0x403E576")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryRaiseStageBarShowSignal;

		// Token: 0x0403E577 RID: 255351
		[Token(Token = "0x403E577")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200781C RID: 30748
		[Token(Token = "0x200781C")]
		[Serializable]
		private class StageBlockPair
		{
			// Token: 0x0602B21D RID: 176669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B21D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StageBlockPair()
			{
			}

			// Token: 0x0403E578 RID: 255352
			[Token(Token = "0x403E578")]
			[FieldOffset(Offset = "0x10")]
			public ActivityCustomZoneStageButton stageButton;

			// Token: 0x0403E579 RID: 255353
			[Token(Token = "0x403E579")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform block;

			// Token: 0x0403E57A RID: 255354
			[Token(Token = "0x403E57A")]
			[FieldOffset(Offset = "0x20")]
			public ActivityCustomZoneStageButton[] includeStageBtns;

			// Token: 0x0403E57B RID: 255355
			[Token(Token = "0x403E57B")]
			[FieldOffset(Offset = "0x28")]
			public GameObject lockObj;
		}
	}
}

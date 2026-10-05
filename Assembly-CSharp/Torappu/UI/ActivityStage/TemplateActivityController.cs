using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI.ActivityStage.Extern;
using Torappu.UI.TemplateMission;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA8 RID: 27816
	[Token(Token = "0x2006CA8")]
	public abstract class TemplateActivityController : ActivityStageController, IBaseActHandler, IHotfixable, IPlayerDataListener
	{
		// Token: 0x06027ADE RID: 162526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027ADE")]
		[Address(RVA = "0x22D9D80", Offset = "0x22D8980", VA = "0x1822D9D80", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x06027ADF RID: 162527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ADF")]
		[Address(RVA = "0x22DA570", Offset = "0x22D9170", VA = "0x1822DA570", Slot = "8")]
		public override void InitController()
		{
		}

		// Token: 0x06027AE0 RID: 162528
		[Token(Token = "0x6027AE0")]
		public abstract void InitModelDict(string actId);

		// Token: 0x06027AE1 RID: 162529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AE1")]
		[Address(RVA = "0x22DA000", Offset = "0x22D8C00", VA = "0x1822DA000")]
		public static TemplateActivityController FindInstanceTemplateInPage()
		{
			return null;
		}

		// Token: 0x06027AE2 RID: 162530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AE2")]
		[Address(RVA = "0x22DA3E0", Offset = "0x22D8FE0", VA = "0x1822DA3E0", Slot = "23")]
		public TemplateActivityViewModel GetViewModel(string param)
		{
			return null;
		}

		// Token: 0x06027AE3 RID: 162531 RVA: 0x000CF030 File Offset: 0x000CD230
		[Token(Token = "0x6027AE3")]
		[Address(RVA = "0x22D97A0", Offset = "0x22D83A0", VA = "0x1822D97A0")]
		public bool CanSkipAnim(bool oncePerLogin)
		{
			return default(bool);
		}

		// Token: 0x06027AE4 RID: 162532 RVA: 0x000CF048 File Offset: 0x000CD248
		[Token(Token = "0x6027AE4")]
		[Address(RVA = "0x22DA160", Offset = "0x22D8D60", VA = "0x1822DA160")]
		public bool ForceSkipEnterAnim()
		{
			return default(bool);
		}

		// Token: 0x06027AE5 RID: 162533 RVA: 0x000CF060 File Offset: 0x000CD260
		[Token(Token = "0x6027AE5")]
		[Address(RVA = "0x22D9AF0", Offset = "0x22D86F0", VA = "0x1822D9AF0")]
		public bool CheckIfBackFromBattle()
		{
			return default(bool);
		}

		// Token: 0x06027AE6 RID: 162534 RVA: 0x000CF078 File Offset: 0x000CD278
		[Token(Token = "0x6027AE6")]
		[Address(RVA = "0x22D99B0", Offset = "0x22D85B0", VA = "0x1822D99B0", Slot = "28")]
		public bool CheckIfActivityIsOpen()
		{
			return default(bool);
		}

		// Token: 0x06027AE7 RID: 162535 RVA: 0x000CF090 File Offset: 0x000CD290
		[Token(Token = "0x6027AE7")]
		[Address(RVA = "0x22DB860", Offset = "0x22DA460", VA = "0x1822DB860")]
		private bool _CheckIfActivityLimitedPerLogin(bool oncePerLogin)
		{
			return default(bool);
		}

		// Token: 0x17005DBA RID: 23994
		// (get) Token: 0x06027AE8 RID: 162536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DBA")]
		public StateEngine floatStateEngine
		{
			[Token(Token = "0x6027AE8")]
			[Address(RVA = "0x22DBB40", Offset = "0x22DA740", VA = "0x1822DBB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027AE9 RID: 162537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AE9")]
		[Address(RVA = "0x22DAE10", Offset = "0x22D9A10", VA = "0x1822DAE10", Slot = "18")]
		protected override void OnStagePageHideEffect()
		{
		}

		// Token: 0x06027AEA RID: 162538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AEA")]
		[Address(RVA = "0x22DB2C0", Offset = "0x22D9EC0", VA = "0x1822DB2C0", Slot = "19")]
		protected override void OnStageZoneSelectStateSetEffect(bool enable)
		{
		}

		// Token: 0x17005DBB RID: 23995
		// (get) Token: 0x06027AEB RID: 162539 RVA: 0x000CF0A8 File Offset: 0x000CD2A8
		[Token(Token = "0x17005DBB")]
		public override bool disableStageEntryPartical
		{
			[Token(Token = "0x6027AEB")]
			[Address(RVA = "0x22DBAE0", Offset = "0x22DA6E0", VA = "0x1822DBAE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005DBC RID: 23996
		// (get) Token: 0x06027AEC RID: 162540 RVA: 0x000CF0C0 File Offset: 0x000CD2C0
		[Token(Token = "0x17005DBC")]
		public virtual bool playEntryAnimAfterAVG
		{
			[Token(Token = "0x6027AEC")]
			[Address(RVA = "0x22DBC90", Offset = "0x22DA890", VA = "0x1822DBC90", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06027AED RID: 162541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AED")]
		[Address(RVA = "0x22DAC00", Offset = "0x22D9800", VA = "0x1822DAC00", Slot = "10")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x06027AEE RID: 162542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AEE")]
		[Address(RVA = "0x22DAA50", Offset = "0x22D9650", VA = "0x1822DAA50", Slot = "21")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06027AEF RID: 162543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AEF")]
		[Address(RVA = "0x22D9510", Offset = "0x22D8110", VA = "0x1822D9510", Slot = "34")]
		protected virtual void AfterEntryAnimPlay()
		{
		}

		// Token: 0x06027AF0 RID: 162544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF0")]
		[Address(RVA = "0x22DB5B0", Offset = "0x22DA1B0", VA = "0x1822DB5B0")]
		public void TriggerAfterEntryAnim()
		{
		}

		// Token: 0x06027AF1 RID: 162545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AF1")]
		[Address(RVA = "0x22DA4C0", Offset = "0x22D90C0", VA = "0x1822DA4C0", Slot = "16")]
		protected override IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06027AF2 RID: 162546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF2")]
		[Address(RVA = "0x22DA630", Offset = "0x22D9230", VA = "0x1822DA630")]
		protected void InitViewModel(string id, TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x06027AF3 RID: 162547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF3")]
		[Address(RVA = "0x22DB700", Offset = "0x22DA300", VA = "0x1822DB700", Slot = "27")]
		public void UnBind(IBaseActViewBinder binder, string param)
		{
		}

		// Token: 0x06027AF4 RID: 162548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF4")]
		[Address(RVA = "0x22D9570", Offset = "0x22D8170", VA = "0x1822D9570", Slot = "26")]
		public void Bind(IBaseActViewBinder binder, string param)
		{
		}

		// Token: 0x06027AF5 RID: 162549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF5")]
		[Address(RVA = "0x22DB400", Offset = "0x22DA000", VA = "0x1822DB400")]
		public void RefreshSingleton(Type type)
		{
		}

		// Token: 0x06027AF6 RID: 162550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF6")]
		[Address(RVA = "0x22DA940", Offset = "0x22D9540", VA = "0x1822DA940", Slot = "25")]
		public void OnDataUpdated(string param)
		{
		}

		// Token: 0x06027AF7 RID: 162551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AF7")]
		[Address(RVA = "0x22DAB70", Offset = "0x22D9770", VA = "0x1822DAB70")]
		public void OnFocusZone(string zoneId)
		{
		}

		// Token: 0x06027AF8 RID: 162552 RVA: 0x000CF0D8 File Offset: 0x000CD2D8
		[Token(Token = "0x6027AF8")]
		[Address(RVA = "0x22DA230", Offset = "0x22D8E30", VA = "0x1822DA230", Slot = "29")]
		public TemplateActivityLifeCycleViewModel.ActState GetCurrentState()
		{
			return TemplateActivityLifeCycleViewModel.ActState.NOT_OPEN;
		}

		// Token: 0x06027AF9 RID: 162553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AF9")]
		[Address(RVA = "0x22D9E10", Offset = "0x22D8A10", VA = "0x1822D9E10", Slot = "35")]
		public virtual TemplateMissionInputParam CreateTemplateMissionInputParam()
		{
			return null;
		}

		// Token: 0x06027AFA RID: 162554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AFA")]
		[Address(RVA = "0x22DA380", Offset = "0x22D8F80", VA = "0x1822DA380", Slot = "36")]
		public virtual string GetTutorialCustomOperationKey()
		{
			return null;
		}

		// Token: 0x06027AFB RID: 162555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AFB")]
		[Address(RVA = "0x22DA310", Offset = "0x22D8F10", VA = "0x1822DA310", Slot = "37")]
		public virtual string GetTutorialCustomOperationKeyOnResume(string fromPage)
		{
			return null;
		}

		// Token: 0x06027AFC RID: 162556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AFC")]
		[Address(RVA = "0x22D91C0", Offset = "0x22D7DC0", VA = "0x1822D91C0")]
		private void AVGOnly_ExecuteResetToEntryCmd()
		{
		}

		// Token: 0x06027AFD RID: 162557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AFD")]
		[Address(RVA = "0x22D9300", Offset = "0x22D7F00", VA = "0x1822D9300")]
		private static IEnumerator AVGOnly_ExecuteResetToEntryCoroutine(string activityId)
		{
			return null;
		}

		// Token: 0x06027AFE RID: 162558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AFE")]
		[Address(RVA = "0x22DB910", Offset = "0x22DA510", VA = "0x1822DB910")]
		private static IEnumerator _WaitForStable()
		{
			return null;
		}

		// Token: 0x06027AFF RID: 162559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AFF")]
		[Address(RVA = "0x22D9460", Offset = "0x22D8060", VA = "0x1822D9460")]
		private static IEnumerator AVGOnly_ResetToEntryImpl(string activityId)
		{
			return null;
		}

		// Token: 0x06027B00 RID: 162560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B00")]
		[Address(RVA = "0x22D93B0", Offset = "0x22D7FB0", VA = "0x1822D93B0")]
		private static IEnumerator AVGOnly_ResetToEntryFallback(string activityId)
		{
			return null;
		}

		// Token: 0x06027B01 RID: 162561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B01")]
		[Address(RVA = "0x22DAAC0", Offset = "0x22D96C0", VA = "0x1822DAAC0")]
		public static void OnFocusStage(string stageId)
		{
		}

		// Token: 0x06027B02 RID: 162562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B02")]
		[Address(RVA = "0x22DAF30", Offset = "0x22D9B30", VA = "0x1822DAF30", Slot = "17")]
		protected override void OnStagePageResumed(UIPageTransContext context)
		{
		}

		// Token: 0x06027B03 RID: 162563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B03")]
		[Address(RVA = "0x22DB550", Offset = "0x22DA150", VA = "0x1822DB550", Slot = "11")]
		protected override void TriggerActivityLoadedAVG()
		{
		}

		// Token: 0x06027B04 RID: 162564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B04")]
		[Address(RVA = "0x22DB1B0", Offset = "0x22D9DB0", VA = "0x1822DB1B0", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06027B05 RID: 162565 RVA: 0x000CF0F0 File Offset: 0x000CD2F0
		[Token(Token = "0x6027B05")]
		[Address(RVA = "0x22D9BA0", Offset = "0x22D87A0", VA = "0x1822D9BA0", Slot = "30")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06027B06 RID: 162566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B06")]
		[Address(RVA = "0x22DAC70", Offset = "0x22D9870", VA = "0x1822DAC70", Slot = "31")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06027B07 RID: 162567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B07")]
		public T GetViewModel<T>(string param) where T : TemplateActivityViewModel
		{
			return null;
		}

		// Token: 0x06027B08 RID: 162568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B08")]
		[Address(RVA = "0x22DA1D0", Offset = "0x22D8DD0", VA = "0x1822DA1D0", Slot = "24")]
		public string GetActId()
		{
			return null;
		}

		// Token: 0x06027B09 RID: 162569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B09")]
		[Address(RVA = "0x22DB9A0", Offset = "0x22DA5A0", VA = "0x1822DB9A0")]
		protected TemplateActivityController()
		{
		}

		// Token: 0x06027B0B RID: 162571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B0B")]
		[Address(RVA = "0x22DB640", Offset = "0x22DA240", VA = "0x1822DB640")]
		private void <>xLuaBaseProxy_InitController()
		{
		}

		// Token: 0x06027B0C RID: 162572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B0C")]
		[Address(RVA = "0x22DB670", Offset = "0x22DA270", VA = "0x1822DB670")]
		private void <>xLuaBaseProxy_OnStagePageHideEffect()
		{
		}

		// Token: 0x06027B0D RID: 162573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B0D")]
		[Address(RVA = "0x22DB6D0", Offset = "0x22DA2D0", VA = "0x1822DB6D0")]
		private void <>xLuaBaseProxy_OnStageZoneSelectStateSetEffect(bool P0)
		{
		}

		// Token: 0x06027B0E RID: 162574 RVA: 0x000CF108 File Offset: 0x000CD308
		[Token(Token = "0x6027B0E")]
		[Address(RVA = "0x22DB6F0", Offset = "0x22DA2F0", VA = "0x1822DB6F0")]
		private bool <>xLuaBaseProxy_get_disableStageEntryPartical()
		{
			return default(bool);
		}

		// Token: 0x06027B0F RID: 162575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B0F")]
		[Address(RVA = "0x22DB660", Offset = "0x22DA260", VA = "0x1822DB660")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x06027B10 RID: 162576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B10")]
		[Address(RVA = "0x22DB650", Offset = "0x22DA250", VA = "0x1822DB650")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06027B11 RID: 162577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027B11")]
		[Address(RVA = "0x22DB630", Offset = "0x22DA230", VA = "0x1822DB630")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine()
		{
			return null;
		}

		// Token: 0x06027B12 RID: 162578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B12")]
		[Address(RVA = "0x22DB680", Offset = "0x22DA280", VA = "0x1822DB680")]
		private void <>xLuaBaseProxy_OnStagePageResumed(UIPageTransContext P0)
		{
		}

		// Token: 0x06027B13 RID: 162579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B13")]
		[Address(RVA = "0x22DB6E0", Offset = "0x22DA2E0", VA = "0x1822DB6E0")]
		private void <>xLuaBaseProxy_TriggerActivityLoadedAVG()
		{
		}

		// Token: 0x06027B14 RID: 162580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027B14")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x04038467 RID: 230503
		[Token(Token = "0x4038467")]
		[NonSerialized]
		public const string COMMON_ZONE_PARAM = "zone";

		// Token: 0x04038468 RID: 230504
		[Token(Token = "0x4038468")]
		[NonSerialized]
		public const string COMMON_MISSION_PARAM = "mission";

		// Token: 0x04038469 RID: 230505
		[Token(Token = "0x4038469")]
		[NonSerialized]
		public const string COMMON_MILESTONE_PARAM = "milestone";

		// Token: 0x0403846A RID: 230506
		[Token(Token = "0x403846A")]
		[NonSerialized]
		public const string LIFE_CYCLE_PARAM = "life_cycle";

		// Token: 0x0403846B RID: 230507
		[Token(Token = "0x403846B")]
		[NonSerialized]
		public const string FAVOR_PARAM = "favor";

		// Token: 0x0403846C RID: 230508
		[Token(Token = "0x403846C")]
		[NonSerialized]
		public const string COIN_PARAM = "coin";

		// Token: 0x0403846D RID: 230509
		[Token(Token = "0x403846D")]
		[NonSerialized]
		public const string MEDAL_PARAM = "medal";

		// Token: 0x0403846E RID: 230510
		[Token(Token = "0x403846E")]
		[NonSerialized]
		public const string MISSION_ARCHIVE = "mission_archive";

		// Token: 0x0403846F RID: 230511
		[Token(Token = "0x403846F")]
		[NonSerialized]
		public const string COMMON_TEMPLATE_MISSION_PARAM = "tempalte_mission";

		// Token: 0x04038470 RID: 230512
		[Token(Token = "0x4038470")]
		[NonSerialized]
		public const string CG_GALLERY_PARAM = "cg_gallery";

		// Token: 0x04038471 RID: 230513
		[Token(Token = "0x4038471")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public TemplateActivityViewModelProperty m_activityModelProperty;

		// Token: 0x04038472 RID: 230514
		[Token(Token = "0x4038472")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Whether to disable partical on zone select state")]
		private bool _disableStageEntryPartical;

		// Token: 0x04038473 RID: 230515
		[Token(Token = "0x4038473")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemplateActivityBindHolder binderListHolder;

		// Token: 0x04038474 RID: 230516
		[Token(Token = "0x4038474")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public List<TemplateEffectView> effectViewList;

		// Token: 0x04038475 RID: 230517
		[Token(Token = "0x4038475")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x04038476 RID: 230518
		[Token(Token = "0x4038476")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitController;

		// Token: 0x04038477 RID: 230519
		[Token(Token = "0x4038477")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindInstanceTemplateInPage;

		// Token: 0x04038478 RID: 230520
		[Token(Token = "0x4038478")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x04038479 RID: 230521
		[Token(Token = "0x4038479")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CanSkipAnim;

		// Token: 0x0403847A RID: 230522
		[Token(Token = "0x403847A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceSkipEnterAnim;

		// Token: 0x0403847B RID: 230523
		[Token(Token = "0x403847B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfBackFromBattle;

		// Token: 0x0403847C RID: 230524
		[Token(Token = "0x403847C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfActivityIsOpen;

		// Token: 0x0403847D RID: 230525
		[Token(Token = "0x403847D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfActivityLimitedPerLogin;

		// Token: 0x0403847E RID: 230526
		[Token(Token = "0x403847E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_floatStateEngine;

		// Token: 0x0403847F RID: 230527
		[Token(Token = "0x403847F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnStagePageHideEffect;

		// Token: 0x04038480 RID: 230528
		[Token(Token = "0x4038480")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnStageZoneSelectStateSetEffect;

		// Token: 0x04038481 RID: 230529
		[Token(Token = "0x4038481")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_disableStageEntryPartical;

		// Token: 0x04038482 RID: 230530
		[Token(Token = "0x4038482")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_playEntryAnimAfterAVG;

		// Token: 0x04038483 RID: 230531
		[Token(Token = "0x4038483")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x04038484 RID: 230532
		[Token(Token = "0x4038484")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04038485 RID: 230533
		[Token(Token = "0x4038485")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AfterEntryAnimPlay;

		// Token: 0x04038486 RID: 230534
		[Token(Token = "0x4038486")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TriggerAfterEntryAnim;

		// Token: 0x04038487 RID: 230535
		[Token(Token = "0x4038487")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04038488 RID: 230536
		[Token(Token = "0x4038488")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x04038489 RID: 230537
		[Token(Token = "0x4038489")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_UnBind;

		// Token: 0x0403848A RID: 230538
		[Token(Token = "0x403848A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0403848B RID: 230539
		[Token(Token = "0x403848B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RefreshSingleton;

		// Token: 0x0403848C RID: 230540
		[Token(Token = "0x403848C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x0403848D RID: 230541
		[Token(Token = "0x403848D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnFocusZone;

		// Token: 0x0403848E RID: 230542
		[Token(Token = "0x403848E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetCurrentState;

		// Token: 0x0403848F RID: 230543
		[Token(Token = "0x403848F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CreateTemplateMissionInputParam;

		// Token: 0x04038490 RID: 230544
		[Token(Token = "0x4038490")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetTutorialCustomOperationKey;

		// Token: 0x04038491 RID: 230545
		[Token(Token = "0x4038491")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetTutorialCustomOperationKeyOnResume;

		// Token: 0x04038492 RID: 230546
		[Token(Token = "0x4038492")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_AVGOnly_ExecuteResetToEntryCmd;

		// Token: 0x04038493 RID: 230547
		[Token(Token = "0x4038493")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_AVGOnly_ExecuteResetToEntryCoroutine;

		// Token: 0x04038494 RID: 230548
		[Token(Token = "0x4038494")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__WaitForStable;

		// Token: 0x04038495 RID: 230549
		[Token(Token = "0x4038495")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_AVGOnly_ResetToEntryImpl;

		// Token: 0x04038496 RID: 230550
		[Token(Token = "0x4038496")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_AVGOnly_ResetToEntryFallback;

		// Token: 0x04038497 RID: 230551
		[Token(Token = "0x4038497")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnFocusStage;

		// Token: 0x04038498 RID: 230552
		[Token(Token = "0x4038498")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnStagePageResumed;

		// Token: 0x04038499 RID: 230553
		[Token(Token = "0x4038499")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TriggerActivityLoadedAVG;

		// Token: 0x0403849A RID: 230554
		[Token(Token = "0x403849A")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403849B RID: 230555
		[Token(Token = "0x403849B")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403849C RID: 230556
		[Token(Token = "0x403849C")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403849D RID: 230557
		[Token(Token = "0x403849D")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix1_GetViewModel;

		// Token: 0x0403849E RID: 230558
		[Token(Token = "0x403849E")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetActId;

		// Token: 0x0403849F RID: 230559
		[Token(Token = "0x403849F")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006CA9 RID: 27817
		[Token(Token = "0x2006CA9")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x06027B15 RID: 162581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B15")]
			[Address(RVA = "0x22D4B30", Offset = "0x22D3730", VA = "0x1822D4B30", Slot = "5")]
			protected override void OnZoneSelected(string selectedZoneId)
			{
			}

			// Token: 0x06027B16 RID: 162582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B16")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Bridge()
			{
			}
		}

		// Token: 0x02006CAA RID: 27818
		[Token(Token = "0x2006CAA")]
		public class AVGResetToActEntryCommandExecutor : ICommandExecutor, IHotfixable
		{
			// Token: 0x06027B17 RID: 162583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B17")]
			[Address(RVA = "0x22D4120", Offset = "0x22D2D20", VA = "0x1822D4120")]
			public AVGResetToActEntryCommandExecutor(TemplateActivityController templateActivityController)
			{
			}

			// Token: 0x17005DBD RID: 23997
			// (get) Token: 0x06027B18 RID: 162584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005DBD")]
			public string command
			{
				[Token(Token = "0x6027B18")]
				[Address(RVA = "0x22D41A0", Offset = "0x22D2DA0", VA = "0x1822D41A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06027B19 RID: 162585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B19")]
			[Address(RVA = "0x22D3E90", Offset = "0x22D2A90", VA = "0x1822D3E90", Slot = "5")]
			public void Execute(Command command, Action<ICommandExecutor> finishCb)
			{
			}

			// Token: 0x06027B1A RID: 162586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B1A")]
			[Address(RVA = "0x22D4060", Offset = "0x22D2C60", VA = "0x1822D4060", Slot = "7")]
			public void ForceEnd()
			{
			}

			// Token: 0x06027B1B RID: 162587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027B1B")]
			[Address(RVA = "0x22D40C0", Offset = "0x22D2CC0", VA = "0x1822D40C0", Slot = "6")]
			public void RaiseSignal(Command command)
			{
			}

			// Token: 0x040384A0 RID: 230560
			[Token(Token = "0x40384A0")]
			private const string RESET_TO_ENTRY_COMMAND = "Activity.ResetToEntry";

			// Token: 0x040384A1 RID: 230561
			[Token(Token = "0x40384A1")]
			[FieldOffset(Offset = "0x10")]
			private TemplateActivityController m_actController;

			// Token: 0x040384A2 RID: 230562
			[Token(Token = "0x40384A2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040384A3 RID: 230563
			[Token(Token = "0x40384A3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_command;

			// Token: 0x040384A4 RID: 230564
			[Token(Token = "0x40384A4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Execute;

			// Token: 0x040384A5 RID: 230565
			[Token(Token = "0x40384A5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ForceEnd;

			// Token: 0x040384A6 RID: 230566
			[Token(Token = "0x40384A6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RaiseSignal;
		}
	}
}
